using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace Labetiq
{
    public class DadosRequisicao
    {

        Image NovaImagem;

        public Image NovaImagem1
        {
            get { return NovaImagem; }
            set { NovaImagem = value; }
        }
        

        private String nome;
        private String tipoPac;
        private String idade;
        private String sexo;
        private String dtColeta;
        private String area;
        private String setor;
        private String bancada;    
        private String rh;
        private String rf;
        private String be;
        private String requisicao;
        private String consulta;
        private String horaExm;
        private String codExamePAR;
        private String codExamePAR_FI;

        private String ExmEtiqUnica;

        public String ExmEtiqUnica1
        {
            get { return ExmEtiqUnica; }
            set { ExmEtiqUnica = value; }
        }

         
        // data de nascimento do paciente das tabelas intb6 e cen54
        private String dtNascRH;

        public String DtNascRH
        {
            get { return dtNascRH; }
            set { dtNascRH = value; }
        }
        private String dtNascBE;

        public String DtNascBE
        {
            get { return dtNascBE; }
            set { dtNascBE = value; }
        }


      
           
              
        private String codExameHEM_Rox;
        private String codExameHEM_Azul;
        private String codExameHEM_DI;
        private String codExameHEM_BR;

       


        // 29/07/2016
        private String ControleEtiq2;

        public String ControleEtiq21
        {
            get { return ControleEtiq2; }
            set { ControleEtiq2 = value; }
        }
       
        private String ControleEtiq;

        public String ControleEtiq1
        {
            get { return ControleEtiq; }
            set { ControleEtiq = value; }
        }


        private String ComprovantePaciente;

        public String ComprovantePaciente1
        {
            get { return ComprovantePaciente; }
            set { ComprovantePaciente = value; }
        }



        #region EXT

        #region Bancada 1 exames externos
        private String codExame_EXT_AM_BC_1; // Pega os exames do tipo EXT AMARELO BC1
        //" "B2G"

        

        private String codExame_EXT_AM_BC_1_B2G; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_B2G
        {
            get { return codExame_EXT_AM_BC_1_B2G; }
            set { codExame_EXT_AM_BC_1_B2G = value; }
        }
      

        //"TOC" "TRA" "ESQ"
        private String codExame_EXT_AM_BC_1_TOC; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_TOC
        {
            get { return codExame_EXT_AM_BC_1_TOC; }
            set { codExame_EXT_AM_BC_1_TOC = value; }
        }
        private String codExame_EXT_AM_BC_1_TRA; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_TRA
        {
            get { return codExame_EXT_AM_BC_1_TRA; }
            set { codExame_EXT_AM_BC_1_TRA = value; }
        }
        private String codExame_EXT_AM_BC_1_ESQ; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ESQ
        {
            get { return codExame_EXT_AM_BC_1_ESQ; }
            set { codExame_EXT_AM_BC_1_ESQ = value; }
        }

        // "RIB"  "IGF"  "TBG"
        private String codExame_EXT_AM_BC_1_RIB; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_RIB
        {
            get { return codExame_EXT_AM_BC_1_RIB; }
            set { codExame_EXT_AM_BC_1_RIB = value; }
        }
        private String codExame_EXT_AM_BC_1_IGF; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_IGF
        {
            get { return codExame_EXT_AM_BC_1_IGF; }
            set { codExame_EXT_AM_BC_1_IGF = value; }
        }
        private String codExame_EXT_AM_BC_1_TBG; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_TBG
        {
            get { return codExame_EXT_AM_BC_1_TBG; }
            set { codExame_EXT_AM_BC_1_TBG = value; }
        }


        //"PCC" "PEP" "PVR"
        private String codExame_EXT_AM_BC_1_PCC; // Pega os exames do tipo EXT ROXO BC1

        public String CodExame_EXT_AM_BC_1_PCC
        {
            get { return codExame_EXT_AM_BC_1_PCC; }
            set { codExame_EXT_AM_BC_1_PCC = value; }
        }
        private String codExame_EXT_AM_BC_1_PCC_ET_2; // Pega os exames do tipo EXT ROXO BC1

        public String CodExame_EXT_AM_BC_1_PCC_ET_2
        {
            get { return codExame_EXT_AM_BC_1_PCC_ET_2; }
            set { codExame_EXT_AM_BC_1_PCC_ET_2 = value; }
        }


        private String codExame_EXT_AM_BC_1_PEP; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_PEP
        {
            get { return codExame_EXT_AM_BC_1_PEP; }
            set { codExame_EXT_AM_BC_1_PEP = value; }
        }
        private String codExame_EXT_AM_BC_1_PVR; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_PVR
        {
            get { return codExame_EXT_AM_BC_1_PVR; }
            set { codExame_EXT_AM_BC_1_PVR = value; }
        }

        // "MON"  "MIC" "PCB"
        private String codExame_EXT_AM_BC_1_MON; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_MON
        {
            get { return codExame_EXT_AM_BC_1_MON; }
            set { codExame_EXT_AM_BC_1_MON = value; }
        }
        private String codExame_EXT_AM_BC_1_MIC; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_MIC
        {
            get { return codExame_EXT_AM_BC_1_MIC; }
            set { codExame_EXT_AM_BC_1_MIC = value; }
        }
        private String codExame_EXT_RO_BC_1_PCB; // Pega os exames do tipo EXT am BC1// mudou para roxo 01/02/2017

        public String CodExame_EXT_RO_BC_1_PCB
        {
            get { return codExame_EXT_RO_BC_1_PCB; }
            set { codExame_EXT_RO_BC_1_PCB = value; }
        }
        private String codExame_EXT_RO_BC_1_PCB_ET_2; // Pega os exames do tipo EXT am BC1// mudou para roxo 01/02/2017

        public String CodExame_EXT_RO_BC_1_PCB_ET_2
        {
            get { return codExame_EXT_RO_BC_1_PCB_ET_2; }
            set { codExame_EXT_RO_BC_1_PCB_ET_2 = value; }
        }


        //"IST"  "LIT"  "LYM"
        private String codExame_EXT_AM_BC_1_IST; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_IST
        {
            get { return codExame_EXT_AM_BC_1_IST; }
            set { codExame_EXT_AM_BC_1_IST = value; }
        }
        private String codExame_EXT_AM_BC_1_LIT; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_LIT
        {
            get { return codExame_EXT_AM_BC_1_LIT; }
            set { codExame_EXT_AM_BC_1_LIT = value; }
        }
        private String codExame_EXT_AM_BC_1_LYM; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_LYM
        {
            get { return codExame_EXT_AM_BC_1_LYM; }
            set { codExame_EXT_AM_BC_1_LYM = value; }
        }

        //"IF3"  "IEP"  "FIX"
        private String codExame_EXT_AM_BC_1_IF3; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_IF3
        {
            get { return codExame_EXT_AM_BC_1_IF3; }
            set { codExame_EXT_AM_BC_1_IF3 = value; }
        }
        private String codExame_EXT_AM_BC_1_IEP; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_IEP
        {
            get { return codExame_EXT_AM_BC_1_IEP; }
            set { codExame_EXT_AM_BC_1_IEP = value; }
        }
        private String codExame_EXT_AM_BC_1_FIX; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_FIX
        {
            get { return codExame_EXT_AM_BC_1_FIX; }
            set { codExame_EXT_AM_BC_1_FIX = value; }
        }

        //"HER"  "HOM"  "HTL"
        private String codExame_EXT_AM_BC_1_HER; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_HER
        {
            get { return codExame_EXT_AM_BC_1_HER; }
            set { codExame_EXT_AM_BC_1_HER = value; }
        }
        private String codExame_EXT_AM_BC_1_HOM; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_HOM
        {
            get { return codExame_EXT_AM_BC_1_HOM; }
            set { codExame_EXT_AM_BC_1_HOM = value; }
        }
        private String codExame_EXT_AM_BC_1_HTL; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_HTL
        {
            get { return codExame_EXT_AM_BC_1_HTL; }
            set { codExame_EXT_AM_BC_1_HTL = value; }
        }

        //"GAT"  "GEC"  "HPT"
        private String codExame_EXT_AM_BC_1_GAT; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_GAT
        {
            get { return codExame_EXT_AM_BC_1_GAT; }
            set { codExame_EXT_AM_BC_1_GAT = value; }
        }
        private String codExame_EXT_AM_BC_1_GEC; // Pega os exames do tipo EXT ROXO

        public String CodExame_EXT_AM_BC_1_GEC
        {
            get { return codExame_EXT_AM_BC_1_GEC; }
            set { codExame_EXT_AM_BC_1_GEC = value; }
        }
        private String codExame_EXT_AM_BC_1_GEC_ET_2; // Pega os exames do tipo EXT ROXO

        public String CodExame_EXT_AM_BC_1_GEC_ET_2
        {
            get { return codExame_EXT_AM_BC_1_GEC_ET_2; }
            set { codExame_EXT_AM_BC_1_GEC_ET_2 = value; }
        }

        private String codExame_EXT_AM_BC_1_HPT; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_HPT
        {
            get { return codExame_EXT_AM_BC_1_HPT; }
            set { codExame_EXT_AM_BC_1_HPT = value; }
        }


        //"ENA"  "EQU"  "ERT"
        private String codExame_EXT_AM_BC_1_ENA; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ENA
        {
            get { return codExame_EXT_AM_BC_1_ENA; }
            set { codExame_EXT_AM_BC_1_ENA = value; }
        }
        private String codExame_EXT_AM_BC_1_EQU; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_EQU
        {
            get { return codExame_EXT_AM_BC_1_EQU; }
            set { codExame_EXT_AM_BC_1_EQU = value; }
        }
        private String codExame_EXT_AM_BC_1_ERT; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ERT
        {
            get { return codExame_EXT_AM_BC_1_ERT; }
            set { codExame_EXT_AM_BC_1_ERT = value; }
        }

        //"DHE" "DGX" "EPR"
        private String codExame_EXT_AM_BC_1_DHE; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_DHE
        {
            get { return codExame_EXT_AM_BC_1_DHE; }
            set { codExame_EXT_AM_BC_1_DHE = value; }
        }
        private String codExame_EXT_AM_BC_1_DGX; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_DGX
        {
            get { return codExame_EXT_AM_BC_1_DGX; }
            set { codExame_EXT_AM_BC_1_DGX = value; }
        }
        private String codExame_EXT_AM_BC_1_EPR; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_EPR
        {
            get { return codExame_EXT_AM_BC_1_EPR; }
            set { codExame_EXT_AM_BC_1_EPR = value; }
        }


        //"CVC" "CER" "COC"
        private String codExame_EXT_AM_BC_1_CVC; // Pega os exames do tipo EXT ROXO

        public String CodExame_EXT_AM_BC_1_CVC
        {
            get { return codExame_EXT_AM_BC_1_CVC; }
            set { codExame_EXT_AM_BC_1_CVC = value; }
        }
        private String codExame_EXT_AM_BC_1_CVC_2ET; // Pega os exames do tipo EXT ROXO

        public String CodExame_EXT_AM_BC_1_CVC_2ET
        {
            get { return codExame_EXT_AM_BC_1_CVC_2ET; }
            set { codExame_EXT_AM_BC_1_CVC_2ET = value; }
        }

        
        private String codExame_EXT_AM_BC_1_CER; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CER
        {
            get { return codExame_EXT_AM_BC_1_CER; }
            set { codExame_EXT_AM_BC_1_CER = value; }
        }
        private String codExame_EXT_AM_BC_1_COC; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_COC
        {
            get { return codExame_EXT_AM_BC_1_COC; }
            set { codExame_EXT_AM_BC_1_COC = value; }
        }

        // "CAC"  "CFF"  
        private String codExame_EXT_AM_BC_1_CAC; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CAC
        {
            get { return codExame_EXT_AM_BC_1_CAC; }
            set { codExame_EXT_AM_BC_1_CAC = value; }
        }
        private String codExame_EXT_AM_BC_1_CFF; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CFF
        {
            get { return codExame_EXT_AM_BC_1_CFF; }
            set { codExame_EXT_AM_BC_1_CFF = value; }
        }
        

        //"BG2"  "C1E" "CAI"
        private String codExame_EXT_AM_BC_1_BG2; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_BG2
        {
            get { return codExame_EXT_AM_BC_1_BG2; }
            set { codExame_EXT_AM_BC_1_BG2 = value; }
        }
        private String codExame_EXT_AM_BC_1_C1E; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_C1E
        {
            get { return codExame_EXT_AM_BC_1_C1E; }
            set { codExame_EXT_AM_BC_1_C1E = value; }
        }
        private String codExame_EXT_AM_BC_1_CAI; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CAI
        {
            get { return codExame_EXT_AM_BC_1_CAI; }
            set { codExame_EXT_AM_BC_1_CAI = value; }
        }


        //"ATR"  "ACN" "CCP"
        private String codExame_EXT_AM_BC_1_ATR; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ATR
        {
            get { return codExame_EXT_AM_BC_1_ATR; }
            set { codExame_EXT_AM_BC_1_ATR = value; }
        }
        private String codExame_EXT_AM_BC_1_ACN; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ACN
        {
            get { return codExame_EXT_AM_BC_1_ACN; }
            set { codExame_EXT_AM_BC_1_ACN = value; }
        }
        private String codExame_EXT_AM_BC_1_CCP; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CCP
        {
            get { return codExame_EXT_AM_BC_1_CCP; }
            set { codExame_EXT_AM_BC_1_CCP = value; }
        }

        //"AIN"  "LKM"  "MUE"
        private String codExame_EXT_AM_BC_1_AIN; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_AIN
        {
            get { return codExame_EXT_AM_BC_1_AIN; }
            set { codExame_EXT_AM_BC_1_AIN = value; }
        }
        private String codExame_EXT_AM_BC_1_LKM; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_LKM
        {
            get { return codExame_EXT_AM_BC_1_LKM; }
            set { codExame_EXT_AM_BC_1_LKM = value; }
        }
        private String codExame_EXT_AM_BC_1_MUE; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_MUE
        {
            get { return codExame_EXT_AM_BC_1_MUE; }
            set { codExame_EXT_AM_BC_1_MUE = value; }
        }


        //"ASM"  "SSA"  "SSB"
        private String codExame_EXT_AM_BC_1_ASM; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ASM
        {
            get { return codExame_EXT_AM_BC_1_ASM; }
            set { codExame_EXT_AM_BC_1_ASM = value; }
        }
        private String codExame_EXT_AM_BC_1_SSA; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_SSA
        {
            get { return codExame_EXT_AM_BC_1_SSA; }
            set { codExame_EXT_AM_BC_1_SSA = value; }
        }
        private String codExame_EXT_AM_BC_1_SSB; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_SSB
        {
            get { return codExame_EXT_AM_BC_1_SSB; }
            set { codExame_EXT_AM_BC_1_SSB = value; }
        }


        //"MUL" "RNP" "S70"
        private String codExame_EXT_AM_BC_1_MUL; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_MUL
        {
            get { return codExame_EXT_AM_BC_1_MUL; }
            set { codExame_EXT_AM_BC_1_MUL = value; }
        }
        private String codExame_EXT_AM_BC_1_RNP; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_RNP
        {
            get { return codExame_EXT_AM_BC_1_RNP; }
            set { codExame_EXT_AM_BC_1_RNP = value; }
        }
        private String codExame_EXT_AM_BC_1_S70; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_S70
        {
            get { return codExame_EXT_AM_BC_1_S70; }
            set { codExame_EXT_AM_BC_1_S70 = value; }
        }


        //"ILH" "JO1"  "MIT"
        private String codExame_EXT_AM_BC_1_ILH; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ILH
        {
            get { return codExame_EXT_AM_BC_1_ILH; }
            set { codExame_EXT_AM_BC_1_ILH = value; }
        }
        private String codExame_EXT_AM_BC_1_JO1; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_JO1
        {
            get { return codExame_EXT_AM_BC_1_JO1; }
            set { codExame_EXT_AM_BC_1_JO1 = value; }
        }
        private String codExame_EXT_AM_BC_1_MIT; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_MIT
        {
            get { return codExame_EXT_AM_BC_1_MIT; }
            set { codExame_EXT_AM_BC_1_MIT = value; }
        }

        //"AEN" "GAD" "AGL"
        private String codExame_EXT_AM_BC_1_AEN; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_AEN
        {
            get { return codExame_EXT_AM_BC_1_AEN; }
            set { codExame_EXT_AM_BC_1_AEN = value; }
        }
        private String codExame_EXT_AM_BC_1_GAD; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_GAD
        {
            get { return codExame_EXT_AM_BC_1_GAD; }
            set { codExame_EXT_AM_BC_1_GAD = value; }
        }
        private String codExame_EXT_AM_BC_1_AGL; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_AGL
        {
            get { return codExame_EXT_AM_BC_1_AGL; }
            set { codExame_EXT_AM_BC_1_AGL = value; }
        }


        private String codExame_EXT_AM_BC_1_AAT; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_AAT
        {
            get { return codExame_EXT_AM_BC_1_AAT; }
            set { codExame_EXT_AM_BC_1_AAT = value; }
        }
        private String codExame_EXT_AM_BC_1_DRO; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_DRO
        {
            get { return codExame_EXT_AM_BC_1_DRO; }
            set { codExame_EXT_AM_BC_1_DRO = value; }
        }
        private String codExame_EXT_AM_BC_1_CAD; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CAD
        {
            get { return codExame_EXT_AM_BC_1_CAD; }
            set { codExame_EXT_AM_BC_1_CAD = value; }
        }
        private String codExame_EXT_AM_BC_1_CAD_ET_2; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CAD_ET_2
        {
            get { return codExame_EXT_AM_BC_1_CAD_ET_2; }
            set { codExame_EXT_AM_BC_1_CAD_ET_2 = value; }
        }

        private String codExame_EXT_AM_BC_1_PAR; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_PAR
        {
            get { return codExame_EXT_AM_BC_1_PAR; }
            set { codExame_EXT_AM_BC_1_PAR = value; }
        }
        private String codExame_EXT_AM_BC_1_CEN; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_CEN
        {
            get { return codExame_EXT_AM_BC_1_CEN; }
            set { codExame_EXT_AM_BC_1_CEN = value; }
        }


        
        private String codExame_EXT_AM_BC_1_ADO;

        public String CodExame_EXT_AM_BC_1_ADO
        {
            get { return codExame_EXT_AM_BC_1_ADO; }
            set { codExame_EXT_AM_BC_1_ADO = value; }
        }
        private String codExame_EXT_AM_BC_1_LAS; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_LAS
        {
            get { return codExame_EXT_AM_BC_1_LAS; }
            set { codExame_EXT_AM_BC_1_LAS = value; }
        }
        
        private String codExame_EXT_AM_BC_1_ADA; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_ADA
        {
            get { return codExame_EXT_AM_BC_1_ADA; }
            set { codExame_EXT_AM_BC_1_ADA = value; }
        }
        private String codExame_EXT_AM_BC_1_C17; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_C17
        {
            get { return codExame_EXT_AM_BC_1_C17; }
            set { codExame_EXT_AM_BC_1_C17 = value; }
        }
        private String codExame_EXT_AM_BC_1_T20; // Pega os exames do tipo EXT AMARELO BC1

        public String CodExame_EXT_AM_BC_1_T20
        {
            get { return codExame_EXT_AM_BC_1_T20; }
            set { codExame_EXT_AM_BC_1_T20 = value; }
        }

        #endregion
        #region Ext bancada 2
        
       

        private String codExame_EXT_AM_BC_2; // Pega os exames do tipo EXT AMARELO BC 2
        //"TIF"  "LEP"  "SVA"  "VRS"
        private String codExame_EXT_AM_BC_2_TIF; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_TIF
        {
            get { return codExame_EXT_AM_BC_2_TIF; }
            set { codExame_EXT_AM_BC_2_TIF = value; }
        }
        private String codExame_EXT_AM_BC_2_LEP; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_LEP
        {
            get { return codExame_EXT_AM_BC_2_LEP; }
            set { codExame_EXT_AM_BC_2_LEP = value; }
        }
        private String codExame_EXT_AM_BC_2_SVA; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_SVA
        {
            get { return codExame_EXT_AM_BC_2_SVA; }
            set { codExame_EXT_AM_BC_2_SVA = value; }
        }
        private String codExame_EXT_AM_BC_2_VRS; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_VRS
        {
            get { return codExame_EXT_AM_BC_2_VRS; }
            set { codExame_EXT_AM_BC_2_VRS = value; }
        }


        //"BLA"  "CLA"  "DEN"
        private String codExame_EXT_AM_BC_2_BLA; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_BLA
        {
            get { return codExame_EXT_AM_BC_2_BLA; }
            set { codExame_EXT_AM_BC_2_BLA = value; }
        }
        private String codExame_EXT_AM_BC_2_CLA; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_CLA
        {
            get { return codExame_EXT_AM_BC_2_CLA; }
            set { codExame_EXT_AM_BC_2_CLA = value; }
        }
        private String codExame_EXT_AM_BC_2_DEN; // Pega os exames do tipo EXT AMARELO BC 2

        public String CodExame_EXT_AM_BC_2_DEN
        {
            get { return codExame_EXT_AM_BC_2_DEN; }
            set { codExame_EXT_AM_BC_2_DEN = value; }
        }


        #endregion
        #region bancada 3 amarelo        
        
        private String codExame_EXT_AM_BC_3; // Pega os exames do tipo EXT AMARELO BC 3
        //"FRT"  "GHH"  "SUA" "HTG"
        private String codExame_EXT_AM_BC_3_FRT; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_FRT
        {
            get { return codExame_EXT_AM_BC_3_FRT; }
            set { codExame_EXT_AM_BC_3_FRT = value; }
        }
        private String codExame_EXT_AM_BC_3_GHH; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_GHH
        {
            get { return codExame_EXT_AM_BC_3_GHH; }
            set { codExame_EXT_AM_BC_3_GHH = value; }
        }
        private String codExame_EXT_AM_BC_3_SUA; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_SUA
        {
            get { return codExame_EXT_AM_BC_3_SUA; }
            set { codExame_EXT_AM_BC_3_SUA = value; }
        }
        private String codExame_EXT_AM_BC_3_HTG; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_HTG
        {
            get { return codExame_EXT_AM_BC_3_HTG; }
            set { codExame_EXT_AM_BC_3_HTG = value; }
        }

        //"RUA"  "TOA"  "HBM" "CTX"
        private String codExame_EXT_AM_BC_3_RUA; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_RUA
        {
            get { return codExame_EXT_AM_BC_3_RUA; }
            set { codExame_EXT_AM_BC_3_RUA = value; }
        }
        private String codExame_EXT_AM_BC_3_TOA; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_TOA
        {
            get { return codExame_EXT_AM_BC_3_TOA; }
            set { codExame_EXT_AM_BC_3_TOA = value; }
        }
        private String codExame_EXT_AM_BC_3_HBM; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_HBM
        {
            get { return codExame_EXT_AM_BC_3_HBM; }
            set { codExame_EXT_AM_BC_3_HBM = value; }
        }
        private String codExame_EXT_AM_BC_3_CTX; // Pega os exames do tipo EXT AMARELO BC 3

        public String CodExame_EXT_AM_BC_3_CTX
        {
            get { return codExame_EXT_AM_BC_3_CTX; }
            set { codExame_EXT_AM_BC_3_CTX = value; }
        }



        #endregion
        #region ext bancada 1 MA
        private String codExame_EXT_MA_BC_1; // Pega os exames do tipo EXT MA BC 1

        //"CSP"  "EIS"  "FRU" "GAL"
        private String codExame_EXT_MA_BC_1_CSP; // Pega os exames do tipo EXT MA BC 1

        public String CodExame_EXT_MA_BC_1_CSP
        {
            get { return codExame_EXT_MA_BC_1_CSP; }
            set { codExame_EXT_MA_BC_1_CSP = value; }
        }
        private String codExame_EXT_MA_BC_1_EIS; // Pega os exames do tipo EXT MA BC 1

        public String CodExame_EXT_MA_BC_1_EIS
        {
            get { return codExame_EXT_MA_BC_1_EIS; }
            set { codExame_EXT_MA_BC_1_EIS = value; }
        }
        private String codExame_EXT_MA_BC_1_FRU; // Pega os exames do tipo EXT MA BC 1

        public String CodExame_EXT_MA_BC_1_FRU
        {
            get { return codExame_EXT_MA_BC_1_FRU; }
            set { codExame_EXT_MA_BC_1_FRU = value; }
        }
        private String codExame_EXT_MA_BC_1_GAL; // Pega os exames do tipo EXT MA BC 1

        public String CodExame_EXT_MA_BC_1_GAL
        {
            get { return codExame_EXT_MA_BC_1_GAL; }
            set { codExame_EXT_MA_BC_1_GAL = value; }
        }


        #endregion

        #region ext bancada 1 24
        private String codExame_EXT_24_BC_1; // Pega os exames do tipo EXT 24 BC 1

        //CIU
        private String codExame_EXT_24_BC_1_CIU; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_CIU
        {
            get { return codExame_EXT_24_BC_1_CIU; }
            set { codExame_EXT_24_BC_1_CIU = value; }
        }
        //OXU
        private String codExame_EXT_24_BC_1_OXU; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_OXU
        {
            get { return codExame_EXT_24_BC_1_OXU; }
            set { codExame_EXT_24_BC_1_OXU = value; }
        }
        

        // "IMU" "MET" "BJO"  "CTU"
        private String codExame_EXT_24_BC_1_IMU; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_IMU
        {
            get { return codExame_EXT_24_BC_1_IMU; }
            set { codExame_EXT_24_BC_1_IMU = value; }
        }
        private String codExame_EXT_24_BC_1_MET; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_MET
        {
            get { return codExame_EXT_24_BC_1_MET; }
            set { codExame_EXT_24_BC_1_MET = value; }
        }
        private String codExame_EXT_24_BC_1_BJO; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_BJO
        {
            get { return codExame_EXT_24_BC_1_BJO; }
            set { codExame_EXT_24_BC_1_BJO = value; }
        }
        private String codExame_EXT_24_BC_1_CTU; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_CTU
        {
            get { return codExame_EXT_24_BC_1_CTU; }
            set { codExame_EXT_24_BC_1_CTU = value; }
        }


        //"C0U"  "COP"  "EPU"
        private String codExame_EXT_24_BC_1_C0U; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_C0U
        {
            get { return codExame_EXT_24_BC_1_C0U; }
            set { codExame_EXT_24_BC_1_C0U = value; }
        }
        private String codExame_EXT_24_BC_1_COP; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_COP
        {
            get { return codExame_EXT_24_BC_1_COP; }
            set { codExame_EXT_24_BC_1_COP = value; }
        }
        private String codExame_EXT_24_BC_1_EPU; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_EPU
        {
            get { return codExame_EXT_24_BC_1_EPU; }
            set { codExame_EXT_24_BC_1_EPU = value; }
        }

        //"VMA" "ADU" "CIT"
        private String codExame_EXT_24_BC_1_VMA; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_VMA
        {
            get { return codExame_EXT_24_BC_1_VMA; }
            set { codExame_EXT_24_BC_1_VMA = value; }
        }
        private String codExame_EXT_24_BC_1_ADU; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_ADU
        {
            get { return codExame_EXT_24_BC_1_ADU; }
            set { codExame_EXT_24_BC_1_ADU = value; }
        }
        private String codExame_EXT_24_BC_1_CIT; // Pega os exames do tipo EXT 24 BC 1

        public String CodExame_EXT_24_BC_1_CIT
        {
            get { return codExame_EXT_24_BC_1_CIT; }
            set { codExame_EXT_24_BC_1_CIT = value; }
        }


        #endregion

        private String codExame_EXT_24_BC_3; // Pega os exames do tipo EXT 24 BC 3

        #region ext bancada 1 br
        private String codExame_EXT_BR_BC_1; // Pega os exames do tipo EXT BR BC 1

        //"COB" "ZIN"
        private String codExame_EXT_BR_BC_1_COB; // Pega os exames do tipo EXT BR BC 1

        public String CodExame_EXT_BR_BC_1_COB
        {
            get { return codExame_EXT_BR_BC_1_COB; }
            set { codExame_EXT_BR_BC_1_COB = value; }
        }
        private String codExame_EXT_BR_BC_1_ZIN; // Pega os exames do tipo EXT BR BC 1

        public String CodExame_EXT_BR_BC_1_ZIN
        {
            get { return codExame_EXT_BR_BC_1_ZIN; }
            set { codExame_EXT_BR_BC_1_ZIN = value; }
        }

        #endregion

        #region ext bancada 1 fr
        private String codExame_EXT_FR_BC_1; // Pega os exames do tipo EXT FR BC 1

        //"CFE" "EIU" "ION"  "MER" "TEP"
        private String codExame_EXT_FR_BC_1_CFE; // Pega os exames do tipo EXT FR BC 1

        public String CodExame_EXT_FR_BC_1_CFE
        {
            get { return codExame_EXT_FR_BC_1_CFE; }
            set { codExame_EXT_FR_BC_1_CFE = value; }
        }
        private String codExame_EXT_FR_BC_1_EIU; // Pega os exames do tipo EXT FR BC 1

        public String CodExame_EXT_FR_BC_1_EIU
        {
            get { return codExame_EXT_FR_BC_1_EIU; }
            set { codExame_EXT_FR_BC_1_EIU = value; }
        }
        private String codExame_EXT_FR_BC_1_ION; // Pega os exames do tipo EXT FR BC 1

        public String CodExame_EXT_FR_BC_1_ION
        {
            get { return codExame_EXT_FR_BC_1_ION; }
            set { codExame_EXT_FR_BC_1_ION = value; }
        }
        private String codExame_EXT_FR_BC_1_MER; // Pega os exames do tipo EXT FR BC 1

        public String CodExame_EXT_FR_BC_1_MER
        {
            get { return codExame_EXT_FR_BC_1_MER; }
            set { codExame_EXT_FR_BC_1_MER = value; }
        }
        private String codExame_EXT_FR_BC_1_TEP; // Pega os exames do tipo EXT FR BC 1

        public String CodExame_EXT_FR_BC_1_TEP
        {
            get { return codExame_EXT_FR_BC_1_TEP; }
            set { codExame_EXT_FR_BC_1_TEP = value; }
        }

        #endregion

        private String codExame_EXT_FR_BC_3; // Pega os exames do tipo EXT FR BC 3

        #region ext bancada 1 LB
        private String codExame_EXT_LB_BC_1; // Pega os exames do tipo EXT LB BC 1

        // "EFL""IML"
        private String codExame_EXT_LB_BC_1_EFL; // Pega os exames do tipo EXT LB BC 1

        public String CodExame_EXT_LB_BC_1_EFL
        {
            get { return codExame_EXT_LB_BC_1_EFL; }
            set { codExame_EXT_LB_BC_1_EFL = value; }
        }
        private String codExame_EXT_LB_BC_1_IML; // Pega os exames do tipo EXT LB BC 1

        public String CodExame_EXT_LB_BC_1_IML
        {
            get { return codExame_EXT_LB_BC_1_IML; }
            set { codExame_EXT_LB_BC_1_IML = value; }
        }

        #endregion


        
        
        
        
        private String codExame_EXT_LB_BC_2; // Pega os exames do tipo EXT LB BC 2
        private String codExame_EXT_SE_BC_1; // Pega os exames do tipo EXT SE BC 1
        private String codExame_EXT_AS_BC_3; // Pega os exames do tipo EXT AS BC 3

        #region ext bancada 1 VE
        private String codExame_EXT_VE_BC_1; // Pega os exames do tipo EXT VE BC 1

        // "CAB" "H50"  "CRI"  "VAN"  "FNI"  "FNB"
        private String codExame_EXT_VE_BC_1_CAB; // Pega os exames do tipo EXT VE BC 1

        public String CodExame_EXT_VE_BC_1_CAB
        {
            get { return codExame_EXT_VE_BC_1_CAB; }
            set { codExame_EXT_VE_BC_1_CAB = value; }
        }
        private String codExame_EXT_VE_BC_1_H50; // Pega os exames do tipo EXT VE BC 1

        public String CodExame_EXT_VE_BC_1_H50
        {
            get { return codExame_EXT_VE_BC_1_H50; }
            set { codExame_EXT_VE_BC_1_H50 = value; }
        }
        private String codExame_EXT_VE_BC_1_CRI; // Pega os exames do tipo EXT VE BC 1

        public String CodExame_EXT_VE_BC_1_CRI
        {
            get { return codExame_EXT_VE_BC_1_CRI; }
            set { codExame_EXT_VE_BC_1_CRI = value; }
        }
        private String codExame_EXT_VE_BC_1_VAN; // Pega os exames do tipo EXT VE BC 1

        public String CodExame_EXT_VE_BC_1_VAN
        {
            get { return codExame_EXT_VE_BC_1_VAN; }
            set { codExame_EXT_VE_BC_1_VAN = value; }
        }
        private String codExame_EXT_VE_BC_1_FNI; // Pega os exames do tipo EXT VE BC 1

        public String CodExame_EXT_VE_BC_1_FNI
        {
            get { return codExame_EXT_VE_BC_1_FNI; }
            set { codExame_EXT_VE_BC_1_FNI = value; }
        }
        private String codExame_EXT_VE_BC_1_FNB; // Pega os exames do tipo EXT VE BC 1

        public String CodExame_EXT_VE_BC_1_FNB
        {
            get { return codExame_EXT_VE_BC_1_FNB; }
            set { codExame_EXT_VE_BC_1_FNB = value; }
        }

        #endregion        
        private String codExame_EXT_VD_BC_3; // Pega os exames do tipo EXT VD BC 3
       
        //DXI
        private String codExame_EXT_CI_BC_1; // Pega os exames do tipo EXT CI BC 1
        private String codExame_EXT_CI_BC_1_2ET; // Pega os exames do tipo EXT CI BC 1

        public String CodExame_EXT_CI_BC_1_2ET
        {
            get { return codExame_EXT_CI_BC_1_2ET; }
            set { codExame_EXT_CI_BC_1_2ET = value; }
        }
        //"DXB"
        private String codExame_EXT_CI_BC_1_DXB; // Pega os exames do tipo EXT CI BC 1

        public String CodExame_EXT_CI_BC_1_DXB
        {
            get { return codExame_EXT_CI_BC_1_DXB; }
            set { codExame_EXT_CI_BC_1_DXB = value; }
        }


        #region ext bancada 1 RO
        private String codExame_EXT_RO_BC_1; // Pega os exames do tipo EXT RO BC 1
        // "PRM" "CD8"  "XFR" "ACT"
        private String codExame_EXT_RO_BC_1_PRM; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_PRM
        {
            get { return codExame_EXT_RO_BC_1_PRM; }
            set { codExame_EXT_RO_BC_1_PRM = value; }
        }
        private String codExame_EXT_RO_BC_1_CD8; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_CD8
        {
            get { return codExame_EXT_RO_BC_1_CD8; }
            set { codExame_EXT_RO_BC_1_CD8 = value; }
        }
        private String codExame_EXT_RO_BC_1_XFR; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_XFR
        {
            get { return codExame_EXT_RO_BC_1_XFR; }
            set { codExame_EXT_RO_BC_1_XFR = value; }
        }
        private String codExame_EXT_RO_BC_1_ACT; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_ACT
        {
            get { return codExame_EXT_RO_BC_1_ACT; }
            set { codExame_EXT_RO_BC_1_ACT = value; }
        }

        //"G6P"  "B27"  "JAK"
        private String codExame_EXT_RO_BC_1_G6P; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_G6P
        {
            get { return codExame_EXT_RO_BC_1_G6P; }
            set { codExame_EXT_RO_BC_1_G6P = value; }
        }
        private String codExame_EXT_RO_BC_1_G6P_2ET; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_G6P_2ET
        {
            get { return codExame_EXT_RO_BC_1_G6P_2ET; }
            set { codExame_EXT_RO_BC_1_G6P_2ET = value; }
        }
        

        private String codExame_EXT_RO_BC_1_B27; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_B27
        {
            get { return codExame_EXT_RO_BC_1_B27; }
            set { codExame_EXT_RO_BC_1_B27 = value; }
        }
        private String codExame_EXT_RO_BC_1_JAK; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_JAK
        {
            get { return codExame_EXT_RO_BC_1_JAK; }
            set { codExame_EXT_RO_BC_1_JAK = value; }
        }


        //"CIC" "EHE"  "FVP"
        private String codExame_EXT_RO_BC_1_CIC; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_CIC
        {
            get { return codExame_EXT_RO_BC_1_CIC; }
            set { codExame_EXT_RO_BC_1_CIC = value; }
        }
        private String codExame_EXT_RO_BC_1_EHE; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_EHE
        {
            get { return codExame_EXT_RO_BC_1_EHE; }
            set { codExame_EXT_RO_BC_1_EHE = value; }
        }
        private String codExame_EXT_RO_BC_1_FVP; // Pega os exames do tipo EXT RO BC 1

        public String CodExame_EXT_RO_BC_1_FVP
        {
            get { return codExame_EXT_RO_BC_1_FVP; }
            set { codExame_EXT_RO_BC_1_FVP = value; }
        }

        #endregion

       private String codExame_EXT_RO_BC_3; // Pega os exames do tipo EXT RO BC 3
       //"BNN"
       private String codExame_EXT_RO_BC_3_BNN; // Pega os exames do tipo EXT RO BC 3

       public String CodExame_EXT_RO_BC_3_BNN
       {
           get { return codExame_EXT_RO_BC_3_BNN; }
           set { codExame_EXT_RO_BC_3_BNN = value; }
       }




       private String codExame_EXT_PPT_CVH; // Pega os exames do tipo EXT CVH Tubo Roxo

       public String CodExame_EXT_PPT_CVH
       {
           get { return codExame_EXT_PPT_CVH; }
           set { codExame_EXT_PPT_CVH = value; }
       }
       private String codExame_EXT_PPT_CVH_ET_2; // Pega os exames do tipo EXT CVH tubo Roxo

       public String CodExame_EXT_PPT_CVH_ET_2
       {
           get { return codExame_EXT_PPT_CVH_ET_2; }
           set { codExame_EXT_PPT_CVH_ET_2 = value; }
       }

        
        //"CVB"
       private String codExame_EXT_RO_BC_1_CVB; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS HEP ETIQUETA 1

       public String CodExame_EXT_RO_BC_1_CVB
       {
           get { return codExame_EXT_RO_BC_1_CVB; }
           set { codExame_EXT_RO_BC_1_CVB = value; }
       }
       private String codExame_EXT_RO_BC_1_CVB_2ET; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS HEP ETIQUETA 1

       public String CodExame_EXT_RO_BC_1_CVB_2ET
       {
           get { return codExame_EXT_RO_BC_1_CVB_2ET; }
           set { codExame_EXT_RO_BC_1_CVB_2ET = value; }
       }

       
        private String codExame_EXT_RO_BC_1_2ET_HEP; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS HEP ETIQUETA 1
        private String codExame_EXT_RO_BC_1_2ET_HEP_ET2; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS HEP ETIQUETA 2
        private String codExame_EXT_RO_BC_1_2ET_IMO; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS IMO
        private String codExame_EXT_RO_BC_1_2ET_IMO_ET2; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS IMO ETIQUETA 2
        private String codExame_EXT_RO_BC_1_2ET_ISP; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS ISP
        private String codExame_EXT_RO_BC_1_2ET_ISP_ET2; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS ISP ETIQUETA 2
        private String codExame_EXT_RO_BC_1_2ET_HEH; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS HEH ETIQUETA 2
        private String codExame_EXT_RO_BC_1_2ET_HEH_ET2; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS HEH ETIQUETA 2
        private String codExame_EXT_RO_BC_1_2ET_PHT; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS PHT ETIQUETA 2
        private String codExame_EXT_RO_BC_1_2ET_PHT_ET2; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS PHT ETIQUETA 2
        private String codExame_EXT_RO_BC_1_3ET_PHQ; // Pega os exames do tipo EXT RO BC_1 3_ETIQUETAS PHQ ETIQUETA 3
        private String codExame_EXT_RO_BC_1_3ET_PHQ_ET2; // Pega os exames do tipo EXT RO BC_1 3_ETIQUETAS PHQ ETIQUETA 3
        private String codExame_EXT_RO_BC_1_3ET_PHQ_ET3; // Pega os exames do tipo EXT RO BC_1 3_ETIQUETAS PHQ ETIQUETA 3

        private String codExame_EXT_RO_BC_1_2ET_CAG; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS CAG ETIQUETA 2

        public String CodExame_EXT_RO_BC_1_2ET_CAG
        {
            get { return codExame_EXT_RO_BC_1_2ET_CAG; }
            set { codExame_EXT_RO_BC_1_2ET_CAG = value; }
        }
        private String codExame_EXT_RO_BC_1_2ET_CAG_2ET; // Pega os exames do tipo EXT RO BC_1 2_ETIQUETAS CAG ETIQUETA 2

        public String CodExame_EXT_RO_BC_1_2ET_CAG_2ET
        {
            get { return codExame_EXT_RO_BC_1_2ET_CAG_2ET; }
            set { codExame_EXT_RO_BC_1_2ET_CAG_2ET = value; }
        }


        #region ext bancada 1 AZ
        
        
        private String codExame_EXT_AZ_BC_1_1ET; // Pega os exames do tipo EXT AZ BC_1 1_ETIQUETA
        //"AT3"  "RIT" "PCS"
        private String codExame_EXT_AZ_BC_1_1ET_AT3; // Pega os exames do tipo EXT AZ BC_1 1_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_1ET_AT3
        {
            get { return codExame_EXT_AZ_BC_1_1ET_AT3; }
            set { codExame_EXT_AZ_BC_1_1ET_AT3 = value; }
        }
        private String codExame_EXT_AZ_BC_1_1ET_RIT; // Pega os exames do tipo EXT AZ BC_1 1_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_1ET_RIT
        {
            get { return codExame_EXT_AZ_BC_1_1ET_RIT; }
            set { codExame_EXT_AZ_BC_1_1ET_RIT = value; }
        }
        private String codExame_EXT_AZ_BC_1_1ET_PCS; // Pega os exames do tipo EXT AZ BC_1 1_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_1ET_PCS
        {
            get { return codExame_EXT_AZ_BC_1_1ET_PCS; }
            set { codExame_EXT_AZ_BC_1_1ET_PCS = value; }
        }
        private String codExame_EXT_AZ_BC_1_1ET_PCS_ET_2; // Pega os exames do tipo EXT AZ BC_1 1_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_1ET_PCS_ET_2
        {
            get { return codExame_EXT_AZ_BC_1_1ET_PCS_ET_2; }
            set { codExame_EXT_AZ_BC_1_1ET_PCS_ET_2 = value; }
        }

        private String codExame_EXT_AZ_BC_1_1ET_PCS_ET_3; // Pega os exames do tipo EXT AZ BC_1 1_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_1ET_PCS_ET_3
        {
            get { return codExame_EXT_AZ_BC_1_1ET_PCS_ET_3; }
            set { codExame_EXT_AZ_BC_1_1ET_PCS_ET_3 = value; }
        }


        #endregion

        #region ext bancada 1 AZ 2
        
        
        private String codExame_EXT_AZ_BC_1_2ET_1; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA
        //"F11" "F12"
        private String codExame_EXT_AZ_BC_1_2ET_1_F11; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_F11
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_F11; }
            set { codExame_EXT_AZ_BC_1_2ET_1_F11 = value; }
        }
        private String codExame_EXT_AZ_BC_1_2ET_1_F12; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_F12
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_F12; }
            set { codExame_EXT_AZ_BC_1_2ET_1_F12 = value; }
        }

        //"FC8" "FVW" "F10"
        private String codExame_EXT_AZ_BC_1_2ET_1_FC8; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_FC8
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_FC8; }
            set { codExame_EXT_AZ_BC_1_2ET_1_FC8 = value; }
        }
        private String codExame_EXT_AZ_BC_1_2ET_1_FVW; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_FVW
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_FVW; }
            set { codExame_EXT_AZ_BC_1_2ET_1_FVW = value; }
        }
        private String codExame_EXT_AZ_BC_1_2ET_1_F10; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_F10
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_F10; }
            set { codExame_EXT_AZ_BC_1_2ET_1_F10 = value; }
        }


        //"FC9" "FC5"  "FC7"
        private String codExame_EXT_AZ_BC_1_2ET_1_FC9; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_FC9
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_FC9; }
            set { codExame_EXT_AZ_BC_1_2ET_1_FC9 = value; }
        }
        private String codExame_EXT_AZ_BC_1_2ET_1_FC5; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_FC5
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_FC5; }
            set { codExame_EXT_AZ_BC_1_2ET_1_FC5 = value; }
        }
        private String codExame_EXT_AZ_BC_1_2ET_1_FC7; // Pega os exames do tipo EXT AZ BC_1 2_ETIQUETA

        public String CodExame_EXT_AZ_BC_1_2ET_1_FC7
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1_FC7; }
            set { codExame_EXT_AZ_BC_1_2ET_1_FC7 = value; }
        }
  



        #endregion


       
        
        
        
        
        private String codExame_EXT_AR_BC_1_5ET_AZ_1; // Pega os exames do tipo EXT AR BC_1 5_ETIQUETA
        private String codExame_EXT_AR_BC_1_5ET_AZ_2; // Pega os exames do tipo EXT AR BC_1 5_ETIQUETA
        private String codExame_EXT_AR_BC_1_5ET_AZ_3; // Pega os exames do tipo EXT AR BC_1 5_ETIQUETA
        private String codExame_EXT_AR_BC_1_5ET_AZ_4; // Pega os exames do tipo EXT AR BC_1 5_ETIQUETA
        private String codExame_EXT_AR_BC_1_5ET_RO_1; // Pega os exames do tipo EXT AR BC_1 5_ETIQUETA

        public String CodExame_EXT_AR_BC_1_5ET_RO_1
        {
            get { return codExame_EXT_AR_BC_1_5ET_RO_1; }
            set { codExame_EXT_AR_BC_1_5ET_RO_1 = value; }
        }

        public String CodExame_EXT_AR_BC_1_5ET_AZ_4
        {
            get { return codExame_EXT_AR_BC_1_5ET_AZ_4; }
            set { codExame_EXT_AR_BC_1_5ET_AZ_4 = value; }
        }

        public String CodExame_EXT_AR_BC_1_5ET_AZ_3
        {
            get { return codExame_EXT_AR_BC_1_5ET_AZ_3; }
            set { codExame_EXT_AR_BC_1_5ET_AZ_3 = value; }
        }

        public String CodExame_EXT_AR_BC_1_5ET_AZ_2
        {
            get { return codExame_EXT_AR_BC_1_5ET_AZ_2; }
            set { codExame_EXT_AR_BC_1_5ET_AZ_2 = value; }
        }

        public String CodExame_EXT_AR_BC_1_5ET_AZ_1
        {
            get { return codExame_EXT_AR_BC_1_5ET_AZ_1; }
            set { codExame_EXT_AR_BC_1_5ET_AZ_1 = value; }
        }
        

        public String CodExame_EXT_AZ_BC_1_2ET_1
        {
            get { return codExame_EXT_AZ_BC_1_2ET_1; }
            set { codExame_EXT_AZ_BC_1_2ET_1 = value; }
        }

        public String CodExame_EXT_AZ_BC_1_1ET
        {
            get { return codExame_EXT_AZ_BC_1_1ET; }
            set { codExame_EXT_AZ_BC_1_1ET = value; }
        }

        public String CodExame_EXT_RO_BC_1_3ET_PHQ_ET3
        {
            get { return codExame_EXT_RO_BC_1_3ET_PHQ_ET3; }
            set { codExame_EXT_RO_BC_1_3ET_PHQ_ET3 = value; }
        }

        public String CodExame_EXT_RO_BC_1_3ET_PHQ_ET2
        {
            get { return codExame_EXT_RO_BC_1_3ET_PHQ_ET2; }
            set { codExame_EXT_RO_BC_1_3ET_PHQ_ET2 = value; }
        }

        public String CodExame_EXT_RO_BC_1_3ET_PHQ
        {
            get { return codExame_EXT_RO_BC_1_3ET_PHQ; }
            set { codExame_EXT_RO_BC_1_3ET_PHQ = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_PHT_ET2
        {
            get { return codExame_EXT_RO_BC_1_2ET_PHT_ET2; }
            set { codExame_EXT_RO_BC_1_2ET_PHT_ET2 = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_PHT
        {
            get { return codExame_EXT_RO_BC_1_2ET_PHT; }
            set { codExame_EXT_RO_BC_1_2ET_PHT = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_HEH_ET2
        {
            get { return codExame_EXT_RO_BC_1_2ET_HEH_ET2; }
            set { codExame_EXT_RO_BC_1_2ET_HEH_ET2 = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_HEH
        {
            get { return codExame_EXT_RO_BC_1_2ET_HEH; }
            set { codExame_EXT_RO_BC_1_2ET_HEH = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_ISP_ET2
        {
            get { return codExame_EXT_RO_BC_1_2ET_ISP_ET2; }
            set { codExame_EXT_RO_BC_1_2ET_ISP_ET2 = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_ISP
        {
            get { return codExame_EXT_RO_BC_1_2ET_ISP; }
            set { codExame_EXT_RO_BC_1_2ET_ISP = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_IMO_ET2
        {
            get { return codExame_EXT_RO_BC_1_2ET_IMO_ET2; }
            set { codExame_EXT_RO_BC_1_2ET_IMO_ET2 = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_IMO
        {
            get { return codExame_EXT_RO_BC_1_2ET_IMO; }
            set { codExame_EXT_RO_BC_1_2ET_IMO = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_HEP_ET2
        {
            get { return codExame_EXT_RO_BC_1_2ET_HEP_ET2; }
            set { codExame_EXT_RO_BC_1_2ET_HEP_ET2 = value; }
        }

        public String CodExame_EXT_RO_BC_1_2ET_HEP
        {
            get { return codExame_EXT_RO_BC_1_2ET_HEP; }
            set { codExame_EXT_RO_BC_1_2ET_HEP = value; }
        }
     

        public String CodExame_EXT_RO_BC_3
        {
            get { return codExame_EXT_RO_BC_3; }
            set { codExame_EXT_RO_BC_3 = value; }
        }

        public String CodExame_EXT_RO_BC_1
        {
            get { return codExame_EXT_RO_BC_1; }
            set { codExame_EXT_RO_BC_1 = value; }
        }

        public String CodExame_EXT_CI_BC_1
        {
            get { return codExame_EXT_CI_BC_1; }
            set { codExame_EXT_CI_BC_1 = value; }
        }

        public String CodExame_EXT_VD_BC_3
        {
            get { return codExame_EXT_VD_BC_3; }
            set { codExame_EXT_VD_BC_3 = value; }
        }

        public String CodExame_EXT_VE_BC_1
        {
            get { return codExame_EXT_VE_BC_1; }
            set { codExame_EXT_VE_BC_1 = value; }
        }

        public String CodExame_EXT_AS_BC_3
        {
            get { return codExame_EXT_AS_BC_3; }
            set { codExame_EXT_AS_BC_3 = value; }
        }

        public String CodExame_EXT_SE_BC_1
        {
            get { return codExame_EXT_SE_BC_1; }
            set { codExame_EXT_SE_BC_1 = value; }
        }

        public String CodExame_EXT_LB_BC_2
        {
            get { return codExame_EXT_LB_BC_2; }
            set { codExame_EXT_LB_BC_2 = value; }
        }

        public String CodExame_EXT_LB_BC_1
        {
            get { return codExame_EXT_LB_BC_1; }
            set { codExame_EXT_LB_BC_1 = value; }
        }

        public String CodExame_EXT_FR_BC_3
        {
            get { return codExame_EXT_FR_BC_3; }
            set { codExame_EXT_FR_BC_3 = value; }
        }

        public String CodExame_EXT_FR_BC_1
        {
            get { return codExame_EXT_FR_BC_1; }
            set { codExame_EXT_FR_BC_1 = value; }
        }

        public String CodExame_EXT_BR_BC_1
        {
            get { return codExame_EXT_BR_BC_1; }
            set { codExame_EXT_BR_BC_1 = value; }
        }

        public String CodExame_EXT_24_BC_3
        {
            get { return codExame_EXT_24_BC_3; }
            set { codExame_EXT_24_BC_3 = value; }
        }

        public String CodExame_EXT_24_BC_1
        {
            get { return codExame_EXT_24_BC_1; }
            set { codExame_EXT_24_BC_1 = value; }
        }

        public String CodExame_EXT_MA_BC_1
        {
            get { return codExame_EXT_MA_BC_1; }
            set { codExame_EXT_MA_BC_1 = value; }
        }
        public String CodExame_EXT_AM_BC_3
        {
            get { return codExame_EXT_AM_BC_3; }
            set { codExame_EXT_AM_BC_3 = value; }
        }

        public String CodExame_EXT_AM_BC_2
        {
            get { return codExame_EXT_AM_BC_2; }
            set { codExame_EXT_AM_BC_2 = value; }
        }


        public String CodExame_EXT_AM_BC_1 // Pega os exames do tipo EXT
        {
            get { return codExame_EXT_AM_BC_1; }
            set { codExame_EXT_AM_BC_1 = value; }
        }

        //private String codExame_EXT_RO_BC_1_HIV; // Pega os exames do tipo EXT ROX

        //public String CodExame_EXT_RO_BC_1_HIV
        //{
        //    get { return codExame_EXT_RO_BC_1_HIV; }
        //    set { codExame_EXT_RO_BC_1_HIV = value; }
        //}
        //private String codExame_EXT_RO_BC_1_HIV_ET_2; // Pega os exames do tipo EXT ROX

        //public String CodExame_EXT_RO_BC_1_HIV_ET_2
        //{
        //    get { return codExame_EXT_RO_BC_1_HIV_ET_2; }
        //    set { codExame_EXT_RO_BC_1_HIV_ET_2 = value; }
        //}



        #endregion

        #region IMU

        private String codExameIMU_Amarelo;
        private String codExameIMU_U12;
        private String codExameIMU_U24;
        private String codExameIMU_COU;
        private String codExameIMU_RO;


        public String CodExameIMU_Amarelo
        {
            get { return codExameIMU_Amarelo; }
            set { codExameIMU_Amarelo = value; }
        }  
        
        public String CodExameIMU_COU
        {
            get { return codExameIMU_COU; }
            set { codExameIMU_COU = value; }
        }
        public String CodExameIMU_RO
        {
            get { return codExameIMU_RO; }
            set { codExameIMU_RO = value; }
        }

        public String CodExameIMU_U24
        {
            get { return codExameIMU_U24; }
            set { codExameIMU_U24 = value; }
        }

        public String CodExameIMU_U12
        {
            get { return codExameIMU_U12; }
            set { codExameIMU_U12 = value; }
        }
        #endregion
        #region BIO        
       //RPC
        private String codExameBIO_FR_RPC;

        public String CodExameBIO_FR_RPC
        {
            get { return codExameBIO_FR_RPC; }
            set { codExameBIO_FR_RPC = value; }
        }

        private String codExameBIO_AM;
        private String codExameBIO_AM_AM;

        public String CodExameBIO_AM_AM
        {
            get { return codExameBIO_AM_AM; }
            set { codExameBIO_AM_AM = value; }
        }
        private String codExameBIO_AM_24;

        public String CodExameBIO_AM_24
        {
            get { return codExameBIO_AM_24; }
            set { codExameBIO_AM_24 = value; }
        }
        
        
        
        private String codExameBIO_LB;
        private String codExameBIO_24;
        private String codExameBIO_FR;
        private String codExameBIO_SE;
        private String codExameBIO_OU;
        private String codExameBIO_RO;

        private String codExameBIO_G1_2ET;   // imprimi 2 etiquetas
        private String codExameBIO_G1_2ET_1; // imprimi 2 etiquetas
        private String codExameBIO_G1_4ET;  // imprimi 4 etiquetas
        private String codExameBIO_G1_4ET_1;// imprimi 4 etiquetas      
        private String codExameBIO_G1_4ET_2;// imprimi 4 etiquetas       
        private String codExameBIO_G1_4ET_3;// imprimi 4 etiquetas 
 
        private String codExameBIO_CI;
        private String codExameBIO_CI_30;
        private String codExameBIO_CI_60;
        
        //private String codExameBIO_CID_GLICOSE;
        private String codExameBIO_CIP;

        private String codExameBIO_CID_5_ET_0; // IMPRIMI 5 ETIQUETAS DO EXAME BIO-C22 DE 0 A 120        
        private String codExameBIO_CID_5_ET_30; // IMPRIMI 5 ETIQUETAS DO EXAME BIO-C22 DE 0 A 120        
        private String codExameBIO_CID_5_ET_60; // IMPRIMI 5 ETIQUETAS DO EXAME BIO-C22 DE 0 A 120        
        private String codExameBIO_CID_5_ET_90; // IMPRIMI 5 ETIQUETAS DO EXAME BIO-C22 DE 0 A 120       
        private String codExameBIO_CID_5_ET_120; // IMPRIMI 5 ETIQUETAS DO EXAME BIO-C22 DE 0 A 120

        private String codExameBIO_CID_8_ET_0; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300        
        private String codExameBIO_CID_8_ET_30; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300        
        private String codExameBIO_CID_8_ET_60; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300        
        private String codExameBIO_CID_8_ET_90; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300        
        private String codExameBIO_CID_8_ET_120; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300       
        private String codExameBIO_CID_8_ET_180; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300        
        private String codExameBIO_CID_8_ET_240; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300       
        private String codExameBIO_CID_8_ET_300; // IMPRIMI 8 ETIQUETAS DO EXAME BIO-CP2 DE 0 A 300  
        
        private String codExameBIO_CI_2_ET_0; // IMPRIMI 2 ETIQUETAS DO EXAME BIO-SG2 DE 0 E 120  
        private String codExameBIO_CI_2_ET_120; // IMPRIMI 2 ETIQUETAS DO EXAME BIO-SG2 DE 0 E 120

        private String codExameBIO_CI_2_ET_CS2_0; // IMPRIMI 2 ETIQUETAS DO EXAME BIO-CS2 DE 0 E 60        
        private String codExameBIO_CI_2_ET_CS2_60; // IMPRIMI 2 ETIQUETAS DO EXAME BIO-CS2 DE 0 E 60


        private String codExameBIO_CI_6_ET_0; // IMPRIMI 6 ETIQUETAS DO EXAME BIO-C32 DE 0 A 180        
        private String codExameBIO_CI_6_ET_30; // IMPRIMI 6 ETIQUETAS DO EXAME BIO-C32 DE 0 A 180        
        private String codExameBIO_CI_6_ET_60; // IMPRIMI 6 ETIQUETAS DO EXAME BIO-C32 DE 0 A 180       
        private String codExameBIO_CI_6_ET_90; // IMPRIMI 6 ETIQUETAS DO EXAME BIO-C32 DE 0 A 180        
        private String codExameBIO_CI_6_ET_120; // IMPRIMI 6 ETIQUETAS DO EXAME BIO-C32 DE 0 A 180        
        private String codExameBIO_CI_6_ET_180; // IMPRIMI 6 ETIQUETAS DO EXAME BIO-C32 DE 0 A 180

        // teste para imprimir 6 etiquetas  exame T14 bio cor cinza 0,30,60,90,120,180

        private String codExameBIO_CINZA_T14_0;

        public String CodExameBIO_CINZA_T14_0
        {
            get { return codExameBIO_CINZA_T14_0; }
            set { codExameBIO_CINZA_T14_0 = value; }
        }

        private String codExameBIO_CINZA_T14_30;

        public String CodExameBIO_CINZA_T14_30
        {
            get { return codExameBIO_CINZA_T14_30; }
            set { codExameBIO_CINZA_T14_30 = value; }
        }
        private String codExameBIO_CINZA_T14_60;

        public String CodExameBIO_CINZA_T14_60
        {
            get { return codExameBIO_CINZA_T14_60; }
            set { codExameBIO_CINZA_T14_60 = value; }
        }
        private String codExameBIO_CINZA_T14_90;

        public String CodExameBIO_CINZA_T14_90
        {
            get { return codExameBIO_CINZA_T14_90; }
            set { codExameBIO_CINZA_T14_90 = value; }
        }
        private String codExameBIO_CINZA_T14_120;

        public String CodExameBIO_CINZA_T14_120
        {
            get { return codExameBIO_CINZA_T14_120; }
            set { codExameBIO_CINZA_T14_120 = value; }
        }
        private String codExameBIO_CINZA_T14_180;

        public String CodExameBIO_CINZA_T14_180
        {
            get { return codExameBIO_CINZA_T14_180; }
            set { codExameBIO_CINZA_T14_180 = value; }
        }

       

      

       
      
        
        
        public String CodExameBIO_AM
        {
            get { return codExameBIO_AM; }
            set { codExameBIO_AM = value; }
        }
        public String CodExameBIO_LB
        {
            get { return codExameBIO_LB; }
            set { codExameBIO_LB = value; }
        }
        public String CodExameBIO_24
        {
            get { return codExameBIO_24; }
            set { codExameBIO_24 = value; }
        }
        public String CodExameBIO_FR
        {
            get { return codExameBIO_FR; }
            set { codExameBIO_FR = value; }
        }
        public String CodExameBIO_SE
        {
            get { return codExameBIO_SE; }
            set { codExameBIO_SE = value; }
        }
        public String CodExameBIO_OU
        {
            get { return codExameBIO_OU; }
            set { codExameBIO_OU = value; }
        }
        public String CodExameBIO_RO
        {
            get { return codExameBIO_RO; }
            set { codExameBIO_RO = value; }
        }
        public String CodExameBIO_G1_2ET
        {
            get { return codExameBIO_G1_2ET; }
            set { codExameBIO_G1_2ET = value; }
        }
        public String CodExameBIO_G1_2ET_1
        {
            get { return codExameBIO_G1_2ET_1; }
            set { codExameBIO_G1_2ET_1 = value; }
        }
        public String CodExameBIO_G1_4ET
        {
            get { return codExameBIO_G1_4ET; }
            set { codExameBIO_G1_4ET = value; }
        }
        public String CodExameBIO_G1_4ET_1
        {
            get { return codExameBIO_G1_4ET_1; }
            set { codExameBIO_G1_4ET_1 = value; }
        }
        public String CodExameBIO_G1_4ET_2
        {
            get { return codExameBIO_G1_4ET_2; }
            set { codExameBIO_G1_4ET_2 = value; }
        }
        public String CodExameBIO_G1_4ET_3
        {
            get { return codExameBIO_G1_4ET_3; }
            set { codExameBIO_G1_4ET_3 = value; }
        }
        public String CodExameBIO_CI
        {
            get { return codExameBIO_CI; }
            set { codExameBIO_CI = value; }
        }
        public String CodExameBIO_CI_30
        {
            get { return codExameBIO_CI_30; }
            set { codExameBIO_CI_30 = value; }
        }
        public String CodExameBIO_CI_60
        {
            get { return codExameBIO_CI_60; }
            set { codExameBIO_CI_60 = value; }
        }
        
        //public String CodExameBIO_CID_GLICOSE
        //{
        //    get { return codExameBIO_CID_GLICOSE; }
        //    set { codExameBIO_CID_GLICOSE = value; }
        //}
        public String CodExameBIO_CIP
        {
            get { return codExameBIO_CIP; }
            set { codExameBIO_CIP = value; }
        }
        public String CodExameBIO_CID_5_ET_0
        {
            get { return codExameBIO_CID_5_ET_0; }
            set { codExameBIO_CID_5_ET_0 = value; }
        }
        
        public String CodExameBIO_CID_5_ET_30
        {
            get { return codExameBIO_CID_5_ET_30; }
            set { codExameBIO_CID_5_ET_30 = value; }
        }
        public String CodExameBIO_CID_5_ET_60
        {
            get { return codExameBIO_CID_5_ET_60; }
            set { codExameBIO_CID_5_ET_60 = value; }
        }
        public String CodExameBIO_CID_5_ET_90
        {
            get { return codExameBIO_CID_5_ET_90; }
            set { codExameBIO_CID_5_ET_90 = value; }
        }

        public String CodExameBIO_CID_5_ET_120
        {
            get { return codExameBIO_CID_5_ET_120; }
            set { codExameBIO_CID_5_ET_120 = value; }
        }
        public String CodExameBIO_CID_8_ET_0
        {
            get { return codExameBIO_CID_8_ET_0; }
            set { codExameBIO_CID_8_ET_0 = value; }
        }
        public String CodExameBIO_CID_8_ET_30
        {
            get { return codExameBIO_CID_8_ET_30; }
            set { codExameBIO_CID_8_ET_30 = value; }
        }
        public String CodExameBIO_CID_8_ET_60
        {
            get { return codExameBIO_CID_8_ET_60; }
            set { codExameBIO_CID_8_ET_60 = value; }
        }
        public String CodExameBIO_CID_8_ET_90
        {
            get { return codExameBIO_CID_8_ET_90; }
            set { codExameBIO_CID_8_ET_90 = value; }
        }
        public String CodExameBIO_CID_8_ET_120
        {
            get { return codExameBIO_CID_8_ET_120; }
            set { codExameBIO_CID_8_ET_120 = value; }
        }
        public String CodExameBIO_CID_8_ET_180
        {
            get { return codExameBIO_CID_8_ET_180; }
            set { codExameBIO_CID_8_ET_180 = value; }
        }
        public String CodExameBIO_CID_8_ET_240
        {
            get { return codExameBIO_CID_8_ET_240; }
            set { codExameBIO_CID_8_ET_240 = value; }
        }
        public String CodExameBIO_CID_8_ET_300
        {
            get { return codExameBIO_CID_8_ET_300; }
            set { codExameBIO_CID_8_ET_300 = value; }
        }
        public String CodExameBIO_CI_2_ET_0
        {
            get { return codExameBIO_CI_2_ET_0; }
            set { codExameBIO_CI_2_ET_0 = value; }
        }
        public String CodExameBIO_CI_2_ET_120
        {
            get { return codExameBIO_CI_2_ET_120; }
            set { codExameBIO_CI_2_ET_120 = value; }
        }
        public String CodExameBIO_CI_2_ET_CS2_0
        {
            get { return codExameBIO_CI_2_ET_CS2_0; }
            set { codExameBIO_CI_2_ET_CS2_0 = value; }
        }
        public String CodExameBIO_CI_2_ET_CS2_60
        {
            get { return codExameBIO_CI_2_ET_CS2_60; }
            set { codExameBIO_CI_2_ET_CS2_60 = value; }
        }
        public String CodExameBIO_CI_6_ET_0
        {
            get { return codExameBIO_CI_6_ET_0; }
            set { codExameBIO_CI_6_ET_0 = value; }
        }
        public String CodExameBIO_CI_6_ET_30
        {
            get { return codExameBIO_CI_6_ET_30; }
            set { codExameBIO_CI_6_ET_30 = value; }
        }
        public String CodExameBIO_CI_6_ET_60
        {
            get { return codExameBIO_CI_6_ET_60; }
            set { codExameBIO_CI_6_ET_60 = value; }
        }
        public String CodExameBIO_CI_6_ET_90
        {
            get { return codExameBIO_CI_6_ET_90; }
            set { codExameBIO_CI_6_ET_90 = value; }
        }
        public String CodExameBIO_CI_6_ET_120
        {
            get { return codExameBIO_CI_6_ET_120; }
            set { codExameBIO_CI_6_ET_120 = value; }
        }
        public String CodExameBIO_CI_6_ET_180
        {
            get { return codExameBIO_CI_6_ET_180; }
            set { codExameBIO_CI_6_ET_180 = value; }
        }

        private String codExameBIO_SER_GS6; // Gasometria

        public String CodExameBIO_SER_GS6
        {
            get { return codExameBIO_SER_GS6; }
            set { codExameBIO_SER_GS6 = value; }
        }


        #endregion

        #region URO

        private String codExameURO; 
        public String CodExameURO
        {
            get { return codExameURO; }
            set { codExameURO = value; }
        }
        private String codExameURO2;

        public String CodExameURO2
        {
            get { return codExameURO2; }
            set { codExameURO2 = value; }
        }
       
        private String codExameURO_ET_2;

        public String CodExameURO_ET_2
        {
            get { return codExameURO_ET_2; }
            set { codExameURO_ET_2 = value; }
        }
        private String codExameURO_ET_22;
        public String CodExameURO_ET_22
        {
            get { return codExameURO_ET_22; }
            set { codExameURO_ET_22 = value; }
        }

        private String codExameURO_CR4;

        public String CodExameURO_CR4
        {
            get { return codExameURO_CR4; }
            set { codExameURO_CR4 = value; }
        } 



        #endregion

        #region HOR
        // PT3
        private String codExameHOR_PT3; // Ele vai sair em 2 etiquetas 1 junto aos demais exames de HOR e 1 sozinho como exame externo Amarelo

        public String CodExameHOR_PT3
        {
            get { return codExameHOR_PT3; }
            set { codExameHOR_PT3 = value; }
        }


        private String codExameHOR;

        public String CodExameHOR
        {
            get { return codExameHOR; }
            set { codExameHOR = value; }
        }

        private String codExameHOR_T14_BIO;

        public String CodExameHOR_T14_BIO
        {
            get { return codExameHOR_T14_BIO; }
            set { codExameHOR_T14_BIO = value; }
        }

        // Teste para imprimir exames de HOR que só devem ser impressos se tiver em bio os exm C22,CP2,SG2 E C32

        private String codExameHOR_T14_BIO_C22_30;

        public String CodExameHOR_T14_BIO_C22_30
        {
            get { return codExameHOR_T14_BIO_C22_30; }
            set { codExameHOR_T14_BIO_C22_30 = value; }
        }
        private String codExameHOR_T14_BIO_C22_60;

        public String CodExameHOR_T14_BIO_C22_60
        {
            get { return codExameHOR_T14_BIO_C22_60; }
            set { codExameHOR_T14_BIO_C22_60 = value; }
        }
        private String codExameHOR_T14_BIO_C22_90;

        public String CodExameHOR_T14_BIO_C22_90
        {
            get { return codExameHOR_T14_BIO_C22_90; }
            set { codExameHOR_T14_BIO_C22_90 = value; }
        }
        private String codExameHOR_T14_BIO_C22_120;

        public String CodExameHOR_T14_BIO_C22_120
        {
            get { return codExameHOR_T14_BIO_C22_120; }
            set { codExameHOR_T14_BIO_C22_120 = value; }
        }
        
       
        private String codExameHOR_T14_BIO_C22; // imprimi a zero

        public String CodExameHOR_T14_BIO_C22
        {
            get { return codExameHOR_T14_BIO_C22; }
            set { codExameHOR_T14_BIO_C22 = value; }
        }
        private String codExameHOR_T14_BIO_CP2; // imprimo o zero

        public String CodExameHOR_T14_BIO_CP2
        {
            get { return codExameHOR_T14_BIO_CP2; }
            set { codExameHOR_T14_BIO_CP2 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_30;

        public String CodExameHOR_T14_BIO_CP2_30
        {
            get { return codExameHOR_T14_BIO_CP2_30; }
            set { codExameHOR_T14_BIO_CP2_30 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_60;

        public String CodExameHOR_T14_BIO_CP2_60
        {
            get { return codExameHOR_T14_BIO_CP2_60; }
            set { codExameHOR_T14_BIO_CP2_60 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_90;

        public String CodExameHOR_T14_BIO_CP2_90
        {
            get { return codExameHOR_T14_BIO_CP2_90; }
            set { codExameHOR_T14_BIO_CP2_90 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_120;

        public String CodExameHOR_T14_BIO_CP2_120
        {
            get { return codExameHOR_T14_BIO_CP2_120; }
            set { codExameHOR_T14_BIO_CP2_120 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_180;

        public String CodExameHOR_T14_BIO_CP2_180
        {
            get { return codExameHOR_T14_BIO_CP2_180; }
            set { codExameHOR_T14_BIO_CP2_180 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_240;

        public String CodExameHOR_T14_BIO_CP2_240
        {
            get { return codExameHOR_T14_BIO_CP2_240; }
            set { codExameHOR_T14_BIO_CP2_240 = value; }
        }
        private String codExameHOR_T14_BIO_CP2_300;

        public String CodExameHOR_T14_BIO_CP2_300
        {
            get { return codExameHOR_T14_BIO_CP2_300; }
            set { codExameHOR_T14_BIO_CP2_300 = value; }
        }


        private String codExameHOR_T14_BIO_SG2;

        public String CodExameHOR_T14_BIO_SG2
        {
            get { return codExameHOR_T14_BIO_SG2; }
            set { codExameHOR_T14_BIO_SG2 = value; }
        }
        private String codExameHOR_T14_BIO_SG2_120;

        public String CodExameHOR_T14_BIO_SG2_120
        {
            get { return codExameHOR_T14_BIO_SG2_120; }
            set { codExameHOR_T14_BIO_SG2_120 = value; }
        }


        private String codExameHOR_T14_BIO_SC2;

        public String CodExameHOR_T14_BIO_SC2
        {
            get { return codExameHOR_T14_BIO_SC2; }
            set { codExameHOR_T14_BIO_SC2 = value; }
        }

        private String codExameHOR_T14_BIO_SC2_60;

        public String CodExameHOR_T14_BIO_SC2_60
        {
            get { return codExameHOR_T14_BIO_SC2_60; }
            set { codExameHOR_T14_BIO_SC2_60 = value; }
        }

        
        private String codExameHOR_T14_BIO_C32;

        public String CodExameHOR_T14_BIO_C32
        {
            get { return codExameHOR_T14_BIO_C32; }
            set { codExameHOR_T14_BIO_C32 = value; }
        }
        private String codExameHOR_T14_BIO_C32_30;

        public String CodExameHOR_T14_BIO_C32_30
        {
            get { return codExameHOR_T14_BIO_C32_30; }
            set { codExameHOR_T14_BIO_C32_30 = value; }
        }
        private String codExameHOR_T14_BIO_C32_60;

        public String CodExameHOR_T14_BIO_C32_60
        {
            get { return codExameHOR_T14_BIO_C32_60; }
            set { codExameHOR_T14_BIO_C32_60 = value; }
        }
        private String codExameHOR_T14_BIO_C32_90;

        public String CodExameHOR_T14_BIO_C32_90
        {
            get { return codExameHOR_T14_BIO_C32_90; }
            set { codExameHOR_T14_BIO_C32_90 = value; }
        }
        private String codExameHOR_T14_BIO_C32_120;

        public String CodExameHOR_T14_BIO_C32_120
        {
            get { return codExameHOR_T14_BIO_C32_120; }
            set { codExameHOR_T14_BIO_C32_120 = value; }
        }
        private String codExameHOR_T14_BIO_C32_180;

        public String CodExameHOR_T14_BIO_C32_180
        {
            get { return codExameHOR_T14_BIO_C32_180; }
            set { codExameHOR_T14_BIO_C32_180 = value; }
        }



        #endregion

        #region HEM 23/03/2015

        public String CodExameHEM_Rox
        {
            get { return codExameHEM_Rox; }
            set { codExameHEM_Rox = value; }
        }
        public String CodExameHEM_Azul
        {
            get { return codExameHEM_Azul; }
            set { codExameHEM_Azul = value; }
        }
        public String CodExameHEM_DI
        {
            get { return codExameHEM_DI; }
            set { codExameHEM_DI = value; }     
        }
        public String CodExameHEM_BR
        {
            get { return codExameHEM_BR; }
            set { codExameHEM_BR = value; }
        }
        #endregion
        #region BAC

        private String codExameBAC;
       

        private String codExameBAC_FV;
        private String codExameBAC_HA;
        private String codExameBAC_HN;
        private String codExameBAC_HP;

        //exmBAC_BK2
        private String codExameBAC_BK2;

        public String CodExameBAC_BK2
        {
            get { return codExameBAC_BK2; }
            set { codExameBAC_BK2 = value; }
        }


        public String CodExameBAC
        {
            get { return codExameBAC; }
            set { codExameBAC = value; }
        }
        public String CodExameBAC_FV
        {
            get { return codExameBAC_FV; }
            set { codExameBAC_FV = value; }
        }
        public String CodExameBAC_HA
        {
            get { return codExameBAC_HA; }
            set { codExameBAC_HA = value; }
        }
        public String CodExameBAC_HN
        {
            get { return codExameBAC_HN; }
            set { codExameBAC_HN = value; }
        }
        public String CodExameBAC_HP
        {
            get { return codExameBAC_HP; }
            set { codExameBAC_HP = value; }
        }
        #endregion

        // LU
        #region LU
        //BAC
        private String LU_codExame_BAC_BK; // Pega os exames LU DO TIPO BAC
        private String LU_codExame_BAC_DI; // Pega os exames LU DO TIPO BAC
        // BIO
        private String LU_codExame_BIO_AM; // Pega os exames LU DO TIPO BIO
        private String LU_codExame_BIO_LB; // Pega os exames LU DO TIPO BIO
        private String LU_codExame_BIO_SE; // Pega os exames LU DO TIPO BIO
        // HEM
        private String LU_codExame_HEM_AZ; // Pega os exames LU DO TIPO HEM
        private String LU_codExame_HEM_RO; // Pega os exames LU DO TIPO HEM
        private String LU_codExame_HEM_DI; // Pega os exames LU DO TIPO HEM
        private String LU_codExame_HEM_LB; // Pega os exames LU DO TIPO HEM
        // HOR
        private String LU_codExame_HOR_AM; // Pega os exames LU DO TIPO HOR
        // IMU
        private String LU_codExame_IMU_RO; // Pega os exames LU DO TIPO IMU
        private String LU_codExame_IMU_AM; // Pega os exames LU DO TIPO IMU
        private String LU_codExame_IMU_LB; // Pega os exames LU DO TIPO IMU
        // PAR
        private String LU_codExame_PAR_FR; // Pega os exames LU DO TIPO PAR
        // URI
        private String LU_codExame_URI_FR; // Pega os exames LU DO TIPO URI
        private String LU_codExame_URI_FR_ET_2; // Pega os exames LU DO TIPO URO

        public String LU_codExame_URI_FR_ET_21
        {
            get { return LU_codExame_URI_FR_ET_2; }
            set { LU_codExame_URI_FR_ET_2 = value; }
        }

        public String LU_codExame_URI_FR1
        {
            get { return LU_codExame_URI_FR; }
            set { LU_codExame_URI_FR = value; }
        }

        public String LU_codExame_PAR_FR1
        {
            get { return LU_codExame_PAR_FR; }
            set { LU_codExame_PAR_FR = value; }
        }

        public String LU_codExame_IMU_LB1
        {
            get { return LU_codExame_IMU_LB; }
            set { LU_codExame_IMU_LB = value; }
        }

        public String LU_codExame_IMU_AM1
        {
            get { return LU_codExame_IMU_AM; }
            set { LU_codExame_IMU_AM = value; }
        }

        public String LU_codExame_IMU_RO1
        {
            get { return LU_codExame_IMU_RO; }
            set { LU_codExame_IMU_RO = value; }
        }


        public String LU_codExame_HOR_AM1
        {
            get { return LU_codExame_HOR_AM; }
            set { LU_codExame_HOR_AM = value; }
        }



        public String LU_codExame_HEM_LB1
        {
            get { return LU_codExame_HEM_LB; }
            set { LU_codExame_HEM_LB = value; }
        }

        public String LU_codExame_HEM_DI1
        {
            get { return LU_codExame_HEM_DI; }
            set { LU_codExame_HEM_DI = value; }
        }

        public String LU_codExame_HEM_RO1
        {
            get { return LU_codExame_HEM_RO; }
            set { LU_codExame_HEM_RO = value; }
        }

        
        public String LU_codExame_HEM_AZ1
        {
            get { return LU_codExame_HEM_AZ; }
            set { LU_codExame_HEM_AZ = value; }
        }





        public String LU_codExame_BIO_SE1
        {
            get { return LU_codExame_BIO_SE; }
            set { LU_codExame_BIO_SE = value; }
        }


        public String LU_codExame_BIO_LB1
        {
            get { return LU_codExame_BIO_LB; }
            set { LU_codExame_BIO_LB = value; }
        }

        public String LU_codExame_BIO_AM1
        {
            get { return LU_codExame_BIO_AM; }
            set { LU_codExame_BIO_AM = value; }
        }


        public String LU_codExame_BAC_DI1
        {
            get { return LU_codExame_BAC_DI; }
            set { LU_codExame_BAC_DI = value; }
        }

        public String LU_codExame_BAC_BK1
        {
            get { return LU_codExame_BAC_BK; }
            set { LU_codExame_BAC_BK = value; }
        }

        // exame não classificado 
        private String Nao_Classificado; // Pega os exames não classificados 

        public String Nao_Classificado1
        {
            get { return Nao_Classificado; }
            set { Nao_Classificado = value; }
        }



        #endregion

        public String CodExamePAR 
        {
            get { return codExamePAR; }
            set { codExamePAR = value; }
        }
        public String CodExamePAR_FI
        {
            get { return codExamePAR_FI; }
            set { codExamePAR_FI = value; }
        }

        public String HoraExm
        {
            get { return horaExm; }
            set { horaExm = value; }
        }

        public String Consulta
        {
            get { return consulta; }
            set { consulta = value; }
        }

        public string Requisicao
        {
            get { return requisicao; }
            set { requisicao = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String TipoPac
        {
            get { return tipoPac; }
            set { tipoPac = value; }
        }

        public String Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public String DtColeta
        {
            get { return dtColeta; }
            set { dtColeta = value; }
        }

        public String Area
        {
            get { return area; }
            set { area = value; }
        }
        
        public String Setor
        {
            get { return setor; }
            set { setor = value; }
        }


        public String Bancada
        {
            get { return bancada; }
            set { bancada = value; }
        }
            
        public String Rh
        {
            get { return rh; }
            set { rh = value; }
        }
        
        public String Rf
        {
            get { return rf; }
            set { rf = value; }
        }

        public String Be
        {
            get { return be; }
            set { be = value; }
        }

     
    }
}

