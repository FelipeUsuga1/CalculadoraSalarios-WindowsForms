using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPunto4
{
    public class clsCalcular
    {
        #region "Atributos"
        private string strNomEmp;
        private string strApeEmp;
        private double dbSalEmp;
        private int intAñosEmp;
        private double dbValorPeso;
        private double dbValSeg;
        private double dbAcuValSeg;
        private double dbValRent;
        private double dbAcuValRent;
        private double dbSalBruto;
        private double dbSalNeto;
        private double dbSalNetoA;
        private string strError;
        private string strCadena;

        #endregion

        #region "Constructor"
        public clsCalcular() {
            strNomEmp = string.Empty;
            strApeEmp = string.Empty;
            dbSalEmp = 0;
            intAñosEmp = 0;
            dbValorPeso = 0;
            dbValSeg = 0;
            dbAcuValSeg = 0;
            dbValRent = 0;
            dbAcuValRent = 0;
            dbSalBruto = 0;
            dbSalNeto = 0;
            dbSalNetoA = 0;
        }

        #endregion

        #region "Propiedades"
        public string nomEmp
        {
            set { strNomEmp = value; }
        }

        public string apeEmp
        {
            set { strApeEmp = value; }
        }

        public double salEmp
        {
            set { dbSalEmp = value; }
        }

        public int añosEmp
        {
            set { intAñosEmp = value; }
        }

        public double valorPeso
        {
            set { dbValorPeso = value; }
        }

        public string nomEmpGet
        {
            get { return strNomEmp; }
        }

        public string apeEmpGet
        {
            get { return strApeEmp; }
        }

        public double valSeg
        {
            get { return dbValSeg; }
        }

        public double acuValSeg
        {
            get { return dbAcuValSeg; }
        }

        public double valRent
        {
            get { return dbValRent; }
        }

        public double acuValRent
        {
            get { return dbAcuValRent; }
        }

        public double salEmpGet
        {
            get { return dbSalEmp; }
        }

        public double salBruto
        {
            get { return dbSalBruto; }
        }


        public double salNeto
        {
            get { return dbSalNeto; }
        }

        public double salNetoA
        {
            get { return dbSalNetoA; }
        }

        public string Error
        {
            get { return strError; }
        }

        public string Cadena
        {
            get { return strCadena; }
        }

        #endregion

        #region "Metodos Privados"

        private bool Validar() {

            if (intAñosEmp < 0) {
                strError = "Error, antiguedad no valida";
                return false;
            }

            if (dbSalEmp < 0)
            {
                strError = "Error, valor de salario no valido";
                return false;
            }

            if (dbValorPeso <= 0)
            {
                strError = "Error, valor del peso no valido";
                return false;
            }

            return true;
        }

        #endregion

        #region "Metodos Publicos"
        public bool Calcular() {
            double dbPorcInc;
            double dbPorcSeg;
            double dbPorcRent;
            double dbValorAum;

            try {
                if (!Validar())
                    return false;

                dbPorcInc = (intAñosEmp < 3) ? 5 : (intAñosEmp < 5) ? 10 : (intAñosEmp < 8) ? 15 : 20;
                dbPorcSeg = (dbSalEmp < 475) ? 4.55 : (dbSalEmp < 850) ? 5.25 : (dbSalEmp < 1300) ? 5.95 : 6.65;
                dbPorcRent = (dbSalEmp < 475) ? 2.8 : (dbSalEmp < 850) ? 4.75 : (dbSalEmp < 1300) ? 6.85 : 9;

                dbValorAum = (dbSalEmp * dbPorcInc / 100);
                dbSalBruto = (dbSalEmp + dbValorAum) * dbValorPeso;
                dbValSeg = (dbSalBruto * dbPorcSeg / 100);
                dbValRent = (dbSalBruto * dbPorcRent / 100);
                dbSalNeto = dbSalBruto - (dbValSeg + dbValRent);

                for (int i = 1; i < 12; i++)
                {
                    if (i == 7 || i == 12)
                    {
                        dbSalNeto = dbSalNeto + (dbSalEmp * dbValorPeso);
                        dbSalNetoA = dbSalNetoA + dbSalNeto + (dbSalEmp * dbValorPeso);
                    }
                    else 
                    {
                        dbSalNetoA = dbSalNetoA + dbSalNeto;
                    }
                    //strCadena = $"{strCadena} \n {i} \n {dbSalNeto}";
                }

                return true;

            }
            catch (Exception ex) {
                strError = ex.Message;
                return false;
            }
        }

        /*public bool calcularSalarioAnual()
        {

            if (!Calcular())
                strError = "Error, no se pudo calcular el salario";
                return false;

            
            return true;
        }*/
        #endregion

    }
}
