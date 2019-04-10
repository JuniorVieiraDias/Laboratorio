using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

//using Labetiq; // add junior teste

namespace Labetiq
{
    public class HospubDados
    {
        public DadosRequisicao getDados(string requis)
        {
            DadosRequisicao detiq = new DadosRequisicao();

            string numRequisicao = requis.ToUpper(); // Usei o ToUpper caso o atendente digite o LC ou LU com minuscula
            string codExmNoped = numRequisicao.Substring(0, 2);
            string codExmReped = numRequisicao.Substring(2, 2);
            string codExmRiped = numRequisicao.Substring(4, 1);
            string codExmSeqped = numRequisicao.Substring(5, 6);

            string conStr = "DSN=hospub-server;Uid=;Pwd=;";//string de conexão com o banco de dados

            string strSql = "select c27labanoped, c27labareped, c27labpriped, c27labseqped,"
                + " c27labnome4, c27compos, c27labtippac, c27labidade, c27labsexo, c27labconsul, "
                + " i27labnumbe, i27labregist, i27labident, "
                + " d27labagdcol, c29labcodare, c29labcodset, c29labcodban,c29labcodexm,c27labhorae, ib6dtnasc, d54nasc"
                + " from tsql.lab27, tsql.lab29, tqsl.intb6, tqsl.cen54 "
                + " where c27labanoped='" + codExmNoped + "' "
                + " and c27labareped='" + codExmReped + "' "
                + " and c27labpriped='" + codExmRiped + "' "
                + " and c27labseqped='" + codExmSeqped + "' "
                + " and c29labanoped='" + codExmNoped + "' "
                + " and c29labareped='" + codExmReped + "' "
                + " and c29labpriped='" + codExmRiped + "' "
                + " and c29labseqped='" + codExmSeqped + "'"
                + "and i27labregist=ib6regist and i27labnumbe=n54numbolet";

            string strExm = "select c29labcodexm, c29labcodset,c29labcodban from tsql.lab29 where c29labanoped='" + codExmNoped + "' and "
                        + " c29labareped='" + codExmReped + "' and c29labpriped='" + codExmRiped + "' and c29labseqped='" + codExmSeqped + "'";

            // Variaveis   

            #region Variaveis exames externos


            #region Bancada 1 exames externos

            string exmEXT_BC_1 = "";  // refere-se ao exm EXT Amarelo BANCADA 1

            string exmEXT_BC_1_C17 = "";  // refere-se ao exm EXT Amarelo BANCADA 1
            string exmEXT_BC_1_T20 = "";
            string exmEXT_BC_1_ADA = "";
            string exmEXT_BC_1_LAS = "";
            string exmEXT_BC_1_ADO = "";
            string exmEXT_BC_1_AAT = "";
            string exmEXT_BC_1_DRO = "";
            string exmEXT_BC_1_CAD = "";
            string exmEXT_BC_1_PAR = "";
            string exmEXT_BC_1_CEN = "";
            //"AEN" "GAD" "AGL"
            string exmEXT_BC_1_AEN = "";
            string exmEXT_BC_1_GAD = "";
            string exmEXT_BC_1_AGL = "";
            //"ILH" "JO1"  "MIT"

            string exmEXT_BC_1_ILH = "";
            string exmEXT_BC_1_JO1 = "";
            string exmEXT_BC_1_MIT = "";
            //"MUL" "RNP" "S70"
            string exmEXT_BC_1_MUL = "";
            string exmEXT_BC_1_RNP = "";
            string exmEXT_BC_1_S70 = "";
            //"ASM"  "SSA"  "SSB"
            string exmEXT_BC_1_ASM = "";
            string exmEXT_BC_1_SSA = "";
            string exmEXT_BC_1_SSB = "";
            //"AIN"  "LKM"  "MUE"
            string exmEXT_BC_1_AIN = "";
            string exmEXT_BC_1_LKM = "";
            string exmEXT_BC_1_MUE = "";
            //"ATR"  "ACN" "CCP"
            string exmEXT_BC_1_ATR = "";
            string exmEXT_BC_1_ACN = "";
            string exmEXT_BC_1_CCP = "";
            //"BG2"  "C1E" "CAI"
            string exmEXT_BC_1_BG2 = "";
            string exmEXT_BC_1_C1E = "";
            string exmEXT_BC_1_CAI = "";
            // "CAC"  "CFF" 
            string exmEXT_BC_1_CAC = "";
            string exmEXT_BC_1_CFF = "";
            //"CVC" "CER" "COC"
            string exmEXT_BC_1_CVC = "";
            string exmEXT_BC_1_CER = "";
            string exmEXT_BC_1_COC = "";
            //"DHE" "DGX" "EPR"
            string exmEXT_BC_1_DHE = "";
            string exmEXT_BC_1_DGX = "";
            string exmEXT_BC_1_EPR = "";
            //"ENA"  "EQU"  "ERT"
            string exmEXT_BC_1_ENA = "";
            string exmEXT_BC_1_EQU = "";
            string exmEXT_BC_1_ERT = "";
            //"GAT"  "GEC"  "HPT"
            string exmEXT_BC_1_GAT = "";
            string exmEXT_BC_1_GEC = "";
            string exmEXT_BC_1_HPT = "";
            //"HER"  "HOM"  "HTL"
            string exmEXT_BC_1_HER = "";
            string exmEXT_BC_1_HOM = "";
            string exmEXT_BC_1_HTL = "";
            //"IF3"  "IEP"  "FIX"
            string exmEXT_BC_1_IF3 = "";
            string exmEXT_BC_1_IEP = "";
            string exmEXT_BC_1_FIX = "";
            //"IST"  "LIT"  "LYM"
            string exmEXT_BC_1_IST = "";
            string exmEXT_BC_1_LIT = "";
            string exmEXT_BC_1_LYM = "";
            // "MON"  "MIC" "PCB"
            string exmEXT_BC_1_MON = "";
            string exmEXT_BC_1_MIC = "";
            string exmEXT_BC_1_PCB = "";
            //"PCC" "PEP" "PVR"
            string exmEXT_BC_1_PCC = "";
            string exmEXT_BC_1_PEP = "";
            string exmEXT_BC_1_PVR = "";
            // "RIB"  "IGF"  "TBG"
            string exmEXT_BC_1_RIB = "";
            string exmEXT_BC_1_IGF = "";
            string exmEXT_BC_1_TBG = "";
            //"TOC" "TRA" "ESQ"
            string exmEXT_BC_1_TOC = "";
            string exmEXT_BC_1_TRA = "";
            string exmEXT_BC_1_ESQ = "";
            // "B2G"
            string exmEXT_BC_1_B2G = "";

            #endregion

            #region bancada 2 amarelo

            string exmEXT_BC_2 = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            //"BLA"  "CLA"  "DEN"
            string exmEXT_BC_2_BLA = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            string exmEXT_BC_2_CLA = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            string exmEXT_BC_2_DEN = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            //"TIF"  "LEP"  "SVA"  "VRS"
            string exmEXT_BC_2_TIF = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            string exmEXT_BC_2_LEP = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            string exmEXT_BC_2_SVA = "";  // refere-se ao exm EXT Amarelo BANCADA 2
            string exmEXT_BC_2_VRS = "";  // refere-se ao exm EXT Amarelo BANCADA 2

            #endregion

            #region bancada 3 amarela
            string exmEXT_BC_3 = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            //"RUA"  "TOA"  "HBM" "CTX"
            string exmEXT_BC_3_RUA = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            string exmEXT_BC_3_TOA = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            string exmEXT_BC_3_HBM = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            string exmEXT_BC_3_CTX = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            //"FRT"  "GHH"  "SUA" "HTG"
            string exmEXT_BC_3_FRT = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            string exmEXT_BC_3_GHH = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            string exmEXT_BC_3_SUA = "";  // refere-se ao exm EXT Amarelo BANCADA 3
            string exmEXT_BC_3_HTG = "";  // refere-se ao exm EXT Amarelo BANCADA 3

            #endregion

            #region ext bancada 1 MA
            string exmEXT_MA_BC_1 = "";  // refere-se ao exm EXT MA BANCADA 1
            //"CSP"  "EIS"  "FRU" "GAL"
            string exmEXT_MA_BC_1_CSP = "";  // refere-se ao exm EXT MA BANCADA 1
            string exmEXT_MA_BC_1_EIS = "";  // refere-se ao exm EXT MA BANCADA 1
            string exmEXT_MA_BC_1_FRU = "";  // refere-se ao exm EXT MA BANCADA 1
            string exmEXT_MA_BC_1_GAL = "";  // refere-se ao exm EXT MA BANCADA 1

            #endregion


            #region ext bancada 1 24
            string exmEXT_24_BC_1 = "";  // refere-se ao exm EXT 24 BANCADA 1
            //CIU
            string exmEXT_24_BC_1_CIU = "";
            //OXU
            string exmEXT_24_BC_1_OXU = "";

            //"VMA" "ADU" "CIT"
            string exmEXT_24_BC_1_VMA = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_ADU = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_CIT = "";  // refere-se ao exm EXT 24 BANCADA 1
            //"C0U"  "COP"  "EPU"
            string exmEXT_24_BC_1_C0U = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_COP = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_EPU = "";  // refere-se ao exm EXT 24 BANCADA 1
            // "IMU" "MET" "BJO"  "CTU"
            string exmEXT_24_BC_1_IMU = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_MET = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_BJO = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_1_CTU = "";  // refere-se ao exm EXT 24 BANCADA 1
            string exmEXT_24_BC_3 = "";  // refere-se ao exm EXT 24 BANCADA 3

            #endregion



            #region ext bancada 1 br

            string exmEXT_BR_BC_1 = "";  // refere-se ao exm EXT BR BANCADA 1
            //"COB" "ZIN"
            string exmEXT_BR_BC_1_COB = "";  // refere-se ao exm EXT BR BANCADA 1
            string exmEXT_BR_BC_1_ZIN = "";  // refere-se ao exm EXT BR BANCADA 1


            #endregion

            #region ext bancada 1 fr
            string exmEXT_FR_BC_1 = "";  // refere-se ao exm EXT FR BANCADA 1

            //"CFE" "EIU" "ION"  "MER" "TEP"
            string exmEXT_FR_BC_1_CFE = "";  // refere-se ao exm EXT FR BANCADA 1
            string exmEXT_FR_BC_1_EIU = "";  // refere-se ao exm EXT FR BANCADA 1
            string exmEXT_FR_BC_1_ION = "";  // refere-se ao exm EXT FR BANCADA 1
            string exmEXT_FR_BC_1_MER = "";  // refere-se ao exm EXT FR BANCADA 1
            string exmEXT_FR_BC_1_TEP = "";  // refere-se ao exm EXT FR BANCADA 1


            #endregion

            string exmEXT_FR_BC_3 = "";  // refere-se ao exm EXT FR BANCADA 3

            #region ext bancada 1 LB
            string exmEXT_LB_BC_1 = "";  // refere-se ao exm EXT LB BANCADA 1

            // "EFL""IML"
            string exmEXT_LB_BC_1_EFL = "";  // refere-se ao exm EXT LB BANCADA 1
            string exmEXT_LB_BC_1_IML = "";  // refere-se ao exm EXT LB BANCADA 1

            #endregion



            string exmEXT_LB_BC_2 = "";  // refere-se ao exm EXT LB BANCADA 2
            string exmEXT_SE_BC_1 = "";  // refere-se ao exm EXT SE BANCADA 1
            string exmEXT_AS_BC_3 = "";  // refere-se ao exm EXT AS BANCADA 3


            #region ext bancada 1 VE
            string exmEXT_VE_BC_1 = "";  // refere-se ao exm EXT VE BANCADA 1


            // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"

            string exmEXT_VE_BC_1_CAB = "";  // refere-se ao exm EXT VE BANCADA 1
            string exmEXT_VE_BC_1_H50 = "";  // refere-se ao exm EXT VE BANCADA 1
            string exmEXT_VE_BC_1_CRI = "";  // refere-se ao exm EXT VE BANCADA 1
            string exmEXT_VE_BC_1_VAN = "";  // refere-se ao exm EXT VE BANCADA 1
            string exmEXT_VE_BC_1_FNI = "";  // refere-se ao exm EXT VE BANCADA 1
            string exmEXT_VE_BC_1_FNB = "";  // refere-se ao exm EXT VE BANCADA 1


            #endregion




            string exmEXT_VD_BC_3 = "";  // refere-se ao exm EXT VD BANCADA 3

            string exmEXT_CI_BC_1 = "";  // refere-se ao exm EXT CI BANCADA 1
            //"DXB"
            string exmEXT_CI_BC_1_DXB = "";  // refere-se ao exm EXT CI BANCADA 1


            #region ext bancada 1 RO
            string exmEXT_RO_BC_1 = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_CVB = "";

            // "PRM" "CD8"  "XFR" "ACT"
            string exmEXT_RO_BC_1_PRM = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_CD8 = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_XFR = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_ACT = "";  // refere-se ao exm EXT RO BANCADA 1

            //"CIC" "EHE"  "FVP"
            string exmEXT_RO_BC_1_CIC = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_EHE = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_FVP = "";  // refere-se ao exm EXT RO BANCADA 1
            //"G6P"  "B27"  "JAK"
            string exmEXT_RO_BC_1_G6P = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_B27 = "";  // refere-se ao exm EXT RO BANCADA 1
            string exmEXT_RO_BC_1_JAK = "";  // refere-se ao exm EXT RO BANCADA 1




            #endregion

            string exmEXT_RO_BC_3 = "";  // refere-se ao exm EXT RO BANCADA 3
            //"BNN"
            string exmEXT_RO_BC_3_BNN = "";  // refere-se ao exm EXT RO BANCADA 3




            string exmEXT_PPT_CVH = "";  // refere-se ao exm EXT RO BANCADA 1 - 2 etiquetaas cvh


            string exmEXT_RO_BC_1_2ET_HEP = "";  // refere-se ao exm EXT RO BANCADA 1 - 2 etiquetaas HEP
            string exmEXT_RO_BC_1_2ET_IMO = "";  // refere-se ao exm EXT RO BANCADA 1 - 2 etiquetaas IMO
            string exmEXT_RO_BC_1_2ET_ISP = "";  // refere-se ao exm EXT RO BANCADA 1 - 2 etiquetaas ISP
            string exmEXT_RO_BC_1_2ET_HEH = "";  // refere-se ao exm EXT RO BANCADA 1 - 2 etiquetaas HEH
            string exmEXT_RO_BC_1_2ET_PHT = "";  // refere-se ao exm EXT RO BANCADA 1 - 2 etiquetaas PHT
            string exmEXT_RO_BC_1_2ET_PHQ = "";  // refere-se ao exm EXT RO BANCADA 1 - 3 etiquetaas PHQ
            string exmEXT_RO_BC_1_2ET_CAG = "";  // refere-se ao exm EXT RO BANCADA 1 - 3 etiquetaas PHQ

            #region ext bancada 1 AZ
            string exmEXT_AZ_BC_1_1ET = "";  // refere-se ao exm EXT AZ BANCADA 1 - 1 etiquetaas 
            //"AT3"  "RIT" "PCS"
            string exmEXT_AZ_BC_1_1ET_AT3 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 1 etiquetaas 
            string exmEXT_AZ_BC_1_1ET_RIT = "";  // refere-se ao exm EXT AZ BANCADA 1 - 1 etiquetaas 
            string exmEXT_AZ_BC_1_1ET_PCS = "";  // refere-se ao exm EXT AZ BANCADA 1 - 1 etiquetaas 


            #endregion

            #region ext bancada 1 AZ 2


            string exmEXT_AZ_BC_1_2ET = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 etiquetaas 
            //"F11" "F12"
            string exmEXT_AZ_BC_1_2ET_F11 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 
            string exmEXT_AZ_BC_1_2ET_F12 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 


            //"FC8" "FVW" "F10"
            string exmEXT_AZ_BC_1_2ET_FC8 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 
            string exmEXT_AZ_BC_1_2ET_FVW = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 
            string exmEXT_AZ_BC_1_2ET_F10 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 

            //"FC9" "FC5"  "FC7"
            string exmEXT_AZ_BC_1_2ET_FC9 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 etiquetaas 
            string exmEXT_AZ_BC_1_2ET_FC5 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 etiquetaas 
            string exmEXT_AZ_BC_1_2ET_FC7 = "";  // refere-se ao exm EXT AZ BANCADA 1 - 2 etiquetaas 




            #endregion

            string exmEXT_AR_BC_1 = "";  // refere-se ao exm EXT AR BANCADA 1 - 5 etiquetaas 
            //string exmEXT_RO_BC_1_HIV = "";

            #endregion
            #region Par
            string exmPAR = "";
            string exmPAR_FI = "";
            #endregion
            #region BAC

            string exmBAC = "";
            string exmBAC_FV = "";
            string exmBAC_BK2 = "";
            string exmBAC_HA = "";
            string exmBAC_HN = "";
            string exmBAC_HP = "";
            #endregion
            #region  BIO
            //RPC
            string exmBIO_FR_RPC = "";

            string exmBIO_AM = "";
            string exmBIO_AM_24 = "";


            string exmBIO_LB = "";
            string exmBIO_24 = "";
            string exmBIO_FR = "";
            string exmBIO_SE = "";
            string exmBIO_OU = "";
            string exmBIO_RO = "";
            string exmBIO_G1_2ET = "";
            string exmBIO_G1_4ET = "";
            string exmBIO_CI = "";
            //string exmBIO_AM_24 = "";
            //string exmBIO_CID_GLICOSE = "";
            string exmBIO_CIP = "";
            string exmBIO_CID_0_120 = "";
            string exmBIO_CID_0_300 = "";
            
            string exmBIO_CI_0_120 = "";
            string exmBIO_CI_0_60 = "";
            string exmBIO_CI_0_180 = "";
            string exmBIO_SER_GS6 = "";
            #endregion

            string exmURO = "";
            string exmURO2 = "";
            string exmURO_CR4 = "";
            string exmIMU_Amarelo = "";
            string exmIMU_U12 = "";
            string exmIMU_U24 = "";
            string exmIMU_COU = "";
            string exmIMU_RO = "";

            string exmHOR = "";
            string exmHOR_T14_Bio = "";
            string exmHOR_PT3 = "";


            string exmHEM_Rox = "";
            string exmHEM_Azul = "";
            string exmHEM_DI = "";
            string exmHEM_BR = "";

            // Variaveis LU
            #region Variaveis LU

            // BAC
            string LU_Exm_Bac_BK = "";
            string LU_Exm_Bac_DI = "";
            // BIO
            string LU_Exm_Bio_AM = "";
            string LU_Exm_Bio_LB = "";
            string LU_Exm_Bio_SE = "";
            // HEM
            string LU_Exm_Hem_AZ = "";
            string LU_Exm_Hem_RO = "";
            string LU_Exm_Hem_DI = "";
            string LU_Exm_Hem_LB = "";
            // HOR
            string LU_Exm_Hor_AM = "";
            // IMU
            string LU_Exm_Imu_RO = "";
            string LU_Exm_Imu_AM = "";
            string LU_Exm_Imu_LB = "";
            // PAR
            string LU_Exm_Par_FR = "";
            // URI
            string LU_Exm_Uri_FR = "";

            // Variavel que pega exame não classificado

            string Nao_Classificado = "";

            #endregion


            try
            {
                OdbcConnection com = new OdbcConnection(conStr);//Define a conexão
                OdbcCommand commd = new OdbcCommand(strSql, com);//obtem acesso e executa o comando SQL
                com.Open();

                OdbcDataReader dr = commd.ExecuteReader();

                if (dr.Read())
                {
                    detiq.Requisicao = dr.GetString(0) + dr.GetString(1) + dr.GetString(2) + dr.GetString(3);

                    //OdbcConnection cn = new OdbcConnection();
                    OdbcCommand cmd = new OdbcCommand(strExm, com);
                    //co.Open();
                    OdbcDataReader dr1 = cmd.ExecuteReader();
                    while (dr1.Read())

                        #region Laço que seapara os exames

                        #region EXT

                        #region Bancada 1 exames externos Amarelo


                        if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "17O")
                        {
                            exmEXT_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT
                        }



                            //ADO

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ADO")
                        {
                            exmEXT_BC_1_ADO += dr1.GetString(0) + " ";
                        }
                        // "B2G"

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "B2G")
                        {
                            exmEXT_BC_1_B2G += dr1.GetString(0) + " ";
                        }

                        //"TOC" "TRA" "ESQ"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "TOC")
                        {
                            exmEXT_BC_1_TOC += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "TRA")
                        {
                            exmEXT_BC_1_TRA += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ESQ")//ESQ NA LISTA DA MONICA ESTÁ NA BANCADA 2 NO HOSPUB BANCADA 1
                        {
                            exmEXT_BC_1_ESQ += dr1.GetString(0) + " ";
                        }
                        // "RIB"  "IGF"  "TBG"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "RIB")
                        {
                            exmEXT_BC_1_RIB += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IGF")
                        {
                            exmEXT_BC_1_IGF += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "TBG")
                        {
                            exmEXT_BC_1_TBG += dr1.GetString(0) + " ";
                        }

                        //"PCC" "PEP" "PVR"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PCC")
                        {
                            exmEXT_BC_1_PCC += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PEP")
                        {
                            exmEXT_BC_1_PEP += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PVR")
                        {
                            exmEXT_BC_1_PVR += dr1.GetString(0) + " ";
                        }

                        // "MON"  "MIC" "PCB"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MON")
                        {
                            exmEXT_BC_1_MON += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MIC")
                        {
                            exmEXT_BC_1_MIC += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PCB")
                        {
                            exmEXT_BC_1_PCB += dr1.GetString(0) + " ";
                        }

                        //"IST"  "LIT"  "LYM"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IST")
                        {
                            exmEXT_BC_1_IST += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LIT")
                        {
                            exmEXT_BC_1_LIT += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LYM")
                        {
                            exmEXT_BC_1_LYM += dr1.GetString(0) + " ";
                        }

                        //"IF3"  "IEP"  "FIX"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IF3")
                        {
                            exmEXT_BC_1_HER += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IEP")
                        {
                            exmEXT_BC_1_HER += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FIX")
                        {
                            exmEXT_BC_1_HER += dr1.GetString(0) + " ";
                        }
                        //"HER"  "HOM"  "HTL"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HER")
                        {
                            exmEXT_BC_1_HER += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HOM")
                        {
                            exmEXT_BC_1_HOM += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HTL")
                        {
                            exmEXT_BC_1_HTL += dr1.GetString(0) + " ";
                        }
                        //"GAT"  "GEC"  "HPT"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "GAT")
                        {
                            exmEXT_BC_1_GAT += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "GEC")
                        {
                            exmEXT_BC_1_GEC += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HPT")
                        {
                            exmEXT_BC_1_HPT += dr1.GetString(0) + " ";
                        }

                        //"ENA"  "EQU"  "ERT"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ENA")
                        {
                            exmEXT_BC_1_ENA += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EQU")
                        {
                            exmEXT_BC_1_EQU += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ERT")
                        {
                            exmEXT_BC_1_ERT += dr1.GetString(0) + " ";
                        }
                        //"DHE" "DGX" "EPR"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "DHE")
                        {
                            exmEXT_BC_1_DHE += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "DGX")
                        {
                            exmEXT_BC_1_DGX += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EPR")
                        {
                            exmEXT_BC_1_EPR += dr1.GetString(0) + " ";
                        }
                        //"CVC" "CER" "COC"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CVC")
                        {
                            exmEXT_BC_1_CVC += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CER")
                        {
                            exmEXT_BC_1_CER += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "COC")
                        {
                            exmEXT_BC_1_COC += dr1.GetString(0) + " ";
                        }

                        // "CAC"  "CFF" 
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAC")
                        {
                            exmEXT_BC_1_CAC += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CFF")
                        {
                            exmEXT_BC_1_CFF += dr1.GetString(0) + " ";
                        }


                        //"BG2"  "C1E" "CAI"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "BG2")
                        {
                            exmEXT_BC_1_BG2 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "C1E")
                        {
                            exmEXT_BC_1_C1E += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAI")
                        {
                            exmEXT_BC_1_CAI += dr1.GetString(0) + " ";
                        }

                        //"ATR"  "ACN" "CCP"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ATR")
                        {
                            exmEXT_BC_1_ATR += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ACN")
                        {
                            exmEXT_BC_1_ACN += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CCP")
                        {
                            exmEXT_BC_1_CCP += dr1.GetString(0) + " ";
                        }
                        //"AIN"  "LKM"  "MUE"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AIN")
                        {
                            exmEXT_BC_1_AIN += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LKM")
                        {
                            exmEXT_BC_1_LKM += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MUE")
                        {
                            exmEXT_BC_1_MUE += dr1.GetString(0) + " ";
                        }

                        //"ASM"  "SSA"  "SSB"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ASM")
                        {
                            exmEXT_BC_1_ASM += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "SSA")
                        {
                            exmEXT_BC_1_SSA += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "SSB")
                        {
                            exmEXT_BC_1_SSB += dr1.GetString(0) + " ";
                        }
                        //"MUL" "RNP" "S70"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MUL")
                        {
                            exmEXT_BC_1_MUL += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "RNP")
                        {
                            exmEXT_BC_1_RNP += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "S70")
                        {
                            exmEXT_BC_1_S70 += dr1.GetString(0) + " ";
                        }

                            //"ILH" "JO1"  "MIT"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ILH")
                        {
                            exmEXT_BC_1_ILH += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "JO1")
                        {
                            exmEXT_BC_1_JO1 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MIT")
                        {
                            exmEXT_BC_1_MIT += dr1.GetString(0) + " ";
                        }

                            //"AEN" "GAD" "AGL"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AEN")
                        {
                            exmEXT_BC_1_AEN += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "GAD")
                        {
                            exmEXT_BC_1_GAD += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AGL")
                        {
                            exmEXT_BC_1_AGL += dr1.GetString(0) + " ";
                        }

                            // "AAT"  "DRO" "CAD" "PAR" "CEN"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AAT")
                        {
                            exmEXT_BC_1_AAT += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "DRO")
                        {
                            exmEXT_BC_1_DRO += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAD")
                        {
                            exmEXT_BC_1_CAD += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PAR")
                        {
                            exmEXT_BC_1_PAR += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CEN")
                        {
                            exmEXT_BC_1_CEN += dr1.GetString(0) + " ";
                        }

                        //LAS
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LAS")
                        {
                            exmEXT_BC_1_LAS += dr1.GetString(0) + " ";
                        }

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ADA")
                        {
                            exmEXT_BC_1_ADA += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "C17")
                        {
                            exmEXT_BC_1_C17 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "T20")
                        {
                            exmEXT_BC_1_T20 += dr1.GetString(0) + " ";
                        }

                        #endregion

                        #region bancada 2 amarelo
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ASP")
                        {
                            exmEXT_BC_2 += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        //"BLA"  "CLA"  "DEN"

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "BLA")
                        {
                            exmEXT_BC_2_BLA += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CLA")
                        {
                            exmEXT_BC_2_CLA += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "DEN")
                        {
                            exmEXT_BC_2_DEN += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        //"TIF"  "LEP"  "SVA"  "VRS"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "TIF")
                        {
                            exmEXT_BC_2_TIF += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LEP")
                        {
                            exmEXT_BC_2_LEP += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "SVA")
                        {
                            exmEXT_BC_2_SVA += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "VRS")
                        {
                            exmEXT_BC_2_VRS += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 2
                        }

                        #endregion

                        #region  bancada 3 amarelo



                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CIA")
                        {
                            exmEXT_BC_3 += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        //"FRT"  "GHH"  "SUA" "HTG"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FRT")
                        {
                            exmEXT_BC_3_FRT += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "GHH")
                        {
                            exmEXT_BC_3_GHH += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "SUA")
                        {
                            exmEXT_BC_3_SUA += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HTG")
                        {
                            exmEXT_BC_3_HTG += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        //"RUA"  "TOA"  "HBM" "CTX"

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "RUA")
                        {
                            exmEXT_BC_3_RUA += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "TOA")
                        {
                            exmEXT_BC_3_TOA += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HBM")
                        {
                            exmEXT_BC_3_HBM += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CTX")
                        {
                            exmEXT_BC_3_CTX += dr1.GetString(0) + " ";// refere-se ao exm EXT amarelo bancada 3
                        }

                        #endregion

                        #region ext bancada 1 MA


                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AMO")
                        {
                            exmEXT_MA_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT MA bancada 1
                        }
                        //"CSP"  "EIS"  "FRU" "GAL"

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CSP")
                        {
                            exmEXT_MA_BC_1_CSP += dr1.GetString(0) + " ";// refere-se ao exm EXT MA bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EIS")
                        {
                            exmEXT_MA_BC_1_EIS += dr1.GetString(0) + " ";// refere-se ao exm EXT MA bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FRU")
                        {
                            exmEXT_MA_BC_1_FRU += dr1.GetString(0) + " ";// refere-se ao exm EXT MA bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "GAL")
                        {
                            exmEXT_MA_BC_1_GAL += dr1.GetString(0) + " ";// refere-se ao exm EXT MA bancada 1
                        }

                        #endregion

                        #region  ext bancada 1 24


                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "5HI")
                        {
                            exmEXT_24_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        //CIU

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CIU")
                        {
                            exmEXT_24_BC_1_CIU += dr1.GetString(0) + " ";
                        }

                            //OXU

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "OXU")
                        {
                            exmEXT_24_BC_1_OXU += dr1.GetString(0) + " ";
                        }


                        // "IMU" "MET" "BJO"  "CTU"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IMU")
                        {
                            exmEXT_24_BC_1_IMU += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MET")
                        {
                            exmEXT_24_BC_1_MET += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "BJO")
                        {
                            exmEXT_24_BC_1_BJO += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CTU")
                        {
                            exmEXT_24_BC_1_CTU += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }

                        //"C0U"  "COP"  "EPU"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "C0U")
                        {
                            exmEXT_24_BC_1_C0U += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "COP")
                        {
                            exmEXT_24_BC_1_COP += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EPU")
                        {
                            exmEXT_24_BC_1_EPU += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }

                        //"VMA" "ADU" "CIT"

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "VMA")
                        {
                            exmEXT_24_BC_1_VMA += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ADU")
                        {
                            exmEXT_24_BC_1_ADU += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CIT")
                        {
                            exmEXT_24_BC_1_CIT += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }



                        #endregion

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CCU")
                        {
                            exmEXT_24_BC_3 += dr1.GetString(0) + " ";// refere-se ao exm EXT 24 bancada 1
                        }

                        #region ext bancada 1 br
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LUM")
                        {
                            exmEXT_BR_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT BR bancada 1
                        }
                        //"COB" "ZIN"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "COB")
                        {
                            exmEXT_BR_BC_1_COB += dr1.GetString(0) + " ";// refere-se ao exm EXT BR bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ZIN")
                        {
                            exmEXT_BR_BC_1_ZIN += dr1.GetString(0) + " ";// refere-se ao exm EXT BR bancada 1
                        }
                        #endregion

                        #region ext bancada 1 FR
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AAF")
                        {
                            exmEXT_FR_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 1
                        }
                        //"CFE" "EIU" "ION"  "MER" "TEP"

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CFE")
                        {
                            exmEXT_FR_BC_1_CFE += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EIU")
                        {
                            exmEXT_FR_BC_1_EIU += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ION")
                        {
                            exmEXT_FR_BC_1_ION += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "MER")
                        {
                            exmEXT_FR_BC_1_MER += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "TEP")
                        {
                            exmEXT_FR_BC_1_TEP += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 1
                        }



                        #endregion



                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CLL")
                        {
                            exmEXT_FR_BC_3 += dr1.GetString(0) + " ";// refere-se ao exm EXT FR bancada 3
                        }

                        #region ext bancada 1 LB
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ADL")
                        {
                            exmEXT_LB_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT LB bancada 1
                        }
                        // "EFL""IML"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EFL")
                        {
                            exmEXT_LB_BC_1_EFL += dr1.GetString(0) + " ";// refere-se ao exm EXT LB bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IML")
                        {
                            exmEXT_LB_BC_1_IML += dr1.GetString(0) + " ";// refere-se ao exm EXT LB bancada 1
                        }

                        #endregion


                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "VSC")
                        {
                            exmEXT_LB_BC_2 += dr1.GetString(0) + " ";// refere-se ao exm EXT LB bancada 2
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAO")
                        {
                            exmEXT_SE_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT SE bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CLS")
                        {
                            exmEXT_AS_BC_3 += dr1.GetString(0) + " ";// refere-se ao exm EXT AS bancada 3
                        }


                        #region ext bancada 1 VE
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "VAL")
                        {
                            exmEXT_VE_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }
                        // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAB")
                        {
                            exmEXT_VE_BC_1_CAB += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "H50")
                        {
                            exmEXT_VE_BC_1_H50 += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CRI")
                        {
                            exmEXT_VE_BC_1_CRI += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "VAN")
                        {
                            exmEXT_VE_BC_1_VAN += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FNI")
                        {
                            exmEXT_VE_BC_1_FNI += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FNB")
                        {
                            exmEXT_VE_BC_1_FNB += dr1.GetString(0) + " ";// refere-se ao exm EXT VE bancada 1
                        }

                        #endregion

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CRG")
                        {
                            exmEXT_VD_BC_3 += dr1.GetString(0) + " ";// refere-se ao exm EXT VD bancada 3
                        }

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "DXI")
                        {
                            exmEXT_CI_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT CI bancada 1
                        }

                            //"DXB"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "DXB")
                        {
                            exmEXT_CI_BC_1_DXB += dr1.GetString(0) + " ";// refere-se ao exm EXT CI bancada 1
                        }

                        #region ext Bancada 1 RO


                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAT")
                        {
                            exmEXT_RO_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        //CVB
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CVB")
                        {
                            exmEXT_RO_BC_1_CVB += dr1.GetString(0) + " ";
                        }
                        // "PRM" "CD8"  "XFR" "ACT"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PRM")
                        {
                            exmEXT_RO_BC_1_PRM += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CD8")
                        {
                            exmEXT_RO_BC_1_CD8 += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "XFR")
                        {
                            exmEXT_RO_BC_1_XFR += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ACT")
                        {
                            exmEXT_RO_BC_1_ACT += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }



                        //"G6P"  "B27"  "JAK"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "G6P")
                        {
                            exmEXT_RO_BC_1_G6P += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "B27")
                        {
                            exmEXT_RO_BC_1_B27 += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "JAK")
                        {
                            exmEXT_RO_BC_1_JAK += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        //"CIC" "EHE"  "FVP"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CIC")
                        {
                            exmEXT_RO_BC_1_CIC += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "EHE")
                        {
                            exmEXT_RO_BC_1_EHE += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FVP")
                        {
                            exmEXT_RO_BC_1_FVP += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 1
                        }



                        #endregion

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ARP")
                        {
                            exmEXT_RO_BC_3 += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 3
                        }
                        //"BNN"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "BNN")
                        {
                            exmEXT_RO_BC_3_BNN += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada 3
                        }

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CVH")
                        {
                            exmEXT_PPT_CVH += dr1.GetString(0) + " ";// refere-se ao exm EXT ROX CVH
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HEP")
                        {
                            exmEXT_RO_BC_1_2ET_HEP += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 2 ETIQUETAS HEP
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "IMO")
                        {
                            exmEXT_RO_BC_1_2ET_IMO += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 2 ETIQUETAS IMO
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "ISP")
                        {
                            exmEXT_RO_BC_1_2ET_ISP += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 2 ETIQUETAS ISP
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HEH")
                        {
                            exmEXT_RO_BC_1_2ET_HEH += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 2 ETIQUETAS HEH
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PHT")
                        {
                            exmEXT_RO_BC_1_2ET_PHT += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 2 ETIQUETAS PHT
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PHQ")
                        {
                            exmEXT_RO_BC_1_2ET_PHQ += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 3 ETIQUETAS PHQ
                        }
                        //TODO 
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "CAG")
                        {
                            exmEXT_RO_BC_1_2ET_CAG += dr1.GetString(0) + " ";// refere-se ao exm EXT RO bancada_1 3 ETIQUETAS PHQ
                        }



                        #region ext bancada 1 AZ
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "LUP")
                        {
                            exmEXT_AZ_BC_1_1ET += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 1_ETIQUETAS
                        }
                        //"AT3"  "RIT" "PCS"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AT3")
                        {
                            exmEXT_AZ_BC_1_1ET_AT3 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 1_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "RIT")
                        {
                            exmEXT_AZ_BC_1_1ET_RIT += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 1_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "PCS")
                        {
                            exmEXT_AZ_BC_1_1ET_PCS += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 1_ETIQUETAS
                        }

                        #endregion


                        #region ext bancada 1 AZ 2



                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FC2")
                        {
                            exmEXT_AZ_BC_1_2ET += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        //"F11" "F12"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "F11")
                        {
                            exmEXT_AZ_BC_1_2ET_F11 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "F12")
                        {
                            exmEXT_AZ_BC_1_2ET_F12 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        //"FC8" "FVW" "F10"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FC8")
                        {
                            exmEXT_AZ_BC_1_2ET_FC8 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FVW")
                        {
                            exmEXT_AZ_BC_1_2ET_FVW += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "F10")
                        {
                            exmEXT_AZ_BC_1_2ET_F10 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }

                             //"FC9" "FC5"  "FC7"
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FC9")
                        {
                            exmEXT_AZ_BC_1_2ET_FC9 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FC5")
                        {
                            exmEXT_AZ_BC_1_2ET_FC5 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }
                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "FC7")
                        {
                            exmEXT_AZ_BC_1_2ET_FC7 += dr1.GetString(0) + " ";// refere-se ao exm EXT AZ bancada_1 2_ETIQUETAS
                        }


                        #endregion

                        else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "AGR")
                        {
                            exmEXT_AR_BC_1 += dr1.GetString(0) + " ";// refere-se ao exm EXT AR bancada_1 5_ETIQUETAS
                        }
                        //else if (dr1.GetString(1) == "EXT" && dr1.GetString(0) == "HIV")
                        //{
                        //    exmEXT_RO_BC_1_HIV += dr1.GetString(0) + " ";// refere-se ao exm EXT ROXO HIV
                        //}

                        #endregion
                        #region PARASITOLOGIA (PAR)

                        else if (dr1.GetString(1) == "PAR" && dr1.GetString(0) == "IC2" || dr1.GetString(0) == "KK2"
                            || dr1.GetString(0) == "PP4" || dr1.GetString(0) == "LF4" || dr1.GetString(0) == "RO4"
                            || dr1.GetString(0) == "GO4" || dr1.GetString(0) == "PH2" || dr1.GetString(0) == "SO2")
                        {
                            exmPAR += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "PAR" && dr1.GetString(0) == "AS4")
                        {
                            exmPAR_FI += dr1.GetString(0) + " ";
                        }
                        #endregion
                        #region BAC

                        else if // Cor / tipo DI 
                            (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "ATB" || dr1.GetString(0) == "A02"
                            || dr1.GetString(0) == "A92" || dr1.GetString(0) == "A52" || dr1.GetString(0) == "AE2"
                            || dr1.GetString(0) == "A42" || dr1.GetString(0) == "A14" || dr1.GetString(0) == "A72"
                            || dr1.GetString(0) == "A32" || dr1.GetString(0) == "GA2" || dr1.GetString(0) == "DIV"
                            || dr1.GetString(0) == "DIN" || dr1.GetString(0) == "DIF" || dr1.GetString(0) == "BC2"
                            || dr1.GetString(0) == "DAF" || dr1.GetString(0) == "HA2" || dr1.GetString(0) == "SE1"
                            || dr1.GetString(0) == "GRA" || dr1.GetString(0) == "SE2" || dr1.GetString(0) == "SE3"
                            || dr1.GetString(0) == "CH2")
                        {
                            exmBAC += dr1.GetString(0) + " "; // Cor / tipo DI 
                        }
                        else if // Cor / tipo FV 
                            (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "URF"
                            || dr1.GetString(0) == "URI")
                        {
                            exmBAC_FV += dr1.GetString(0) + " "; // Cor / tipo FV
                        }

                        else if
                        (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "BK2")
                        {
                            exmBAC_BK2 += dr1.GetString(0) + " "; // Cor / tipo HA
                        }

                        else if // Cor / tipo HA 
                            (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "HC1")
                        {
                            exmBAC_HA += dr1.GetString(0) + " "; // Cor / tipo HA
                        }
                        else if // Cor / tipo HN 
                            (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "HN1")
                        {
                            exmBAC_HN += dr1.GetString(0) + " "; // Cor / tipo HN
                        }
                        else if // Cor / tipo HP
                            (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "HCP")
                        {
                            exmBAC_HP += dr1.GetString(0) + " "; // Cor / tipo HP
                        }

                        #endregion
                        #region BIO

                        //RPC
                       /* else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "RPC")
                        {
                            exmBIO_FR_RPC += dr1.GetString(0) + " ";
                        }*/


                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "AU6" || dr1.GetString(0) == "A24"
                            || dr1.GetString(0) == "AM4" || dr1.GetString(0) == "OT4" || dr1.GetString(0) == "BF6"
                            || dr1.GetString(0) == "CA4" || dr1.GetString(0) == "CO4" || dr1.GetString(0) == "CF6"
                            || dr1.GetString(0) == "CT4" || dr1.GetString(0) == "CK4" || dr1.GetString(0) == "MB4"
                            || dr1.GetString(0) == "DL6" || dr1.GetString(0) == "AP4" || dr1.GetString(0) == "FO4"
                            || dr1.GetString(0) == "GG4" || dr1.GetString(0) == "HD2" || dr1.GetString(0) == "LP4"
                            || dr1.GetString(0) == "MG4" || dr1.GetString(0) == "PT2" || dr1.GetString(0) == "PC4"
                            || dr1.GetString(0) == "AG6" || dr1.GetString(0) == "SP4" || dr1.GetString(0) == "TR4"
                            || dr1.GetString(0) == "UR4" || dr1.GetString(0) == "FE4" || dr1.GetString(0) == "MB6"
                            || dr1.GetString(0) == "CL4" || dr1.GetString(0) == "LP5" || dr1.GetString(0) == "GL4"
                            || dr1.GetString(0) == "DC2")
                        {
                            exmBIO_AM += dr1.GetString(0) + " ";

                            if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "DC2")
                            {
                                exmBIO_AM_24 += dr1.GetString(0) + " ";

                            }
                        }


                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "LL2" || dr1.GetString(0) == "AR2"
                            || dr1.GetString(0) == "BL2" || dr1.GetString(0) == "ML2" || dr1.GetString(0) == "LC2"
                            || dr1.GetString(0) == "LG2" || dr1.GetString(0) == "DA2" || dr1.GetString(0) == "DP2"
                            || dr1.GetString(0) == "PD2" || dr1.GetString(0) == "LT2")
                        {
                            exmBIO_LB += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "UC2" || dr1.GetString(0) == "UT2"
                        || dr1.GetString(0) == "UF2" || dr1.GetString(0) == "G24" || dr1.GetString(0) == "UP2"
                        || dr1.GetString(0) == "P24" || dr1.GetString(0) == "SU2" || dr1.GetString(0) == "UH2"
                        || dr1.GetString(0) == "UU2")
                        {
                            exmBIO_24 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "NI2")
                        {
                            exmBIO_FR += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "GS4" || dr1.GetString(0) == "PL2")
                        {
                            exmBIO_SE += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "OUT")
                        {
                            exmBIO_OU += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "2HG" || dr1.GetString(0) == "3HG")
                        {
                            exmBIO_RO += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "2PG")// pra fazer
                        {
                            exmBIO_G1_2ET += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "4PG")
                        {
                            exmBIO_G1_4ET += dr1.GetString(0) + " ";
                        }

                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "LTT")
                        {
                            exmBIO_CI += dr1.GetString(0) + " ";
                        }
                        //else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "DC2")
                        //{
                        //    exmBIO_AM_24 += dr1.GetString(0) + " ";
                        //}
                        //else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "GL4")
                        //{
                        //    exmBIO_CID_GLICOSE += dr1.GetString(0) + " ";
                        //}
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "GP4")
                        {
                            exmBIO_CIP += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "C22")
                        {
                            exmBIO_CID_0_120 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "CP2")
                        {
                            exmBIO_CID_0_300 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "SG2")
                        {
                            exmBIO_CI_0_120 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "SC2")
                        {
                            exmBIO_CI_0_60 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "C32")
                        {
                            exmBIO_CI_0_180 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "GS6")
                        {
                            exmBIO_SER_GS6 += dr1.GetString(0) + " ";
                        }

                        #endregion
                        #region URO

                        else if (dr1.GetString(0) == "DE4" || dr1.GetString(0) == "GR2" || dr1.GetString(0) == "U12"|| dr1.GetString(0) == "RPC" || dr1.GetString(0) == "PE2" || dr1.GetString(0) == "CI2" || dr1.GetString(0) == "ON2" || dr1.GetString(0) == "PC2" || dr1.GetString(0) == "MII")
                        {
                             exmURO += dr1.GetString(0) ;
                            var selectedArr = new List<String> { "U12", "CI2", "ON2", "PC2", "PE2","MII", "RPC" ,"DE4","GR2" };
                            var unorderArr = exmURO.Split(' ');
         
                            var orderedArr = unorderArr.OrderBy(o => selectedArr.IndexOf(o));
                            exmURO = "";
                            foreach (string  items in orderedArr)
                            {
                                
                                exmURO += items + " ";  
                            }
                        }
                        else if (dr1.GetString(1) == "URO" && dr1.GetString(0) == "EM2")
                        {
                            exmURO2 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "URO" && dr1.GetString(0) == "CR4")
                        {
                            exmURO_CR4 += dr1.GetString(0) + " ";
                        }
                        
                        #endregion
                        #region IMU
                        else if
                              (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "VDR" || dr1.GetString(0) == "CHA" || dr1.GetString(0) == "TO5"
                            || dr1.GetString(0) == "RU5" || dr1.GetString(0) == "CM5" || dr1.GetString(0) == "VA2" || dr1.GetString(0) == "VB2"
                            || dr1.GetString(0) == "VC2" || dr1.GetString(0) == "HI7" || dr1.GetString(0) == "C33" || dr1.GetString(0) == "PLI"
                            || dr1.GetString(0) == "C44" || dr1.GetString(0) == "1AG" || dr1.GetString(0) == "ASL" || dr1.GetString(0) == "TFR"
                            || dr1.GetString(0) == "IG2" || dr1.GetString(0) == "IA2" || dr1.GetString(0) == "IM2" || dr1.GetString(0) == "VDL"
                            || dr1.GetString(0) == "FAN" || dr1.GetString(0) == "ADN" || dr1.GetString(0) == "FR1" || dr1.GetString(0) == "PS2"
                            || dr1.GetString(0) == "ACE" || dr1.GetString(0) == "C25" || dr1.GetString(0) == "C15" || dr1.GetString(0) == "C19"
                            || dr1.GetString(0) == "AF4" || dr1.GetString(0) == "MCO" || dr1.GetString(0) == "ANE" || dr1.GetString(0) == "HI8"
                            || dr1.GetString(0) == "AGE" || dr1.GetString(0) == "FTA")
                        {

                            exmIMU_Amarelo += dr1.GetString(0) + " ";

                        }
                        else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "MI1")
                        {
                            exmIMU_U12 += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "MI2")
                        {
                            exmIMU_U24 += dr1.GetString(0) + " ";
                        }
                       /* else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "MII")
                        {
                            exmIMU_COU += dr1.GetString(0) + " ";


                        }*/
                        else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "WB2")
                        {
                            exmIMU_RO += dr1.GetString(0) + " ";


                        }


                        #endregion
                        #region HOR
                        // PT3 //  agora é PT5 Ele vai sair em 2 etiquetas 1 junto aos demais exames de HOR e 1 sozinho como exame externo Amarelo
                        else if (dr1.GetString(1) == "HOR" && dr1.GetString(0) == "PT6")
                        {
                            exmHOR_PT3 = dr1.GetString(0);
                            exmHOR += "PT6 ";
                        }


                        else if (dr1.GetString(1) == "HOR" && ( dr1.GetString(0) == "AFL" || dr1.GetString(0) == "VI1" 
                            || dr1.GetString(0) == "ATP" || dr1.GetString(0) == "HBG" || dr1.GetString(0) == "GC1" || dr1.GetString(0) == "COT"
                            || dr1.GetString(0) == "CON" || dr1.GetString(0) == "COO" || dr1.GetString(0) == "CO8" || dr1.GetString(0) == "CTS"
                            || dr1.GetString(0) == "DEA" || dr1.GetString(0) == "FRR" || dr1.GetString(0) == "TT4" || dr1.GetString(0) == "TT3"
                            || dr1.GetString(0) == "T06" || dr1.GetString(0) == "ES4" || dr1.GetString(0) == "BBG" || dr1.GetString(0) == "FS3"
                            || dr1.GetString(0) == "LH3" || dr1.GetString(0) == "IN3" || dr1.GetString(0) == "T09" || dr1.GetString(0) == "PG3"
                            || dr1.GetString(0) == "PRH" || dr1.GetString(0) == "PRH" || dr1.GetString(0) == "T08" || dr1.GetString(0) == "T13"
                            || dr1.GetString(0) == "T10" || dr1.GetString(0) == "T11" || dr1.GetString(0) == "T12" || dr1.GetString(0) == "T04"
                            || dr1.GetString(0) == "T15" || dr1.GetString(0) == "T05" || dr1.GetString(0) == "T03" || dr1.GetString(0) == "T01"
                            || dr1.GetString(0) == "T16" || dr1.GetString(0) == "T02" || dr1.GetString(0) == "TBC" || dr1.GetString(0) == "TLC"
                            || dr1.GetString(0) == "TE5" || dr1.GetString(0) == "TL4" || dr1.GetString(0) == "HST" || dr1.GetString(0) == "12B"))// || dr1.GetString(0) == "PT3" 
                        {

                            exmHOR += dr1.GetString(0) + " ";
                        }


                        else if (dr1.GetString(1) == "HOR" && dr1.GetString(0) == "T14")
                        {
                            exmHOR_T14_Bio += dr1.GetString(0) + " ";
                        }

                        #endregion
                        #region HEM
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "HM2" || dr1.GetString(0) == "HH2"
                              || dr1.GetString(0) == "PQ2" || dr1.GetString(0) == "PF2"
                             || dr1.GetString(0) == "RT2" || dr1.GetString(0) == "VH2" || dr1.GetString(0) == "VHS")
                        {
                            exmHEM_Rox += dr1.GetString(0) + " "; // continuar daqui TODO: 23/03/2015
                        }
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "DI2" || dr1.GetString(0) == "DD4"
                            || dr1.GetString(0) == "FI2" || dr1.GetString(0) == "FB2" || dr1.GetString(0) == "TA4"
                            || dr1.GetString(0) == "TP6" || dr1.GetString(0) == "TA2" || dr1.GetString(0) == "T2H"
                            || dr1.GetString(0) == "T41" || dr1.GetString(0) == "T50" || dr1.GetString(0) == "PLC")
                        {
                            exmHEM_Azul += dr1.GetString(0) + " "; //EXAME DD2 mudou para DD4
                        }
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "PA2" 
                             || dr1.GetString(0) == "EOS" )
                        {
                            exmHEM_DI += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "LE2")
                        {
                            exmHEM_BR += dr1.GetString(0) + " ";
                        }
                        #endregion //

                        #region Laço que seapara os exames LU

                        // BAC
                        else if (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "BK1") // teste Junior 03/08/2015
                        {
                            LU_Exm_Bac_BK += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BAC" && dr1.GetString(0) == "GA1" || dr1.GetString(0) == "CH1")
                        {
                            LU_Exm_Bac_DI += dr1.GetString(0) + " ";
                        }
                        // BIO
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "A23" || dr1.GetString(0) == "AM3"
                            || dr1.GetString(0) == "OT3" || dr1.GetString(0) == "BF5" || dr1.GetString(0) == "CA3"
                            || dr1.GetString(0) == "CE1" || dr1.GetString(0) == "CL3" || dr1.GetString(0) == "CT3"
                            || dr1.GetString(0) == "CK3" || dr1.GetString(0) == "MB3" || dr1.GetString(0) == "DL5"
                            || dr1.GetString(0) == "GL3" || dr1.GetString(0) == "MG3" || dr1.GetString(0) == "PC5"
                            || dr1.GetString(0) == "SP3" || dr1.GetString(0) == "TN1" || dr1.GetString(0) == "UR3"
                                || dr1.GetString(0) == "MB5")
                        {
                            LU_Exm_Bio_AM += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "LQ1" || dr1.GetString(0) == "PN1"
                            || dr1.GetString(0) == "GI1" || dr1.GetString(0) == "UA1")
                        {
                            LU_Exm_Bio_LB += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "BIO" && dr1.GetString(0) == "GS5")
                        {
                            LU_Exm_Bio_SE += dr1.GetString(0) + " ";
                        }
                        //HEM
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "DI1" || dr1.GetString(0) == "DD3"
                            || dr1.GetString(0) == "FB1" || dr1.GetString(0) == "TA3" || dr1.GetString(0) == "TP1"
                            || dr1.GetString(0) == "TA1" || dr1.GetString(0) == "TP3" || dr1.GetString(0) == "PCI")
                        {
                            LU_Exm_Hem_AZ += dr1.GetString(0) + " "; // EXAME DD1 mudou para DD3
                        }
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "HH1" || dr1.GetString(0) == "HM1"
                            || dr1.GetString(0) == "HM3" || dr1.GetString(0) == "PQ1" || dr1.GetString(0) == "RT1")
                        {
                            LU_Exm_Hem_RO += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "PA1")
                        {
                            LU_Exm_Hem_DI += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "HEM" && dr1.GetString(0) == "LI1")
                        {
                            LU_Exm_Hem_LB += dr1.GetString(0) + " ";
                        }
                        // HOR
                        else if (dr1.GetString(1) == "HOR" && dr1.GetString(0) == "BH1")
                        {
                            LU_Exm_Hor_AM += dr1.GetString(0) + " ";
                        }
                        // IMU
                        else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "HV1")
                        {
                            LU_Exm_Imu_RO += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "PC3")
                        {
                            LU_Exm_Imu_AM += dr1.GetString(0) + " ";
                        }
                        else if (dr1.GetString(1) == "IMU" && dr1.GetString(0) == "VD1")
                        {
                            LU_Exm_Imu_LB += dr1.GetString(0) + " ";
                        }
                        // PAR
                        else if (dr1.GetString(1) == "PAR" && dr1.GetString(0) == "ROT")
                        {
                            LU_Exm_Par_FR += dr1.GetString(0) + " ";
                        }
                        // URI
                        else if (dr1.GetString(1) == "URO" && dr1.GetString(0) == "GR1" || dr1.GetString(0) == "UI7" || dr1.GetString(0) == "U11" || dr1.GetString(0) == "U10")
                        {
                            LU_Exm_Uri_FR += dr1.GetString(0) + " ";
                        }

                        // pega exame não classificado
                        else if (dr1.GetString(1) != "" && dr1.GetString(0) != "")
                        {
                            Nao_Classificado += dr1.GetString(1) + "-" + dr1.GetString(0) + " ";
                        }

                        #endregion

                        #endregion


                    // 29/07/2016  pra fazer a etiqueta controle
                    detiq.ControleEtiq1 = "a";
                    detiq.ControleEtiq21 = "a";
                    detiq.ComprovantePaciente1 = "a";

                    detiq.CodExamePAR = exmPAR; // Amarzena os tipos de exames PAR   //Jr
                    detiq.CodExamePAR_FI = exmPAR_FI;

                    #region EXT

                    #region Bancada 1

                    detiq.CodExame_EXT_AM_BC_1 = exmEXT_BC_1; //Pega os exames do tipo EXT


                    detiq.CodExame_EXT_AM_BC_1_ADA = exmEXT_BC_1_ADA; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_C17 = exmEXT_BC_1_C17; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_T20 = exmEXT_BC_1_T20; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_LAS = exmEXT_BC_1_LAS; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_ADO = exmEXT_BC_1_ADO; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_B2G = exmEXT_BC_1_B2G;
                    // "AAT"  "DRO" "CAD" "PAR" "CEN"
                    detiq.CodExame_EXT_AM_BC_1_AAT = exmEXT_BC_1_AAT; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_DRO = exmEXT_BC_1_DRO; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CAD = exmEXT_BC_1_CAD; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CAD_ET_2 = exmEXT_BC_1_CAD; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_PAR = exmEXT_BC_1_PAR; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CEN = exmEXT_BC_1_CEN; //Pega os exames do tipo EXT
                    //"AEN" "GAD" "AGL"
                    detiq.CodExame_EXT_AM_BC_1_AEN = exmEXT_BC_1_AEN; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_GAD = exmEXT_BC_1_GAD; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_AGL = exmEXT_BC_1_AGL; //Pega os exames do tipo EXT
                    //"ILH" "JO1"  "MIT"
                    detiq.CodExame_EXT_AM_BC_1_ILH = exmEXT_BC_1_ILH; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_JO1 = exmEXT_BC_1_JO1; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_MIT = exmEXT_BC_1_MIT; //Pega os exames do tipo EXT
                    //"MUL" "RNP" "S70"
                    detiq.CodExame_EXT_AM_BC_1_MUL = exmEXT_BC_1_MUL; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_RNP = exmEXT_BC_1_RNP; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_S70 = exmEXT_BC_1_S70; //Pega os exames do tipo EXT
                    //"ASM"  "SSA"  "SSB"
                    detiq.CodExame_EXT_AM_BC_1_ASM = exmEXT_BC_1_ASM; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_SSA = exmEXT_BC_1_SSA; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_SSB = exmEXT_BC_1_SSB; //Pega os exames do tipo EXT
                    //"AIN"  "LKM"  "MUE"
                    detiq.CodExame_EXT_AM_BC_1_AIN = exmEXT_BC_1_AIN; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_LKM = exmEXT_BC_1_LKM; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_MUE = exmEXT_BC_1_MUE; //Pega os exames do tipo EXT
                    //"ATR"  "ACN" "CCP"
                    detiq.CodExame_EXT_AM_BC_1_ATR = exmEXT_BC_1_ATR; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_ACN = exmEXT_BC_1_ACN; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CCP = exmEXT_BC_1_CCP; //Pega os exames do tipo EXT
                    //"BG2"  "C1E" "CAI"
                    detiq.CodExame_EXT_AM_BC_1_BG2 = exmEXT_BC_1_BG2; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_C1E = exmEXT_BC_1_C1E; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CAI = exmEXT_BC_1_CAI; //Pega os exames do tipo EXT
                    // "CAC"  "CFF"  
                    detiq.CodExame_EXT_AM_BC_1_CAC = exmEXT_BC_1_CAC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CFF = exmEXT_BC_1_CFF; //Pega os exames do tipo EXT
                    //"CVC" "CER" "COC"
                    detiq.CodExame_EXT_AM_BC_1_CVC = exmEXT_BC_1_CVC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CVC_2ET = exmEXT_BC_1_CVC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_CER = exmEXT_BC_1_CER; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_COC = exmEXT_BC_1_COC; //Pega os exames do tipo EXT
                    //"DHE" "DGX" "EPR"
                    detiq.CodExame_EXT_AM_BC_1_DHE = exmEXT_BC_1_DHE; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_DGX = exmEXT_BC_1_DGX; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_EPR = exmEXT_BC_1_EPR; //Pega os exames do tipo EXT
                    //"ENA"  "EQU"  "ERT"
                    detiq.CodExame_EXT_AM_BC_1_ENA = exmEXT_BC_1_ENA; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_EQU = exmEXT_BC_1_EQU; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_ERT = exmEXT_BC_1_ERT; //Pega os exames do tipo EXT
                    //"GAT"  "GEC"  "HPT"
                    detiq.CodExame_EXT_AM_BC_1_GAT = exmEXT_BC_1_GAT; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_GEC = exmEXT_BC_1_GEC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_GEC_ET_2 = exmEXT_BC_1_GEC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_HPT = exmEXT_BC_1_HPT; //Pega os exames do tipo EXT
                    //"HER"  "HOM"  "HTL"
                    detiq.CodExame_EXT_AM_BC_1_HER = exmEXT_BC_1_HER; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_HOM = exmEXT_BC_1_HOM; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_HTL = exmEXT_BC_1_HTL; //Pega os exames do tipo EXT
                    //"IF3"  "IEP"  "FIX"
                    detiq.CodExame_EXT_AM_BC_1_IF3 = exmEXT_BC_1_IF3; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_IEP = exmEXT_BC_1_IEP; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_FIX = exmEXT_BC_1_FIX; //Pega os exames do tipo EXT
                    //"IST"  "LIT"  "LYM"
                    detiq.CodExame_EXT_AM_BC_1_IST = exmEXT_BC_1_IST; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_LIT = exmEXT_BC_1_LIT; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_LYM = exmEXT_BC_1_LYM; //Pega os exames do tipo EXT
                    // "MON"  "MIC" "PCB"
                    detiq.CodExame_EXT_AM_BC_1_MON = exmEXT_BC_1_MON; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_MIC = exmEXT_BC_1_MIC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_RO_BC_1_PCB = exmEXT_BC_1_PCB; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_RO_BC_1_PCB_ET_2 = exmEXT_BC_1_PCB; //Pega os exames do tipo EXT
                    //"PCC" "PEP" "PVR"
                    detiq.CodExame_EXT_AM_BC_1_PCC = exmEXT_BC_1_PCC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_PCC_ET_2 = exmEXT_BC_1_PCC; //Pega os exames do tipo EXT                    
                    detiq.CodExame_EXT_AM_BC_1_PEP = exmEXT_BC_1_PEP; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_PVR = exmEXT_BC_1_PVR; //Pega os exames do tipo EXT
                    // "RIB"  "IGF"  "TBG"
                    detiq.CodExame_EXT_AM_BC_1_RIB = exmEXT_BC_1_RIB; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_IGF = exmEXT_BC_1_IGF; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_TBG = exmEXT_BC_1_TBG; //Pega os exames do tipo EXT
                    //"TOC" "TRA" "ESQ"
                    detiq.CodExame_EXT_AM_BC_1_TOC = exmEXT_BC_1_TOC; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_TRA = exmEXT_BC_1_TRA; //Pega os exames do tipo EXT
                    detiq.CodExame_EXT_AM_BC_1_ESQ = exmEXT_BC_1_ESQ; //Pega os exames do tipo EXT

                    #endregion

                    #region Bancada 2

                    detiq.CodExame_EXT_AM_BC_2 = exmEXT_BC_2; //Pega os exames do tipo EXT AMARELO BANCADA 2

                    //"TIF"  "LEP"  "SVA"  "VRS"
                    detiq.CodExame_EXT_AM_BC_2_TIF = exmEXT_BC_2_TIF; //Pega os exames do tipo EXT AMARELO BANCADA 2
                    detiq.CodExame_EXT_AM_BC_2_LEP = exmEXT_BC_2_LEP; //Pega os exames do tipo EXT AMARELO BANCADA 2
                    detiq.CodExame_EXT_AM_BC_2_SVA = exmEXT_BC_2_SVA; //Pega os exames do tipo EXT AMARELO BANCADA 2
                    detiq.CodExame_EXT_AM_BC_2_VRS = exmEXT_BC_2_VRS; //Pega os exames do tipo EXT AMARELO BANCADA 2

                    //"BLA"  "CLA"  "DEN"
                    detiq.CodExame_EXT_AM_BC_2_BLA = exmEXT_BC_2_BLA; //Pega os exames do tipo EXT AMARELO BANCADA 2
                    detiq.CodExame_EXT_AM_BC_2_CLA = exmEXT_BC_2_CLA; //Pega os exames do tipo EXT AMARELO BANCADA 2
                    detiq.CodExame_EXT_AM_BC_2_DEN = exmEXT_BC_2_DEN; //Pega os exames do tipo EXT AMARELO BANCADA 2

                    #endregion

                    #region bancada 3 amarelo


                    detiq.CodExame_EXT_AM_BC_3 = exmEXT_BC_3; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    //"RUA"  "TOA"  "HBM" "CTX"
                    detiq.CodExame_EXT_AM_BC_3_RUA = exmEXT_BC_3_RUA; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    detiq.CodExame_EXT_AM_BC_3_TOA = exmEXT_BC_3_TOA; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    detiq.CodExame_EXT_AM_BC_3_HBM = exmEXT_BC_3_HBM; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    detiq.CodExame_EXT_AM_BC_3_CTX = exmEXT_BC_3_CTX; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    //"FRT"  "GHH"  "SUA" "HTG"
                    detiq.CodExame_EXT_AM_BC_3_FRT = exmEXT_BC_3_FRT; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    detiq.CodExame_EXT_AM_BC_3_GHH = exmEXT_BC_3_GHH; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    detiq.CodExame_EXT_AM_BC_3_SUA = exmEXT_BC_3_SUA; //Pega os exames do tipo EXT AMARELO BANCADA 3
                    detiq.CodExame_EXT_AM_BC_3_HTG = exmEXT_BC_3_HTG; //Pega os exames do tipo EXT AMARELO BANCADA 3


                    #endregion

                    #region ext bancada 1 MA
                    detiq.CodExame_EXT_MA_BC_1 = exmEXT_MA_BC_1; //Pega os exames do tipo EXT MA BANCADA 1

                    //"CSP"  "EIS"  "FRU" "GAL"
                    detiq.CodExame_EXT_MA_BC_1_CSP = exmEXT_MA_BC_1_CSP; //Pega os exames do tipo EXT MA BANCADA 1
                    detiq.CodExame_EXT_MA_BC_1_EIS = exmEXT_MA_BC_1_EIS; //Pega os exames do tipo EXT MA BANCADA 1
                    detiq.CodExame_EXT_MA_BC_1_FRU = exmEXT_MA_BC_1_FRU; //Pega os exames do tipo EXT MA BANCADA 1
                    detiq.CodExame_EXT_MA_BC_1_GAL = exmEXT_MA_BC_1_GAL; //Pega os exames do tipo EXT MA BANCADA 1

                    #endregion

                    #region ext bancada 1 24


                    detiq.CodExame_EXT_24_BC_1 = exmEXT_24_BC_1; //Pega os exames do tipo EXT 24 BANCADA 1

                    //CIU
                    detiq.CodExame_EXT_24_BC_1_CIU = exmEXT_24_BC_1_CIU;
                    //OXU
                    detiq.CodExame_EXT_24_BC_1_OXU = exmEXT_24_BC_1_OXU; //Pega os exames do tipo EXT

                    // "IMU" "MET" "BJO"  "CTU"
                    detiq.CodExame_EXT_24_BC_1_IMU = exmEXT_24_BC_1_IMU; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_MET = exmEXT_24_BC_1_MET; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_BJO = exmEXT_24_BC_1_BJO; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_CTU = exmEXT_24_BC_1_CTU; //Pega os exames do tipo EXT 24 BANCADA 1

                    //"C0U"  "COP"  "EPU"
                    detiq.CodExame_EXT_24_BC_1_C0U = exmEXT_24_BC_1_C0U; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_COP = exmEXT_24_BC_1_COP; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_EPU = exmEXT_24_BC_1_EPU; //Pega os exames do tipo EXT 24 BANCADA 1

                    //"VMA" "ADU" "CIT"
                    detiq.CodExame_EXT_24_BC_1_VMA = exmEXT_24_BC_1_VMA; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_ADU = exmEXT_24_BC_1_ADU; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_1_CIT = exmEXT_24_BC_1_CIT; //Pega os exames do tipo EXT 24 BANCADA 1
                    detiq.CodExame_EXT_24_BC_3 = exmEXT_24_BC_3; //Pega os exames do tipo EXT 24 BANCADA 3


                    #endregion


                    #region ext bancada 1 br
                    detiq.CodExame_EXT_BR_BC_1 = exmEXT_BR_BC_1; //Pega os exames do tipo EXT BR BANCADA 1

                    //"COB" "ZIN"
                    detiq.CodExame_EXT_BR_BC_1_COB = exmEXT_BR_BC_1_COB; //Pega os exames do tipo EXT BR BANCADA 1
                    detiq.CodExame_EXT_BR_BC_1_ZIN = exmEXT_BR_BC_1_ZIN; //Pega os exames do tipo EXT BR BANCADA 1


                    #endregion

                    #region ext bancada 1 FR
                    detiq.CodExame_EXT_FR_BC_1 = exmEXT_FR_BC_1; //Pega os exames do tipo EXT FR BANCADA 1

                    //"CFE" "EIU" "ION"  "MER" "TEP"
                    detiq.CodExame_EXT_FR_BC_1_CFE = exmEXT_FR_BC_1_CFE; //Pega os exames do tipo EXT FR BANCADA 1
                    detiq.CodExame_EXT_FR_BC_1_EIU = exmEXT_FR_BC_1_EIU; //Pega os exames do tipo EXT FR BANCADA 1
                    detiq.CodExame_EXT_FR_BC_1_ION = exmEXT_FR_BC_1_ION; //Pega os exames do tipo EXT FR BANCADA 1
                    detiq.CodExame_EXT_FR_BC_1_MER = exmEXT_FR_BC_1_MER; //Pega os exames do tipo EXT FR BANCADA 1
                    detiq.CodExame_EXT_FR_BC_1_TEP = exmEXT_FR_BC_1_TEP; //Pega os exames do tipo EXT FR BANCADA 1


                    #endregion



                    detiq.CodExame_EXT_FR_BC_3 = exmEXT_FR_BC_3; //Pega os exames do tipo EXT FR BANCADA 3


                    #region ext bancada 1 LB
                    detiq.CodExame_EXT_LB_BC_1 = exmEXT_LB_BC_1;// teste 04/08/2015


                    // "EFL""IML"
                    detiq.CodExame_EXT_LB_BC_1_EFL = exmEXT_LB_BC_1_EFL;// teste 04/08/2015
                    detiq.CodExame_EXT_LB_BC_1_IML = exmEXT_LB_BC_1_IML;// teste 04/08/2015


                    #endregion
                    detiq.CodExame_EXT_LB_BC_2 = exmEXT_LB_BC_2;// teste 04/08/2015 as 15:20

                    detiq.CodExame_EXT_SE_BC_1 = exmEXT_SE_BC_1; //Pega os exames do tipo EXT SE BANCADA 1
                    detiq.CodExame_EXT_AS_BC_3 = exmEXT_AS_BC_3; //Pega os exames do tipo EXT AS BANCADA 3

                    #region ext bancada 1 VE
                    detiq.CodExame_EXT_VE_BC_1 = exmEXT_VE_BC_1; //Pega os exames do tipo EXT VE BANCADA 1

                    // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"
                    detiq.CodExame_EXT_VE_BC_1_CAB = exmEXT_VE_BC_1_CAB; //Pega os exames do tipo EXT VE BANCADA 1
                    detiq.CodExame_EXT_VE_BC_1_H50 = exmEXT_VE_BC_1_H50; //Pega os exames do tipo EXT VE BANCADA 1
                    detiq.CodExame_EXT_VE_BC_1_CRI = exmEXT_VE_BC_1_CRI; //Pega os exames do tipo EXT VE BANCADA 1
                    detiq.CodExame_EXT_VE_BC_1_VAN = exmEXT_VE_BC_1_VAN; //Pega os exames do tipo EXT VE BANCADA 1
                    detiq.CodExame_EXT_VE_BC_1_FNI = exmEXT_VE_BC_1_FNI; //Pega os exames do tipo EXT VE BANCADA 1
                    detiq.CodExame_EXT_VE_BC_1_FNB = exmEXT_VE_BC_1_FNB; //Pega os exames do tipo EXT VE BANCADA 1

                    #endregion




                    detiq.CodExame_EXT_VD_BC_3 = exmEXT_VD_BC_3; //Pega os exames do tipo EXT VD BANCADA 3

                    //DXI
                    detiq.CodExame_EXT_CI_BC_1 = exmEXT_CI_BC_1; //Pega os exames do tipo EXT CI BANCADA 1
                    detiq.CodExame_EXT_CI_BC_1_2ET = exmEXT_CI_BC_1; //Pega os exames do tipo EXT CI BANCADA 1
                    //"DXB"
                    detiq.CodExame_EXT_CI_BC_1_DXB = exmEXT_CI_BC_1_DXB; //Pega os exames do tipo EXT CI BANCADA 1



                    #region ext bancada 1 RO
                    detiq.CodExame_EXT_RO_BC_1 = exmEXT_RO_BC_1; //Pega os exames do tipo EXT RO BANCADA 1

                    detiq.CodExame_EXT_RO_BC_1_CVB = exmEXT_RO_BC_1_CVB; //Pega os exames do tipo EXT tudo roxo
                    detiq.CodExame_EXT_RO_BC_1_CVB_2ET = exmEXT_RO_BC_1_CVB; //Pega os exames do tipo EXT tudo roxo

                    // "PRM" "CD8"  "XFR" "ACT"
                    detiq.CodExame_EXT_RO_BC_1_PRM = exmEXT_RO_BC_1_PRM; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_CD8 = exmEXT_RO_BC_1_CD8; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_XFR = exmEXT_RO_BC_1_XFR; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_ACT = exmEXT_RO_BC_1_ACT; //Pega os exames do tipo EXT RO BANCADA 1



                    //"G6P"  "B27"  "JAK"
                    detiq.CodExame_EXT_RO_BC_1_G6P = exmEXT_RO_BC_1_G6P; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_G6P_2ET = exmEXT_RO_BC_1_G6P; //Pega os exames do tipo EXT RO BANCADA 1

                    detiq.CodExame_EXT_RO_BC_1_B27 = exmEXT_RO_BC_1_B27; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_JAK = exmEXT_RO_BC_1_JAK; //Pega os exames do tipo EXT RO BANCADA 1

                    //"CIC" "EHE"  "FVP"
                    detiq.CodExame_EXT_RO_BC_1_CIC = exmEXT_RO_BC_1_CIC; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_EHE = exmEXT_RO_BC_1_EHE; //Pega os exames do tipo EXT RO BANCADA 1
                    detiq.CodExame_EXT_RO_BC_1_FVP = exmEXT_RO_BC_1_FVP; //Pega os exames do tipo EXT RO BANCADA 1

                    #endregion



                    detiq.CodExame_EXT_RO_BC_3 = exmEXT_RO_BC_3; //Pega os exames do tipo EXT RO BANCADA 3
                    //"BNN"
                    detiq.CodExame_EXT_RO_BC_3_BNN = exmEXT_RO_BC_3_BNN; //Pega os exames do tipo EXT RO BANCADA 3




                    detiq.CodExame_EXT_PPT_CVH = exmEXT_PPT_CVH; //Pega os exames do tipo EXT ROXO CVH                  
                    detiq.CodExame_EXT_PPT_CVH_ET_2 = exmEXT_PPT_CVH; //Pega os exames do tipo EXT ROXO CVH                  
                    detiq.CodExame_EXT_RO_BC_1_2ET_HEP = exmEXT_RO_BC_1_2ET_HEP; //Pega os exames do tipo EXT RO BANCADA 1 EET HEP
                    detiq.CodExame_EXT_RO_BC_1_2ET_HEP_ET2 = exmEXT_RO_BC_1_2ET_HEP; //Pega os exames do tipo EXT RO BANCADA 1 EET HEP
                    detiq.CodExame_EXT_RO_BC_1_2ET_IMO = exmEXT_RO_BC_1_2ET_IMO; //Pega os exames do tipo EXT RO BANCADA 1 EET IMO
                    detiq.CodExame_EXT_RO_BC_1_2ET_IMO_ET2 = exmEXT_RO_BC_1_2ET_IMO; //Pega os exames do tipo EXT RO BANCADA 1 EET IMO
                    detiq.CodExame_EXT_RO_BC_1_2ET_ISP = exmEXT_RO_BC_1_2ET_ISP; //Pega os exames do tipo EXT RO BANCADA 1 EET ISP
                    detiq.CodExame_EXT_RO_BC_1_2ET_ISP_ET2 = exmEXT_RO_BC_1_2ET_ISP; //Pega os exames do tipo EXT RO BANCADA 1 EET ISP
                    detiq.CodExame_EXT_RO_BC_1_2ET_HEH = exmEXT_RO_BC_1_2ET_HEH; //Pega os exames do tipo EXT RO BANCADA 1 EET HEH
                    detiq.CodExame_EXT_RO_BC_1_2ET_HEH_ET2 = exmEXT_RO_BC_1_2ET_HEH; //Pega os exames do tipo EXT RO BANCADA 1 EET HEH
                    detiq.CodExame_EXT_RO_BC_1_2ET_PHT = exmEXT_RO_BC_1_2ET_PHT; //Pega os exames do tipo EXT RO BANCADA 1 EET PHT
                    detiq.CodExame_EXT_RO_BC_1_2ET_PHT_ET2 = exmEXT_RO_BC_1_2ET_PHT; //Pega os exames do tipo EXT RO BANCADA 1 EET PHT
                    detiq.CodExame_EXT_RO_BC_1_3ET_PHQ = exmEXT_RO_BC_1_2ET_PHQ; //Pega os exames do tipo EXT RO BANCADA 1 EET PHQ
                    detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET2 = exmEXT_RO_BC_1_2ET_PHQ; //Pega os exames do tipo EXT RO BANCADA 1 EET PHQ
                    detiq.CodExame_EXT_RO_BC_1_3ET_PHQ_ET3 = exmEXT_RO_BC_1_2ET_PHQ; //Pega os exames do tipo EXT RO BANCADA 1 EET PHQ
                    detiq.CodExame_EXT_RO_BC_1_2ET_CAG = exmEXT_RO_BC_1_2ET_CAG; //Pega os exames do tipo EXT RO BANCADA 1 CAG
                    detiq.CodExame_EXT_RO_BC_1_2ET_CAG_2ET = exmEXT_RO_BC_1_2ET_CAG; //Pega os exames do tipo EXT RO BANCADA 1 CAG



                    #region ext bancada 1 AZ


                    detiq.CodExame_EXT_AZ_BC_1_1ET = exmEXT_AZ_BC_1_1ET; //Pega os exames do tipo EXT AZ BANCADA 1 1_ET
                    //"AT3"  "RIT" "PCS"
                    detiq.CodExame_EXT_AZ_BC_1_1ET_AT3 = exmEXT_AZ_BC_1_1ET_AT3; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_1ET_RIT = exmEXT_AZ_BC_1_1ET_RIT; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_1ET_PCS = exmEXT_AZ_BC_1_1ET_PCS; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2 = exmEXT_AZ_BC_1_1ET_PCS; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3 = exmEXT_AZ_BC_1_1ET_PCS; //Pega os exames do tipo EXT AZ BANCADA 1 

                    #endregion

                    #region ext bancada 1 AZ 2


                    detiq.CodExame_EXT_AZ_BC_1_2ET_1 = exmEXT_AZ_BC_1_2ET; //Pega os exames do tipo EXT AZ BANCADA 1 2_ET
                    //"F11" "F12"
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_F11 = exmEXT_AZ_BC_1_2ET_F11; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_F12 = exmEXT_AZ_BC_1_2ET_F12; //Pega os exames do tipo EXT AZ BANCADA 1 


                    //"FC8" "FVW" "F10"
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC8 = exmEXT_AZ_BC_1_2ET_FC8; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FVW = exmEXT_AZ_BC_1_2ET_FVW; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_F10 = exmEXT_AZ_BC_1_2ET_F10; //Pega os exames do tipo EXT AZ BANCADA 1 

                    //"FC9" "FC5"  "FC7"
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC9 = exmEXT_AZ_BC_1_2ET_FC9; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC5 = exmEXT_AZ_BC_1_2ET_FC5; //Pega os exames do tipo EXT AZ BANCADA 1 
                    detiq.CodExame_EXT_AZ_BC_1_2ET_1_FC7 = exmEXT_AZ_BC_1_2ET_FC7; //Pega os exames do tipo EXT AZ BANCADA 1 



                    #endregion



                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_1 = exmEXT_AR_BC_1; //Pega os exames do tipo EXT AR AZ BANCADA 1 5_ET
                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_2 = exmEXT_AR_BC_1; //Pega os exames do tipo EXT AR AZ BANCADA 1 5_ET
                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_3 = exmEXT_AR_BC_1; //Pega os exames do tipo EXT AR AZ BANCADA 1 5_ET
                    detiq.CodExame_EXT_AR_BC_1_5ET_AZ_4 = exmEXT_AR_BC_1; //Pega os exames do tipo EXT AR AZ BANCADA 1 5_ET
                    detiq.CodExame_EXT_AR_BC_1_5ET_RO_1 = exmEXT_AR_BC_1; //Pega os exames do tipo EXT AR RO BANCADA 1 5_ET


                    //detiq.CodExame_EXT_RO_BC_1_HIV = exmEXT_RO_BC_1_HIV; //Pega os exames do tipo EXT ROXO HIV
                    //detiq.CodExame_EXT_RO_BC_1_HIV_ET_2 = exmEXT_RO_BC_1_HIV; //Pega os exames do tipo EXT ROXO HIV



                    #endregion

                    #region BAC
                    detiq.CodExameBAC = exmBAC;
                    detiq.CodExameBAC_FV = exmBAC_FV;
                    detiq.CodExameBAC_BK2 = exmBAC_BK2;

                    detiq.CodExameBAC_HA = exmBAC_HA;
                    detiq.CodExameBAC_HN = exmBAC_HN;
                    detiq.CodExameBAC_HP = exmBAC_HP;
                    #endregion

                    #region BIO

                    //RPC
                    detiq.CodExameBIO_FR_RPC = exmBIO_FR_RPC;
                    //detiq.CodExameBIO_AM = exmBIO_AM;
                    //detiq.CodExameBIO_AM_AM = exmBIO_AM;
                    detiq.CodExameBIO_AM_24 = exmBIO_AM_24;




                    //  if (exmBIO_AM == "DC2 ")
                    //  {
                    //      detiq.CodExameBIO_AM = "";

                    //  }
                    //  else
                    //  {
                    //      detiq.CodExameBIO_AM = exmBIO_AM;
                    //  }

                    if (exmBIO_AM == "DC2 ")
                    {
                        detiq.CodExameBIO_AM_AM = "DC2 ";
                        detiq.CodExameBIO_AM = "";


                    }
                    else
                    {
                        detiq.CodExameBIO_AM = exmBIO_AM;
                        detiq.CodExameBIO_AM_AM = "";

                    }

                    //   if (exmBIO_AM != "")
                    //  {
                    //     detiq.CodExameBIO_AM_24 = "DC2 ";

                    //}

                    // else
                    //  {
                    //     // detiq.CodExameBIO_AM_24 = "";
                    //  }

                    detiq.CodExameBIO_LB = exmBIO_LB;
                    detiq.CodExameBIO_24 = exmBIO_24;
                    detiq.CodExameBIO_FR = exmBIO_FR;
                    detiq.CodExameBIO_SE = exmBIO_SE;
                    detiq.CodExameBIO_OU = exmBIO_OU;
                    detiq.CodExameBIO_RO = exmBIO_RO;
                    detiq.CodExameBIO_G1_2ET = exmBIO_G1_2ET;
                    detiq.CodExameBIO_G1_2ET_1 = exmBIO_G1_2ET;
                    detiq.CodExameBIO_G1_4ET = exmBIO_G1_4ET;
                    detiq.CodExameBIO_G1_4ET_1 = exmBIO_G1_4ET;
                    detiq.CodExameBIO_G1_4ET_2 = exmBIO_G1_4ET;
                    detiq.CodExameBIO_G1_4ET_3 = exmBIO_G1_4ET;
                    detiq.CodExameBIO_CI = exmBIO_CI;
                    detiq.CodExameBIO_CI_30 = exmBIO_CI;
                    detiq.CodExameBIO_CI_60 = exmBIO_CI;


                    //detiq.CodExameBIO_CID_GLICOSE = exmBIO_CID_GLICOSE;

                    detiq.CodExameBIO_CIP = exmBIO_CIP;
                    detiq.CodExameBIO_CID_5_ET_0 = exmBIO_CID_0_120; //C22
                    detiq.CodExameBIO_CID_5_ET_30 = exmBIO_CID_0_120;//C22
                    detiq.CodExameBIO_CID_5_ET_60 = exmBIO_CID_0_120;//C22
                    detiq.CodExameBIO_CID_5_ET_90 = exmBIO_CID_0_120;//C22
                    detiq.CodExameBIO_CID_5_ET_120 = exmBIO_CID_0_120;//C22

                    detiq.CodExameBIO_CID_8_ET_0 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_30 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_60 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_90 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_120 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_180 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_240 = exmBIO_CID_0_300;//CP2
                    detiq.CodExameBIO_CID_8_ET_300 = exmBIO_CID_0_300;//CP2

                    detiq.CodExameBIO_CI_2_ET_0 = exmBIO_CI_0_120; //SG2
                    detiq.CodExameBIO_CI_2_ET_120 = exmBIO_CI_0_120;

                    detiq.CodExameBIO_CI_2_ET_CS2_0 = exmBIO_CI_0_60; //SC2
                    detiq.CodExameBIO_CI_2_ET_CS2_60 = exmBIO_CI_0_60;

                    detiq.CodExameBIO_CI_6_ET_0 = exmBIO_CI_0_180; //C32
                    detiq.CodExameBIO_CI_6_ET_30 = exmBIO_CI_0_180;
                    detiq.CodExameBIO_CI_6_ET_60 = exmBIO_CI_0_180;
                    detiq.CodExameBIO_CI_6_ET_90 = exmBIO_CI_0_180;
                    detiq.CodExameBIO_CI_6_ET_120 = exmBIO_CI_0_180;
                    detiq.CodExameBIO_CI_6_ET_180 = exmBIO_CI_0_180;
                    detiq.CodExameBIO_SER_GS6= exmBIO_SER_GS6;



                    #endregion
                    // Etiquetas para URO FR U12 c12 ON2 PC2 PE2 MII RPC DE4
                    detiq.CodExameURO = exmURO;
                    detiq.CodExameURO_ET_2 = exmURO;
                    // Etiquetas para URO FR EM2
                    detiq.CodExameURO2 = exmURO2;
                    detiq.CodExameURO_ET_22 = exmURO2;
                    detiq.CodExameURO_CR4 = exmURO_CR4;
                    detiq.CodExameIMU_Amarelo = exmIMU_Amarelo;
                    detiq.CodExameIMU_U12 = exmIMU_U12;
                    detiq.CodExameIMU_U24 = exmIMU_U24;
                    detiq.CodExameIMU_COU = exmIMU_COU;
                    detiq.CodExameIMU_RO = exmIMU_RO;

                    #region HOR detip recebe variavel
                    // PT3// agora é PT5 Ele vai sair em 2 etiquetas 1 junto aos demais exames de HOR e 1 sozinho como exame externo Amarelo
                    detiq.CodExameHOR_PT3 = exmHOR_PT3;

                    detiq.CodExameHOR = exmHOR;
                    detiq.CodExameHOR_T14_BIO = exmHOR_T14_Bio;
                    detiq.CodExameHOR_T14_BIO_C22 = exmBIO_CID_0_120; //C22
                    detiq.CodExameHOR_T14_BIO_C22_30 = exmBIO_CID_0_120; //C22
                    detiq.CodExameHOR_T14_BIO_C22_60 = exmBIO_CID_0_120; //C22
                    detiq.CodExameHOR_T14_BIO_C22_90 = exmBIO_CID_0_120; //C22
                    detiq.CodExameHOR_T14_BIO_C22_120 = exmBIO_CID_0_120; //C22
                    detiq.CodExameHOR_T14_BIO_CP2 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_30 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_60 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_90 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_120 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_180 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_240 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_CP2_300 = exmBIO_CID_0_300; //CP2
                    detiq.CodExameHOR_T14_BIO_SG2 = exmBIO_CI_0_120;  //SG2
                    detiq.CodExameHOR_T14_BIO_SG2_120 = exmBIO_CI_0_120;  //SG2
                    detiq.CodExameHOR_T14_BIO_SC2 = exmBIO_CI_0_60;   //SC2
                    detiq.CodExameHOR_T14_BIO_SC2_60 = exmBIO_CI_0_60; //SC2
                    detiq.CodExameHOR_T14_BIO_C32 = exmBIO_CI_0_180;  //C32
                    detiq.CodExameHOR_T14_BIO_C32_30 = exmBIO_CI_0_180;  //C32
                    detiq.CodExameHOR_T14_BIO_C32_60 = exmBIO_CI_0_180;  //C32
                    detiq.CodExameHOR_T14_BIO_C32_90 = exmBIO_CI_0_180;  //C32
                    detiq.CodExameHOR_T14_BIO_C32_120 = exmBIO_CI_0_180;  //C32
                    detiq.CodExameHOR_T14_BIO_C32_180 = exmBIO_CI_0_180;  //C32
                    // teste T14 bio Cinza
                    //detiq.CodExameBIO_CINZA_T14_0 = exmHOR_T14_Bio;
                    //detiq.CodExameBIO_CINZA_T14_30 = exmHOR_T14_Bio;
                    //detiq.CodExameBIO_CINZA_T14_60 = exmHOR_T14_Bio;
                    //detiq.CodExameBIO_CINZA_T14_90 = exmHOR_T14_Bio;
                    //detiq.CodExameBIO_CINZA_T14_120 = exmHOR_T14_Bio;
                    //detiq.CodExameBIO_CINZA_T14_180 = exmHOR_T14_Bio;

                    #endregion

                    detiq.CodExameHEM_Rox = exmHEM_Rox;
                    detiq.CodExameHEM_Azul = exmHEM_Azul;
                    detiq.CodExameHEM_DI = exmHEM_DI;
                    detiq.CodExameHEM_BR = exmHEM_BR;
                    
                    //Dados do paciente que vão na etiqueta
                    detiq.Nome = dr.GetString(4) + dr.GetString(5);
                    detiq.TipoPac = dr.GetString(6);
                    detiq.Idade = dr.GetString(7);
                    detiq.Sexo = dr.GetString(8);
                    detiq.Consulta = dr.GetString(9);
                    detiq.Be = dr.GetString(10);
                    detiq.Rh = dr.GetString(11);
                    detiq.DtColeta = dr.GetString(13);
                    detiq.HoraExm = dr.GetString(18); // pega a hora da coleta   //Jr
                    detiq.DtNascRH = dr.GetString(19); // pega a hora da coleta   //Jr
                    detiq.DtNascBE = dr.GetString(20); // pega a hora da coleta   //Jr


                    // LU
                    #region LU
                    //BAC
                    detiq.LU_codExame_BAC_BK1 = LU_Exm_Bac_BK;
                    detiq.LU_codExame_BAC_DI1 = LU_Exm_Bac_DI;
                    // BIO
                    detiq.LU_codExame_BIO_AM1 = LU_Exm_Bio_AM;
                    detiq.LU_codExame_BIO_LB1 = LU_Exm_Bio_LB;
                    detiq.LU_codExame_BIO_SE1 = LU_Exm_Bio_SE;
                    // HEM
                    detiq.LU_codExame_HEM_AZ1 = LU_Exm_Hem_AZ;
                    detiq.LU_codExame_HEM_RO1 = LU_Exm_Hem_RO;
                    detiq.LU_codExame_HEM_DI1 = LU_Exm_Hem_DI;
                    detiq.LU_codExame_HEM_LB1 = LU_Exm_Hem_LB;
                    // HOR                     
                    detiq.LU_codExame_HOR_AM1 = LU_Exm_Hor_AM;
                    // IMU
                    detiq.LU_codExame_IMU_RO1 = LU_Exm_Imu_RO;
                    detiq.LU_codExame_IMU_AM1 = LU_Exm_Imu_AM;
                    detiq.LU_codExame_IMU_LB1 = LU_Exm_Imu_LB;
                    // PAR
                    detiq.LU_codExame_PAR_FR1 = LU_Exm_Par_FR;
                    // URO
                    detiq.LU_codExame_URI_FR1 = LU_Exm_Uri_FR;
                    detiq.LU_codExame_URI_FR_ET_21 = LU_Exm_Uri_FR;

                    // não classificado
                    detiq.Nao_Classificado1 = Nao_Classificado;

                    #endregion


                    #region Mostra o sexo como M ,F ou Outro
                    if (detiq.Sexo == "1")
                    {
                        detiq.Sexo = "M";
                    }
                    else if (detiq.Sexo == "3")
                    {
                        detiq.Sexo = "F";
                    }
                    else
                    {
                        detiq.Sexo = "Outro";

                    }
                    #endregion

                    dr1.Close();
                }
                
                dr.Close();
                
                commd.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return detiq;
        }
    }
}
