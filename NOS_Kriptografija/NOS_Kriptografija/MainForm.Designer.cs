namespace NOS_Kriptografija
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKeys = new System.Windows.Forms.TabPage();
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.btnGenerateAsymKeys = new System.Windows.Forms.Button();
            this.btnBrowsePrivateKey = new System.Windows.Forms.Button();
            this.txtPrivateKeyPath = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.btnBrowsePublicKey = new System.Windows.Forms.Button();
            this.txtPublicKeyPath = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.btnGenerateSymKey = new System.Windows.Forms.Button();
            this.btnBrowseSymKey = new System.Windows.Forms.Button();
            this.txtSymKeyPath = new System.Windows.Forms.TextBox();
            this.lblSymKey = new System.Windows.Forms.Label();
            this.tabSymmetric = new System.Windows.Forms.TabPage();
            this.btnSymDecrypt = new System.Windows.Forms.Button();
            this.btnSymEncrypt = new System.Windows.Forms.Button();
            this.btnSymBrowseKey = new System.Windows.Forms.Button();
            this.txtSymKeyPath_Sym = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecretKeyHeading = new System.Windows.Forms.Label();
            this.btnSymBrowseOutput = new System.Windows.Forms.Button();
            this.txtSymOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.lblOutputFileHeading = new System.Windows.Forms.Label();
            this.btnSymBrowseInput = new System.Windows.Forms.Button();
            this.txtSymInputFile = new System.Windows.Forms.TextBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblInputFileHeading = new System.Windows.Forms.Label();
            this.tabHybrid = new System.Windows.Forms.TabPage();
            this.btnHybridBrowsePrivateKey = new System.Windows.Forms.Button();
            this.txtHybridPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKeyHybrid = new System.Windows.Forms.Label();
            this.btnHybridDecrypt = new System.Windows.Forms.Button();
            this.btnHybridEncrypt = new System.Windows.Forms.Button();
            this.btnHybridBrowsePublicKey = new System.Windows.Forms.Button();
            this.txtHybridPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKeyHybrid = new System.Windows.Forms.Label();
            this.lblKeysHybridHeading = new System.Windows.Forms.Label();
            this.btnHybridBrowseOutput = new System.Windows.Forms.Button();
            this.txtHybridOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFileHybrid = new System.Windows.Forms.Label();
            this.lblOutputHeading = new System.Windows.Forms.Label();
            this.btnHybridBrowseInput = new System.Windows.Forms.Button();
            this.txtHybridInputFile = new System.Windows.Forms.TextBox();
            this.lblInputFileHybrid = new System.Windows.Forms.Label();
            this.lblInputHeading = new System.Windows.Forms.Label();
            this.tabHash = new System.Windows.Forms.TabPage();
            this.txtHashValue = new System.Windows.Forms.TextBox();
            this.lblHashValue = new System.Windows.Forms.Label();
            this.lblHashValueHeading = new System.Windows.Forms.Label();
            this.btnComputeHash = new System.Windows.Forms.Button();
            this.btnHashBrowseOutput = new System.Windows.Forms.Button();
            this.txtHashOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFileHash = new System.Windows.Forms.Label();
            this.lblOutputFileHashHeading = new System.Windows.Forms.Label();
            this.btnHashBrowseInput = new System.Windows.Forms.Button();
            this.txtHashInputFile = new System.Windows.Forms.TextBox();
            this.lblInputFileHash = new System.Windows.Forms.Label();
            this.lblInputFileHashHeading = new System.Windows.Forms.Label();
            this.tabSignature = new System.Windows.Forms.TabPage();
            this.btnSignBrowseInput = new System.Windows.Forms.Button();
            this.txtSignInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSignatureHeading = new System.Windows.Forms.Label();
            this.btnSignBrowsePrivateKey = new System.Windows.Forms.Button();
            this.txtSignPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKeyInput = new System.Windows.Forms.Label();
            this.btnSignBrowseOutput = new System.Windows.Forms.Button();
            this.txtSignOutput = new System.Windows.Forms.TextBox();
            this.lblSignOutput = new System.Windows.Forms.Label();
            this.btnSignFile = new System.Windows.Forms.Button();
            this.btnVerifyBrowseSignature = new System.Windows.Forms.Button();
            this.txtVerifySignature = new System.Windows.Forms.TextBox();
            this.lblFileSignature = new System.Windows.Forms.Label();
            this.btnVerifyBrowsePublicKey = new System.Windows.Forms.Button();
            this.txtVerifyPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKeyInput = new System.Windows.Forms.Label();
            this.btnVerifyBrowseInput = new System.Windows.Forms.Button();
            this.txtVerifyInput = new System.Windows.Forms.TextBox();
            this.lblOriginalFile = new System.Windows.Forms.Label();
            this.lblVerifyHeading = new System.Windows.Forms.Label();
            this.btnVerifySignatureFile = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabKeys.SuspendLayout();
            this.tabSymmetric.SuspendLayout();
            this.tabHybrid.SuspendLayout();
            this.tabHash.SuspendLayout();
            this.tabSignature.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabKeys);
            this.tabMain.Controls.Add(this.tabSymmetric);
            this.tabMain.Controls.Add(this.tabHybrid);
            this.tabMain.Controls.Add(this.tabHash);
            this.tabMain.Controls.Add(this.tabSignature);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(884, 561);
            this.tabMain.TabIndex = 0;
            // 
            // tabKeys
            // 
            this.tabKeys.Controls.Add(this.lblHeading2);
            this.tabKeys.Controls.Add(this.lblHeading1);
            this.tabKeys.Controls.Add(this.btnGenerateAsymKeys);
            this.tabKeys.Controls.Add(this.btnBrowsePrivateKey);
            this.tabKeys.Controls.Add(this.txtPrivateKeyPath);
            this.tabKeys.Controls.Add(this.lblPrivateKey);
            this.tabKeys.Controls.Add(this.btnBrowsePublicKey);
            this.tabKeys.Controls.Add(this.txtPublicKeyPath);
            this.tabKeys.Controls.Add(this.lblPublicKey);
            this.tabKeys.Controls.Add(this.btnGenerateSymKey);
            this.tabKeys.Controls.Add(this.btnBrowseSymKey);
            this.tabKeys.Controls.Add(this.txtSymKeyPath);
            this.tabKeys.Controls.Add(this.lblSymKey);
            this.tabKeys.Location = new System.Drawing.Point(4, 22);
            this.tabKeys.Name = "tabKeys";
            this.tabKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeys.Size = new System.Drawing.Size(876, 535);
            this.tabKeys.TabIndex = 0;
            this.tabKeys.Text = "Ključevi";
            this.tabKeys.UseVisualStyleBackColor = true;
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeading2.Location = new System.Drawing.Point(20, 293);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(219, 20);
            this.lblHeading2.TabIndex = 12;
            this.lblHeading2.Text = "Asimetrični (RSA) ključevi:";
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeading1.Location = new System.Drawing.Point(20, 54);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(187, 20);
            this.lblHeading1.TabIndex = 11;
            this.lblHeading1.Text = "Simetrični (AES) ključ:";
            // 
            // btnGenerateAsymKeys
            // 
            this.btnGenerateAsymKeys.Location = new System.Drawing.Point(115, 425);
            this.btnGenerateAsymKeys.Name = "btnGenerateAsymKeys";
            this.btnGenerateAsymKeys.Size = new System.Drawing.Size(144, 23);
            this.btnGenerateAsymKeys.TabIndex = 10;
            this.btnGenerateAsymKeys.Text = "Generiraj RSA ključeve";
            this.btnGenerateAsymKeys.UseVisualStyleBackColor = true;
            this.btnGenerateAsymKeys.Click += new System.EventHandler(this.btnGenerateAsymKeys_Click);
            // 
            // btnBrowsePrivateKey
            // 
            this.btnBrowsePrivateKey.Location = new System.Drawing.Point(471, 398);
            this.btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            this.btnBrowsePrivateKey.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePrivateKey.TabIndex = 9;
            this.btnBrowsePrivateKey.Text = "Odaberi...";
            this.btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnBrowsePrivateKey.Click += new System.EventHandler(this.btnBrowsePrivateKey_Click);
            // 
            // txtPrivateKeyPath
            // 
            this.txtPrivateKeyPath.Location = new System.Drawing.Point(115, 398);
            this.txtPrivateKeyPath.Name = "txtPrivateKeyPath";
            this.txtPrivateKeyPath.ReadOnly = true;
            this.txtPrivateKeyPath.Size = new System.Drawing.Size(350, 20);
            this.txtPrivateKeyPath.TabIndex = 8;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(39, 406);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(70, 13);
            this.lblPrivateKey.TabIndex = 7;
            this.lblPrivateKey.Text = "Privatni ključ:";
            // 
            // btnBrowsePublicKey
            // 
            this.btnBrowsePublicKey.Location = new System.Drawing.Point(471, 344);
            this.btnBrowsePublicKey.Name = "btnBrowsePublicKey";
            this.btnBrowsePublicKey.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePublicKey.TabIndex = 6;
            this.btnBrowsePublicKey.Text = "Odaberi...";
            this.btnBrowsePublicKey.UseVisualStyleBackColor = true;
            this.btnBrowsePublicKey.Click += new System.EventHandler(this.btnBrowsePublicKey_Click);
            // 
            // txtPublicKeyPath
            // 
            this.txtPublicKeyPath.Location = new System.Drawing.Point(115, 344);
            this.txtPublicKeyPath.Name = "txtPublicKeyPath";
            this.txtPublicKeyPath.ReadOnly = true;
            this.txtPublicKeyPath.Size = new System.Drawing.Size(350, 20);
            this.txtPublicKeyPath.TabIndex = 5;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(49, 347);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(60, 13);
            this.lblPublicKey.TabIndex = 4;
            this.lblPublicKey.Text = "Javni ključ:";
            // 
            // btnGenerateSymKey
            // 
            this.btnGenerateSymKey.Location = new System.Drawing.Point(115, 131);
            this.btnGenerateSymKey.Name = "btnGenerateSymKey";
            this.btnGenerateSymKey.Size = new System.Drawing.Size(114, 23);
            this.btnGenerateSymKey.TabIndex = 3;
            this.btnGenerateSymKey.Text = "Generiraj AES ključ";
            this.btnGenerateSymKey.UseVisualStyleBackColor = true;
            this.btnGenerateSymKey.Click += new System.EventHandler(this.btnGenerateSymKey_Click);
            // 
            // btnBrowseSymKey
            // 
            this.btnBrowseSymKey.Location = new System.Drawing.Point(471, 105);
            this.btnBrowseSymKey.Name = "btnBrowseSymKey";
            this.btnBrowseSymKey.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSymKey.TabIndex = 2;
            this.btnBrowseSymKey.Text = "Odaberi...";
            this.btnBrowseSymKey.UseVisualStyleBackColor = true;
            this.btnBrowseSymKey.Click += new System.EventHandler(this.btnBrowseSymKey_Click);
            // 
            // txtSymKeyPath
            // 
            this.txtSymKeyPath.Location = new System.Drawing.Point(115, 105);
            this.txtSymKeyPath.Name = "txtSymKeyPath";
            this.txtSymKeyPath.ReadOnly = true;
            this.txtSymKeyPath.Size = new System.Drawing.Size(350, 20);
            this.txtSymKeyPath.TabIndex = 1;
            // 
            // lblSymKey
            // 
            this.lblSymKey.AutoSize = true;
            this.lblSymKey.Location = new System.Drawing.Point(21, 108);
            this.lblSymKey.Name = "lblSymKey";
            this.lblSymKey.Size = new System.Drawing.Size(88, 13);
            this.lblSymKey.TabIndex = 0;
            this.lblSymKey.Text = "Tajni (AES) ključ:";
            // 
            // tabSymmetric
            // 
            this.tabSymmetric.Controls.Add(this.btnSymDecrypt);
            this.tabSymmetric.Controls.Add(this.btnSymEncrypt);
            this.tabSymmetric.Controls.Add(this.btnSymBrowseKey);
            this.tabSymmetric.Controls.Add(this.txtSymKeyPath_Sym);
            this.tabSymmetric.Controls.Add(this.label1);
            this.tabSymmetric.Controls.Add(this.lblSecretKeyHeading);
            this.tabSymmetric.Controls.Add(this.btnSymBrowseOutput);
            this.tabSymmetric.Controls.Add(this.txtSymOutputFile);
            this.tabSymmetric.Controls.Add(this.lblOutputFile);
            this.tabSymmetric.Controls.Add(this.lblOutputFileHeading);
            this.tabSymmetric.Controls.Add(this.btnSymBrowseInput);
            this.tabSymmetric.Controls.Add(this.txtSymInputFile);
            this.tabSymmetric.Controls.Add(this.lblInputFile);
            this.tabSymmetric.Controls.Add(this.lblInputFileHeading);
            this.tabSymmetric.Location = new System.Drawing.Point(4, 22);
            this.tabSymmetric.Name = "tabSymmetric";
            this.tabSymmetric.Padding = new System.Windows.Forms.Padding(3);
            this.tabSymmetric.Size = new System.Drawing.Size(876, 535);
            this.tabSymmetric.TabIndex = 1;
            this.tabSymmetric.Text = "Simetrično kriptiranje";
            this.tabSymmetric.UseVisualStyleBackColor = true;
            // 
            // btnSymDecrypt
            // 
            this.btnSymDecrypt.Location = new System.Drawing.Point(253, 470);
            this.btnSymDecrypt.Name = "btnSymDecrypt";
            this.btnSymDecrypt.Size = new System.Drawing.Size(104, 23);
            this.btnSymDecrypt.TabIndex = 13;
            this.btnSymDecrypt.Text = "Dekriptiraj (AES)";
            this.btnSymDecrypt.UseVisualStyleBackColor = true;
            this.btnSymDecrypt.Click += new System.EventHandler(this.btnSymDecrypt_Click);
            // 
            // btnSymEncrypt
            // 
            this.btnSymEncrypt.Location = new System.Drawing.Point(253, 441);
            this.btnSymEncrypt.Name = "btnSymEncrypt";
            this.btnSymEncrypt.Size = new System.Drawing.Size(104, 23);
            this.btnSymEncrypt.TabIndex = 12;
            this.btnSymEncrypt.Text = "Kriptiraj (AES)";
            this.btnSymEncrypt.UseVisualStyleBackColor = true;
            this.btnSymEncrypt.Click += new System.EventHandler(this.btnSymEncrypt_Click);
            // 
            // btnSymBrowseKey
            // 
            this.btnSymBrowseKey.Location = new System.Drawing.Point(488, 388);
            this.btnSymBrowseKey.Name = "btnSymBrowseKey";
            this.btnSymBrowseKey.Size = new System.Drawing.Size(75, 23);
            this.btnSymBrowseKey.TabIndex = 11;
            this.btnSymBrowseKey.Text = "Odaberi...";
            this.btnSymBrowseKey.UseVisualStyleBackColor = true;
            this.btnSymBrowseKey.Click += new System.EventHandler(this.btnSymBrowseKey_Click);
            // 
            // txtSymKeyPath_Sym
            // 
            this.txtSymKeyPath_Sym.Location = new System.Drawing.Point(132, 388);
            this.txtSymKeyPath_Sym.Name = "txtSymKeyPath_Sym";
            this.txtSymKeyPath_Sym.ReadOnly = true;
            this.txtSymKeyPath_Sym.Size = new System.Drawing.Size(350, 20);
            this.txtSymKeyPath_Sym.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tajni (AES) ključ:";
            // 
            // lblSecretKeyHeading
            // 
            this.lblSecretKeyHeading.AutoSize = true;
            this.lblSecretKeyHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSecretKeyHeading.Location = new System.Drawing.Point(37, 340);
            this.lblSecretKeyHeading.Name = "lblSecretKeyHeading";
            this.lblSecretKeyHeading.Size = new System.Drawing.Size(88, 20);
            this.lblSecretKeyHeading.TabIndex = 8;
            this.lblSecretKeyHeading.Text = "Tajni ključ";
            // 
            // btnSymBrowseOutput
            // 
            this.btnSymBrowseOutput.Location = new System.Drawing.Point(132, 263);
            this.btnSymBrowseOutput.Name = "btnSymBrowseOutput";
            this.btnSymBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnSymBrowseOutput.TabIndex = 7;
            this.btnSymBrowseOutput.Text = "Odaberi...";
            this.btnSymBrowseOutput.UseVisualStyleBackColor = true;
            this.btnSymBrowseOutput.Click += new System.EventHandler(this.btnSymBrowseOutput_Click);
            // 
            // txtSymOutputFile
            // 
            this.txtSymOutputFile.Location = new System.Drawing.Point(132, 237);
            this.txtSymOutputFile.Name = "txtSymOutputFile";
            this.txtSymOutputFile.ReadOnly = true;
            this.txtSymOutputFile.Size = new System.Drawing.Size(350, 20);
            this.txtSymOutputFile.TabIndex = 6;
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(38, 240);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(88, 13);
            this.lblOutputFile.TabIndex = 5;
            this.lblOutputFile.Text = "Izlazna datoteka:";
            // 
            // lblOutputFileHeading
            // 
            this.lblOutputFileHeading.AutoSize = true;
            this.lblOutputFileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutputFileHeading.Location = new System.Drawing.Point(37, 190);
            this.lblOutputFileHeading.Name = "lblOutputFileHeading";
            this.lblOutputFileHeading.Size = new System.Drawing.Size(143, 20);
            this.lblOutputFileHeading.TabIndex = 4;
            this.lblOutputFileHeading.Text = "Izlazna datoteka";
            // 
            // btnSymBrowseInput
            // 
            this.btnSymBrowseInput.Location = new System.Drawing.Point(132, 117);
            this.btnSymBrowseInput.Name = "btnSymBrowseInput";
            this.btnSymBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnSymBrowseInput.TabIndex = 3;
            this.btnSymBrowseInput.Text = "Odaberi...";
            this.btnSymBrowseInput.UseVisualStyleBackColor = true;
            this.btnSymBrowseInput.Click += new System.EventHandler(this.btnSymBrowseInput_Click);
            // 
            // txtSymInputFile
            // 
            this.txtSymInputFile.Location = new System.Drawing.Point(132, 90);
            this.txtSymInputFile.Name = "txtSymInputFile";
            this.txtSymInputFile.ReadOnly = true;
            this.txtSymInputFile.Size = new System.Drawing.Size(350, 20);
            this.txtSymInputFile.TabIndex = 2;
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(38, 93);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(88, 13);
            this.lblInputFile.TabIndex = 1;
            this.lblInputFile.Text = "Ulazna datoteka:";
            // 
            // lblInputFileHeading
            // 
            this.lblInputFileHeading.AutoSize = true;
            this.lblInputFileHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInputFileHeading.Location = new System.Drawing.Point(32, 46);
            this.lblInputFileHeading.Name = "lblInputFileHeading";
            this.lblInputFileHeading.Size = new System.Drawing.Size(141, 20);
            this.lblInputFileHeading.TabIndex = 0;
            this.lblInputFileHeading.Text = "Ulazna datoteka";
            // 
            // tabHybrid
            // 
            this.tabHybrid.Controls.Add(this.btnHybridBrowsePrivateKey);
            this.tabHybrid.Controls.Add(this.txtHybridPrivateKey);
            this.tabHybrid.Controls.Add(this.lblPrivateKeyHybrid);
            this.tabHybrid.Controls.Add(this.btnHybridDecrypt);
            this.tabHybrid.Controls.Add(this.btnHybridEncrypt);
            this.tabHybrid.Controls.Add(this.btnHybridBrowsePublicKey);
            this.tabHybrid.Controls.Add(this.txtHybridPublicKey);
            this.tabHybrid.Controls.Add(this.lblPublicKeyHybrid);
            this.tabHybrid.Controls.Add(this.lblKeysHybridHeading);
            this.tabHybrid.Controls.Add(this.btnHybridBrowseOutput);
            this.tabHybrid.Controls.Add(this.txtHybridOutputFile);
            this.tabHybrid.Controls.Add(this.lblOutputFileHybrid);
            this.tabHybrid.Controls.Add(this.lblOutputHeading);
            this.tabHybrid.Controls.Add(this.btnHybridBrowseInput);
            this.tabHybrid.Controls.Add(this.txtHybridInputFile);
            this.tabHybrid.Controls.Add(this.lblInputFileHybrid);
            this.tabHybrid.Controls.Add(this.lblInputHeading);
            this.tabHybrid.Location = new System.Drawing.Point(4, 22);
            this.tabHybrid.Name = "tabHybrid";
            this.tabHybrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabHybrid.Size = new System.Drawing.Size(876, 535);
            this.tabHybrid.TabIndex = 2;
            this.tabHybrid.Text = "Hibridno (RSA+AES)";
            this.tabHybrid.UseVisualStyleBackColor = true;
            // 
            // btnHybridBrowsePrivateKey
            // 
            this.btnHybridBrowsePrivateKey.Location = new System.Drawing.Point(583, 413);
            this.btnHybridBrowsePrivateKey.Name = "btnHybridBrowsePrivateKey";
            this.btnHybridBrowsePrivateKey.Size = new System.Drawing.Size(75, 23);
            this.btnHybridBrowsePrivateKey.TabIndex = 30;
            this.btnHybridBrowsePrivateKey.Text = "Odaberi...";
            this.btnHybridBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnHybridBrowsePrivateKey.Click += new System.EventHandler(this.btnHybridBrowsePrivateKey_Click);
            // 
            // txtHybridPrivateKey
            // 
            this.txtHybridPrivateKey.Location = new System.Drawing.Point(227, 413);
            this.txtHybridPrivateKey.Name = "txtHybridPrivateKey";
            this.txtHybridPrivateKey.ReadOnly = true;
            this.txtHybridPrivateKey.Size = new System.Drawing.Size(350, 20);
            this.txtHybridPrivateKey.TabIndex = 29;
            // 
            // lblPrivateKeyHybrid
            // 
            this.lblPrivateKeyHybrid.AutoSize = true;
            this.lblPrivateKeyHybrid.Location = new System.Drawing.Point(46, 416);
            this.lblPrivateKeyHybrid.Name = "lblPrivateKeyHybrid";
            this.lblPrivateKeyHybrid.Size = new System.Drawing.Size(175, 13);
            this.lblPrivateKeyHybrid.TabIndex = 28;
            this.lblPrivateKeyHybrid.Text = "Privatni ključ (RSA) za dekriptiranje:";
            // 
            // btnHybridDecrypt
            // 
            this.btnHybridDecrypt.Location = new System.Drawing.Point(340, 487);
            this.btnHybridDecrypt.Name = "btnHybridDecrypt";
            this.btnHybridDecrypt.Size = new System.Drawing.Size(150, 23);
            this.btnHybridDecrypt.TabIndex = 27;
            this.btnHybridDecrypt.Text = "Dekriptiraj (RSA + AES)";
            this.btnHybridDecrypt.UseVisualStyleBackColor = true;
            this.btnHybridDecrypt.Click += new System.EventHandler(this.btnHybridDecrypt_Click);
            // 
            // btnHybridEncrypt
            // 
            this.btnHybridEncrypt.Location = new System.Drawing.Point(340, 458);
            this.btnHybridEncrypt.Name = "btnHybridEncrypt";
            this.btnHybridEncrypt.Size = new System.Drawing.Size(150, 23);
            this.btnHybridEncrypt.TabIndex = 26;
            this.btnHybridEncrypt.Text = "Kriptiraj (RSA + AES)";
            this.btnHybridEncrypt.UseVisualStyleBackColor = true;
            this.btnHybridEncrypt.Click += new System.EventHandler(this.btnHybridEncrypt_Click);
            // 
            // btnHybridBrowsePublicKey
            // 
            this.btnHybridBrowsePublicKey.Location = new System.Drawing.Point(583, 377);
            this.btnHybridBrowsePublicKey.Name = "btnHybridBrowsePublicKey";
            this.btnHybridBrowsePublicKey.Size = new System.Drawing.Size(75, 23);
            this.btnHybridBrowsePublicKey.TabIndex = 25;
            this.btnHybridBrowsePublicKey.Text = "Odaberi...";
            this.btnHybridBrowsePublicKey.UseVisualStyleBackColor = true;
            this.btnHybridBrowsePublicKey.Click += new System.EventHandler(this.btnHybridBrowsePublicKey_Click);
            // 
            // txtHybridPublicKey
            // 
            this.txtHybridPublicKey.Location = new System.Drawing.Point(227, 377);
            this.txtHybridPublicKey.Name = "txtHybridPublicKey";
            this.txtHybridPublicKey.ReadOnly = true;
            this.txtHybridPublicKey.Size = new System.Drawing.Size(350, 20);
            this.txtHybridPublicKey.TabIndex = 24;
            // 
            // lblPublicKeyHybrid
            // 
            this.lblPublicKeyHybrid.AutoSize = true;
            this.lblPublicKeyHybrid.Location = new System.Drawing.Point(46, 380);
            this.lblPublicKeyHybrid.Name = "lblPublicKeyHybrid";
            this.lblPublicKeyHybrid.Size = new System.Drawing.Size(153, 13);
            this.lblPublicKeyHybrid.TabIndex = 23;
            this.lblPublicKeyHybrid.Text = "Javni ključ (RSA) za kriptiranje:";
            // 
            // lblKeysHybridHeading
            // 
            this.lblKeysHybridHeading.AutoSize = true;
            this.lblKeysHybridHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKeysHybridHeading.Location = new System.Drawing.Point(45, 336);
            this.lblKeysHybridHeading.Name = "lblKeysHybridHeading";
            this.lblKeysHybridHeading.Size = new System.Drawing.Size(109, 20);
            this.lblKeysHybridHeading.TabIndex = 22;
            this.lblKeysHybridHeading.Text = "RSA ključevi";
            // 
            // btnHybridBrowseOutput
            // 
            this.btnHybridBrowseOutput.Location = new System.Drawing.Point(140, 259);
            this.btnHybridBrowseOutput.Name = "btnHybridBrowseOutput";
            this.btnHybridBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnHybridBrowseOutput.TabIndex = 21;
            this.btnHybridBrowseOutput.Text = "Odaberi...";
            this.btnHybridBrowseOutput.UseVisualStyleBackColor = true;
            this.btnHybridBrowseOutput.Click += new System.EventHandler(this.btnHybridBrowseOutput_Click);
            // 
            // txtHybridOutputFile
            // 
            this.txtHybridOutputFile.Location = new System.Drawing.Point(140, 233);
            this.txtHybridOutputFile.Name = "txtHybridOutputFile";
            this.txtHybridOutputFile.ReadOnly = true;
            this.txtHybridOutputFile.Size = new System.Drawing.Size(350, 20);
            this.txtHybridOutputFile.TabIndex = 20;
            // 
            // lblOutputFileHybrid
            // 
            this.lblOutputFileHybrid.AutoSize = true;
            this.lblOutputFileHybrid.Location = new System.Drawing.Point(46, 236);
            this.lblOutputFileHybrid.Name = "lblOutputFileHybrid";
            this.lblOutputFileHybrid.Size = new System.Drawing.Size(88, 13);
            this.lblOutputFileHybrid.TabIndex = 19;
            this.lblOutputFileHybrid.Text = "Izlazna datoteka:";
            // 
            // lblOutputHeading
            // 
            this.lblOutputHeading.AutoSize = true;
            this.lblOutputHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutputHeading.Location = new System.Drawing.Point(45, 186);
            this.lblOutputHeading.Name = "lblOutputHeading";
            this.lblOutputHeading.Size = new System.Drawing.Size(143, 20);
            this.lblOutputHeading.TabIndex = 18;
            this.lblOutputHeading.Text = "Izlazna datoteka";
            // 
            // btnHybridBrowseInput
            // 
            this.btnHybridBrowseInput.Location = new System.Drawing.Point(140, 113);
            this.btnHybridBrowseInput.Name = "btnHybridBrowseInput";
            this.btnHybridBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnHybridBrowseInput.TabIndex = 17;
            this.btnHybridBrowseInput.Text = "Odaberi...";
            this.btnHybridBrowseInput.UseVisualStyleBackColor = true;
            this.btnHybridBrowseInput.Click += new System.EventHandler(this.btnHybridBrowseInput_Click);
            // 
            // txtHybridInputFile
            // 
            this.txtHybridInputFile.Location = new System.Drawing.Point(140, 86);
            this.txtHybridInputFile.Name = "txtHybridInputFile";
            this.txtHybridInputFile.ReadOnly = true;
            this.txtHybridInputFile.Size = new System.Drawing.Size(350, 20);
            this.txtHybridInputFile.TabIndex = 16;
            // 
            // lblInputFileHybrid
            // 
            this.lblInputFileHybrid.AutoSize = true;
            this.lblInputFileHybrid.Location = new System.Drawing.Point(46, 89);
            this.lblInputFileHybrid.Name = "lblInputFileHybrid";
            this.lblInputFileHybrid.Size = new System.Drawing.Size(88, 13);
            this.lblInputFileHybrid.TabIndex = 15;
            this.lblInputFileHybrid.Text = "Ulazna datoteka:";
            // 
            // lblInputHeading
            // 
            this.lblInputHeading.AutoSize = true;
            this.lblInputHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInputHeading.Location = new System.Drawing.Point(40, 42);
            this.lblInputHeading.Name = "lblInputHeading";
            this.lblInputHeading.Size = new System.Drawing.Size(141, 20);
            this.lblInputHeading.TabIndex = 14;
            this.lblInputHeading.Text = "Ulazna datoteka";
            // 
            // tabHash
            // 
            this.tabHash.Controls.Add(this.txtHashValue);
            this.tabHash.Controls.Add(this.lblHashValue);
            this.tabHash.Controls.Add(this.lblHashValueHeading);
            this.tabHash.Controls.Add(this.btnComputeHash);
            this.tabHash.Controls.Add(this.btnHashBrowseOutput);
            this.tabHash.Controls.Add(this.txtHashOutputFile);
            this.tabHash.Controls.Add(this.lblOutputFileHash);
            this.tabHash.Controls.Add(this.lblOutputFileHashHeading);
            this.tabHash.Controls.Add(this.btnHashBrowseInput);
            this.tabHash.Controls.Add(this.txtHashInputFile);
            this.tabHash.Controls.Add(this.lblInputFileHash);
            this.tabHash.Controls.Add(this.lblInputFileHashHeading);
            this.tabHash.Location = new System.Drawing.Point(4, 22);
            this.tabHash.Name = "tabHash";
            this.tabHash.Padding = new System.Windows.Forms.Padding(3);
            this.tabHash.Size = new System.Drawing.Size(876, 535);
            this.tabHash.TabIndex = 3;
            this.tabHash.Text = "Hash";
            this.tabHash.UseVisualStyleBackColor = true;
            // 
            // txtHashValue
            // 
            this.txtHashValue.Location = new System.Drawing.Point(183, 446);
            this.txtHashValue.Multiline = true;
            this.txtHashValue.Name = "txtHashValue";
            this.txtHashValue.ReadOnly = true;
            this.txtHashValue.Size = new System.Drawing.Size(350, 50);
            this.txtHashValue.TabIndex = 19;
            // 
            // lblHashValue
            // 
            this.lblHashValue.AutoSize = true;
            this.lblHashValue.Location = new System.Drawing.Point(63, 449);
            this.lblHashValue.Name = "lblHashValue";
            this.lblHashValue.Size = new System.Drawing.Size(114, 13);
            this.lblHashValue.TabIndex = 18;
            this.lblHashValue.Text = "Hash vrijednost (HEX):";
            // 
            // lblHashValueHeading
            // 
            this.lblHashValueHeading.AutoSize = true;
            this.lblHashValueHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHashValueHeading.Location = new System.Drawing.Point(54, 397);
            this.lblHashValueHeading.Name = "lblHashValueHeading";
            this.lblHashValueHeading.Size = new System.Drawing.Size(188, 20);
            this.lblHashValueHeading.TabIndex = 17;
            this.lblHashValueHeading.Text = "Prikaz hash vrijednosti";
            // 
            // btnComputeHash
            // 
            this.btnComputeHash.Location = new System.Drawing.Point(247, 333);
            this.btnComputeHash.Name = "btnComputeHash";
            this.btnComputeHash.Size = new System.Drawing.Size(150, 25);
            this.btnComputeHash.TabIndex = 16;
            this.btnComputeHash.Text = "Izračunaj hash (SHA-256)";
            this.btnComputeHash.UseVisualStyleBackColor = true;
            this.btnComputeHash.Click += new System.EventHandler(this.btnComputeHash_Click);
            // 
            // btnHashBrowseOutput
            // 
            this.btnHashBrowseOutput.Location = new System.Drawing.Point(149, 270);
            this.btnHashBrowseOutput.Name = "btnHashBrowseOutput";
            this.btnHashBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnHashBrowseOutput.TabIndex = 15;
            this.btnHashBrowseOutput.Text = "Odaberi...";
            this.btnHashBrowseOutput.UseVisualStyleBackColor = true;
            this.btnHashBrowseOutput.Click += new System.EventHandler(this.btnHashBrowseOutput_Click);
            // 
            // txtHashOutputFile
            // 
            this.txtHashOutputFile.Location = new System.Drawing.Point(149, 244);
            this.txtHashOutputFile.Name = "txtHashOutputFile";
            this.txtHashOutputFile.ReadOnly = true;
            this.txtHashOutputFile.Size = new System.Drawing.Size(350, 20);
            this.txtHashOutputFile.TabIndex = 14;
            // 
            // lblOutputFileHash
            // 
            this.lblOutputFileHash.AutoSize = true;
            this.lblOutputFileHash.Location = new System.Drawing.Point(63, 247);
            this.lblOutputFileHash.Name = "lblOutputFileHash";
            this.lblOutputFileHash.Size = new System.Drawing.Size(80, 13);
            this.lblOutputFileHash.TabIndex = 13;
            this.lblOutputFileHash.Text = "Hash datoteka:";
            // 
            // lblOutputFileHashHeading
            // 
            this.lblOutputFileHashHeading.AutoSize = true;
            this.lblOutputFileHashHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutputFileHashHeading.Location = new System.Drawing.Point(54, 197);
            this.lblOutputFileHashHeading.Name = "lblOutputFileHashHeading";
            this.lblOutputFileHashHeading.Size = new System.Drawing.Size(199, 20);
            this.lblOutputFileHashHeading.TabIndex = 12;
            this.lblOutputFileHashHeading.Text = "Izlazna datoteka (hash)";
            // 
            // btnHashBrowseInput
            // 
            this.btnHashBrowseInput.Location = new System.Drawing.Point(149, 124);
            this.btnHashBrowseInput.Name = "btnHashBrowseInput";
            this.btnHashBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnHashBrowseInput.TabIndex = 11;
            this.btnHashBrowseInput.Text = "Odaberi...";
            this.btnHashBrowseInput.UseVisualStyleBackColor = true;
            this.btnHashBrowseInput.Click += new System.EventHandler(this.btnHashBrowseInput_Click);
            // 
            // txtHashInputFile
            // 
            this.txtHashInputFile.Location = new System.Drawing.Point(149, 97);
            this.txtHashInputFile.Name = "txtHashInputFile";
            this.txtHashInputFile.ReadOnly = true;
            this.txtHashInputFile.Size = new System.Drawing.Size(350, 20);
            this.txtHashInputFile.TabIndex = 10;
            // 
            // lblInputFileHash
            // 
            this.lblInputFileHash.AutoSize = true;
            this.lblInputFileHash.Location = new System.Drawing.Point(55, 100);
            this.lblInputFileHash.Name = "lblInputFileHash";
            this.lblInputFileHash.Size = new System.Drawing.Size(88, 13);
            this.lblInputFileHash.TabIndex = 9;
            this.lblInputFileHash.Text = "Ulazna datoteka:";
            // 
            // lblInputFileHashHeading
            // 
            this.lblInputFileHashHeading.AutoSize = true;
            this.lblInputFileHashHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInputFileHashHeading.Location = new System.Drawing.Point(49, 53);
            this.lblInputFileHashHeading.Name = "lblInputFileHashHeading";
            this.lblInputFileHashHeading.Size = new System.Drawing.Size(141, 20);
            this.lblInputFileHashHeading.TabIndex = 8;
            this.lblInputFileHashHeading.Text = "Ulazna datoteka";
            // 
            // tabSignature
            // 
            this.tabSignature.Controls.Add(this.btnVerifySignatureFile);
            this.tabSignature.Controls.Add(this.btnVerifyBrowseSignature);
            this.tabSignature.Controls.Add(this.txtVerifySignature);
            this.tabSignature.Controls.Add(this.lblFileSignature);
            this.tabSignature.Controls.Add(this.btnVerifyBrowsePublicKey);
            this.tabSignature.Controls.Add(this.txtVerifyPublicKey);
            this.tabSignature.Controls.Add(this.lblPublicKeyInput);
            this.tabSignature.Controls.Add(this.btnVerifyBrowseInput);
            this.tabSignature.Controls.Add(this.txtVerifyInput);
            this.tabSignature.Controls.Add(this.lblOriginalFile);
            this.tabSignature.Controls.Add(this.lblVerifyHeading);
            this.tabSignature.Controls.Add(this.btnSignFile);
            this.tabSignature.Controls.Add(this.btnSignBrowseOutput);
            this.tabSignature.Controls.Add(this.txtSignOutput);
            this.tabSignature.Controls.Add(this.lblSignOutput);
            this.tabSignature.Controls.Add(this.btnSignBrowsePrivateKey);
            this.tabSignature.Controls.Add(this.txtSignPrivateKey);
            this.tabSignature.Controls.Add(this.lblPrivateKeyInput);
            this.tabSignature.Controls.Add(this.btnSignBrowseInput);
            this.tabSignature.Controls.Add(this.txtSignInput);
            this.tabSignature.Controls.Add(this.label2);
            this.tabSignature.Controls.Add(this.lblSignatureHeading);
            this.tabSignature.Location = new System.Drawing.Point(4, 22);
            this.tabSignature.Name = "tabSignature";
            this.tabSignature.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignature.Size = new System.Drawing.Size(876, 535);
            this.tabSignature.TabIndex = 4;
            this.tabSignature.Text = "Digitalni potpis";
            this.tabSignature.UseVisualStyleBackColor = true;
            // 
            // btnSignBrowseInput
            // 
            this.btnSignBrowseInput.Location = new System.Drawing.Point(502, 106);
            this.btnSignBrowseInput.Name = "btnSignBrowseInput";
            this.btnSignBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnSignBrowseInput.TabIndex = 21;
            this.btnSignBrowseInput.Text = "Odaberi...";
            this.btnSignBrowseInput.UseVisualStyleBackColor = true;
            this.btnSignBrowseInput.Click += new System.EventHandler(this.btnSignBrowseInput_Click);
            // 
            // txtSignInput
            // 
            this.txtSignInput.Location = new System.Drawing.Point(146, 106);
            this.txtSignInput.Name = "txtSignInput";
            this.txtSignInput.ReadOnly = true;
            this.txtSignInput.Size = new System.Drawing.Size(350, 20);
            this.txtSignInput.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ulazna datoteka:";
            // 
            // lblSignatureHeading
            // 
            this.lblSignatureHeading.AutoSize = true;
            this.lblSignatureHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSignatureHeading.Location = new System.Drawing.Point(39, 61);
            this.lblSignatureHeading.Name = "lblSignatureHeading";
            this.lblSignatureHeading.Size = new System.Drawing.Size(181, 20);
            this.lblSignatureHeading.TabIndex = 18;
            this.lblSignatureHeading.Text = "Potpisivanje datoteke";
            // 
            // btnSignBrowsePrivateKey
            // 
            this.btnSignBrowsePrivateKey.Location = new System.Drawing.Point(502, 142);
            this.btnSignBrowsePrivateKey.Name = "btnSignBrowsePrivateKey";
            this.btnSignBrowsePrivateKey.Size = new System.Drawing.Size(75, 23);
            this.btnSignBrowsePrivateKey.TabIndex = 24;
            this.btnSignBrowsePrivateKey.Text = "Odaberi...";
            this.btnSignBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnSignBrowsePrivateKey.Click += new System.EventHandler(this.btnSignBrowsePrivateKey_Click);
            // 
            // txtSignPrivateKey
            // 
            this.txtSignPrivateKey.Location = new System.Drawing.Point(146, 142);
            this.txtSignPrivateKey.Name = "txtSignPrivateKey";
            this.txtSignPrivateKey.ReadOnly = true;
            this.txtSignPrivateKey.Size = new System.Drawing.Size(350, 20);
            this.txtSignPrivateKey.TabIndex = 23;
            // 
            // lblPrivateKeyInput
            // 
            this.lblPrivateKeyInput.AutoSize = true;
            this.lblPrivateKeyInput.Location = new System.Drawing.Point(39, 145);
            this.lblPrivateKeyInput.Name = "lblPrivateKeyInput";
            this.lblPrivateKeyInput.Size = new System.Drawing.Size(101, 13);
            this.lblPrivateKeyInput.TabIndex = 22;
            this.lblPrivateKeyInput.Text = "Privatni ključ (RSA):";
            // 
            // btnSignBrowseOutput
            // 
            this.btnSignBrowseOutput.Location = new System.Drawing.Point(502, 178);
            this.btnSignBrowseOutput.Name = "btnSignBrowseOutput";
            this.btnSignBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnSignBrowseOutput.TabIndex = 27;
            this.btnSignBrowseOutput.Text = "Odaberi...";
            this.btnSignBrowseOutput.UseVisualStyleBackColor = true;
            this.btnSignBrowseOutput.Click += new System.EventHandler(this.btnSignBrowseOutput_Click);
            // 
            // txtSignOutput
            // 
            this.txtSignOutput.Location = new System.Drawing.Point(146, 178);
            this.txtSignOutput.Name = "txtSignOutput";
            this.txtSignOutput.ReadOnly = true;
            this.txtSignOutput.Size = new System.Drawing.Size(350, 20);
            this.txtSignOutput.TabIndex = 26;
            // 
            // lblSignOutput
            // 
            this.lblSignOutput.AutoSize = true;
            this.lblSignOutput.Location = new System.Drawing.Point(70, 183);
            this.lblSignOutput.Name = "lblSignOutput";
            this.lblSignOutput.Size = new System.Drawing.Size(70, 13);
            this.lblSignOutput.TabIndex = 25;
            this.lblSignOutput.Text = "Izlazni potpis:";
            // 
            // btnSignFile
            // 
            this.btnSignFile.Location = new System.Drawing.Point(290, 217);
            this.btnSignFile.Name = "btnSignFile";
            this.btnSignFile.Size = new System.Drawing.Size(75, 26);
            this.btnSignFile.TabIndex = 28;
            this.btnSignFile.Text = "Potpiši";
            this.btnSignFile.UseVisualStyleBackColor = true;
            this.btnSignFile.Click += new System.EventHandler(this.btnSignFile_Click);
            // 
            // btnVerifyBrowseSignature
            // 
            this.btnVerifyBrowseSignature.Location = new System.Drawing.Point(516, 407);
            this.btnVerifyBrowseSignature.Name = "btnVerifyBrowseSignature";
            this.btnVerifyBrowseSignature.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyBrowseSignature.TabIndex = 38;
            this.btnVerifyBrowseSignature.Text = "Odaberi...";
            this.btnVerifyBrowseSignature.UseVisualStyleBackColor = true;
            this.btnVerifyBrowseSignature.Click += new System.EventHandler(this.btnVerifyBrowseSignature_Click);
            // 
            // txtVerifySignature
            // 
            this.txtVerifySignature.Location = new System.Drawing.Point(160, 407);
            this.txtVerifySignature.Name = "txtVerifySignature";
            this.txtVerifySignature.ReadOnly = true;
            this.txtVerifySignature.Size = new System.Drawing.Size(350, 20);
            this.txtVerifySignature.TabIndex = 37;
            // 
            // lblFileSignature
            // 
            this.lblFileSignature.AutoSize = true;
            this.lblFileSignature.Location = new System.Drawing.Point(63, 412);
            this.lblFileSignature.Name = "lblFileSignature";
            this.lblFileSignature.Size = new System.Drawing.Size(91, 13);
            this.lblFileSignature.TabIndex = 36;
            this.lblFileSignature.Text = "Datoteka potpisa:";
            // 
            // btnVerifyBrowsePublicKey
            // 
            this.btnVerifyBrowsePublicKey.Location = new System.Drawing.Point(516, 373);
            this.btnVerifyBrowsePublicKey.Name = "btnVerifyBrowsePublicKey";
            this.btnVerifyBrowsePublicKey.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyBrowsePublicKey.TabIndex = 35;
            this.btnVerifyBrowsePublicKey.Text = "Odaberi...";
            this.btnVerifyBrowsePublicKey.UseVisualStyleBackColor = true;
            this.btnVerifyBrowsePublicKey.Click += new System.EventHandler(this.btnVerifyBrowsePublicKey_Click);
            // 
            // txtVerifyPublicKey
            // 
            this.txtVerifyPublicKey.Location = new System.Drawing.Point(160, 373);
            this.txtVerifyPublicKey.Name = "txtVerifyPublicKey";
            this.txtVerifyPublicKey.ReadOnly = true;
            this.txtVerifyPublicKey.Size = new System.Drawing.Size(350, 20);
            this.txtVerifyPublicKey.TabIndex = 34;
            // 
            // lblPublicKeyInput
            // 
            this.lblPublicKeyInput.AutoSize = true;
            this.lblPublicKeyInput.Location = new System.Drawing.Point(63, 378);
            this.lblPublicKeyInput.Name = "lblPublicKeyInput";
            this.lblPublicKeyInput.Size = new System.Drawing.Size(91, 13);
            this.lblPublicKeyInput.TabIndex = 33;
            this.lblPublicKeyInput.Text = "Javni ključ (RSA):";
            // 
            // btnVerifyBrowseInput
            // 
            this.btnVerifyBrowseInput.Location = new System.Drawing.Point(516, 339);
            this.btnVerifyBrowseInput.Name = "btnVerifyBrowseInput";
            this.btnVerifyBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnVerifyBrowseInput.TabIndex = 32;
            this.btnVerifyBrowseInput.Text = "Odaberi...";
            this.btnVerifyBrowseInput.UseVisualStyleBackColor = true;
            this.btnVerifyBrowseInput.Click += new System.EventHandler(this.btnVerifyBrowseInput_Click);
            // 
            // txtVerifyInput
            // 
            this.txtVerifyInput.Location = new System.Drawing.Point(160, 339);
            this.txtVerifyInput.Name = "txtVerifyInput";
            this.txtVerifyInput.ReadOnly = true;
            this.txtVerifyInput.Size = new System.Drawing.Size(350, 20);
            this.txtVerifyInput.TabIndex = 31;
            // 
            // lblOriginalFile
            // 
            this.lblOriginalFile.AutoSize = true;
            this.lblOriginalFile.Location = new System.Drawing.Point(52, 342);
            this.lblOriginalFile.Name = "lblOriginalFile";
            this.lblOriginalFile.Size = new System.Drawing.Size(102, 13);
            this.lblOriginalFile.TabIndex = 30;
            this.lblOriginalFile.Text = "Originalna datoteka:";
            // 
            // lblVerifyHeading
            // 
            this.lblVerifyHeading.AutoSize = true;
            this.lblVerifyHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVerifyHeading.Location = new System.Drawing.Point(39, 292);
            this.lblVerifyHeading.Name = "lblVerifyHeading";
            this.lblVerifyHeading.Size = new System.Drawing.Size(138, 20);
            this.lblVerifyHeading.TabIndex = 29;
            this.lblVerifyHeading.Text = "Provjera potpisa";
            // 
            // btnVerifySignatureFile
            // 
            this.btnVerifySignatureFile.Location = new System.Drawing.Point(281, 447);
            this.btnVerifySignatureFile.Name = "btnVerifySignatureFile";
            this.btnVerifySignatureFile.Size = new System.Drawing.Size(100, 26);
            this.btnVerifySignatureFile.TabIndex = 39;
            this.btnVerifySignatureFile.Text = "Provjeri potpis";
            this.btnVerifySignatureFile.UseVisualStyleBackColor = true;
            this.btnVerifySignatureFile.Click += new System.EventHandler(this.btnVerifySignatureFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOS - Kriptografija";
            this.tabMain.ResumeLayout(false);
            this.tabKeys.ResumeLayout(false);
            this.tabKeys.PerformLayout();
            this.tabSymmetric.ResumeLayout(false);
            this.tabSymmetric.PerformLayout();
            this.tabHybrid.ResumeLayout(false);
            this.tabHybrid.PerformLayout();
            this.tabHash.ResumeLayout(false);
            this.tabHash.PerformLayout();
            this.tabSignature.ResumeLayout(false);
            this.tabSignature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKeys;
        private System.Windows.Forms.TabPage tabSymmetric;
        private System.Windows.Forms.TabPage tabHybrid;
        private System.Windows.Forms.TabPage tabHash;
        private System.Windows.Forms.TabPage tabSignature;
        private System.Windows.Forms.TextBox txtSymKeyPath;
        private System.Windows.Forms.Label lblSymKey;
        private System.Windows.Forms.Button btnGenerateSymKey;
        private System.Windows.Forms.Button btnBrowseSymKey;
        private System.Windows.Forms.Button btnBrowsePublicKey;
        private System.Windows.Forms.TextBox txtPublicKeyPath;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Button btnBrowsePrivateKey;
        private System.Windows.Forms.TextBox txtPrivateKeyPath;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.Button btnGenerateAsymKeys;
        private System.Windows.Forms.Label lblInputFileHeading;
        private System.Windows.Forms.TextBox txtSymInputFile;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.Button btnSymBrowseInput;
        private System.Windows.Forms.Label lblOutputFileHeading;
        private System.Windows.Forms.Button btnSymBrowseOutput;
        private System.Windows.Forms.TextBox txtSymOutputFile;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.Button btnSymDecrypt;
        private System.Windows.Forms.Button btnSymEncrypt;
        private System.Windows.Forms.Button btnSymBrowseKey;
        private System.Windows.Forms.TextBox txtSymKeyPath_Sym;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecretKeyHeading;
        private System.Windows.Forms.Button btnHybridDecrypt;
        private System.Windows.Forms.Button btnHybridEncrypt;
        private System.Windows.Forms.Button btnHybridBrowsePublicKey;
        private System.Windows.Forms.TextBox txtHybridPublicKey;
        private System.Windows.Forms.Label lblPublicKeyHybrid;
        private System.Windows.Forms.Label lblKeysHybridHeading;
        private System.Windows.Forms.Button btnHybridBrowseOutput;
        private System.Windows.Forms.TextBox txtHybridOutputFile;
        private System.Windows.Forms.Label lblOutputFileHybrid;
        private System.Windows.Forms.Label lblOutputHeading;
        private System.Windows.Forms.Button btnHybridBrowseInput;
        private System.Windows.Forms.TextBox txtHybridInputFile;
        private System.Windows.Forms.Label lblInputFileHybrid;
        private System.Windows.Forms.Label lblInputHeading;
        private System.Windows.Forms.Button btnHybridBrowsePrivateKey;
        private System.Windows.Forms.TextBox txtHybridPrivateKey;
        private System.Windows.Forms.Label lblPrivateKeyHybrid;
        private System.Windows.Forms.Button btnHashBrowseOutput;
        private System.Windows.Forms.TextBox txtHashOutputFile;
        private System.Windows.Forms.Label lblOutputFileHash;
        private System.Windows.Forms.Label lblOutputFileHashHeading;
        private System.Windows.Forms.Button btnHashBrowseInput;
        private System.Windows.Forms.TextBox txtHashInputFile;
        private System.Windows.Forms.Label lblInputFileHash;
        private System.Windows.Forms.Label lblInputFileHashHeading;
        private System.Windows.Forms.Label lblHashValueHeading;
        private System.Windows.Forms.Button btnComputeHash;
        private System.Windows.Forms.TextBox txtHashValue;
        private System.Windows.Forms.Label lblHashValue;
        private System.Windows.Forms.Button btnSignBrowseInput;
        private System.Windows.Forms.TextBox txtSignInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSignatureHeading;
        private System.Windows.Forms.Button btnSignBrowsePrivateKey;
        private System.Windows.Forms.TextBox txtSignPrivateKey;
        private System.Windows.Forms.Label lblPrivateKeyInput;
        private System.Windows.Forms.Button btnSignBrowseOutput;
        private System.Windows.Forms.TextBox txtSignOutput;
        private System.Windows.Forms.Label lblSignOutput;
        private System.Windows.Forms.Button btnSignFile;
        private System.Windows.Forms.Button btnVerifyBrowseSignature;
        private System.Windows.Forms.TextBox txtVerifySignature;
        private System.Windows.Forms.Label lblFileSignature;
        private System.Windows.Forms.Button btnVerifyBrowsePublicKey;
        private System.Windows.Forms.TextBox txtVerifyPublicKey;
        private System.Windows.Forms.Label lblPublicKeyInput;
        private System.Windows.Forms.Button btnVerifyBrowseInput;
        private System.Windows.Forms.TextBox txtVerifyInput;
        private System.Windows.Forms.Label lblOriginalFile;
        private System.Windows.Forms.Label lblVerifyHeading;
        private System.Windows.Forms.Button btnVerifySignatureFile;
    }
}

