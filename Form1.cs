using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using GenCode128;
using System.Drawing.Printing;



namespace Labetiq
{
    public partial class Form1 : Form
    {
        String error;
        int status;
        DadosRequisicao detiq;
        HospubDados dados = new HospubDados();

        public Form1()
        {
            try
            {
                InitializeComponent();
                status = 0;
                error = "";

                // printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
                //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
                //printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);

                // teste Comprovante
               // printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
               // printDialog2.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);

            }
     
            catch (Exception ex)
            {
                string mensagem = ex.Message;
               
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {

            // printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
           // printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
           // printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);

            // teste Comprovante
           //  printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
            // printDialog2.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);

            // foi criado para escolher impressora para imprimir comprovante paciente
            // onde está else if (checkBoxEscolherImpressora.Checked == true)
            // antes era  if (checkBoxEscolherImpressora.Checked == true)
            if (checkBoxEscolherImpressora.Checked == true && checkBoxComprovante.Checked == true)
            {
                printDialog2.ShowDialog();
                backgroundWorker1.RunWorkerAsync();
                this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);

            }// criado em 20/10/2016

            else if (checkBoxEscolherImpressora.Checked == true)
            {

                //IMPRESSORA 
                printDialog1.ShowDialog();//escolher impressora versão para o quinto andar no quarto andar comentar esse trecho de codigo
                backgroundWorker1.RunWorkerAsync();
                this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);


            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);

            }
          
        

            btnImprimir.Enabled = false;
        }





        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            btnImprimir.Enabled = true;
            if (status == 1)
                lblError.Text = error;
            else
                this.lblError.ResetText();
            this.txbRequis.ResetText();
            this.txbRequis.Enabled = true;
            this.txbRequis.Focus();
            this.txbRequis.Text = "";


            // habilita o botão imprimir depois de terminado o processo de impressão das etiquetas
            btnImprimir.Enabled = true;

            // Para limpar os dados do usuario 
            //detiq.Nome = "";
            //detiq.TipoPac = "";
            //detiq.Idade = "";
            //detiq.Sexo = "";
            //detiq.Consulta = "";
            //detiq.Be = "";
            //detiq.Rh = "";
            //detiq.DtColeta = "";
            //detiq.HoraExm = "";
            //detiq.DtNascRH = "";
            //detiq.DtNascBE = "";

            // Para tirar o checked do campo comprovante
            checkBoxComprovante.Checked = false;
            checkBoxControle.Checked = false;
            checkBoxEXT.Checked = false;
            maskTbEtqUnica.Text = "000";
            checkBoxPAR.Checked = false;
            checkBoxBAC.Checked = false;
            checkBoxBIO.Checked = false;
            checkBoxURO.Checked = false;
            checkBoxIMU.Checked = false;
            checkBoxHOR.Checked = false;
            checkBoxHEM.Checked = false;
            checkBox_LU_BAC.Checked = false;
            checkBox_LU_BIO.Checked = false;
            checkBox_LU_HEM.Checked = false;
            checkBox_LU_HOR.Checked = false;
            checkBox_LU_IMU.Checked = false;
            checkBox_LU_PAR.Checked = false;
            checkBox_LU_URI.Checked = false;
            checkBoxImprUnica.Checked = false;



        }




        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                //string _requis = null;
                string _requis = txbRequis.Text.Replace(".", "");//.ToUpper();
                detiq = dados.getDados(_requis);




                if (!(detiq == null))
                {


                    //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110); //("Custom2", 200, 110.old)
                    //printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
                    // teste comprovante
                    //printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110); //("Custom2", 200, 110.old)
                    //printDialog2.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);



                    if (checkBoxImprUnica.Checked != true)
                    {

                        #region Função imprimir original

                        // /*

                        #region imprimir etiquetas
                        // 29/07/2016

                        if (detiq.ControleEtiq1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.ControleEtiq21 != "")
                        {
                            printDocument1.Print();
                        }


                        #region URO  ok 25/03/2015

                        if (detiq.CodExameURO != "")
                        {
                            printDocument1.Print();

                        }
                        if (detiq.CodExameURO_ET_2 != "")
                        {
                            printDocument1.Print();

                        }
                        if (detiq.CodExameURO2 != "")
                        {
                            printDocument1.Print();

                        }
                        if (detiq.CodExameURO_ET_22 != "")
                        {
                            printDocument1.Print();

                        }
                        if (detiq.CodExameURO_CR4 != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion
                        #region EXT

                        // PT3 Ele vai sair em 2 etiquetas 1 junto aos demais exames de HOR e 1 sozinho como exame externo Amarelo
                        // ESSE EXAME PERTENCE AO GRUPO HOR MAS ESSA COPIA TEM QUE SAIR COM ETIQUETA EXT AMARELO
                        if (detiq.CodExameHOR_PT3 != "")
                        {
                            printDocument1.Print();
                        }
                        #region Bancada 1 exames externos
                        if (detiq.CodExame_EXT_AM_BC_1 != "")
                        {
                            //DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1, "Confirmação", MessageBoxButtons.YesNo);
                            //if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //    detiq.CodExame_EXT_AM_BC_1 = "";
                        }

                        //"TOC" "TRA" "ESQ"
                        if (detiq.CodExame_EXT_AM_BC_1_TOC != "")
                        {
                            //DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_TOC, "Confirmação", MessageBoxButtons.YesNo);
                            //if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //    detiq.CodExame_EXT_AM_BC_1_TOC = "";
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_TRA != "")
                        {
                            //DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_TRA, "Confirmação", MessageBoxButtons.YesNo);
                            //if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //    detiq.CodExame_EXT_AM_BC_1_TRA = "";
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_ESQ != "")
                        {
                            printDocument1.Print();
                        }
                        // "RIB"  "IGF"  "TBG"
                        if (detiq.CodExame_EXT_AM_BC_1_RIB != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_IGF != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_TBG != "")
                        {
                            printDocument1.Print();
                        }
                        //"PCC" "PEP" "PVR"
                        if (detiq.CodExame_EXT_AM_BC_1_PCC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_PEP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_PVR != "")
                        {
                            printDocument1.Print();
                        }
                        // "MON"  "MIC" "PCB"
                        if (detiq.CodExame_EXT_AM_BC_1_MON != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_MIC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_PCB != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 != "")
                        {
                            printDocument1.Print();
                        }

                        //"IST"  "LIT"  "LYM"
                        if (detiq.CodExame_EXT_AM_BC_1_IST != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_LIT != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_LYM != "")
                        {
                            printDocument1.Print();
                        }

                        //"IF3"  "IEP"  "FIX"
                        if (detiq.CodExame_EXT_AM_BC_1_IF3 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_IEP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_FIX != "")
                        {
                            printDocument1.Print();
                        }
                        //"HER"  "HOM"  "HTL"
                        if (detiq.CodExame_EXT_AM_BC_1_HER != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_HOM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_HTL != "")
                        {
                            printDocument1.Print();
                        }
                        //"GAT"  "GEC"  "HPT"
                        if (detiq.CodExame_EXT_AM_BC_1_GAT != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_GEC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_HPT != "")
                        {
                            printDocument1.Print();
                        }
                        //"ENA"  "EQU"  "ERT"
                        if (detiq.CodExame_EXT_AM_BC_1_ENA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_EQU != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_ERT != "")
                        {
                            printDocument1.Print();
                        }
                        //"DHE" "DGX" "EPR"
                        if (detiq.CodExame_EXT_AM_BC_1_DHE != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_DGX != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_EPR != "")
                        {
                            printDocument1.Print();
                        }

                        //"CVC" "CER" "COC"
                        if (detiq.CodExame_EXT_AM_BC_1_CVC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CVC_2ET != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_AM_BC_1_CER != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_COC != "")
                        {
                            printDocument1.Print();
                        }

                        // "CAC"  "CFF"  
                        if (detiq.CodExame_EXT_AM_BC_1_CAC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CFF != "")
                        {
                            printDocument1.Print();
                        }

                        //"BG2"  "C1E" "CAI"
                        if (detiq.CodExame_EXT_AM_BC_1_BG2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_C1E != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CAI != "")
                        {
                            printDocument1.Print();
                        }

                        //"ATR"  "ACN" "CCP"
                        if (detiq.CodExame_EXT_AM_BC_1_ATR != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_ACN != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CCP != "")
                        {
                            printDocument1.Print();
                        }
                        //"AIN"  "LKM"  "MUE"
                        if (detiq.CodExame_EXT_AM_BC_1_AIN != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_LKM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_MUE != "")
                        {
                            printDocument1.Print();
                        }
                        //"ASM"  "SSA"  "SSB"
                        if (detiq.CodExame_EXT_AM_BC_1_ASM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_SSA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_SSB != "")
                        {
                            printDocument1.Print();
                        }
                        //"MUL" "RNP" "S70"
                        if (detiq.CodExame_EXT_AM_BC_1_MUL != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_RNP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_S70 != "")
                        {
                            printDocument1.Print();
                        }

                        //"ILH" "JO1"  "MIT"
                        if (detiq.CodExame_EXT_AM_BC_1_ILH != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_JO1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_MIT != "")
                        {
                            printDocument1.Print();
                        }
                        //"AEN" "GAD" "AGL"
                        if (detiq.CodExame_EXT_AM_BC_1_AEN != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_GAD != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_AGL != "")
                        {
                            printDocument1.Print();
                        }
                        // "AAT"  "DRO" "CAD" "PAR" "CEN"
                        if (detiq.CodExame_EXT_AM_BC_1_AAT != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_DRO != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CAD != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_PAR != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_CEN != "")
                        {
                            //DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CEN, "Confirmação", MessageBoxButtons.YesNo);
                            //if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //    detiq.CodExame_EXT_AM_BC_1_CEN = "";
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_ADO != "")
                        {
                            //    DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ADO, "Confirmação", MessageBoxButtons.YesNo);
                            //    if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //    detiq.CodExame_EXT_AM_BC_1_ADO = "";
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_B2G != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_AM_BC_1_LAS != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_AM_BC_1_ADA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_1_C17 != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_AM_BC_1_T20 != "")
                        {
                            printDocument1.Print();
                        }

                        #endregion

                        #region Bancada 2
                        if (detiq.CodExame_EXT_AM_BC_2 != "")
                        {
                            printDocument1.Print();
                        }
                        //"TIF"  "LEP"  "SVA"  "VRS"
                        if (detiq.CodExame_EXT_AM_BC_2_TIF != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_2_LEP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_2_SVA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_2_VRS != "")
                        {
                            printDocument1.Print();
                        }

                        //"BLA"  "CLA"  "DEN"
                        if (detiq.CodExame_EXT_AM_BC_2_BLA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_2_CLA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_2_DEN != "")
                        {
                            printDocument1.Print();
                        }


                        #endregion

                        #region bancada 3 amarelo

                        if (detiq.CodExame_EXT_AM_BC_3 != "")
                        {
                            printDocument1.Print();
                        }
                        //"FRT"  "GHH"  "SUA" "HTG"
                        if (detiq.CodExame_EXT_AM_BC_3_FRT != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_3_GHH != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_3_SUA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_3_HTG != "")
                        {
                            printDocument1.Print();
                        }
                        //"RUA"  "TOA"  "HBM" "CTX"
                        if (detiq.CodExame_EXT_AM_BC_3_RUA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_3_TOA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_3_HBM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AM_BC_3_CTX != "")
                        {
                            printDocument1.Print();
                        }


                        #endregion


                        #region ext bancada 1 MA
                        if (detiq.CodExame_EXT_MA_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        //"CSP"  "EIS"  "FRU" "GAL"
                        if (detiq.CodExame_EXT_MA_BC_1_CSP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_MA_BC_1_EIS != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_MA_BC_1_FRU != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_MA_BC_1_GAL != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion

                        #region ext bancada 1 24
                        if (detiq.CodExame_EXT_24_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        //CIU
                        if (detiq.CodExame_EXT_24_BC_1_CIU != "")
                        {
                            printDocument1.Print();
                        }
                        //OXU
                        if (detiq.CodExame_EXT_24_BC_1_OXU != "")
                        {
                            printDocument1.Print();
                        }

                        // "IMU" "MET" "BJO"  "CTU"
                        if (detiq.CodExame_EXT_24_BC_1_IMU != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_24_BC_1_MET != "")
                        {
                            //DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_MET, "Confirmação", MessageBoxButtons.YesNo);
                            //if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //detiq.CodExame_EXT_24_BC_1_MET = "";
                        }
                        if (detiq.CodExame_EXT_24_BC_1_BJO != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_24_BC_1_CTU != "")
                        {
                            //DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_CTU, "Confirmação", MessageBoxButtons.YesNo);
                            //if (confirm.ToString().ToUpper() == "YES")

                            printDocument1.Print();
                            //else
                            //    detiq.CodExame_EXT_24_BC_1_CTU = "";
                        }
                        //"C0U"  "COP"  "EPU"
                        if (detiq.CodExame_EXT_24_BC_1_C0U != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_24_BC_1_COP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_24_BC_1_EPU != "")
                        {
                            printDocument1.Print();
                        }

                        //"VMA" "ADU" "CIT"
                        if (detiq.CodExame_EXT_24_BC_1_VMA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_24_BC_1_ADU != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_24_BC_1_CIT != "")
                        {
                            printDocument1.Print();
                        }



                        #endregion



                        if (detiq.CodExame_EXT_24_BC_3 != "")
                        {
                            printDocument1.Print();
                        }

                        #region ext bancada 1 br
                        if (detiq.CodExame_EXT_BR_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        //"COB" "ZIN"
                        if (detiq.CodExame_EXT_BR_BC_1_COB != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_BR_BC_1_ZIN != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion

                        #region ext bancada 1 FR
                        if (detiq.CodExame_EXT_FR_BC_1 != "")
                        {
                            printDocument1.Print();
                        }

                        //"CFE" "EIU" "ION"  "MER" "TEP"
                        if (detiq.CodExame_EXT_FR_BC_1_CFE != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_FR_BC_1_EIU != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_FR_BC_1_ION != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_FR_BC_1_MER != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_FR_BC_1_TEP != "")
                        {
                            printDocument1.Print();
                        }

                        #endregion


                        if (detiq.CodExame_EXT_FR_BC_3 != "")
                        {
                            printDocument1.Print();
                        }

                        #region ext bancada 1 LB
                        if (detiq.CodExame_EXT_LB_BC_1 != "")
                        {
                            printDocument1.Print();
                        }

                        // "EFL""IML"
                        if (detiq.CodExame_EXT_LB_BC_1_EFL != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_LB_BC_1_IML != "")
                        {
                            printDocument1.Print();
                        }


                        #endregion

                        if (detiq.CodExame_EXT_LB_BC_2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_SE_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AS_BC_3 != "")
                        {
                            printDocument1.Print();
                        }

                        #region ext bancada 1 VE
                        if (detiq.CodExame_EXT_VE_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"
                        if (detiq.CodExame_EXT_VE_BC_1_CAB != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_VE_BC_1_H50 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_VE_BC_1_CRI != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_VE_BC_1_VAN != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_VE_BC_1_FNI != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_VE_BC_1_FNB != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion


                        if (detiq.CodExame_EXT_VD_BC_3 != "")
                        {
                            printDocument1.Print();
                        }
                        //DXI
                        if (detiq.CodExame_EXT_CI_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_CI_BC_1_2ET != "")
                        {
                            printDocument1.Print();
                        }
                        //"DXB"
                        if (detiq.CodExame_EXT_CI_BC_1_DXB != "")
                        {
                            printDocument1.Print();
                        }


                        #region ext bancada 1 RO
                        if (detiq.CodExame_EXT_RO_BC_1 != "")
                        {
                            printDocument1.Print();
                        }
                        //CVB
                        if (detiq.CodExame_EXT_RO_BC_1_CVB != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_CVB_2ET != "")
                        {
                            printDocument1.Print();
                        }

                        // "PRM" "CD8"  "XFR" "ACT"
                        if (detiq.CodExame_EXT_RO_BC_1_PRM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_CD8 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_XFR != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_ACT != "")
                        {
                            printDocument1.Print();
                        }

                        //"G6P"  "B27"  "JAK"
                        if (detiq.CodExame_EXT_RO_BC_1_G6P != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_G6P_2ET != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_RO_BC_1_B27 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_JAK != "")
                        {
                            printDocument1.Print();
                        }

                        //"CIC" "EHE"  "FVP"
                        if (detiq.CodExame_EXT_RO_BC_1_CIC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_EHE != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_FVP != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion
                        if (detiq.CodExame_EXT_RO_BC_3 != "")
                        {
                            printDocument1.Print();
                        }

                        //"BNN"                                   

                        if (detiq.CodExame_EXT_RO_BC_3_BNN != "")
                        {
                            printDocument1.Print();
                        }


                        if (detiq.CodExame_EXT_PPT_CVH != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_PPT_CVH_ET_2 != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_RO_BC_1_2ET_HEP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_IMO != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_ISP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_HEH != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_PHT != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_CAG != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET != "")
                        {
                            printDocument1.Print();
                        }




                        #region ext bancada 1 AZ



                        if (detiq.CodExame_EXT_AZ_BC_1_1ET != "")
                        {
                            printDocument1.Print();
                        }
                        //"AT3"  "RIT" "PCS"
                        if (detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_1ET_RIT != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 != "")
                        {
                            printDocument1.Print();
                        }


                        #endregion

                        #region EXT bancada 1 AZ 2


                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1 != "")
                        {
                            printDocument1.Print();
                        }
                        //"F11" "F12"
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 != "")
                        {
                            printDocument1.Print();
                        }
                        //"FC8" "FVW" "F10"
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 != "")
                        {
                            printDocument1.Print();
                        }
                        //"FC9" "FC5"  "FC7"
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 != "")
                        {
                            printDocument1.Print();
                        }

                        #endregion


                        if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 != "")
                        {
                            printDocument1.Print();
                        }
                        //if (detiq.CodExame_EXT_RO_BC_1_HIV != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        //if (detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        #endregion
                        #region HOR Tem que Ficar antes de BIO

                        if (detiq.CodExameHOR != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C22 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C22_30 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C22_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C22_90 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C22_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_30 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_90 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_180 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_240 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_CP2_300 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_SG2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_SG2_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_SC2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_SC2_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C32 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C32_30 != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExameHOR_T14_BIO_C32_60 != "")
                        {
                            printDocument1.Print();
                        }

                        if (detiq.CodExameHOR_T14_BIO_C32_90 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C32_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHOR_T14_BIO_C32_180 != "")
                        {
                            printDocument1.Print();
                        }


                        #endregion
                        #region BAC

                        if (detiq.CodExameBAC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBAC_FV != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBAC_BK2 != "")
                        {
                            printDocument1.Print();
                        }


                        if (detiq.CodExameBAC_HA != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBAC_HN != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBAC_HP != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion
                        #region BIO
                        if (detiq.CodExameBIO_FR_RPC != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_AM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_AM_AM != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_AM_24 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_LB != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_24 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_FR != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_SE != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_OU != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_RO != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_G1_2ET != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_G1_2ET_1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_G1_4ET != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_G1_4ET_1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_G1_4ET_2 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_G1_4ET_3 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_30 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_60 != "")
                        {
                            printDocument1.Print();
                        }

                        //if (detiq.CodExameBIO_CID_GLICOSE != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        if (detiq.CodExameBIO_CIP != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_5_ET_0 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_5_ET_30 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_5_ET_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_5_ET_90 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_5_ET_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_0 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_30 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_90 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_180 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_240 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CID_8_ET_300 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_2_ET_0 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_2_ET_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_2_ET_CS2_0 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_2_ET_CS2_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_6_ET_0 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_6_ET_30 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_6_ET_60 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_6_ET_90 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_6_ET_120 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_CI_6_ET_180 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameBIO_SER_GS6 != "")
                        {
                            printDocument1.Print();
                        }
                        // teste T14 cinza

                        //if (detiq.CodExameBIO_CINZA_T14_0 != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        //if (detiq.CodExameBIO_CINZA_T14_30 != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        //if (detiq.CodExameBIO_CINZA_T14_60 != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        //if (detiq.CodExameBIO_CINZA_T14_90 != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        //if (detiq.CodExameBIO_CINZA_T14_120 != "")
                        //{
                        //    printDocument1.Print();
                        //}
                        //if (detiq.CodExameBIO_CINZA_T14_180 != "")
                        //{
                        //    printDocument1.Print();
                        //}


                        // TODO terminar 

                        #endregion
                        #region Função Imprimir HEM  OK  24/03/2015

                        if (detiq.CodExameHEM_Rox != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHEM_Azul != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHEM_DI != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameHEM_BR != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion
                        #region IMU - chamada de função imprimir // ok 19/03/2015

                        if (detiq.CodExameIMU_Amarelo != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameIMU_U12 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameIMU_U24 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExameIMU_COU != "")//FR
                        {
                            printDocument1.Print();
                        }
                        #endregion
                        #region PAR ok 24/03/2015

                        if (detiq.CodExamePAR != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.CodExamePAR_FI != "")
                        {
                            printDocument1.Print();
                        }
                        #endregion

                        //LU
                        #region LU
                        if (detiq.LU_codExame_BAC_BK1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_BAC_DI1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_BIO_AM1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_BIO_LB1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_BIO_SE1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_HEM_AZ1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_HEM_RO1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_HEM_DI1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_HEM_LB1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_HOR_AM1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_IMU_RO1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_IMU_AM1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_IMU_LB1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_PAR_FR1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_URI_FR1 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.LU_codExame_URI_FR_ET_21 != "")
                        {
                            printDocument1.Print();
                        }
                        if (detiq.Nao_Classificado1 != "")
                        {
                            printDocument1.Print();
                        }
                        // comprovante
                        //try
                        //{
                        if (detiq.ComprovantePaciente1 != "" && checkBoxComprovante.Checked == true)
                        {

                            printDocument2.Print();

                        }
                        else
                        {
                            detiq.ComprovantePaciente1 = "";
                        }
                        
                        /*limpar dados do paciente
                        detiq.Nome = "";
                        detiq.TipoPac = "";
                        detiq.Idade = "";
                        detiq.Sexo = "";
                        detiq.Consulta = "";
                        detiq.Be = "";
                        detiq.Rh = "";
                        detiq.DtColeta = "";
                        detiq.HoraExm = "";
                        detiq.DtNascRH = "";
                        detiq.DtNascBE = "";

                        // Teste Junior 05/04/2019
                     //   txbRequis = null;
                        detiq.NovaImagem1 = null;
                       // detiq = null; // Junior 08.04.2019

                        /*try
                        {
                            
                            Application.Restart();
                            detiq = null;

                        }
                        catch (Exception )
                        {
                            //MessageBox.Show(ex.Message);
                            
                            
                        }*/

                        
                        //MessageBox.Show("FIM DO PROGRAMA");

                        //}
                        //catch (Exception xxx)
                        //{

                        //   MessageBox.Show( xxx.Message);
                        //}



                        #endregion
                        //// Imprimi as etiquetas de controle 2 etiquetas

                        //for (int i = 0; i < 2; i++)
                        //    printDocument1.Print();

                        #endregion
                        //  */ 
                        #endregion
                    }

                    else
                    {


                        {
                            #region Função imprimir etiqueta unica.


                            #region imprimir etiquetas unicas
                            string mnemonico = maskTbEtqUnica.Text.ToUpper();


                            if (detiq.ControleEtiq1 != "")
                            {
                                detiq.ControleEtiq1 = "";
                                // printDocument1.Print();
                            }
                            if (detiq.ControleEtiq21 != "" && checkBoxControle.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.Nome, "CONTROLE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.ControleEtiq21 = "";
                            }
                            else
                                detiq.ControleEtiq21 = "";


                            #region URO  ok 25/03/2015
                            //********************************************************//
                            if (detiq.CodExameURO != "" && checkBoxURO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameURO, "URO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameURO = "";
                            }
                            else
                                detiq.CodExameURO = "";
                            //********************************************************//
                            if (detiq.CodExameURO_ET_2 != "" && checkBoxURO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameURO_ET_2, "URO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameURO_ET_2 = "";
                            }
                            else
                                detiq.CodExameURO_ET_2 = "";
                            //********************************************************//
                            if (detiq.CodExameURO2 != "" && checkBoxURO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameURO2, "URO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameURO2 = "";
                            }
                            else
                                detiq.CodExameURO2 = "";
                            //********************************************************//
                            if (detiq.CodExameURO_ET_22 != "" && checkBoxURO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameURO_ET_22, "URO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameURO_ET_22 = "";
                            }
                            else
                                detiq.CodExameURO_ET_22 = "";
                            //********************************************************//
                            if (detiq.CodExameURO_CR4 != "" && checkBoxURO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameURO_CR4, "URO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameURO_CR4 = "";
                            }
                            else
                                detiq.CodExameURO_CR4 = "";
                            //********************************************************//

                            #endregion
                            #region EXT
                            // PT3 //agora é PT5 Ele vai sair em 2 etiquetas 1 junto aos demais exames de HOR e 1 sozinho como exame externo Amarelo
                            // ESSE EXAME PERTENCE AO GRUPO HOR MAS ESSA COPIA TEM QUE SAIR COM ETIQUETA EXT AMARELO
                            if (detiq.CodExameHOR_PT3 != "" && checkBoxEXT.Checked == true && mnemonico == "PT6" || (detiq.CodExameHOR_PT3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_PT3, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_PT3 = "";
                            }
                            else
                                detiq.CodExameHOR_PT3 = "";
                            //********************************************************//



                            #region Bancada 1 exames externos
                            if (detiq.CodExame_EXT_AM_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "17O" || (detiq.CodExame_EXT_AM_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))//17O
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1 = "";
                            //********************************************************//
                            //"TOC" "TRA" "ESQ"
                            if (detiq.CodExame_EXT_AM_BC_1_TOC != "" && checkBoxEXT.Checked == true && mnemonico == "TOC" || (detiq.CodExame_EXT_AM_BC_1_TOC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_TOC, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_TOC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_TOC = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_TRA != "" && checkBoxEXT.Checked == true && mnemonico == "TRA" || (detiq.CodExame_EXT_AM_BC_1_TRA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_TRA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_TRA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_TRA = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_ESQ != "" && checkBoxEXT.Checked == true && mnemonico == "ESQ" || (detiq.CodExame_EXT_AM_BC_1_ESQ != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ESQ, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ESQ = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ESQ = "";

                            //********************************************************//

                            // "RIB"  "IGF"  "TBG"
                            if (detiq.CodExame_EXT_AM_BC_1_RIB != "" && checkBoxEXT.Checked == true && mnemonico == "RIB" || (detiq.CodExame_EXT_AM_BC_1_RIB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_RIB, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_RIB = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_RIB = "";

                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_IGF != "" && checkBoxEXT.Checked == true && mnemonico == "IGF" || (detiq.CodExame_EXT_AM_BC_1_IGF != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_IGF, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_IGF = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_IGF = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_TBG != "" && checkBoxEXT.Checked == true && mnemonico == "TBG" || (detiq.CodExame_EXT_AM_BC_1_TBG != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_TBG, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_TBG = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_TBG = "";

                            //********************************************************//
                            //"PCC" "PEP" "PVR"
                            if (detiq.CodExame_EXT_AM_BC_1_PCC != "" && checkBoxEXT.Checked == true && mnemonico == "PCC" || (detiq.CodExame_EXT_AM_BC_1_PCC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {

                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_PCC, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_PCC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_PCC = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "PCC" || (detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {

                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_PCC_ET_2, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_PEP != "" && checkBoxEXT.Checked == true && mnemonico == "PEP" || (detiq.CodExame_EXT_AM_BC_1_PEP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_PEP, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_PEP = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_PEP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_PVR != "" && checkBoxEXT.Checked == true && mnemonico == "PVR" || (detiq.CodExame_EXT_AM_BC_1_PVR != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_PVR, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_PVR = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_PVR = "";
                            //********************************************************//
                            // "MON"  "MIC" "PCB"
                            if (detiq.CodExame_EXT_AM_BC_1_MON != "" && checkBoxEXT.Checked == true && mnemonico == "MON" || (detiq.CodExame_EXT_AM_BC_1_MON != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_MON, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_MON = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_MON = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_MIC != "" && checkBoxEXT.Checked == true && mnemonico == "MIC" || (detiq.CodExame_EXT_AM_BC_1_MIC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_MIC, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_MIC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_MIC = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_PCB != "" && checkBoxEXT.Checked == true && mnemonico == "PCB" || (detiq.CodExame_EXT_RO_BC_1_PCB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_PCB, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_PCB = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_PCB = "";
                            //*******************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "PCB" || (detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_PCB_ET_2, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 = "";
                            //********************************************************//
                            //"IST"  "LIT"  "LYM"
                            if (detiq.CodExame_EXT_AM_BC_1_IST != "" && checkBoxEXT.Checked == true && mnemonico == "IST" || (detiq.CodExame_EXT_AM_BC_1_IST != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_IST, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_IST = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_IST = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_LIT != "" && checkBoxEXT.Checked == true && mnemonico == "LIT" || (detiq.CodExame_EXT_AM_BC_1_LIT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_LIT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_LIT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_LIT = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_LYM != "" && checkBoxEXT.Checked == true && mnemonico == "LYM" || (detiq.CodExame_EXT_AM_BC_1_LYM != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_LYM, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_LYM = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_LYM = "";
                            //********************************************************//

                            //"IF3"  "IEP"  "FIX"
                            if (detiq.CodExame_EXT_AM_BC_1_IF3 != "" && checkBoxEXT.Checked == true && mnemonico == "IF3" || (detiq.CodExame_EXT_AM_BC_1_IF3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_IF3, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_IF3 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_IF3 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_IEP != "" && checkBoxEXT.Checked == true && mnemonico == "IEP" || (detiq.CodExame_EXT_AM_BC_1_IEP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_IEP, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_IEP = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_IEP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_FIX != "" && checkBoxEXT.Checked == true && mnemonico == "FIX" || (detiq.CodExame_EXT_AM_BC_1_FIX != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_FIX, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_FIX = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_FIX = "";
                            //********************************************************//
                            //"HER"  "HOM"  "HTL"
                            if (detiq.CodExame_EXT_AM_BC_1_HER != "" && checkBoxEXT.Checked == true && mnemonico == "HER" || (detiq.CodExame_EXT_AM_BC_1_HER != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_HER, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_HER = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_HER = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_HOM != "" && checkBoxEXT.Checked == true && mnemonico == "HOM" || (detiq.CodExame_EXT_AM_BC_1_HOM != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_HOM, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_HOM = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_HOM = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_HTL != "" && checkBoxEXT.Checked == true && mnemonico == "HTL" || (detiq.CodExame_EXT_AM_BC_1_HTL != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_HTL, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_HTL = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_HTL = "";
                            //********************************************************//
                            //"GAT"  "GEC"  "HPT"
                            if (detiq.CodExame_EXT_AM_BC_1_GAT != "" && checkBoxEXT.Checked == true && mnemonico == "GAT" || (detiq.CodExame_EXT_AM_BC_1_GAT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_GAT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_GAT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_GAT = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_GEC != "" && checkBoxEXT.Checked == true && mnemonico == "GEC" || (detiq.CodExame_EXT_AM_BC_1_GEC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_GEC, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_GEC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_GEC = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "GEC" || (detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_GEC_ET_2, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_HPT != "" && checkBoxEXT.Checked == true && mnemonico == "HPT" || (detiq.CodExame_EXT_AM_BC_1_HPT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_HPT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_HPT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_HPT = "";
                            //********************************************************//
                            //"ENA"  "EQU"  "ERT"
                            if (detiq.CodExame_EXT_AM_BC_1_ENA != "" && checkBoxEXT.Checked == true && mnemonico == "ENA" || (detiq.CodExame_EXT_AM_BC_1_ENA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ENA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ENA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ENA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_EQU != "" && checkBoxEXT.Checked == true && mnemonico == "EQU" || (detiq.CodExame_EXT_AM_BC_1_EQU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_EQU, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_EQU = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_EQU = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_ERT != "" && checkBoxEXT.Checked == true && mnemonico == "ERT" || (detiq.CodExame_EXT_AM_BC_1_ERT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ERT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ERT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ERT = "";
                            //********************************************************//
                            //"DHE" "DGX" "EPR"
                            if (detiq.CodExame_EXT_AM_BC_1_DHE != "" && checkBoxEXT.Checked == true && mnemonico == "DHE" || (detiq.CodExame_EXT_AM_BC_1_DHE != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_DHE, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_DHE = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_DHE = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_DGX != "" && checkBoxEXT.Checked == true && mnemonico == "DGX" || (detiq.CodExame_EXT_AM_BC_1_DGX != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_DGX, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_DGX = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_DGX = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_EPR != "" && checkBoxEXT.Checked == true && mnemonico == "EPR" || (detiq.CodExame_EXT_AM_BC_1_EPR != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_EPR, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_EPR = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_EPR = "";
                            //********************************************************//
                            //"CVC" "CER" "COC"
                            if (detiq.CodExame_EXT_AM_BC_1_CVC != "" && checkBoxEXT.Checked == true && mnemonico == "CVC" || (detiq.CodExame_EXT_AM_BC_1_CVC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CVC, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CVC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CVC = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CVC_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "CVC" || (detiq.CodExame_EXT_AM_BC_1_CVC_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CVC_2ET, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CVC_2ET = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CVC_2ET = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_CER != "" && checkBoxEXT.Checked == true && mnemonico == "CER" || (detiq.CodExame_EXT_AM_BC_1_CER != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CER, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CER = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CER = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_COC != "" && checkBoxEXT.Checked == true && mnemonico == "COC" || (detiq.CodExame_EXT_AM_BC_1_COC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_COC, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_COC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_COC = "";
                            //********************************************************//

                            // "CAC"  "CFF"  
                            if (detiq.CodExame_EXT_AM_BC_1_CAC != "" && checkBoxEXT.Checked == true && mnemonico == "CAC" || (detiq.CodExame_EXT_AM_BC_1_CAC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CAC, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CAC = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CAC = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CFF != "" && checkBoxEXT.Checked == true && mnemonico == "CFF" || (detiq.CodExame_EXT_AM_BC_1_TOC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CFF, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CFF = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CFF = "";
                            //********************************************************//

                            //"BG2"  "C1E" "CAI"
                            if (detiq.CodExame_EXT_AM_BC_1_BG2 != "" && checkBoxEXT.Checked == true && mnemonico == "BG2" || (detiq.CodExame_EXT_AM_BC_1_BG2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_BG2, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_BG2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_BG2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_C1E != "" && checkBoxEXT.Checked == true && mnemonico == "C1E" || (detiq.CodExame_EXT_AM_BC_1_C1E != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_C1E, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_C1E = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_C1E = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CAI != "" && checkBoxEXT.Checked == true && mnemonico == "CAI" || (detiq.CodExame_EXT_AM_BC_1_CAI != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CAI, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CAI = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CAI = "";
                            //********************************************************//

                            //"ATR"  "ACN" "CCP"
                            if (detiq.CodExame_EXT_AM_BC_1_ATR != "" && checkBoxEXT.Checked == true && mnemonico == "ATR" || (detiq.CodExame_EXT_AM_BC_1_ATR != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ATR, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ATR = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ATR = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_ACN != "" && checkBoxEXT.Checked == true && mnemonico == "ACN" || (detiq.CodExame_EXT_AM_BC_1_ACN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ACN, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ACN = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ACN = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CCP != "" && checkBoxEXT.Checked == true && mnemonico == "CCP" || (detiq.CodExame_EXT_AM_BC_1_CCP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CCP, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CCP = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CCP = "";
                            //********************************************************//
                            //"AIN"  "LKM"  "MUE"
                            if (detiq.CodExame_EXT_AM_BC_1_AIN != "" && checkBoxEXT.Checked == true && mnemonico == "AIN" || (detiq.CodExame_EXT_AM_BC_1_AIN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_AIN, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_AIN = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_AIN = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_LKM != "" && checkBoxEXT.Checked == true && mnemonico == "LKM" || (detiq.CodExame_EXT_AM_BC_1_LKM != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_LKM, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_LKM = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_LKM = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_MUE != "" && checkBoxEXT.Checked == true && mnemonico == "MUE" || (detiq.CodExame_EXT_AM_BC_1_MUE != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_MUE, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_MUE = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_MUE = "";
                            //********************************************************//
                            //"ASM"  "SSA"  "SSB"
                            if (detiq.CodExame_EXT_AM_BC_1_ASM != "" && checkBoxEXT.Checked == true && mnemonico == "ASM" || (detiq.CodExame_EXT_AM_BC_1_ASM != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ASM, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ASM = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ASM = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_SSA != "" && checkBoxEXT.Checked == true && mnemonico == "SSA" || (detiq.CodExame_EXT_AM_BC_1_SSA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_SSA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_SSA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_SSA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_SSB != "" && checkBoxEXT.Checked == true && mnemonico == "SSB" || (detiq.CodExame_EXT_AM_BC_1_SSB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_SSB, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_SSB = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_SSB = "";
                            //********************************************************//
                            //"MUL" "RNP" "S70"
                            if (detiq.CodExame_EXT_AM_BC_1_MUL != "" && checkBoxEXT.Checked == true && mnemonico == "MUL" || (detiq.CodExame_EXT_AM_BC_1_MUL != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_MUL, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_MUL = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_MUL = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_RNP != "" && checkBoxEXT.Checked == true && mnemonico == "RNP" || (detiq.CodExame_EXT_AM_BC_1_RNP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_RNP, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_RNP = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_RNP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_S70 != "" && checkBoxEXT.Checked == true && mnemonico == "S70" || (detiq.CodExame_EXT_AM_BC_1_S70 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_S70, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_S70 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_S70 = "";
                            //********************************************************//

                            //"ILH" "JO1"  "MIT"
                            if (detiq.CodExame_EXT_AM_BC_1_ILH != "" && checkBoxEXT.Checked == true && mnemonico == "ILH" || (detiq.CodExame_EXT_AM_BC_1_ILH != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ILH, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ILH = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ILH = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_JO1 != "" && checkBoxEXT.Checked == true && mnemonico == "JO1" || (detiq.CodExame_EXT_AM_BC_1_JO1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_JO1, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_JO1 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_JO1 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_MIT != "" && checkBoxEXT.Checked == true && mnemonico == "MIT" || (detiq.CodExame_EXT_AM_BC_1_MIT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_MIT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_MIT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_MIT = "";
                            //********************************************************//
                            //"AEN" "GAD" "AGL"
                            if (detiq.CodExame_EXT_AM_BC_1_AEN != "" && checkBoxEXT.Checked == true && mnemonico == "AEN" || (detiq.CodExame_EXT_AM_BC_1_AEN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_AEN, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_AEN = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_AEN = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_GAD != "" && checkBoxEXT.Checked == true && mnemonico == "GAD" || (detiq.CodExame_EXT_AM_BC_1_GAD != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_GAD, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_GAD = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_GAD = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_AGL != "" && checkBoxEXT.Checked == true && mnemonico == "AGL" || (detiq.CodExame_EXT_AM_BC_1_AGL != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_AGL, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_AGL = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_AGL = "";
                            //********************************************************//
                            // "AAT"  "DRO" "CAD" "PAR" "CEN"
                            if (detiq.CodExame_EXT_AM_BC_1_AAT != "" && checkBoxEXT.Checked == true && mnemonico == "AAT" || (detiq.CodExame_EXT_AM_BC_1_AAT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_AAT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_AAT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_AAT = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_DRO != "" && checkBoxEXT.Checked == true && mnemonico == "DRO" || (detiq.CodExame_EXT_AM_BC_1_DRO != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_DRO, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_DRO = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_DRO = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CAD != "" && checkBoxEXT.Checked == true && mnemonico == "CAD" || (detiq.CodExame_EXT_AM_BC_1_CAD != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CAD, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CAD = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CAD = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "CAD" || (detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CAD_ET_2, "EXT AM 2_Etiqueta", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_PAR != "" && checkBoxEXT.Checked == true && mnemonico == "PAR" || (detiq.CodExame_EXT_AM_BC_1_PAR != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_PAR, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_PAR = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_PAR = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_CEN != "" && checkBoxEXT.Checked == true && mnemonico == "CEN" || (detiq.CodExame_EXT_AM_BC_1_CEN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_CEN, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_CEN = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_CEN = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_ADO != "" && checkBoxEXT.Checked == true && mnemonico == "ADO" || (detiq.CodExame_EXT_AM_BC_1_ADO != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ADO, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ADO = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ADO = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_B2G != "" && checkBoxEXT.Checked == true && mnemonico == "B2G" || (detiq.CodExame_EXT_AM_BC_1_B2G != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_B2G, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_B2G = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_B2G = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_LAS != "" && checkBoxEXT.Checked == true && mnemonico == "LAS" || (detiq.CodExame_EXT_AM_BC_1_LAS != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_LAS, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_LAS = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_LAS = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_ADA != "" && checkBoxEXT.Checked == true && mnemonico == "ADA" || (detiq.CodExame_EXT_AM_BC_1_ADA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_ADA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_ADA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_ADA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_1_C17 != "" && checkBoxEXT.Checked == true && mnemonico == "C17" || (detiq.CodExame_EXT_AM_BC_1_C17 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_C17, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_C17 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_C17 = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AM_BC_1_T20 != "" && checkBoxEXT.Checked == true && mnemonico == "T20" || (detiq.CodExame_EXT_AM_BC_1_T20 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_1_T20, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_1_T20 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_1_T20 = "";
                            //********************************************************//

                            #endregion

                            #region Bancada 2
                            if (detiq.CodExame_EXT_AM_BC_2 != "" && checkBoxEXT.Checked == true && mnemonico == "ASP" || (detiq.CodExame_EXT_AM_BC_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2 = "";
                            //********************************************************//
                            //"TIF"  "LEP"  "SVA"  "VRS"
                            if (detiq.CodExame_EXT_AM_BC_2_TIF != "" && checkBoxEXT.Checked == true && mnemonico == "TIF" || (detiq.CodExame_EXT_AM_BC_2_TIF != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_TIF, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_TIF = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_TIF = "";

                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_2_LEP != "" && checkBoxEXT.Checked == true && mnemonico == "LEP" || (detiq.CodExame_EXT_AM_BC_2_LEP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_LEP, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_LEP = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_LEP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_2_SVA != "" && checkBoxEXT.Checked == true && mnemonico == "SVA" || (detiq.CodExame_EXT_AM_BC_2_SVA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_SVA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_SVA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_SVA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_2_VRS != "" && checkBoxEXT.Checked == true && mnemonico == "VRS" || (detiq.CodExame_EXT_AM_BC_2_VRS != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_VRS, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_VRS = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_VRS = "";
                            //********************************************************//
                            //"BLA"  "CLA"  "DEN"
                            if (detiq.CodExame_EXT_AM_BC_2_BLA != "" && checkBoxEXT.Checked == true && mnemonico == "BLA" || (detiq.CodExame_EXT_AM_BC_2_BLA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_BLA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_BLA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_BLA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_2_CLA != "" && checkBoxEXT.Checked == true && mnemonico == "CLA" || (detiq.CodExame_EXT_AM_BC_2_CLA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_CLA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_CLA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_CLA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_2_DEN != "" && checkBoxEXT.Checked == true && mnemonico == "DEN" || (detiq.CodExame_EXT_AM_BC_2_DEN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_2_DEN, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_2_DEN = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_2_DEN = "";
                            //********************************************************//

                            #endregion

                            #region bancada 3 amarelo

                            if (detiq.CodExame_EXT_AM_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "CIA" || (detiq.CodExame_EXT_AM_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3 = "";
                            //********************************************************//
                            //"FRT"  "GHH"  "SUA" "HTG"
                            if (detiq.CodExame_EXT_AM_BC_3_FRT != "" && checkBoxEXT.Checked == true && mnemonico == "FRT" || (detiq.CodExame_EXT_AM_BC_3_FRT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_FRT, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_FRT = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_FRT = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_3_GHH != "" && checkBoxEXT.Checked == true && mnemonico == "GHH" || (detiq.CodExame_EXT_AM_BC_3_GHH != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_GHH, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_GHH = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_GHH = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_3_SUA != "" && checkBoxEXT.Checked == true && mnemonico == "SUA" || (detiq.CodExame_EXT_AM_BC_3_SUA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_SUA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_SUA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_SUA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_3_HTG != "" && checkBoxEXT.Checked == true && mnemonico == "HTG" || (detiq.CodExame_EXT_AM_BC_3_HTG != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_HTG, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_HTG = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_HTG = "";
                            //********************************************************//
                            //"RUA"  "TOA"  "HBM" "CTX"
                            if (detiq.CodExame_EXT_AM_BC_3_RUA != "" && checkBoxEXT.Checked == true && mnemonico == "RUA" || (detiq.CodExame_EXT_AM_BC_3_RUA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_RUA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_RUA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_RUA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_3_TOA != "" && checkBoxEXT.Checked == true && mnemonico == "TOA" || (detiq.CodExame_EXT_AM_BC_3_TOA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_TOA, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_TOA = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_TOA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_3_HBM != "" && checkBoxEXT.Checked == true && mnemonico == "HBM" || (detiq.CodExame_EXT_AM_BC_3_HBM != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_HBM, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_HBM = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_HBM = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AM_BC_3_CTX != "" && checkBoxEXT.Checked == true && mnemonico == "CTX" || (detiq.CodExame_EXT_AM_BC_3_CTX != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AM_BC_3_CTX, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AM_BC_3_CTX = "";
                            }
                            else
                                detiq.CodExame_EXT_AM_BC_3_CTX = "";
                            //********************************************************//

                            #endregion


                            #region ext bancada 1 MA
                            if (detiq.CodExame_EXT_MA_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "AMO" || (detiq.CodExame_EXT_MA_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_MA_BC_1, "EXT MA", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_MA_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_MA_BC_1 = "";
                            //********************************************************//
                            //"CSP"  "EIS"  "FRU" "GAL"
                            if (detiq.CodExame_EXT_MA_BC_1_CSP != "" && checkBoxEXT.Checked == true && mnemonico == "CSP" || (detiq.CodExame_EXT_MA_BC_1_CSP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_MA_BC_1_CSP, "EXT MA", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_MA_BC_1_CSP = "";
                            }
                            else
                                detiq.CodExame_EXT_MA_BC_1_CSP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_MA_BC_1_EIS != "" && checkBoxEXT.Checked == true && mnemonico == "EIS" || (detiq.CodExame_EXT_MA_BC_1_EIS != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_MA_BC_1_EIS, "EXT MA", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_MA_BC_1_EIS = "";
                            }
                            else
                                detiq.CodExame_EXT_MA_BC_1_EIS = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_MA_BC_1_FRU != "" && checkBoxEXT.Checked == true && mnemonico == "FRU" || (detiq.CodExame_EXT_MA_BC_1_FRU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_MA_BC_1_FRU, "EXT MA", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_MA_BC_1_FRU = "";
                            }
                            else
                                detiq.CodExame_EXT_MA_BC_1_FRU = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_MA_BC_1_GAL != "" && checkBoxEXT.Checked == true && mnemonico == "GAL" || (detiq.CodExame_EXT_MA_BC_1_GAL != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_MA_BC_1_GAL, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_MA_BC_1_GAL = "";
                            }
                            else
                                detiq.CodExame_EXT_MA_BC_1_GAL = "";
                            //********************************************************//
                            #endregion

                            #region ext bancada 1 24
                            if (detiq.CodExame_EXT_24_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "5HI" || (detiq.CodExame_EXT_24_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1 = "";
                            //********************************************************//
                            //CIU
                            if (detiq.CodExame_EXT_24_BC_1_CIU != "" && checkBoxEXT.Checked == true && mnemonico == "CIU" || (detiq.CodExame_EXT_24_BC_1_CIU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_CIU, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_CIU = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_CIU = "";
                            //********************************************************//
                            //OXU
                            if (detiq.CodExame_EXT_24_BC_1_OXU != "" && checkBoxEXT.Checked == true && mnemonico == "OXU" || (detiq.CodExame_EXT_24_BC_1_OXU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_OXU, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_OXU = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_OXU = "";
                            //********************************************************//

                            // "IMU" "MET" "BJO"  "CTU"
                            if (detiq.CodExame_EXT_24_BC_1_IMU != "" && checkBoxEXT.Checked == true && mnemonico == "IMU" || (detiq.CodExame_EXT_24_BC_1_IMU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_IMU, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_IMU = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_IMU = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_MET != "" && checkBoxEXT.Checked == true && mnemonico == "MET" || (detiq.CodExame_EXT_24_BC_1_MET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_MET, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_MET = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_MET = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_BJO != "" && checkBoxEXT.Checked == true && mnemonico == "BJO" || (detiq.CodExame_EXT_24_BC_1_BJO != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_BJO, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_BJO = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_BJO = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_CTU != "" && checkBoxEXT.Checked == true && mnemonico == "CTU" || (detiq.CodExame_EXT_24_BC_1_CTU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_CTU, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_CTU = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_CTU = "";
                            //********************************************************//
                            //"C0U"  "COP"  "EPU"
                            if (detiq.CodExame_EXT_24_BC_1_C0U != "" && checkBoxEXT.Checked == true && mnemonico == "C0U" || (detiq.CodExame_EXT_24_BC_1_C0U != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_C0U, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_C0U = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_C0U = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_COP != "" && checkBoxEXT.Checked == true && mnemonico == "COP" || (detiq.CodExame_EXT_24_BC_1_COP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_COP, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_COP = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_COP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_EPU != "" && checkBoxEXT.Checked == true && mnemonico == "EPU" || (detiq.CodExame_EXT_24_BC_1_EPU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_EPU, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_EPU = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_EPU = "";
                            //********************************************************//

                            //"VMA" "ADU" "CIT"
                            if (detiq.CodExame_EXT_24_BC_1_VMA != "" && checkBoxEXT.Checked == true && mnemonico == "VMA" || (detiq.CodExame_EXT_24_BC_1_VMA != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_VMA, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_VMA = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_VMA = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_ADU != "" && checkBoxEXT.Checked == true && mnemonico == "ADU" || (detiq.CodExame_EXT_24_BC_1_ADU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_ADU, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_ADU = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_ADU = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_24_BC_1_CIT != "" && checkBoxEXT.Checked == true && mnemonico == "CIT" || (detiq.CodExame_EXT_24_BC_1_CIT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_1_CIT, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_1_CIT = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_1_CIT = "";
                            //********************************************************//


                            #endregion



                            if (detiq.CodExame_EXT_24_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "CCU" || (detiq.CodExame_EXT_24_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_24_BC_3, "EXT 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_24_BC_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_24_BC_3 = "";
                            //********************************************************//

                            #region ext bancada 1 br
                            if (detiq.CodExame_EXT_BR_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "LUM" || (detiq.CodExame_EXT_BR_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_BR_BC_1, "EXT BR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_BR_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_BR_BC_1 = "";
                            //********************************************************//
                            //"COB" "ZIN"
                            if (detiq.CodExame_EXT_BR_BC_1_COB != "" && checkBoxEXT.Checked == true && mnemonico == "COB" || (detiq.CodExame_EXT_BR_BC_1_COB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_BR_BC_1_COB, "EXT BR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_BR_BC_1_COB = "";
                            }
                            else
                                detiq.CodExame_EXT_BR_BC_1_COB = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_BR_BC_1_ZIN != "" && checkBoxEXT.Checked == true && mnemonico == "ZIN" || (detiq.CodExame_EXT_BR_BC_1_ZIN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_BR_BC_1_ZIN, "EXT BR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_BR_BC_1_ZIN = "";
                            }
                            else
                                detiq.CodExame_EXT_BR_BC_1_ZIN = "";
                            //********************************************************//
                            #endregion

                            #region ext bancada 1 FR
                            if (detiq.CodExame_EXT_FR_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "AAF" || (detiq.CodExame_EXT_FR_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_1, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_1 = "";
                            //********************************************************//
                            //"CFE" "EIU" "ION"  "MER" "TEP"
                            if (detiq.CodExame_EXT_FR_BC_1_CFE != "" && checkBoxEXT.Checked == true && mnemonico == "CFE" || (detiq.CodExame_EXT_FR_BC_1_CFE != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_1_CFE, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_1_CFE = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_1_CFE = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_FR_BC_1_EIU != "" && checkBoxEXT.Checked == true && mnemonico == "EIU" || (detiq.CodExame_EXT_FR_BC_1_EIU != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_1_EIU, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_1_EIU = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_1_EIU = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_FR_BC_1_ION != "" && checkBoxEXT.Checked == true && mnemonico == "ION" || (detiq.CodExame_EXT_FR_BC_1_ION != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_1_ION, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_1_ION = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_1_ION = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_FR_BC_1_MER != "" && checkBoxEXT.Checked == true && mnemonico == "MER" || (detiq.CodExame_EXT_FR_BC_1_MER != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_1_MER, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_1_MER = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_1_MER = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_FR_BC_1_TEP != "" && checkBoxEXT.Checked == true && mnemonico == "TEP" || (detiq.CodExame_EXT_FR_BC_1_TEP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_1_TEP, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_1_TEP = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_1_TEP = "";
                            //********************************************************//
                            #endregion


                            if (detiq.CodExame_EXT_FR_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "TOC" || (detiq.CodExame_EXT_FR_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_FR_BC_3, "EXT FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_FR_BC_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_FR_BC_3 = "";
                            //********************************************************//

                            #region ext bancada 1 LB
                            if (detiq.CodExame_EXT_LB_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "ADL" || (detiq.CodExame_EXT_LB_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_LB_BC_1, "EXT LB", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_LB_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_LB_BC_1 = "";
                            //********************************************************//

                            // "EFL""IML"
                            if (detiq.CodExame_EXT_LB_BC_1_EFL != "" && checkBoxEXT.Checked == true && mnemonico == "EFL" || (detiq.CodExame_EXT_LB_BC_1_EFL != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_LB_BC_1_EFL, "EXT LB", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_LB_BC_1_EFL = "";
                            }
                            else
                                detiq.CodExame_EXT_LB_BC_1_EFL = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_LB_BC_1_IML != "" && checkBoxEXT.Checked == true && mnemonico == "IML" || (detiq.CodExame_EXT_LB_BC_1_IML != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_LB_BC_1_IML, "EXT LB", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_LB_BC_1_IML = "";
                            }
                            else
                                detiq.CodExame_EXT_LB_BC_1_IML = "";
                            //********************************************************//

                            #endregion

                            if (detiq.CodExame_EXT_LB_BC_2 != "" && checkBoxEXT.Checked == true && mnemonico == "VSC" || (detiq.CodExame_EXT_LB_BC_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_LB_BC_2, "EXT LB", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_LB_BC_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_LB_BC_2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_SE_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "CAO" || (detiq.CodExame_EXT_SE_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_SE_BC_1, "EXT SE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_SE_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_SE_BC_1 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AS_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "CLS" || (detiq.CodExame_EXT_AS_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AS_BC_3, "EXT AS", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AS_BC_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_AS_BC_3 = "";
                            //********************************************************//

                            #region ext bancada 1 VE
                            if (detiq.CodExame_EXT_VE_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "VAL" || (detiq.CodExame_EXT_VE_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1 = "";
                            //********************************************************//
                            // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"
                            if (detiq.CodExame_EXT_VE_BC_1_CAB != "" && checkBoxEXT.Checked == true && mnemonico == "CAB" || (detiq.CodExame_EXT_VE_BC_1_CAB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1_CAB, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1_CAB = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1_CAB = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_VE_BC_1_H50 != "" && checkBoxEXT.Checked == true && mnemonico == "H50" || (detiq.CodExame_EXT_VE_BC_1_H50 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1_H50, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1_H50 = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1_H50 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_VE_BC_1_CRI != "" && checkBoxEXT.Checked == true && mnemonico == "CRI" || (detiq.CodExame_EXT_VE_BC_1_CRI != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1_CRI, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1_CRI = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1_CRI = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_VE_BC_1_VAN != "" && checkBoxEXT.Checked == true && mnemonico == "VAN" || (detiq.CodExame_EXT_VE_BC_1_VAN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1_VAN, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1_VAN = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1_VAN = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_VE_BC_1_FNI != "" && checkBoxEXT.Checked == true && mnemonico == "FNI" || (detiq.CodExame_EXT_VE_BC_1_FNI != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1_FNI, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1_FNI = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1_FNI = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_VE_BC_1_FNB != "" && checkBoxEXT.Checked == true && mnemonico == "FNB" || (detiq.CodExame_EXT_VE_BC_1_FNB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VE_BC_1_FNB, "EXT VE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VE_BC_1_FNB = "";
                            }
                            else
                                detiq.CodExame_EXT_VE_BC_1_FNB = "";
                            //********************************************************//
                            #endregion


                            if (detiq.CodExame_EXT_VD_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "CRG" || (detiq.CodExame_EXT_VD_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_VD_BC_3, "EXT VD", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_VD_BC_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_VD_BC_3 = "";
                            //********************************************************//
                            //DXI
                            if (detiq.CodExame_EXT_CI_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "DXI" || (detiq.CodExame_EXT_CI_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_CI_BC_1, "EXT CI 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_CI_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_CI_BC_1 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_CI_BC_1_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "DXI" || (detiq.CodExame_EXT_CI_BC_1_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_CI_BC_1_2ET, "EXT CI 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_CI_BC_1_2ET = "";
                            }
                            else
                                detiq.CodExame_EXT_CI_BC_1_2ET = "";
                            //********************************************************//
                            //"DXB"
                            if (detiq.CodExame_EXT_CI_BC_1_DXB != "" && checkBoxEXT.Checked == true && mnemonico == "DXB" || (detiq.CodExame_EXT_CI_BC_1_DXB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_CI_BC_1_DXB, "EXT CI", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_CI_BC_1_DXB = "";
                            }
                            else
                                detiq.CodExame_EXT_CI_BC_1_DXB = "";
                            //********************************************************//

                            #region ext bancada 1 RO
                            if (detiq.CodExame_EXT_RO_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "CAT" || (detiq.CodExame_EXT_RO_BC_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1 = "";
                            //********************************************************//
                            //CVB
                            if (detiq.CodExame_EXT_RO_BC_1_CVB != "" && checkBoxEXT.Checked == true && mnemonico == "CVB" || (detiq.CodExame_EXT_RO_BC_1_CVB != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_CVB, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_CVB = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_CVB = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_CVB_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "CVB" || (detiq.CodExame_EXT_RO_BC_1_CVB_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_CVB_2ET, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_CVB_2ET = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_CVB_2ET = "";
                            //********************************************************//

                            // "PRM" "CD8"  "XFR" "ACT"
                            if (detiq.CodExame_EXT_RO_BC_1_PRM != "" && checkBoxEXT.Checked == true && mnemonico == "PRM" || (detiq.CodExame_EXT_RO_BC_1_PRM != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_PRM, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_PRM = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_PRM = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_CD8 != "" && checkBoxEXT.Checked == true && mnemonico == "CD8" || (detiq.CodExame_EXT_RO_BC_1_CD8 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_CD8, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_CD8 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_CD8 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_XFR != "" && checkBoxEXT.Checked == true && mnemonico == "XFR" || (detiq.CodExame_EXT_RO_BC_1_XFR != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_XFR, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_XFR = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_XFR = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_ACT != "" && checkBoxEXT.Checked == true && mnemonico == "ACT" || (detiq.CodExame_EXT_RO_BC_1_ACT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_ACT, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_ACT = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_ACT = "";
                            //********************************************************//
                            //"G6P"  "B27"  "JAK"
                            if (detiq.CodExame_EXT_RO_BC_1_G6P != "" && checkBoxEXT.Checked == true && mnemonico == "G6P" || (detiq.CodExame_EXT_RO_BC_1_G6P != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_G6P, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_G6P = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_G6P = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_G6P_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "G6P" || (detiq.CodExame_EXT_RO_BC_1_G6P_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_G6P_2ET, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_G6P_2ET = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_G6P_2ET = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_B27 != "" && checkBoxEXT.Checked == true && mnemonico == "B27" || (detiq.CodExame_EXT_RO_BC_1_B27 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_B27, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_B27 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_B27 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_JAK != "" && checkBoxEXT.Checked == true && mnemonico == "JAK" || (detiq.CodExame_EXT_RO_BC_1_JAK != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_JAK, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_JAK = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_JAK = "";
                            //********************************************************//
                            //"CIC" "EHE"  "FVP"
                            if (detiq.CodExame_EXT_RO_BC_1_CIC != "" && checkBoxEXT.Checked == true && mnemonico == "CIC" || (detiq.CodExame_EXT_RO_BC_1_CIC != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_CIC, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_CIC = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_CIC = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_EHE != "" && checkBoxEXT.Checked == true && mnemonico == "EHE" || (detiq.CodExame_EXT_RO_BC_1_EHE != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_EHE, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_EHE = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_EHE = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_FVP != "" && checkBoxEXT.Checked == true && mnemonico == "FVP" || (detiq.CodExame_EXT_RO_BC_1_FVP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_FVP, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_FVP = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_FVP = "";
                            //********************************************************//
                            #endregion
                            if (detiq.CodExame_EXT_RO_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "ARP" || (detiq.CodExame_EXT_RO_BC_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_3, "EXT RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_3 = "";
                            //********************************************************//
                            //"BNN"                                   

                            if (detiq.CodExame_EXT_RO_BC_3_BNN != "" && checkBoxEXT.Checked == true && mnemonico == "BNN" || (detiq.CodExame_EXT_RO_BC_3_BNN != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_3_BNN, "EXT AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_3_BNN = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_3_BNN = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_PPT_CVH != "" && checkBoxEXT.Checked == true && mnemonico == "CVH" || (detiq.CodExame_EXT_PPT_CVH != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_PPT_CVH, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_PPT_CVH = "";
                            }
                            else
                                detiq.CodExame_EXT_PPT_CVH = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_PPT_CVH_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "CVH" || (detiq.CodExame_EXT_PPT_CVH_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_PPT_CVH_ET_2, "EXT ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_PPT_CVH_ET_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_PPT_CVH_ET_2 = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_RO_BC_1_2ET_HEP != "" && checkBoxEXT.Checked == true && mnemonico == "HEP" || (detiq.CodExame_EXT_RO_BC_1_2ET_HEP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_HEP, "EXT RO 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_HEP = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_HEP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "HEP" || (detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2, "EXT RO 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_IMO != "" && checkBoxEXT.Checked == true && mnemonico == "IMO" || (detiq.CodExame_EXT_RO_BC_1_2ET_IMO != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_IMO, "EXT RO 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_IMO = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_IMO = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "IMO" || (detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2, "EXT RO 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_ISP != "" && checkBoxEXT.Checked == true && mnemonico == "ISP" || (detiq.CodExame_EXT_RO_BC_1_2ET_ISP != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_ISP, "EXT RO 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_ISP = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_ISP = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "ISP" || (detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2, "EXT RO 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_HEH != "" && checkBoxEXT.Checked == true && mnemonico == "HEH" || (detiq.CodExame_EXT_RO_BC_1_2ET_HEH != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_HEH, "EXT RO 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_HEH = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_HEH = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "HEH" || (detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2, "EXT RO 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_PHT != "" && checkBoxEXT.Checked == true && mnemonico == "PHT" || (detiq.CodExame_EXT_RO_BC_1_2ET_PHT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_PHT, "EXT RO 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_PHT = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_PHT = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "PHT" || (detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2, "EXT RO 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ != "" && checkBoxEXT.Checked == true && mnemonico == "PHQ" || (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_3ET_PHQ, "EXT RO 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_3ET_PHQ = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_3ET_PHQ = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "PHQ" || (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2, "EXT RO 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 != "" && checkBoxEXT.Checked == true && mnemonico == "PHQ" || (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3, "EXT RO 3 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_CAG != "" && checkBoxEXT.Checked == true && mnemonico == "CAG" || (detiq.CodExame_EXT_RO_BC_1_2ET_CAG != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_CAG, "EXT RO CAG", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_CAG = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_CAG = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "CAG" || (detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET, "EXT RO CAG", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET = "";
                            }
                            else
                                detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET = "";
                            //********************************************************//




                            #region ext bancada 1 AZ



                            if (detiq.CodExame_EXT_AZ_BC_1_1ET != "" && checkBoxEXT.Checked == true && mnemonico == "LUP" || (detiq.CodExame_EXT_AZ_BC_1_1ET != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_1ET, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_1ET = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_1ET = "";
                            //********************************************************//
                            //"AT3"  "RIT" "PCS"
                            if (detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 != "" && checkBoxEXT.Checked == true && mnemonico == "AT3" || (detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_1ET_AT3, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_1ET_RIT != "" && checkBoxEXT.Checked == true && mnemonico == "RIT" || (detiq.CodExame_EXT_AZ_BC_1_1ET_RIT != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_1ET_RIT, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_1ET_RIT = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_1ET_RIT = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS != "" && checkBoxEXT.Checked == true && mnemonico == "PCS" || (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_1ET_PCS, "EXT AZ 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_1ET_PCS = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_1ET_PCS = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "PCS" || (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2, "EXT AZ 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 = "";
                            //********************************************************//

                            if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 != "" && checkBoxEXT.Checked == true && mnemonico == "PCS" || (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3, "EXT AZ 3 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 = "";
                            //********************************************************//


                            #endregion

                            #region EXT bancada 1 AZ 2


                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1 != "" && checkBoxEXT.Checked == true && mnemonico == "FC2" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1 = "";
                            //********************************************************//
                            //"F11" "F12"
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 != "" && checkBoxEXT.Checked == true && mnemonico == "F11" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 != "" && checkBoxEXT.Checked == true && mnemonico == "F12" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 = "";
                            //********************************************************//
                            //"FC8" "FVW" "F10"
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 != "" && checkBoxEXT.Checked == true && mnemonico == "FC8" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW != "" && checkBoxEXT.Checked == true && mnemonico == "FVW" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 != "" && checkBoxEXT.Checked == true && mnemonico == "F10" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 = "";
                            //********************************************************//
                            //"FC9" "FC5"  "FC7"
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 != "" && checkBoxEXT.Checked == true && mnemonico == "FC9" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 != "" && checkBoxEXT.Checked == true && mnemonico == "FC5" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 != "" && checkBoxEXT.Checked == true && mnemonico == "FC7" || (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7, "EXT AZ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 = "";
                            }
                            else
                                detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 = "";
                            //********************************************************//
                            #endregion


                            if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 != "" && checkBoxEXT.Checked == true && mnemonico == "AGR" || (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1, "EXT AR AZ 1 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 != "" && checkBoxEXT.Checked == true && mnemonico == "AGR" || (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2, "EXT AR AZ 2 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 = "";
                            }
                            else
                                detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 != "" && checkBoxEXT.Checked == true && mnemonico == "AGR" || (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3, "EXT AR AZ 3 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 = "";
                            }
                            else
                                detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 != "" && checkBoxEXT.Checked == true && mnemonico == "AGR" || (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4, "EXT AR AZ 4 ETQ", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 = "";
                            }
                            else
                                detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 = "";
                            //********************************************************//
                            if (detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 != "" && checkBoxEXT.Checked == true && mnemonico == "AGR" || (detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_AR_BC_1_5ET_RO_1, "EXT AR RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 = "";
                            }
                            else
                                detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 = "";
                            //********************************************************//
                            //if (detiq.CodExame_EXT_RO_BC_1_HIV != "" && checkBoxEXT.Checked == true && mnemonico == "HIV" || (detiq.CodExame_EXT_RO_BC_1_HIV != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            //{
                            //    DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_HIV, "EXT ROX", MessageBoxButtons.YesNo);
                            //    if (confirm.ToString().ToUpper() == "YES")

                            //        printDocument1.Print();
                            //    else
                            //        detiq.CodExame_EXT_RO_BC_1_HIV = "";
                            //}
                            //else
                            //    detiq.CodExame_EXT_RO_BC_1_HIV = "";
                            ////********************************************************//
                            //if (detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "HIV" || (detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 != "" && checkBoxEXT.Checked == true && mnemonico == "000"))
                            //{
                            //    DialogResult confirm = MessageBox.Show(detiq.CodExame_EXT_RO_BC_1_HIV_ET_2, "EXT ROX", MessageBoxButtons.YesNo);
                            //    if (confirm.ToString().ToUpper() == "YES")

                            //        printDocument1.Print();
                            //    else
                            //        detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 = "";
                            //}
                            //else
                            //    detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 = "";
                            //********************************************************//

                            #endregion
                            #region HOR Tem que Ficar antes de BIO

                            if (detiq.CodExameHOR != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR, "HOR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR = "";
                            }
                            else
                                detiq.CodExameHOR = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C22 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C22, "HOR AM 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C22 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C22 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C22_30 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C22_30, "HOR AM 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C22_30 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C22_30 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C22_60 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C22_60, "HOR AM 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C22_60 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C22_60 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C22_90 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C22_90, "HOR AM 90", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C22_90 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C22_90 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C22_120 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C22_120, "HOR AM 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C22_120 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C22_120 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2, "HOR AM 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_30 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_30, "HOR AM 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_30 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_30 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_60 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_60, "HOR AM 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_60 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_60 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_90 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_90, "HOR AM 90", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_90 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_90 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_120 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_120, "HOR AM 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_120 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_120 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_180 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_180, "HOR AM 180", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_180 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_180 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_240 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_240, "HOR AM 240", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_240 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_240 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_CP2_300 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_CP2_300, "HOR AM 300", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_CP2_300 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_CP2_300 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_SG2 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_SG2, "HOR AM 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_SG2 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_SG2 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_SG2_120 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_SG2_120, "HOR AM 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_SG2_120 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_SG2_120 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_SC2 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_SC2, "HOR AM 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_SC2 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_SC2 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_SC2_60 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_SC2_60, "HOR AM 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_SC2_60 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_SC2_60 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C32 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C32, "HOR AM 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C32 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C32 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C32_30 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C32_30, "HOR AM 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C32_30 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C32_30 = "";
                            //********************************************************//

                            if (detiq.CodExameHOR_T14_BIO_C32_60 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C32_60, "HOR AM 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C32_60 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C32_60 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C32_90 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C32_90, "HOR AM 90", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C32_90 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C32_90 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C32_120 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C32_120, "HOR AM 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C32_120 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C32_120 = "";
                            //********************************************************//
                            if (detiq.CodExameHOR_T14_BIO_C32_180 != "" && checkBoxHOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHOR_T14_BIO_C32_180, "HOR AM 180", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHOR_T14_BIO_C32_180 = "";
                            }
                            else
                                detiq.CodExameHOR_T14_BIO_C32_180 = "";
                            //********************************************************//

                            #endregion
                            #region BAC

                            if (detiq.CodExameBAC != "" && checkBoxBAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBAC, "BAC", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBAC = "";
                            }
                            else
                                detiq.CodExameBAC = "";
                            //********************************************************//
                            if (detiq.CodExameBAC_FV != "" && checkBoxBAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBAC_FV, "BAC", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBAC_FV = "";
                            }
                            else
                                detiq.CodExameBAC_FV = "";
                            //********************************************************//
                            if (detiq.CodExameBAC_BK2 != "" && checkBoxBAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBAC_BK2, "BAC", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBAC_BK2 = "";
                            }
                            else
                                detiq.CodExameBAC_BK2 = "";
                            //********************************************************//

                            if (detiq.CodExameBAC_HA != "" && checkBoxBAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBAC_HA, "BAC", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBAC_HA = "";
                            }
                            else
                                detiq.CodExameBAC_HA = "";
                            //********************************************************//
                            if (detiq.CodExameBAC_HN != "" && checkBoxBAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBAC_HN, "BAC", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBAC_HN = "";
                            }
                            else
                                detiq.CodExameBAC_HN = "";
                            //********************************************************//
                            if (detiq.CodExameBAC_HP != "" && checkBoxBAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBAC_HP, "BAC", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBAC_HP = "";
                            }
                            else
                                detiq.CodExameBAC_HP = "";
                            //********************************************************//
                            #endregion
                            #region BIO
                            if (detiq.CodExameBIO_FR_RPC != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_FR_RPC, "BIO FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_FR_RPC = "";
                            }
                            else
                                detiq.CodExameBIO_FR_RPC = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_AM != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_AM, "BIO AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_AM = "";
                            }
                            else
                                detiq.CodExameBIO_AM = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_AM_AM != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_AM_AM, "BIO AM AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_AM_AM = "";
                            }
                            else
                                detiq.CodExameBIO_AM_AM = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_AM_24 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_AM_24, "BIO 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_AM_24 = "";
                            }
                            else
                                detiq.CodExameBIO_AM_24 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_LB != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_LB, "BIO LB", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_LB = "";
                            }
                            else
                                detiq.CodExameBIO_LB = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_24 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_24, "BIO 24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_24 = "";
                            }
                            else
                                detiq.CodExameBIO_24 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_FR != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_FR, "BIO FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_FR = "";
                            }
                            else
                                detiq.CodExameBIO_FR = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_SE != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_SE, "BIO SE", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_SE = "";
                            }
                            else
                                detiq.CodExameBIO_SE = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_OU != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_OU, "BIO OU", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_OU = "";
                            }
                            else
                                detiq.CodExameBIO_OU = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_RO != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_RO, "BIO RO", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_RO = "";
                            }
                            else
                                detiq.CodExameBIO_RO = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_G1_2ET != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_G1_2ET, "BIO G1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_G1_2ET = "";
                            }
                            else
                                detiq.CodExameBIO_G1_2ET = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_G1_2ET_1 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_G1_2ET_1, "BIO G1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_G1_2ET_1 = "";
                            }
                            else
                                detiq.CodExameBIO_G1_2ET_1 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_G1_4ET != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_G1_4ET, "BIO G1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_G1_4ET = "";
                            }
                            else
                                detiq.CodExameBIO_G1_4ET = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_G1_4ET_1 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_G1_4ET_1, "BIO G1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_G1_4ET_1 = "";
                            }
                            else
                                detiq.CodExameBIO_G1_4ET_1 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_G1_4ET_2 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_G1_4ET_2, "BIO G1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_G1_4ET_2 = "";
                            }
                            else
                                detiq.CodExameBIO_G1_4ET_2 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_G1_4ET_3 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_G1_4ET_3, "BIO G1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_G1_4ET_3 = "";
                            }
                            else
                                detiq.CodExameBIO_G1_4ET_3 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI, "BIO CI 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI = "";
                            }
                            else
                                detiq.CodExameBIO_CI = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_30 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_30, "BIO CI 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_30 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_30 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_60 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_60, "BIO CI 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_60 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_60 = "";
                            //********************************************************//

                            //if (detiq.CodExameBIO_CID_GLICOSE != "")
                            //{
                            //    printDocument1.Print();
                            //}
                            //********************************************************//
                            if (detiq.CodExameBIO_CIP != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CIP, "BIO CIP", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CIP = "";
                            }
                            else
                                detiq.CodExameBIO_CIP = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_5_ET_0 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_5_ET_0, "BIO CID 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_5_ET_0 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_5_ET_0 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_5_ET_30 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_5_ET_30, "BIO CID 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_5_ET_30 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_5_ET_30 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_5_ET_60 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_5_ET_60, "BIO CID 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_5_ET_60 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_5_ET_60 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_5_ET_90 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_5_ET_90, "BIO CID 90", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_5_ET_90 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_5_ET_90 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_5_ET_120 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_5_ET_120, "BIO CID 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_5_ET_120 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_5_ET_120 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_0 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_0, "BIO CID 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_0 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_0 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_30 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_30, "BIO CID 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_30 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_30 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_60 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_60, "BIO CID 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_60 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_60 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_90 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_0, "BIO CID 90", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_90 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_90 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_120 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_120, "BIO CID 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_120 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_120 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_180 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_180, "BIO CID 180", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_180 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_180 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_240 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_240, "BIO CID 240", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_240 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_240 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CID_8_ET_300 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CID_8_ET_300, "BIO CID 300", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CID_8_ET_300 = "";
                            }
                            else
                                detiq.CodExameBIO_CID_8_ET_300 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_2_ET_0 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_2_ET_0, "BIO CID 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_2_ET_0 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_2_ET_0 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_2_ET_120 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_2_ET_120, "BIO CID 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_2_ET_120 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_2_ET_120 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_2_ET_CS2_0 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_2_ET_CS2_0, "BIO CID 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_2_ET_CS2_0 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_2_ET_CS2_0 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_2_ET_CS2_60 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_2_ET_CS2_60, "BIO CID 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_2_ET_CS2_60 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_2_ET_CS2_60 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_6_ET_0 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_6_ET_0, "BIO CID 0", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_6_ET_0 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_6_ET_0 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_6_ET_30 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_6_ET_30, "BIO CID 30", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_6_ET_30 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_6_ET_30 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_6_ET_60 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_6_ET_60, "BIO CID 60", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_6_ET_60 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_6_ET_60 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_6_ET_90 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_6_ET_90, "BIO CID 90", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_6_ET_90 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_6_ET_90 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_6_ET_120 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_6_ET_120, "BIO CID 120", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_6_ET_120 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_6_ET_120 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_CI_6_ET_180 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_CI_6_ET_0, "BIO CID 180", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_CI_6_ET_180 = "";
                            }
                            else
                                detiq.CodExameBIO_CI_6_ET_180 = "";
                            //********************************************************//
                            if (detiq.CodExameBIO_SER_GS6 != "" && checkBoxBIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameBIO_SER_GS6, "BIO SER", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameBIO_SER_GS6 = "";
                            }
                            else
                                detiq.CodExameBIO_SER_GS6 = "";
                            //********************************************************//

                            #endregion
                            #region HEM

                            if (detiq.CodExameHEM_Rox != "" && checkBoxHEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHEM_Rox, "HEM ROX", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHEM_Rox = "";
                            }
                            else
                                detiq.CodExameHEM_Rox = "";
                            //********************************************************//
                            if (detiq.CodExameHEM_Azul != "" && checkBoxHEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHEM_Azul, "HEM AZU", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHEM_Azul = "";
                            }
                            else
                                detiq.CodExameHEM_Azul = "";
                            //********************************************************//
                            if (detiq.CodExameHEM_DI != "" && checkBoxHEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHEM_DI, "HEM DI", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHEM_DI = "";
                            }
                            else
                                detiq.CodExameHEM_DI = "";
                            //********************************************************//
                            if (detiq.CodExameHEM_BR != "" && checkBoxHEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameHEM_BR, "HEM BR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameHEM_BR = "";
                            }
                            else
                                detiq.CodExameHEM_BR = "";
                            //********************************************************//
                            #endregion
                            #region IMU -

                            if (detiq.CodExameIMU_Amarelo != "" && checkBoxIMU.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameIMU_Amarelo, "IMU AM", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameIMU_Amarelo = "";
                            }
                            else
                                detiq.CodExameIMU_Amarelo = "";
                            //********************************************************//
                            if (detiq.CodExameIMU_U12 != "" && checkBoxIMU.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameIMU_U12, "IMU U12", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameIMU_U12 = "";
                            }
                            else
                                detiq.CodExameIMU_U12 = "";
                            //********************************************************//
                            if (detiq.CodExameIMU_U24 != "" && checkBoxIMU.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameIMU_U24, "IMU U24", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameIMU_U24 = "";
                            }
                            else
                                detiq.CodExameIMU_U24 = "";
                            //********************************************************//
                            if (detiq.CodExameIMU_COU != "" && checkBoxIMU.Checked == true)//FR
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExameIMU_COU, "IMU COU", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExameIMU_COU = "";
                            }
                            else
                                detiq.CodExameIMU_COU = "";
                            //********************************************************//
                            #endregion
                            #region PAR ok 24/03/2015

                            if (detiq.CodExamePAR != "" && checkBoxPAR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExamePAR, "PAR FR", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExamePAR = "";
                            }
                            else
                                detiq.CodExamePAR = "";
                            //********************************************************//
                            if (detiq.CodExamePAR_FI != "" && checkBoxPAR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.CodExamePAR_FI, "PAR FI", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.CodExamePAR_FI = "";
                            }
                            else
                                detiq.CodExamePAR_FI = "";

                            //********************************************************//
                            #endregion

                            //LU
                            #region LU
                            if (detiq.LU_codExame_BAC_BK1 != "" && checkBox_LU_BAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_BAC_BK1, "BAC BK1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_BAC_BK1 = "";
                            }
                            else
                                detiq.LU_codExame_BAC_BK1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_BAC_DI1 != "" && checkBox_LU_BAC.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_BAC_DI1, "BAC DI1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_BAC_DI1 = "";
                            }
                            else
                                detiq.LU_codExame_BAC_DI1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_BIO_AM1 != "" && checkBox_LU_BIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_BIO_AM1, "BIO AM1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_BIO_AM1 = "";
                            }
                            else
                                detiq.LU_codExame_BIO_AM1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_BIO_LB1 != "" && checkBox_LU_BIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_BIO_LB1, "BIO LB1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_BIO_LB1 = "";
                            }
                            else
                                detiq.LU_codExame_BIO_LB1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_BIO_SE1 != "" && checkBox_LU_BIO.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_BIO_SE1, "BIO SER", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_BIO_SE1 = "";
                            }
                            else
                                detiq.LU_codExame_BIO_SE1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_HEM_AZ1 != "" && checkBox_LU_HEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_HEM_AZ1, "HEM AZ1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_HEM_AZ1 = "";
                            }
                            else
                                detiq.LU_codExame_HEM_AZ1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_HEM_RO1 != "" && checkBox_LU_HEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_HEM_RO1, "HEM RO1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_HEM_RO1 = "";
                            }
                            else
                                detiq.LU_codExame_HEM_RO1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_HEM_DI1 != "" && checkBox_LU_HEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_HEM_DI1, "HEM DI1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_HEM_DI1 = "";
                            }
                            else
                                detiq.LU_codExame_HEM_DI1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_HEM_LB1 != "" && checkBox_LU_HEM.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_HEM_LB1, "HEM LB1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_HEM_LB1 = "";
                            }
                            else
                                detiq.LU_codExame_HEM_LB1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_HOR_AM1 != "" && checkBox_LU_HOR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_HOR_AM1, "HOR AM1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_HOR_AM1 = "";
                            }
                            else
                                detiq.LU_codExame_HOR_AM1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_IMU_RO1 != "" && checkBox_LU_IMU.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_IMU_RO1, "IMU R01", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_IMU_RO1 = "";
                            }
                            else
                                detiq.LU_codExame_IMU_RO1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_IMU_AM1 != "" && checkBox_LU_IMU.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_IMU_AM1, "IMU AM1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_IMU_AM1 = "";
                            }
                            else
                                detiq.LU_codExame_IMU_AM1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_IMU_LB1 != "" && checkBox_LU_IMU.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_IMU_LB1, "IMU LB1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_IMU_LB1 = "";
                            }
                            else
                                detiq.LU_codExame_IMU_LB1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_PAR_FR1 != "" && checkBox_LU_PAR.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_PAR_FR1, "PAR FR1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_PAR_FR1 = "";
                            }
                            else
                                detiq.LU_codExame_PAR_FR1 = "";
                            //********************************************************//

                            if (detiq.LU_codExame_URI_FR1 != "" && checkBox_LU_URI.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_URI_FR1, "URI FR1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_URI_FR1 = "";
                            }
                            else
                                detiq.LU_codExame_URI_FR1 = "";
                            //********************************************************//
                            if (detiq.LU_codExame_URI_FR_ET_21 != "" && checkBox_LU_URI.Checked == true)
                            {
                                DialogResult confirm = MessageBox.Show(detiq.LU_codExame_URI_FR_ET_21, "URO FR1", MessageBoxButtons.YesNo);
                                if (confirm.ToString().ToUpper() == "YES")

                                    printDocument1.Print();
                                else
                                    detiq.LU_codExame_URI_FR_ET_21 = "";
                            }
                            else
                                detiq.LU_codExame_URI_FR_ET_21 = "";
                            //********************************************************//
                            

                            if (detiq.Nao_Classificado1 != "")
                            {
                                printDocument1.Print();
                            }
                            //********************************************************//


                            if (detiq.ComprovantePaciente1 != "" && checkBoxComprovante.Checked == true)
                            {

                                printDocument2.Print();


                            }

                            else
                            {

                                MessageBox.Show("Sem Exames");
                            }
                            _requis = null;
                            //limpar dados do paciente
                            detiq.Nome = "";
                            detiq.TipoPac = "";
                            detiq.Idade = "";
                            detiq.Sexo = "";
                            detiq.Consulta = "";
                            detiq.Be = "";
                            detiq.Rh = "";
                            detiq.DtColeta = "";
                            detiq.HoraExm = "";
                            detiq.DtNascRH = "";
                            detiq.DtNascBE = "";
                            //MessageBox.Show("FIM DO PROGRAMA");
                            #endregion


                            //// Imprimi as etiquetas de controle 2 etiquetas

                            //for (int i = 0; i < 2; i++)
                            //    printDocument1.Print();

                            #endregion
                            //  */ 




                            #endregion
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Número de requisição não existe! ");
                }
                status = 0;
                _requis = null;
                detiq = null; // alteracao 05.04.2019  henrique
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//  + ex.Message // o ex.Message é para mostrar 
                status = 1;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTime data = DateTime.Now;
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);//900 é a largura da página
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
            printDialog1.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 14)) // antes estava 12
                {
                    int startXCenter = 10;//margem da esquerda da etiqueta
                    //int startXEsquerda = 50; // codigo de baras
                    int starty = 10;//distancia das linhas

                    PointF pointF2 = new PointF(182, 25);// 14/08/2015
                    PointF pointF3 = new PointF(30, 60); //
                    PointF pointF = new PointF(171, 0);// sempre 10 a menos que o f1
                    PointF pointF1 = new PointF(188, 25);// horinzontal , Vertical
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

                    #region Converte a data do Hospub para o padrão dd/mm/aaaa
                    string dia = detiq.DtColeta.Substring(6, 2);
                    string mes = detiq.DtColeta.Substring(4, 2);
                    string ano = detiq.DtColeta.Substring(0, 4);
                    string dt = dia + "/" + mes + "/" + ano;
                    #endregion
                    #region Converte hora do banco de dados do hospub
                    string Hr = detiq.HoraExm.Substring(0, 2);
                    string Min = detiq.HoraExm.Substring(2, 2);
                    string horaCompleta = Hr + ":" + Min;

                    #endregion

                    int cont = 1;
                    if (cont != 0)
                    {
                        cont = cont - 1;
                    }



                    #region Posições da Etiqueta

                    g.DrawString(detiq.Nome, new Font("Arial", 6), System.Drawing.Brushes.Black, startXCenter - 3, starty - 1); // posição onde começa o nome // antigo - 10, starty - 9
                    g.DrawString(detiq.Requisicao, new Font("Arial", 11, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 40, starty + 6);// LC ou LU
                    //g.DrawString("RH: " + detiq.Rh, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty - 10); // antigo pointF2, stringFormat
                    g.DrawString("RH: " + detiq.Rh, new Font("Arial", 6), System.Drawing.Brushes.Black, 6, starty - 10); // antigo pointF2, stringFormat
                    if (detiq.Be != "0.")
                    {
                        //g.DrawString("BE: " + detiq.Be, new Font("Arial", 5), System.Drawing.Brushes.Black, pointF2, stringFormat);
                        //startXCenter + 0, starty + 90
                        g.DrawString("BE: " + detiq.Be, new Font("Arial", 5), System.Drawing.Brushes.Black, startXCenter + 100, starty + 93);

                    }
                    else if (detiq.Consulta != "")
                    {
                        //g.DrawString("FAA: " + detiq.Consulta, new Font("Arial", 5), System.Drawing.Brushes.Black, pointF2, stringFormat);// antigo - 10, starty + 2
                        g.DrawString("FAA: " + detiq.Consulta, new Font("Arial", 5), System.Drawing.Brushes.Black, startXCenter + 100, starty + 93);// antigo - 10, starty + 2
                    }

                    //g.DrawString("Idade: " + detiq.Idade + " Sexo: " + detiq.Sexo, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 82, starty - 10);//startXCenter - 10, starty - 12
                    g.DrawString("Idade: " + detiq.Idade + " Sexo: " + detiq.Sexo, new Font("Arial", 6), System.Drawing.Brushes.Black, startXCenter + 82, starty - 10);//startXCenter - 10, starty - 12
                    //g.DrawString("Col: " + dt + " H:" + horaCompleta, new Font("Arial", 5), System.Drawing.Brushes.Black, pointF1, stringFormat); // data da coleta
                    g.DrawString("Col: " + dt + " H:" + horaCompleta, new Font("Arial", 5), System.Drawing.Brushes.Black, startXCenter + 0, starty + 93); // data da coleta

                    #endregion



                    // 29/07/2016
                    if (detiq.ControleEtiq1 != "")
                    {
                        g.DrawString("CONTROLE", new Font("Arial", 11, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 40, starty + 72);
                        detiq.ControleEtiq1 = "";

                    }
                    else if (detiq.ControleEtiq21 != "")
                    {
                        g.DrawString("CONTROLE", new Font("Arial", 11, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 40, starty + 72);
                        detiq.ControleEtiq21 = "";

                    }
                    // Imprime Etiqueta da URO com código EM2


                    #region Imprimi a etiqueta pelo tipo do exame se é EXT, BIO, BAC.....
                    #region URO
                    else if (detiq.CodExameURO != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameURO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameURO = "";
                    }
                    else if (detiq.CodExameURO_ET_2 != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameURO_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameURO_ET_2 = "";
                    }
                    else if (detiq.CodExameURO2 != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameURO2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameURO2 = "";
                    }
                    else if (detiq.CodExameURO_ET_22 != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameURO_ET_22, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameURO_ET_22 = "";
                    }
                    else if (detiq.CodExameURO_CR4 != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameURO_CR4, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameURO_CR4 = "";
                    }


                    #endregion
                    #region EXT
                    // PT3 //agora é PT5 Ele vai sair em 2 etiquetas 1 junto aos demais exames de HOR e 1 sozinho como exame externo Amarelo
                    else if (detiq.CodExameHOR_PT3 != "") // ESSE EXAME PERTENCE AO GRUPO HOR MAS ESSA COPIA TEM QUE SAIR COM ETIQUETA EXT AMARELO
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_PT3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_PT3 = ""; // agora é PT5
                    }



                    #region Bancada 1 exames externos
                    else if (detiq.CodExame_EXT_AM_BC_1 != "")
                    {

                        //if (detiq.CodExame_EXT_AM_BC_1.Length > 37)
                        //{
                        //    detiq.CodExame_EXT_AM_BC_1 = detiq.CodExame_EXT_AM_BC_1.Substring(0, 33)+"...";
                        //}
                        // g.DrawString("EXT", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1 = "";
                    }


                        //"TOC" "TRA" "ESQ"
                    else if (detiq.CodExame_EXT_AM_BC_1_TOC != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_TOC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_TOC = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_TRA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_TRA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_TRA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_ESQ != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ESQ, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ESQ = "";
                    }
                    // "RIB"  "IGF"  "TBG"
                    else if (detiq.CodExame_EXT_AM_BC_1_RIB != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_RIB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_RIB = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_IGF != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_IGF, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_IGF = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_TBG != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_TBG, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_TBG = "";
                    }

                    //"PCC" "PEP" "PVR"
                    else if (detiq.CodExame_EXT_AM_BC_1_PCC != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_PCC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_PCC = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_PCC_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_PEP != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_PEP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_PEP = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_PVR != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_PVR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_PVR = "";
                    }

                    // "MON"  "MIC" "PCB"
                    else if (detiq.CodExame_EXT_AM_BC_1_MON != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_MON, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_MON = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_MIC != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_MIC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_MIC = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_PCB != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_PCB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_PCB = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_PCB_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 = "";
                    }

                    //"IST"  "LIT"  "LYM"
                    else if (detiq.CodExame_EXT_AM_BC_1_IST != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_IST, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_IST = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_LIT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_LIT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_LIT = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_LYM != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_LYM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_LYM = "";
                    }
                    //"IF3"  "IEP"  "FIX"
                    else if (detiq.CodExame_EXT_AM_BC_1_IF3 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_IF3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_IF3 = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_IEP != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_IEP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_IEP = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_FIX != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_FIX, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_FIX = "";
                    }

                    //"HER"  "HOM"  "HTL"
                    else if (detiq.CodExame_EXT_AM_BC_1_HER != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_HER, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_HER = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_HOM != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_HOM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_HOM = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_HTL != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_HTL, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_HTL = "";
                    }
                    //"GAT"  "GEC"  "HPT"
                    else if (detiq.CodExame_EXT_AM_BC_1_GAT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_GAT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_GAT = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_GEC != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_GEC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_GEC = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_GEC_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_HPT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_HPT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_HPT = "";
                    }
                    //"ENA"  "EQU"  "ERT"
                    else if (detiq.CodExame_EXT_AM_BC_1_ENA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ENA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ENA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_EQU != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_EQU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_EQU = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_ERT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ERT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ERT = "";
                    }
                    //"DHE" "DGX" "EPR"
                    else if (detiq.CodExame_EXT_AM_BC_1_DHE != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_DHE, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_DHE = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_DGX != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_DGX, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_DGX = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_EPR != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_EPR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_EPR = "";
                    }

                    //"CVC" "CER" "COC"
                    else if (detiq.CodExame_EXT_AM_BC_1_CVC != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CVC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CVC = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CVC_2ET != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CVC_2ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CVC_2ET = "";
                    }

                    else if (detiq.CodExame_EXT_AM_BC_1_CER != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CER, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CER = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_COC != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_COC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_COC = "";
                    }

                    // "CAC"  "CFF" 
                    else if (detiq.CodExame_EXT_AM_BC_1_CAC != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CAC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CAC = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CFF != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CFF, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CFF = "";
                    }


                    //"BG2"  "C1E" "CAI"
                    else if (detiq.CodExame_EXT_AM_BC_1_BG2 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_BG2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_BG2 = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_C1E != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_C1E, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_C1E = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CAI != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CAI, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CAI = "";
                    }
                    //"ATR"  "ACN" "CCP"
                    else if (detiq.CodExame_EXT_AM_BC_1_ATR != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ATR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ATR = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_ACN != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ACN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ACN = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CCP != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CCP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CCP = "";
                    }
                    //"AIN"  "LKM"  "MUE"
                    else if (detiq.CodExame_EXT_AM_BC_1_AIN != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_AIN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_AIN = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_LKM != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_LKM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_LKM = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_MUE != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_MUE, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_MUE = "";
                    }

                        //"ASM"  "SSA"  "SSB"
                    else if (detiq.CodExame_EXT_AM_BC_1_ASM != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ASM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ASM = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_SSA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_SSA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_SSA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_SSB != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_SSB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_SSB = "";
                    }

                    //"MUL" "RNP" "S70"
                    else if (detiq.CodExame_EXT_AM_BC_1_MUL != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_MUL, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_MUL = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_RNP != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_RNP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_RNP = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_S70 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_S70, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_S70 = "";
                    }


                    //"ILH" "JO1"  "MIT"
                    else if (detiq.CodExame_EXT_AM_BC_1_ILH != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ILH, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ILH = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_JO1 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_JO1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_JO1 = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_MIT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_MIT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_MIT = "";
                    }


                    //"AEN" "GAD" "AGL"
                    else if (detiq.CodExame_EXT_AM_BC_1_AEN != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_AEN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_AEN = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_GAD != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_GAD, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_GAD = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_AGL != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_AGL, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_AGL = "";
                    }

                    //  "PAR" "CEN"
                    else if (detiq.CodExame_EXT_AM_BC_1_AAT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_AAT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_AAT = "";
                    }

                    else if (detiq.CodExame_EXT_AM_BC_1_DRO != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_DRO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_DRO = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CAD != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CAD, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CAD = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CAD_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_PAR != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_PAR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_PAR = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_CEN != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_CEN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_CEN = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_ADO != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ADO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ADO = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_B2G != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_B2G, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_B2G = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_LAS != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_LAS, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_LAS = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_ADA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_ADA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_ADA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_1_C17 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_C17, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_C17 = "";
                    }

                    else if (detiq.CodExame_EXT_AM_BC_1_T20 != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_1_T20, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_1_T20 = "";
                    }

                    #endregion

                    #region bancada 2 amarelo

                    else if (detiq.CodExame_EXT_AM_BC_2 != "")
                    {
                        //if (detiq.CodExame_EXT_AM_BC_2.Length > 37)
                        //{
                        //    detiq.CodExame_EXT_AM_BC_2 = detiq.CodExame_EXT_AM_BC_2.Substring(0, 33) + "...";
                        //}
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2 = "";
                    }
                    //"TIF"  "LEP"  "SVA"  "VRS"
                    else if (detiq.CodExame_EXT_AM_BC_2_TIF != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_TIF, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_TIF = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_2_LEP != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_LEP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_LEP = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_2_SVA != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_SVA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_SVA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_2_VRS != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_VRS, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_VRS = "";
                    }
                    //"BLA"  "CLA"  "DEN"
                    else if (detiq.CodExame_EXT_AM_BC_2_BLA != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_BLA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_BLA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_2_CLA != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_CLA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_CLA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_2_DEN != "")
                    {
                        g.DrawString("EXT AM BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_2_DEN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_2_DEN = "";
                    }


                    #endregion

                    #region bancada 3 amarelo

                    else if (detiq.CodExame_EXT_AM_BC_3 != "")
                    {
                        //if (detiq.CodExame_EXT_AM_BC_3.Length > 37)
                        //{
                        //    detiq.CodExame_EXT_AM_BC_3 = detiq.CodExame_EXT_AM_BC_3.Substring(0, 33) + "...";
                        //}
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3 = "";
                    }
                    //"FRT"  "GHH"  "SUA" "HTG"
                    else if (detiq.CodExame_EXT_AM_BC_3_FRT != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_FRT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_FRT = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_3_GHH != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_GHH, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_GHH = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_3_SUA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_SUA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_SUA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_3_HTG != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_HTG, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_HTG = "";
                    }

                    //"RUA"  "TOA"  "HBM" "CTX"
                    else if (detiq.CodExame_EXT_AM_BC_3_RUA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_RUA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_RUA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_3_TOA != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_TOA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_TOA = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_3_HBM != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_HBM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_HBM = "";
                    }
                    else if (detiq.CodExame_EXT_AM_BC_3_CTX != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AM_BC_3_CTX, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AM_BC_3_CTX = "";
                    }

                    #endregion

                    #region ext bancada 1 MA
                    else if (detiq.CodExame_EXT_MA_BC_1 != "")
                    {
                        g.DrawString("EXT MA ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_MA_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_MA_BC_1 = "";
                    }

                    //"CSP"  "EIS"  "FRU" "GAL"

                    else if (detiq.CodExame_EXT_MA_BC_1_CSP != "")
                    {
                        g.DrawString("EXT MA ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_MA_BC_1_CSP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_MA_BC_1_CSP = "";
                    }
                    else if (detiq.CodExame_EXT_MA_BC_1_EIS != "")
                    {
                        g.DrawString("EXT MA ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_MA_BC_1_EIS, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_MA_BC_1_EIS = "";
                    }
                    else if (detiq.CodExame_EXT_MA_BC_1_FRU != "")
                    {
                        g.DrawString("EXT MA ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_MA_BC_1_FRU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_MA_BC_1_FRU = "";
                    }
                    else if (detiq.CodExame_EXT_MA_BC_1_GAL != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_MA_BC_1_GAL, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_MA_BC_1_GAL = "";
                    }
                    #endregion

                    #region ext bancada 1 24
                    else if (detiq.CodExame_EXT_24_BC_1 != "")
                    {
                        //if (detiq.CodExame_EXT_24_BC_1.Length > 37)
                        //{
                        //    detiq.CodExame_EXT_24_BC_1 = detiq.CodExame_EXT_24_BC_1.Substring(0, 33) + "...";
                        //}
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1 = "";
                    }
                    //CIU
                    else if (detiq.CodExame_EXT_24_BC_1_CIU != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_CIU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_CIU = "";
                    }
                    //OXU
                    else if (detiq.CodExame_EXT_24_BC_1_OXU != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_OXU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_OXU = "";
                    }
                    // "IMU" "MET" "BJO"  "CTU"
                    else if (detiq.CodExame_EXT_24_BC_1_IMU != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_IMU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_IMU = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_MET != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_MET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_MET = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_BJO != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_BJO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_BJO = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_CTU != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_CTU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_CTU = "";
                    }
                    //"C0U"  "COP"  "EPU"
                    else if (detiq.CodExame_EXT_24_BC_1_C0U != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_C0U, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_C0U = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_COP != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_COP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_COP = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_EPU != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_EPU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_EPU = "";
                    }
                    //"VMA" "ADU" "CIT"
                    else if (detiq.CodExame_EXT_24_BC_1_VMA != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_VMA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_VMA = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_ADU != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_ADU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_ADU = "";
                    }
                    else if (detiq.CodExame_EXT_24_BC_1_CIT != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_1_CIT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_1_CIT = "";
                    }

                    else if (detiq.CodExame_EXT_24_BC_3 != "")
                    {
                        g.DrawString("EXT 24 ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_24_BC_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_24_BC_3 = "";
                    }



                    #endregion



                    #region ext bancada 1 br
                    else if (detiq.CodExame_EXT_BR_BC_1 != "")
                    {
                        g.DrawString("EXT BR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_BR_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_BR_BC_1 = "";
                    }
                    //"COB" "ZIN"
                    else if (detiq.CodExame_EXT_BR_BC_1_COB != "")
                    {
                        g.DrawString("EXT BR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_BR_BC_1_COB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_BR_BC_1_COB = "";
                    }
                    else if (detiq.CodExame_EXT_BR_BC_1_ZIN != "")
                    {
                        g.DrawString("EXT BR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_BR_BC_1_ZIN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_BR_BC_1_ZIN = "";
                    }

                    #endregion

                    #region ext bancada 1 fr
                    else if (detiq.CodExame_EXT_FR_BC_1 != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_1 = "";
                    }
                    //"CFE" "EIU" "ION"  "MER" "TEP"
                    else if (detiq.CodExame_EXT_FR_BC_1_CFE != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_1_CFE, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_1_CFE = "";
                    }
                    else if (detiq.CodExame_EXT_FR_BC_1_EIU != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_1_EIU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_1_EIU = "";
                    }
                    else if (detiq.CodExame_EXT_FR_BC_1_ION != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_1_ION, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_1_ION = "";
                    }
                    else if (detiq.CodExame_EXT_FR_BC_1_MER != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_1_MER, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_1_MER = "";
                    }
                    else if (detiq.CodExame_EXT_FR_BC_1_TEP != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_1_TEP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_1_TEP = "";
                    }
                    #endregion




                    else if (detiq.CodExame_EXT_FR_BC_3 != "")
                    {
                        g.DrawString("EXT FR ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_FR_BC_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_FR_BC_3 = "";
                    }



                    #region ext bancada 1 LB
                    else if (detiq.CodExame_EXT_LB_BC_1 != "")
                    {
                        g.DrawString("EXT LB ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_LB_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_LB_BC_1 = "";
                    }

                    // "EFL""IML"
                    else if (detiq.CodExame_EXT_LB_BC_1_EFL != "")
                    {
                        g.DrawString("EXT LB ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_LB_BC_1_EFL, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_LB_BC_1_EFL = "";
                    }
                    else if (detiq.CodExame_EXT_LB_BC_1_IML != "")
                    {
                        g.DrawString("EXT LB ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_LB_BC_1_IML, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_LB_BC_1_IML = "";
                    }
                    #endregion



                    else if (detiq.CodExame_EXT_LB_BC_2 != "")
                    {
                        g.DrawString("EXT LB BC_2", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_LB_BC_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_LB_BC_2 = "";
                    }
                    else if (detiq.CodExame_EXT_SE_BC_1 != "")
                    {
                        g.DrawString("EXT SE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_SE_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_SE_BC_1 = "";
                    }
                    else if (detiq.CodExame_EXT_AS_BC_3 != "")
                    {
                        g.DrawString("EXT AS ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AS_BC_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AS_BC_3 = "";
                    }

                    #region ext bancada 1 VE
                    else if (detiq.CodExame_EXT_VE_BC_1 != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1 = "";
                    }

                    // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"
                    else if (detiq.CodExame_EXT_VE_BC_1_CAB != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1_CAB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1_CAB = "";
                    }
                    else if (detiq.CodExame_EXT_VE_BC_1_H50 != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1_H50, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1_H50 = "";
                    }
                    else if (detiq.CodExame_EXT_VE_BC_1_CRI != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1_CRI, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1_CRI = "";
                    }
                    else if (detiq.CodExame_EXT_VE_BC_1_VAN != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1_VAN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1_VAN = "";
                    }
                    else if (detiq.CodExame_EXT_VE_BC_1_FNI != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1_FNI, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1_FNI = "";
                    }
                    else if (detiq.CodExame_EXT_VE_BC_1_FNB != "")
                    {
                        g.DrawString("EXT VE ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VE_BC_1_FNB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VE_BC_1_FNB = "";
                    }

                    #endregion



                    else if (detiq.CodExame_EXT_VD_BC_3 != "")
                    {
                        g.DrawString("EXT VD ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_VD_BC_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_VD_BC_3 = "";
                    }

                        //DXI
                    else if (detiq.CodExame_EXT_CI_BC_1 != "")
                    {
                        g.DrawString("EXT CI   0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_CI_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_CI_BC_1 = "";
                    }
                    else if (detiq.CodExame_EXT_CI_BC_1_2ET != "")
                    {
                        g.DrawString("EXT CI   60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_CI_BC_1_2ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_CI_BC_1_2ET = "";
                    }



                    //"DXB"
                    else if (detiq.CodExame_EXT_CI_BC_1_DXB != "")
                    {
                        g.DrawString("EXT CI ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_CI_BC_1_DXB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_CI_BC_1_DXB = "";
                    }



                    #region ext bancada 1 RO
                    else if (detiq.CodExame_EXT_RO_BC_1 != "")
                    {
                        //if (detiq.CodExame_EXT_RO_BC_1.Length > 37)
                        //{
                        //    detiq.CodExame_EXT_RO_BC_1 = detiq.CodExame_EXT_RO_BC_1.Substring(0, 33) + "...";
                        //}
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1 = "";
                    }
                    //CVB
                    else if (detiq.CodExame_EXT_RO_BC_1_CVB != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_CVB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_CVB = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_CVB_2ET != "")
                    {
                        g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_CVB_2ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_CVB_2ET = "";
                    }

                        // "PRM" "CD8"  "XFR" "ACT"
                    else if (detiq.CodExame_EXT_RO_BC_1_PRM != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_PRM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_PRM = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_CD8 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_CD8, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_CD8 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_XFR != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_XFR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_XFR = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_ACT != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_ACT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_ACT = "";
                    }

                    //"G6P"  "B27"  "JAK"
                    else if (detiq.CodExame_EXT_RO_BC_1_G6P != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_G6P, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_G6P = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_G6P_2ET != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_G6P_2ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_G6P_2ET = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_B27 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_B27, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_B27 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_JAK != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_JAK, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_JAK = "";
                    }
                    //"CIC" "EHE"  "FVP"
                    else if (detiq.CodExame_EXT_RO_BC_1_CIC != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_CIC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_CIC = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_EHE != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_EHE, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_EHE = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_FVP != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_FVP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_FVP = "";
                    }

                    #endregion





                    else if (detiq.CodExame_EXT_RO_BC_3 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_3 = "";
                    }
                    //"BNN"
                    else if (detiq.CodExame_EXT_RO_BC_3_BNN != "")
                    {
                        g.DrawString("EXT AM ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_3_BNN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_3_BNN = "";
                    }


                    else if (detiq.CodExame_EXT_PPT_CVH != "")
                    {
                        g.DrawString("EXT ROX", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_PPT_CVH, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_PPT_CVH = "";
                    }
                    else if (detiq.CodExame_EXT_PPT_CVH_ET_2 != "")
                    {
                        g.DrawString("EXT ROX", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_PPT_CVH_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_PPT_CVH_ET_2 = "";
                    }

                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_HEP != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_HEP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_HEP = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_IMO != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_IMO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_IMO = "";
                    }

                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_ISP != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_ISP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_ISP = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_HEH != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_HEH, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_HEH = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_PHT != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_PHT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_PHT = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_3ET_PHQ, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_3ET_PHQ = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_CAG != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_CAG, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_CAG = "";
                    }
                    else if (detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET != "")
                    {
                        g.DrawString("EXT RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET = "";
                    }


                    #region ext bancada 1 AZ



                    else if (detiq.CodExame_EXT_AZ_BC_1_1ET != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_1ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_1ET = "";
                    }
                    //"AT3"  "RIT" "PCS"
                    else if (detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_1ET_AT3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_1ET_RIT != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_1ET_RIT, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_1ET_RIT = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_1ET_PCS, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_1ET_PCS = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 = "";
                    }


                    #endregion




                    #region ext bancada 1 AZ 2


                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1 != "")
                    {
                        //if (detiq.CodExame_EXT_AZ_BC_1_2ET_1.Length > 37)
                        //{
                        //    detiq.CodExame_EXT_AZ_BC_1_2ET_1 = detiq.CodExame_EXT_AZ_BC_1_2ET_1.Substring(0, 33) + "...";
                        //}
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1 = "";
                    }
                    //"F11" "F12"
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 = "";
                    }
                    //"FC8" "FVW" "F10"
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 = "";
                    }

                    //"FC9" "FC5"  "FC7"

                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 = "";
                    }
                    else if (detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 != "")
                    {
                        g.DrawString("EXT AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 = "";
                    }

                    #endregion



                    else if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 != "")
                    {
                        g.DrawString("EXT AR AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 = "";
                    }
                    else if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 != "")
                    {
                        g.DrawString("EXT AR AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 = "";
                    }
                    else if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 != "")
                    {
                        g.DrawString("EXT AR AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 = "";
                    }
                    else if (detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 != "")
                    {
                        g.DrawString("EXT AR AZ ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 = "";
                    }
                    else if (detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 != "")
                    {
                        g.DrawString("EXT AR RO ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExame_EXT_AR_BC_1_5ET_RO_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 = "";
                    }
                    //else if (detiq.CodExame_EXT_RO_BC_1_HIV != "")
                    //{
                    //    g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExame_EXT_RO_BC_1_HIV, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExame_EXT_RO_BC_1_HIV = "";
                    //}
                    //else if (detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 != "")
                    //{
                    //    g.DrawString("EXT ROX ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExame_EXT_RO_BC_1_HIV_ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 = "";
                    //}


                    #endregion
                    #region HOR Tem que ficar antes de BIO

                    else if (detiq.CodExameHOR != "")
                    {
                        if (detiq.CodExameHOR.Length > 42)
                        {
                            detiq.CodExameHOR = detiq.CodExameHOR.Substring(0, 39) + "...";
                        }

                        g.DrawString("HOR AM", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR = "";
                    }

                        // TESTE PARA HOR E BIO, OU SEJA IMPRIMIR T14 SE TIVER O EXAMES EM BIO

                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C22 != "")
                    {
                        g.DrawString("HOR AM 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C22 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C22_30 != "")
                    {
                        g.DrawString("HOR AM 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C22_30 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C22_60 != "")
                    {
                        g.DrawString("HOR AM 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C22_60 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C22_90 != "")
                    {
                        g.DrawString("HOR AM 90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C22_90 = "";
                    }

                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C22_120 != "")
                    {
                        g.DrawString("HOR AM 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C22_120 = "";
                    }


                        // falta completar  as 8 etiquetas e chamar a função
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2 != "")
                    {
                        g.DrawString("HOR AM 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_30 != "")
                    {
                        g.DrawString("HOR AM 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_30 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_60 != "")
                    {
                        g.DrawString("HOR AM 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_60 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_90 != "")
                    {
                        g.DrawString("HOR AM 90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_90 = "";
                    }

                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_120 != "")
                    {
                        g.DrawString("HOR AM 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_120 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_180 != "")
                    {
                        g.DrawString("HOR AM 180", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_180 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_240 != "")
                    {
                        g.DrawString("HOR AM 240", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_240 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_CP2_300 != "")
                    {
                        g.DrawString("HOR AM 300", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_CP2_300 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_SG2 != "")
                    {
                        g.DrawString("HOR AM 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_SG2 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_SG2_120 != "")
                    {
                        g.DrawString("HOR AM 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_SG2_120 = "";
                    }

                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_SC2 != "")
                    {
                        g.DrawString("HOR AM 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_SC2 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_SC2_60 != "")
                    {
                        g.DrawString("HOR AM 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_SC2_60 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C32 != "")
                    {
                        g.DrawString("HOR AM 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C32 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C32_30 != "")
                    {
                        g.DrawString("HOR AM 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C32_30 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C32_60 != "")
                    {
                        g.DrawString("HOR AM 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C32_60 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C32_90 != "")
                    {
                        g.DrawString("HOR AM 90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C32_90 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C32_120 != "")
                    {
                        g.DrawString("HOR AM 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C32_120 = "";
                    }
                    else if (detiq.CodExameHOR_T14_BIO != "" && detiq.CodExameHOR_T14_BIO_C32_180 != "")
                    {
                        g.DrawString("HOR AM 180", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHOR_T14_BIO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHOR_T14_BIO_C32_180 = "";
                    }

                    #endregion
                    #region BAC        OK

                    else if (detiq.CodExameBAC != "")
                    {
                        if (detiq.CodExameBAC.Length > 42)
                        {
                            detiq.CodExameBAC = detiq.CodExameBAC.Substring(0, 39) + "...";
                        }

                        g.DrawString("BAC ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBAC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBAC = "";
                    }
                    else if (detiq.CodExameBAC_FV != "")
                    {
                        g.DrawString("BAC  FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBAC_FV, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBAC_FV = "";
                    }
                    else if (detiq.CodExameBAC_BK2 != "")
                    {
                        g.DrawString("BAC  FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBAC_BK2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBAC_BK2 = "";
                    }

                    else if (detiq.CodExameBAC_HA != "")
                    {
                        g.DrawString("BAC  HA", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBAC_HA, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBAC_HA = "";
                    }
                    else if (detiq.CodExameBAC_HN != "")
                    {
                        g.DrawString("BAC  HN", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBAC_HN, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBAC_HN = "";
                    }
                    else if (detiq.CodExameBAC_HP != "")
                    {
                        g.DrawString("BAC  HP", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBAC_HP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBAC_HP = "";
                    }
                    #endregion
                    #region BIO
                    // Teste
                    else if (detiq.CodExameBIO_FR_RPC != "")
                    {
                        g.DrawString("BIO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_FR_RPC, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_FR_RPC = "";
                    }


                    else if (detiq.CodExameBIO_AM != "" && detiq.CodExameBIO_AM == "GL4 ")
                    {
                        g.DrawString("BIO CID", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_AM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_AM = "";
                    }
                    // teste DC2
                    //else if (detiq.CodExameBIO_AM != "" && detiq.CodExameBIO_AM == "DC2 ")
                    //{
                    //    detiq.CodExameBIO_AM = "";
                    //}
                    //else if (detiq.CodExameBIO_AM_AM != "" && detiq.CodExameBIO_AM_AM != "DC2 ")
                    //{
                    //    detiq.CodExameBIO_AM_AM = "";
                    //}
                    //else if (detiq.CodExameBIO_AM_24 != "" && detiq.CodExameBIO_AM_24 != "DC2 ")
                    //{
                    //    detiq.CodExameBIO_AM_24 = "";
                    //}


                    else if (detiq.CodExameBIO_AM != "")
                    {
                        if (detiq.CodExameBIO_AM.Length > 42)
                        {
                            detiq.CodExameBIO_AM = detiq.CodExameBIO_AM.Substring(0, 39) + "...";
                        }
                        g.DrawString("BIO AM", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_AM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_AM = "";
                    }


                    else if (detiq.CodExameBIO_AM_AM != "")
                    {
                        g.DrawString("BIO AM AM", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_AM_AM, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_AM_AM = "";
                    }

                    else if (detiq.CodExameBIO_AM_24 != "")
                    {
                        g.DrawString("BIO 24", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_AM_24, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_AM_24 = "";
                    }

                    else if (detiq.CodExameBIO_LB != "")
                    {
                        if (detiq.CodExameBIO_LB.Length > 37)
                        {
                            detiq.CodExameBIO_LB = detiq.CodExameBIO_LB.Substring(0, 33) + "...";
                        }
                        g.DrawString("BIO LB", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_LB, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_LB = "";
                    }
                    else if (detiq.CodExameBIO_24 != "")
                    {
                        if (detiq.CodExameBIO_24.Length > 37)
                        {
                            detiq.CodExameBIO_24 = detiq.CodExameBIO_24.Substring(0, 33) + "...";
                        }
                        g.DrawString("BIO 24", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_24, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_24 = "";
                    }
                    else if (detiq.CodExameBIO_FR != "")
                    {
                        g.DrawString("BIO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_FR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_FR = "";
                    }
                    else if (detiq.CodExameBIO_SE != "")
                    {
                        g.DrawString("BIO SE", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_SE, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_SE = "";
                    }
                    else if (detiq.CodExameBIO_OU != "")
                    {
                        g.DrawString("BIO OU", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_OU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_OU = "";
                    }
                    else if (detiq.CodExameBIO_RO != "")
                    {
                        g.DrawString("BIO RO", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_RO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_RO = "";
                    }
                    else if (detiq.CodExameBIO_G1_2ET != "")
                    {
                        g.DrawString("BIO G1", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_G1_2ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_G1_2ET = "";
                    }
                    else if (detiq.CodExameBIO_G1_2ET_1 != "")
                    {
                        g.DrawString("BIO G1", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_G1_2ET_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_G1_2ET_1 = "";
                    }
                    else if (detiq.CodExameBIO_G1_4ET != "")
                    {
                        g.DrawString("BIO G1", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_G1_4ET, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_G1_4ET = "";
                    }
                    else if (detiq.CodExameBIO_G1_4ET_1 != "")
                    {
                        g.DrawString("BIO G1", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_G1_4ET_1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_G1_4ET_1 = "";
                    }
                    else if (detiq.CodExameBIO_G1_4ET_2 != "")
                    {
                        g.DrawString("BIO G1", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_G1_4ET_2, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_G1_4ET_2 = "";
                    }
                    else if (detiq.CodExameBIO_G1_4ET_3 != "")
                    {
                        g.DrawString("BIO G1", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_G1_4ET_3, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_G1_4ET_3 = "";
                    }
                    else if (detiq.CodExameBIO_CI != "")
                    {
                        g.DrawString("BIO CI 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI = "";
                    }
                    else if (detiq.CodExameBIO_CI_30 != "")
                    {
                        g.DrawString("BIO CI 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_30, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_30 = "";
                    }
                    else if (detiq.CodExameBIO_CI_60 != "")
                    {
                        g.DrawString("BIO CI 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_60, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_60 = "";
                    }


                    //else if (detiq.CodExameBIO_CID_GLICOSE != "")
                    //{
                    //    g.DrawString("BIO CID", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CID_GLICOSE, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CID_GLICOSE = "";
                    //}
                    else if (detiq.CodExameBIO_CIP != "")
                    {
                        g.DrawString("BIO CIP POS PRANDIAL", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CIP, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CIP = "";
                    }
                    else if (detiq.CodExameBIO_CID_5_ET_0 != "")
                    {
                        g.DrawString("BIO CID 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_5_ET_0, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_5_ET_0 = "";
                    }
                    else if (detiq.CodExameBIO_CID_5_ET_30 != "")
                    {
                        g.DrawString("BIO CID 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_5_ET_30, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_5_ET_30 = "";
                    }
                    else if (detiq.CodExameBIO_CID_5_ET_60 != "")
                    {
                        g.DrawString("BIO CID 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_5_ET_60, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_5_ET_60 = "";
                    }
                    else if (detiq.CodExameBIO_CID_5_ET_90 != "")
                    {
                        g.DrawString("BIO CID 90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_5_ET_90, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_5_ET_90 = "";
                    }
                    else if (detiq.CodExameBIO_CID_5_ET_120 != "")
                    {
                        g.DrawString("BIO CID 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_5_ET_120, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_5_ET_120 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_0 != "")
                    {
                        g.DrawString("BIO CID 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_0, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_0 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_30 != "")
                    {
                        g.DrawString("BIO CID 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_30, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_30 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_60 != "")
                    {
                        g.DrawString("BIO CID 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_60, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_60 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_90 != "")
                    {
                        g.DrawString("BIO CID 90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_90, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_90 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_120 != "")
                    {
                        g.DrawString("BIO CID 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_120, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_120 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_180 != "")
                    {
                        g.DrawString("BIO CID 180", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_180, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_180 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_240 != "")
                    {
                        g.DrawString("BIO CID 240", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_240, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_240 = "";
                    }
                    else if (detiq.CodExameBIO_CID_8_ET_300 != "")
                    {
                        g.DrawString("BIO CID 300", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CID_8_ET_300, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CID_8_ET_300 = "";
                    }
                    else if (detiq.CodExameBIO_CI_2_ET_0 != "")
                    {
                        g.DrawString("BIO CID 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_2_ET_0, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_2_ET_0 = "";
                    }
                    else if (detiq.CodExameBIO_CI_2_ET_120 != "")
                    {
                        g.DrawString("BIO CID 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_2_ET_120, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_2_ET_120 = "";
                    }
                    else if (detiq.CodExameBIO_CI_2_ET_CS2_0 != "")
                    {
                        g.DrawString("BIO CID 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_2_ET_CS2_0, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_2_ET_CS2_0 = "";
                    }
                    else if (detiq.CodExameBIO_CI_2_ET_CS2_60 != "")
                    {
                        g.DrawString("BIO CID 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_2_ET_CS2_60, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_2_ET_CS2_60 = "";
                    }
                    else if (detiq.CodExameBIO_CI_6_ET_0 != "")
                    {
                        g.DrawString("BIO CID 0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_6_ET_0, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_6_ET_0 = "";
                    }
                    else if (detiq.CodExameBIO_CI_6_ET_30 != "")
                    {
                        g.DrawString("BIO CID 30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_6_ET_30, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_6_ET_30 = "";
                    }
                    else if (detiq.CodExameBIO_CI_6_ET_60 != "")
                    {
                        g.DrawString("BIO CID 60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_6_ET_60, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_6_ET_60 = "";
                    }
                    else if (detiq.CodExameBIO_CI_6_ET_90 != "")
                    {
                        g.DrawString("BIO CID 90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_6_ET_90, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_6_ET_90 = "";
                    }
                    else if (detiq.CodExameBIO_CI_6_ET_120 != "")
                    {
                        g.DrawString("BIO CID 120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_6_ET_120, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_6_ET_120 = "";
                    }
                    else if (detiq.CodExameBIO_CI_6_ET_180 != "")
                    {
                        g.DrawString("BIO CID 180", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_CI_6_ET_180, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_CI_6_ET_180 = "";
                    }
                    else if (detiq.CodExameBIO_SER_GS6 != "")
                    {
                        g.DrawString("BIO SER", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameBIO_SER_GS6, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameBIO_SER_GS6 = "";
                    }
                    //else if (detiq.CodExameBIO_CINZA_T14_0 != "")
                    //{
                    //    g.DrawString("BIO CINZA  0", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CINZA_T14_0, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CINZA_T14_0 = "";
                    //}
                    //else if (detiq.CodExameBIO_CINZA_T14_30 != "")
                    //{
                    //    g.DrawString("BIO CINZA  30", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CINZA_T14_30, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CINZA_T14_30 = "";
                    //}
                    //else if (detiq.CodExameBIO_CINZA_T14_60 != "")
                    //{
                    //    g.DrawString("BIO CINZA  60", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CINZA_T14_60, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CINZA_T14_60 = "";
                    //}
                    //else if (detiq.CodExameBIO_CINZA_T14_90 != "")
                    //{
                    //    g.DrawString("BIO CINZA  90", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CINZA_T14_90, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CINZA_T14_90 = "";
                    //}
                    //else if (detiq.CodExameBIO_CINZA_T14_120 != "")
                    //{
                    //    g.DrawString("BIO CINZA  120", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CINZA_T14_120, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CINZA_T14_120 = "";
                    //}
                    //else if (detiq.CodExameBIO_CINZA_T14_180 != "")
                    //{
                    //    g.DrawString("BIO CINZA  180", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                    //    g.DrawString(detiq.CodExameBIO_CINZA_T14_180, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                    //    detiq.CodExameBIO_CINZA_T14_180 = "";
                    //}

                    #endregion
                    #region HEM
                    else if (detiq.CodExameHEM_Rox != "")
                    {
                        if (detiq.CodExameHEM_Rox.Length > 42)
                        {
                            detiq.CodExameHEM_Rox = detiq.CodExameHEM_Rox.Substring(0, 39) + "...";
                        }
                        g.DrawString("HEM ROX", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHEM_Rox, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHEM_Rox = "";
                    }
                    else if (detiq.CodExameHEM_Azul != "")
                    {
                        if (detiq.CodExameHEM_Azul.Length > 42)
                        {
                            detiq.CodExameHEM_Azul = detiq.CodExameHEM_Azul.Substring(0, 39) + "...";
                        }
                        g.DrawString("HEM AZU", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHEM_Azul, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHEM_Azul = "";
                    }
                    else if (detiq.CodExameHEM_DI != "")
                    {
                        g.DrawString("HEM DI", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHEM_DI, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHEM_DI = "";
                    }
                    else if (detiq.CodExameHEM_BR != "")
                    {
                        g.DrawString("HEM BR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameHEM_BR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameHEM_BR = "";
                    }

                    #endregion
                    #region IMU Imprimi
                    else if (detiq.CodExameIMU_Amarelo != "")
                    {

                        if (detiq.CodExameIMU_Amarelo.Length > 42)
                        {
                            detiq.CodExameIMU_Amarelo = detiq.CodExameIMU_Amarelo.Substring(0, 39) + "...";
                        }

                        g.DrawString("IMU AMA", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameIMU_Amarelo, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameIMU_Amarelo = "";
                    }
                    else if (detiq.CodExameIMU_U12 != "")
                    {
                        g.DrawString("IMU U12", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameIMU_U12, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameIMU_U12 = "";
                    }
                    else if (detiq.CodExameIMU_U24 != "")
                    {
                        g.DrawString("IMU U24", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameIMU_U24, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameIMU_U24 = "";
                    }
                    else if (detiq.CodExameIMU_COU != "")
                    {
                        g.DrawString("IMU COU", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameIMU_COU, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameIMU_COU = "";
                    }
                    else if (detiq.CodExameIMU_RO != "")
                    {
                        g.DrawString("IMU ROX", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExameIMU_RO, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExameIMU_RO = "";
                    }

                    #endregion
                    #region PAR

                    else if (detiq.CodExamePAR != "")
                    {
                        if (detiq.CodExamePAR.Length > 42)
                        {
                            detiq.CodExamePAR = detiq.CodExamePAR.Substring(0, 39) + "...";
                        }
                        g.DrawString("PAR  FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExamePAR, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExamePAR = "";
                    }
                    else if (detiq.CodExamePAR_FI != "")
                    {
                        g.DrawString("PAR  FI", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.CodExamePAR_FI, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.CodExamePAR_FI = "";
                    }
                    #endregion


                    // LU
                    #region LU
                    //BAC
                    else if (detiq.LU_codExame_BAC_BK1 != "") // Teste conserto bug 04/08/2015 as 15:10
                    {
                        g.DrawString("BAC BK", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_BAC_BK1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_BAC_BK1 = "";
                    }
                    else if (detiq.LU_codExame_BAC_DI1 != "")
                    {
                        g.DrawString("BAC DI", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_BAC_DI1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_BAC_DI1 = "";
                    }
                    // BIO
                    else if (detiq.LU_codExame_BIO_AM1 != "")
                    {
                        if (detiq.LU_codExame_BIO_AM1.Length > 42)
                        {
                            detiq.LU_codExame_BIO_AM1 = detiq.LU_codExame_BIO_AM1.Substring(0, 39) + "...";
                        }
                        g.DrawString("BIO AM", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_BIO_AM1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_BIO_AM1 = "";
                    }
                    else if (detiq.LU_codExame_BIO_LB1 != "")
                    {
                        g.DrawString("BIO LB", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_BIO_LB1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_BIO_LB1 = "";
                    }
                    else if (detiq.LU_codExame_BIO_SE1 != "")
                    {
                        g.DrawString("BIO SER", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_BIO_SE1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_BIO_SE1 = "";
                    }
                    // HEM

                    else if (detiq.LU_codExame_HEM_AZ1 != "")
                    {
                        g.DrawString("HEM AZ", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_HEM_AZ1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_HEM_AZ1 = "";
                    }
                    else if (detiq.LU_codExame_HEM_RO1 != "")
                    {
                        g.DrawString("HEM RO", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_HEM_RO1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_HEM_RO1 = "";
                    }
                    else if (detiq.LU_codExame_HEM_DI1 != "")
                    {
                        g.DrawString("HEM DI", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_HEM_DI1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_HEM_DI1 = "";
                    }
                    else if (detiq.LU_codExame_HEM_LB1 != "")
                    {
                        g.DrawString("HEM LB", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_HEM_LB1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_HEM_LB1 = "";
                    }
                    // HOR
                    else if (detiq.LU_codExame_HOR_AM1 != "")
                    {
                        g.DrawString("HOR AM", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_HOR_AM1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_HOR_AM1 = "";
                    }
                    // IMU

                    else if (detiq.LU_codExame_IMU_RO1 != "")
                    {
                        g.DrawString("IMU RO", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_IMU_RO1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_IMU_RO1 = "";
                    }
                    else if (detiq.LU_codExame_IMU_AM1 != "")
                    {
                        g.DrawString("IMU AM", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_IMU_AM1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_IMU_AM1 = "";
                    }
                    else if (detiq.LU_codExame_IMU_LB1 != "")
                    {
                        g.DrawString("IMU LB", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_IMU_LB1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_IMU_LB1 = "";
                    }
                    //PAR
                    else if (detiq.LU_codExame_PAR_FR1 != "")
                    {
                        g.DrawString("PAR FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_PAR_FR1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_PAR_FR1 = "";
                    }
                    // URI Na Verdade é URO mas tem que verificar com a Monica 
                    else if (detiq.LU_codExame_URI_FR1 != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_URI_FR1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_URI_FR1 = "";
                    }
                    else if (detiq.LU_codExame_URI_FR_ET_21 != "")
                    {
                        g.DrawString("URO FR", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.LU_codExame_URI_FR_ET_21, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.LU_codExame_URI_FR_ET_21 = "";
                    }
                    else if (detiq.Nao_Classificado1 != "")
                    {
                        g.DrawString("Não Classificado", new Font("Arial", 8, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 50, starty + 71);
                        g.DrawString(detiq.Nao_Classificado1, new Font("Arial", 6, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter + 0, starty + 83);
                        detiq.Nao_Classificado1 = "";
                    }


                    #endregion






                    #endregion

                    string txbRequis2 = txbRequis.Text.Replace(".", "");
                    string txbRequis3 = txbRequis2.ToUpper();

                   // Image newImage = Code128Rendering.MakeBarcodeImage(txbRequis3, 1, true);

                    detiq.NovaImagem1 = Code128Rendering.MakeBarcodeImage(txbRequis3, 1, true);


                    // Create coordinates for upper-left corner.

                    int x = 12; // antes -8
                    int y = 33;

                    int width = 174; // com 180 funciona corretamente na maquina 
                    int height = 49; // 40 antes

                    // Draw image to screen.
                    //e.Graphics.DrawImage(newImage, x, y, width, height);

                    e.Graphics.DrawImage(detiq.NovaImagem1, x, y, width, height);
                    
                  


                }


                //e.Graphics.DrawImage();
            }
        }
        //Fim do print1

        
        

        #region Print2 comprovante paciente




        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            string data = DateTime.Now.ToShortDateString();
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);//900 é a largura da página
            printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
            printDialog2.PrinterSettings.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom2", 203, 110);
            using (Graphics g = e.Graphics)
            {
                using (Font fnt = new Font("Arial", 14)) // antes estava 12
                {
                    int startXCenter = 10;//margem da esquerda da etiqueta
                    int starty = 10;//distancia das linhas

                    PointF pointF2 = new PointF(182, 25);// 14/08/2015
                    PointF pointF3 = new PointF(30, 60); //
                    PointF pointF = new PointF(171, 0);// sempre 10 a menos que o f1
                    PointF pointF1 = new PointF(188, 25);// horinzontal , Vertical
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                    string dia = detiq.DtColeta.Substring(6, 2);
                    string mes = detiq.DtColeta.Substring(4, 2);
                    string ano = detiq.DtColeta.Substring(0, 4);
                    string dt = dia + "/" + mes + "/" + ano;

                    string dataNascPaciente = "";

                    if (detiq.DtNascRH.Length > 7 || detiq.DtNascBE.Length > 7)
                    {


                        // Data de Nascimento //99999999.

                        string diaRH = detiq.DtNascRH.Substring(6, 2);
                        string mesRH = detiq.DtNascRH.Substring(4, 2);
                        string anoRH = detiq.DtNascRH.Substring(0, 4);
                        string dataNascRH = diaRH + "/" + mesRH + "/" + anoRH;

                        string diaBE = detiq.DtNascBE.Substring(6, 2);
                        string mesBE = detiq.DtNascBE.Substring(4, 2);
                        string anoBE = detiq.DtNascBE.Substring(0, 4);
                        string dataNascBE = diaBE + "/" + mesBE + "/" + anoBE;
                        if (dataNascRH == "99/99/9999" && dataNascBE != "99/99/9999")
                        {
                            dataNascPaciente = dataNascBE;
                        }
                        else if (dataNascBE == "99/99/9999" && dataNascRH != "99/99/9999")
                        {
                            dataNascPaciente = dataNascRH;

                        }
                        else if (dataNascRH == "99/99/9999" && dataNascBE == "99/99/9999")
                        {
                            dataNascPaciente = "";

                        }

                    }
                    else
                    {
                        dataNascPaciente = "";
                    }


                    if (detiq.Nome.Length > 33)
                    {
                        string Nome1 = detiq.Nome.Substring(0, 31) + "-";
                        int RestoNome = Convert.ToInt32(detiq.Nome.Length);
                        string ComplementoNome = detiq.Nome.Substring(31, RestoNome - 31);

                        g.DrawString(Nome1, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter - 3, starty - 1); // posição onde começa o nome // antigo - 10, starty - 9                        
                        g.DrawString(ComplementoNome, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter - 3, starty + 10); // posição onde começa o nome // antigo - 10, starty - 9
                        g.DrawString("Data Coleta: " + dt, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty + 60); // antigo pointF2, stringFormat
                        g.DrawString("Data Nasc: " + dataNascPaciente, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty + 25); // antigo pointF2, stringFormat



                        detiq.ComprovantePaciente1 = "";
                    }
                    else
                    {

                        //if (detiq.ComprovantePaciente1!="")
                        //{

                        g.DrawString(detiq.Nome, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, startXCenter - 3, starty - 1); // posição onde começa o nome // antigo - 10, starty - 9
                        g.DrawString("Data Coleta: " + dt, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty + 60); // antigo pointF2, stringFormat
                        g.DrawString("Data Nasc: " + dataNascPaciente, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty + 25); // antigo pointF2, stringFormat

                        //Hospital do Servidor Público Municipal


                        detiq.ComprovantePaciente1 = "";
                    }
                    if (detiq.Rh != "0.")
                    {
                        g.DrawString("RH: " + detiq.Rh, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty + 42); // antigo pointF2, stringFormat

                    }

                    if (detiq.Be != "0.")
                    {

                        g.DrawString("BE: " + detiq.Be, new Font("Arial", 7, FontStyle.Bold), System.Drawing.Brushes.Black, 6, starty + 42);
                        //detiq.ComprovantePaciente1 = "";

                    }




                    //else if (detiq.Consulta != "")
                    //{
                    //    g.DrawString("FAA: " + detiq.Consulta, new Font("Arial", 10), System.Drawing.Brushes.Black, startXCenter + 110, starty + 94);// antigo - 10, starty + 2
                    //    detiq.ComprovantePaciente1 = "";

                    //}
                    //}



                }
        #endregion


            }
        
        }

        private void txbRequis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        // limpar aqui

        


    }
}
