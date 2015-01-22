using DevScope.CartaoDeCidadao;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections.Generic;
using System.Net;
using iTextSharp;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Cms;
using System.Collections;
using iTextSharp.text.pdf.security;
using Org.BouncyCastle.X509;
using System.Security;

namespace pdfSigner
{
    public partial class MainForm : Form
    {
        private SCWatcher _scWatcher = null;

        private delegate void OnShowCitizenInfo();
        private delegate void OnHideCitizenInfo();

        private List<string> filesToSign = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true; // allow multiple files
            fd.Filter = "PDF files (*.pdf)|*.pdf";
            fd.ShowDialog();

            string[] tempPaths = fd.FileNames;

            foreach (string path in tempPaths)
            {
                lbFilesToSign.Items.Add(path);
            }
            btnRemoveFile.Enabled = true;
            btnSignNow.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Init Card Reader
            try
            {
                lblStatus.Text = "initializing the card reader...";
                ScWatcher_Init();

                lblStatus.Text += " OK.";
            }
            catch
            {
                lblStatus.Text = "Erro ao iniciar o leitor de cartões!";
            }
        }

        #region CartaoDeCidadao Code

        /// <summary>
        /// Read the Citizen ID data and sets the class properties
        /// </summary>
        public void CC_Read_Info()
        {
            // Public Citizen Identity Data   
            Id citizen = EIDPT.GetID();

            txtIdNumber.Text = citizen.BI;
            txtFullName.Text = citizen.FirstName + " " + citizen.Name;
        }

        /// <summary>
        /// Only Reads the photo, set's the class properties and returns the photo
        /// </summary>
        /// <returns>Citizen photo</returns>
        public Image CC_Get_Photo()
        {
            MemoryStream ms = null;
            try
            {
                Picture picture = EIDPT.GetPicture();
                ms = new MemoryStream(picture.Bytes, 0, picture.BytesLength, false);
                // JPEG2000 Support provided by CSJ2K (http://csj2k.codeplex.com/)
                Image tempImage = CSJ2K.J2kImage.FromStream(ms);
                return tempImage;
            }
            finally
            {
                ms.Close();
            }
        }
        #endregion


        #region Card Reader Code
        // Manage
        private void ScWatcher_Init()
        {
            this._scWatcher = SCWatcher.GetInstance(); // Daemon starts when instantiated
            this._scWatcher.CardInserted += new SCWatcher.CardInsertedHandler(ScWatcher_CardInserted);
            this._scWatcher.CardRemoved += new SCWatcher.CardRemovedHandler(ScWatcher_CardRemoved);
            this._scWatcher.ReaderInserted += new SCWatcher.ReaderInsertedHandler(ScWatcher_ReaderInserted);
            this._scWatcher.ReaderRemoved += new SCWatcher.ReaderRemovedHandler(ScWatcher_ReaderRemoved);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ScWatcher_Stop()
        {
            if (this._scWatcher != null)
                this._scWatcher.Stop();
        }

        // Events(only for UI update)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName"></param>
        /// <param name="cardName"></param>
        void ScWatcher_CardInserted(string readerName, string cardName)
        {
            try
            {
                EIDPT.Init(readerName);
                EIDPT.SetSODChecking(false);
            }
            catch
            {
                EIDPT.Exit(ExitMode.LEAVE_CARD);
                return;
            }

            lblStatus.Text = "Card Inserted.";
            ShowCitizenInfo();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName"></param>
        void ScWatcher_CardRemoved(string readerName)
        {
            EIDPT.Exit(ExitMode.LEAVE_CARD);
            lblStatus.Text = "Card Removed.";
            HideCitizenInfo();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName"></param>
        void ScWatcher_ReaderInserted(string readerName)
        {
            lblStatus.Text = "Card Reader Inserted: " + readerName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName"></param>
        void ScWatcher_ReaderRemoved(string readerName)
        {
            EIDPT.Exit(ExitMode.LEAVE_CARD);
            lblStatus.Text = "Card Reader Removed: " + readerName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        void ScWatcher_OnError(int errorCode, string errorMessage)
        {

            string messageBoxText = errorMessage;
            string caption = "Error " + errorCode;
            MessageBox.Show(messageBoxText, caption);
            HideCitizenInfo();
        }

        /* http://stackoverflow.com/questions/2367718/automating-the-invokerequired-code-pattern */
        private void ShowCitizenInfo()
        {
            if (this.InvokeRequired)
            {
                Invoke(new OnShowCitizenInfo(ShowCitizenInfo));
            }
            else
            {
                // Read CC Info
                CC_Read_Info();
                this.pbPhoto.Image = CC_Get_Photo();
            }
        }

        private void HideCitizenInfo()
        {
            if (this.InvokeRequired)
            {
                Invoke(new OnHideCitizenInfo(HideCitizenInfo));
            }
            else
            {
                txtIdNumber.Text = "";
                txtFullName.Text = "";
                this.pbPhoto.Image = null;

            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // free the card reader
            ScWatcher_Stop();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                // Set wait cursor
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);

                // Get signature certificate for current citizen
                X509Certificate2Collection certsToShow = store.Certificates.Find(X509FindType.FindBySubjectName, "Assinatura", false);
                X509Certificate2Collection certs = certsToShow.Find(X509FindType.FindBySubjectName, "BI" + txtIdNumber.Text, false);

                if (certs.Count <= 0)
                {
                    MessageBox.Show("Certificate not found.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                var cert = certs[0];

                if (cert != null)
                {

                    // Sign every file found on listbox
                    foreach (string file in lbFilesToSign.Items)
                    {

                        try
                        {
                            // Get source folder and source filename
                            string sourceFolder = Path.GetDirectoryName(file);
                            string filename = Path.GetFileName(file);

                            lblStatus.Text = "A assinar o file " + filename;

                            // Create "Signed" sub-folder if doesn't exists
                            string signedFolder = Path.Combine(sourceFolder, "Signed");

                            if (!Directory.Exists(signedFolder)) Directory.CreateDirectory(signedFolder);

                            // Generate destination path for signed file
                            var signedFile = signedFolder + "/" + filename;

                            // Convert X509Certificate2 to X509Certificate
                            X509CertificateParser certParse = new Org.BouncyCastle.X509.X509CertificateParser();
                            Org.BouncyCastle.X509.X509Certificate[] chain = new Org.BouncyCastle.X509.X509Certificate[] { certParse.ReadCertificate(cert.RawData) };

                            // Reader and stamper
                            PdfReader pdfReader = new PdfReader(file);
                            Stream signedPdf = new FileStream(signedFile, FileMode.Create);
                            PdfStamper stamper = PdfStamper.CreateSignature(pdfReader, signedPdf, '\0', null, cbMultiSign.Checked);

                            // Appearance
                            PdfSignatureAppearance appearance = stamper.SignatureAppearance;
                            appearance.SignatureCreator = "PDF Signer 1.0";
                            if (txtReason.Text != "") appearance.Reason = txtReason.Text;
                            if (txtLocation.Text != "") appearance.Location = txtLocation.Text;

                            // Timestamp
                            TSAClientBouncyCastle tsc = null;
                            if (cbSignWithTSA.Checked == true)
                            {
                                tsc = new TSAClientBouncyCastle("http://ts.cartaodecidadao.pt/tsa/server", "", "");
                            }

                            // Digital signature
                            X509Certificate2Signature externalSignature = new X509Certificate2Signature(cert, "SHA-1");
                            MakeSignature.SignDetached(appearance, externalSignature, chain, null, null, tsc, 0, CryptoStandard.CMS);

                            stamper.Close();
                        }
                        catch (System.IO.IOException)
                        {
                            MessageBox.Show("File not found",
                                    "Error!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                        }
                    }

                    // Remove all files from listbox
                    lbFilesToSign.Items.Clear();
                    btnRemoveFile.Enabled = false;
                    btnSignNow.Enabled = false;
                    MessageBox.Show("You have successfully signed the document(s)", "Success!");
                }
                else
                {
                    MessageBox.Show("Certificate not found.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (System.Security.Cryptography.CryptographicException)
            {

            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("You must have an internet connection to use timestamp server.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Oops.. Something wrong.",
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            finally
            {
                // Set default cursor
                this.Cursor = Cursors.Default;

                if (lblStatus.Text.Contains("A assinar o file"))
                {
                    lblStatus.Text = "Card Inserted.";
                }

            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (lbFilesToSign.SelectedIndex >= 0)
            {
                lbFilesToSign.Items.Remove(lbFilesToSign.SelectedItem);
            }

            if (lbFilesToSign.Items.Count == 0)
            {
                btnRemoveFile.Enabled = false;
                btnSignNow.Enabled = false;
            }

        }
    }
}
