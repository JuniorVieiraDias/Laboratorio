namespace Labetiq
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblError = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.txbRequis = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxImprUnica = new System.Windows.Forms.CheckBox();
            this.checkBoxEscolherImpressora = new System.Windows.Forms.CheckBox();
            this.checkBoxEXT = new System.Windows.Forms.CheckBox();
            this.checkBoxPAR = new System.Windows.Forms.CheckBox();
            this.checkBoxBAC = new System.Windows.Forms.CheckBox();
            this.checkBoxBIO = new System.Windows.Forms.CheckBox();
            this.checkBoxURO = new System.Windows.Forms.CheckBox();
            this.checkBoxIMU = new System.Windows.Forms.CheckBox();
            this.checkBoxHOR = new System.Windows.Forms.CheckBox();
            this.checkBoxHEM = new System.Windows.Forms.CheckBox();
            this.maskTbEtqUnica = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxControle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_LU_BAC = new System.Windows.Forms.CheckBox();
            this.checkBox_LU_BIO = new System.Windows.Forms.CheckBox();
            this.checkBox_LU_HEM = new System.Windows.Forms.CheckBox();
            this.checkBox_LU_HOR = new System.Windows.Forms.CheckBox();
            this.checkBox_LU_IMU = new System.Windows.Forms.CheckBox();
            this.checkBox_LU_PAR = new System.Windows.Forms.CheckBox();
            this.checkBox_LU_URI = new System.Windows.Forms.CheckBox();
            this.checkBoxComprovante = new System.Windows.Forms.CheckBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nº da Requisição:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(179, 97);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(112, 157);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // txbRequis
            // 
            this.txbRequis.Location = new System.Drawing.Point(168, 46);
            this.txbRequis.Mask = "00,LL,0,000000";
            this.txbRequis.Name = "txbRequis";
            this.txbRequis.Size = new System.Drawing.Size(93, 20);
            this.txbRequis.TabIndex = 4;
            this.txbRequis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbRequis_KeyPress);
            // 
            // checkBoxImprUnica
            // 
            this.checkBoxImprUnica.AutoSize = true;
            this.checkBoxImprUnica.Location = new System.Drawing.Point(304, 12);
            this.checkBoxImprUnica.Name = "checkBoxImprUnica";
            this.checkBoxImprUnica.Size = new System.Drawing.Size(59, 17);
            this.checkBoxImprUnica.TabIndex = 5;
            this.checkBoxImprUnica.Text = "UNICA";
            this.checkBoxImprUnica.UseVisualStyleBackColor = true;
            // 
            // checkBoxEscolherImpressora
            // 
            this.checkBoxEscolherImpressora.AutoSize = true;
            this.checkBoxEscolherImpressora.Location = new System.Drawing.Point(27, 101);
            this.checkBoxEscolherImpressora.Name = "checkBoxEscolherImpressora";
            this.checkBoxEscolherImpressora.Size = new System.Drawing.Size(120, 17);
            this.checkBoxEscolherImpressora.TabIndex = 7;
            this.checkBoxEscolherImpressora.Text = "Escolher impressora";
            this.checkBoxEscolherImpressora.UseVisualStyleBackColor = true;
            // 
            // checkBoxEXT
            // 
            this.checkBoxEXT.AutoSize = true;
            this.checkBoxEXT.Location = new System.Drawing.Point(305, 77);
            this.checkBoxEXT.Name = "checkBoxEXT";
            this.checkBoxEXT.Size = new System.Drawing.Size(47, 17);
            this.checkBoxEXT.TabIndex = 8;
            this.checkBoxEXT.Text = "EXT";
            this.checkBoxEXT.UseVisualStyleBackColor = true;
            // 
            // checkBoxPAR
            // 
            this.checkBoxPAR.AutoSize = true;
            this.checkBoxPAR.Location = new System.Drawing.Point(304, 101);
            this.checkBoxPAR.Name = "checkBoxPAR";
            this.checkBoxPAR.Size = new System.Drawing.Size(48, 17);
            this.checkBoxPAR.TabIndex = 9;
            this.checkBoxPAR.Text = "PAR";
            this.checkBoxPAR.UseVisualStyleBackColor = true;
            // 
            // checkBoxBAC
            // 
            this.checkBoxBAC.AutoSize = true;
            this.checkBoxBAC.Location = new System.Drawing.Point(304, 124);
            this.checkBoxBAC.Name = "checkBoxBAC";
            this.checkBoxBAC.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBAC.TabIndex = 10;
            this.checkBoxBAC.Text = "BAC";
            this.checkBoxBAC.UseVisualStyleBackColor = true;
            // 
            // checkBoxBIO
            // 
            this.checkBoxBIO.AutoSize = true;
            this.checkBoxBIO.Location = new System.Drawing.Point(304, 147);
            this.checkBoxBIO.Name = "checkBoxBIO";
            this.checkBoxBIO.Size = new System.Drawing.Size(44, 17);
            this.checkBoxBIO.TabIndex = 11;
            this.checkBoxBIO.Text = "BIO";
            this.checkBoxBIO.UseVisualStyleBackColor = true;
            // 
            // checkBoxURO
            // 
            this.checkBoxURO.AutoSize = true;
            this.checkBoxURO.Location = new System.Drawing.Point(304, 168);
            this.checkBoxURO.Name = "checkBoxURO";
            this.checkBoxURO.Size = new System.Drawing.Size(50, 17);
            this.checkBoxURO.TabIndex = 12;
            this.checkBoxURO.Text = "URO";
            this.checkBoxURO.UseVisualStyleBackColor = true;
            // 
            // checkBoxIMU
            // 
            this.checkBoxIMU.AutoSize = true;
            this.checkBoxIMU.Location = new System.Drawing.Point(358, 122);
            this.checkBoxIMU.Name = "checkBoxIMU";
            this.checkBoxIMU.Size = new System.Drawing.Size(46, 17);
            this.checkBoxIMU.TabIndex = 13;
            this.checkBoxIMU.Text = "IMU";
            this.checkBoxIMU.UseVisualStyleBackColor = true;
            // 
            // checkBoxHOR
            // 
            this.checkBoxHOR.AutoSize = true;
            this.checkBoxHOR.Location = new System.Drawing.Point(358, 143);
            this.checkBoxHOR.Name = "checkBoxHOR";
            this.checkBoxHOR.Size = new System.Drawing.Size(50, 17);
            this.checkBoxHOR.TabIndex = 14;
            this.checkBoxHOR.Text = "HOR";
            this.checkBoxHOR.UseVisualStyleBackColor = true;
            // 
            // checkBoxHEM
            // 
            this.checkBoxHEM.AutoSize = true;
            this.checkBoxHEM.Location = new System.Drawing.Point(358, 166);
            this.checkBoxHEM.Name = "checkBoxHEM";
            this.checkBoxHEM.Size = new System.Drawing.Size(50, 17);
            this.checkBoxHEM.TabIndex = 15;
            this.checkBoxHEM.Text = "HEM";
            this.checkBoxHEM.UseVisualStyleBackColor = true;
            // 
            // maskTbEtqUnica
            // 
            this.maskTbEtqUnica.Location = new System.Drawing.Point(358, 75);
            this.maskTbEtqUnica.Mask = "AAA";
            this.maskTbEtqUnica.Name = "maskTbEtqUnica";
            this.maskTbEtqUnica.Size = new System.Drawing.Size(28, 20);
            this.maskTbEtqUnica.TabIndex = 16;
            this.maskTbEtqUnica.Text = "000";
            // 
            // checkBoxControle
            // 
            this.checkBoxControle.AutoSize = true;
            this.checkBoxControle.Location = new System.Drawing.Point(450, 12);
            this.checkBoxControle.Name = "checkBoxControle";
            this.checkBoxControle.Size = new System.Drawing.Size(85, 17);
            this.checkBoxControle.TabIndex = 17;
            this.checkBoxControle.Text = "CONTROLE";
            this.checkBoxControle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "LU Exames";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "LC Exames";
            // 
            // checkBox_LU_BAC
            // 
            this.checkBox_LU_BAC.AutoSize = true;
            this.checkBox_LU_BAC.Location = new System.Drawing.Point(450, 97);
            this.checkBox_LU_BAC.Name = "checkBox_LU_BAC";
            this.checkBox_LU_BAC.Size = new System.Drawing.Size(47, 17);
            this.checkBox_LU_BAC.TabIndex = 20;
            this.checkBox_LU_BAC.Text = "BAC";
            this.checkBox_LU_BAC.UseVisualStyleBackColor = true;
            // 
            // checkBox_LU_BIO
            // 
            this.checkBox_LU_BIO.AutoSize = true;
            this.checkBox_LU_BIO.Location = new System.Drawing.Point(450, 120);
            this.checkBox_LU_BIO.Name = "checkBox_LU_BIO";
            this.checkBox_LU_BIO.Size = new System.Drawing.Size(44, 17);
            this.checkBox_LU_BIO.TabIndex = 21;
            this.checkBox_LU_BIO.Text = "BIO";
            this.checkBox_LU_BIO.UseVisualStyleBackColor = true;
            // 
            // checkBox_LU_HEM
            // 
            this.checkBox_LU_HEM.AutoSize = true;
            this.checkBox_LU_HEM.Location = new System.Drawing.Point(450, 143);
            this.checkBox_LU_HEM.Name = "checkBox_LU_HEM";
            this.checkBox_LU_HEM.Size = new System.Drawing.Size(50, 17);
            this.checkBox_LU_HEM.TabIndex = 22;
            this.checkBox_LU_HEM.Text = "HEM";
            this.checkBox_LU_HEM.UseVisualStyleBackColor = true;
            // 
            // checkBox_LU_HOR
            // 
            this.checkBox_LU_HOR.AutoSize = true;
            this.checkBox_LU_HOR.Location = new System.Drawing.Point(450, 166);
            this.checkBox_LU_HOR.Name = "checkBox_LU_HOR";
            this.checkBox_LU_HOR.Size = new System.Drawing.Size(50, 17);
            this.checkBox_LU_HOR.TabIndex = 23;
            this.checkBox_LU_HOR.Text = "HOR";
            this.checkBox_LU_HOR.UseVisualStyleBackColor = true;
            // 
            // checkBox_LU_IMU
            // 
            this.checkBox_LU_IMU.AutoSize = true;
            this.checkBox_LU_IMU.Location = new System.Drawing.Point(505, 122);
            this.checkBox_LU_IMU.Name = "checkBox_LU_IMU";
            this.checkBox_LU_IMU.Size = new System.Drawing.Size(46, 17);
            this.checkBox_LU_IMU.TabIndex = 24;
            this.checkBox_LU_IMU.Text = "IMU";
            this.checkBox_LU_IMU.UseVisualStyleBackColor = true;
            // 
            // checkBox_LU_PAR
            // 
            this.checkBox_LU_PAR.AutoSize = true;
            this.checkBox_LU_PAR.Location = new System.Drawing.Point(506, 145);
            this.checkBox_LU_PAR.Name = "checkBox_LU_PAR";
            this.checkBox_LU_PAR.Size = new System.Drawing.Size(48, 17);
            this.checkBox_LU_PAR.TabIndex = 25;
            this.checkBox_LU_PAR.Text = "PAR";
            this.checkBox_LU_PAR.UseVisualStyleBackColor = true;
            // 
            // checkBox_LU_URI
            // 
            this.checkBox_LU_URI.AutoSize = true;
            this.checkBox_LU_URI.Location = new System.Drawing.Point(506, 168);
            this.checkBox_LU_URI.Name = "checkBox_LU_URI";
            this.checkBox_LU_URI.Size = new System.Drawing.Size(45, 17);
            this.checkBox_LU_URI.TabIndex = 26;
            this.checkBox_LU_URI.Text = "URI";
            this.checkBox_LU_URI.UseVisualStyleBackColor = true;
            // 
            // checkBoxComprovante
            // 
            this.checkBoxComprovante.AutoSize = true;
            this.checkBoxComprovante.Location = new System.Drawing.Point(27, 153);
            this.checkBoxComprovante.Name = "checkBoxComprovante";
            this.checkBoxComprovante.Size = new System.Drawing.Size(89, 17);
            this.checkBoxComprovante.TabIndex = 27;
            this.checkBoxComprovante.Text = "Comprovante";
            this.checkBoxComprovante.UseVisualStyleBackColor = true;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printDialog2
            // 
            this.printDialog2.Document = this.printDocument2;
            this.printDialog2.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 211);
            this.Controls.Add(this.checkBoxComprovante);
            this.Controls.Add(this.checkBox_LU_URI);
            this.Controls.Add(this.checkBox_LU_PAR);
            this.Controls.Add(this.checkBox_LU_IMU);
            this.Controls.Add(this.checkBox_LU_HOR);
            this.Controls.Add(this.checkBox_LU_HEM);
            this.Controls.Add(this.checkBox_LU_BIO);
            this.Controls.Add(this.checkBox_LU_BAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxControle);
            this.Controls.Add(this.maskTbEtqUnica);
            this.Controls.Add(this.checkBoxHEM);
            this.Controls.Add(this.checkBoxHOR);
            this.Controls.Add(this.checkBoxIMU);
            this.Controls.Add(this.checkBoxURO);
            this.Controls.Add(this.checkBoxBIO);
            this.Controls.Add(this.checkBoxBAC);
            this.Controls.Add(this.checkBoxPAR);
            this.Controls.Add(this.checkBoxEXT);
            this.Controls.Add(this.checkBoxEscolherImpressora);
            this.Controls.Add(this.checkBoxImprUnica);
            this.Controls.Add(this.txbRequis);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ETIQUETA LABORATÓRIO  EXAMES V-35  ------  08.04.19";
            this.Enter += new System.EventHandler(this.btnImprimir_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblError;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MaskedTextBox txbRequis;
        private System.Windows.Forms.CheckBox checkBoxImprUnica;
        private System.Windows.Forms.CheckBox checkBoxEscolherImpressora;
        private System.Windows.Forms.CheckBox checkBoxEXT;
        private System.Windows.Forms.CheckBox checkBoxPAR;
        private System.Windows.Forms.CheckBox checkBoxBAC;
        private System.Windows.Forms.CheckBox checkBoxBIO;
        private System.Windows.Forms.CheckBox checkBoxURO;
        private System.Windows.Forms.CheckBox checkBoxIMU;
        private System.Windows.Forms.CheckBox checkBoxHOR;
        private System.Windows.Forms.CheckBox checkBoxHEM;
        private System.Windows.Forms.MaskedTextBox maskTbEtqUnica;
        private System.Windows.Forms.CheckBox checkBoxControle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_LU_BAC;
        private System.Windows.Forms.CheckBox checkBox_LU_BIO;
        private System.Windows.Forms.CheckBox checkBox_LU_HEM;
        private System.Windows.Forms.CheckBox checkBox_LU_HOR;
        private System.Windows.Forms.CheckBox checkBox_LU_IMU;
        private System.Windows.Forms.CheckBox checkBox_LU_PAR;
        private System.Windows.Forms.CheckBox checkBox_LU_URI;
        private System.Windows.Forms.CheckBox checkBoxComprovante;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PrintDialog printDialog2;

    }
}

