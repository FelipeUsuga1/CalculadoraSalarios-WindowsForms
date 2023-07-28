using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libPunto4;

namespace Punto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = String.Empty;
            this.txtApellido.Text = String.Empty;
            this.txtSal.Text = String.Empty;
            this.txtValorP.Text = String.Empty;
            this.lbRet.Text = string.Empty;
            this.lbSalBru.Text = string.Empty;
            this.lbSeg.Text = string.Empty;
            this.lbSalNetoA.Text = string.Empty;
            this.txtAños.Text = string.Empty;
            this.grbCalcular.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string strNombre;
            string strApeEmp;
            double dbSalEmp;
            int intAñosEmp;
            double dbValPeso;

            try {

                strNombre = this.txtNombre.Text;
                strApeEmp = this.txtApellido.Text;
                dbSalEmp = Convert.ToDouble(this.txtSal.Text);
                dbValPeso = Convert.ToDouble(this.txtValorP.Text);
                intAñosEmp = Convert.ToInt32(this.txtAños.Text);

                //Creamos el objeto

                clsCalcular cSal = new clsCalcular();

                //Envio de la info

                cSal.añosEmp = intAñosEmp;
                cSal.salEmp = dbSalEmp;
                cSal.valorPeso = dbValPeso;
                cSal.nomEmp = strNombre;
                cSal.apeEmp = strApeEmp;


                //Invocacion del Metodo y Tratamiento del error

                if (!cSal.Calcular())
                {
                    MessageBox.Show(cSal.Error);
                    cSal = null; // opcional
                    return;
                }

                /*if (!cSal.calcularSalarioAnual())
                {
                    MessageBox.Show(cSal.Error);
                    cSal = null; // opcional
                    return;
                }*/

                //Mostramos la informacion

                this.lbSeg.Text = cSal.valSeg.ToString();
                this.lbRet.Text = cSal.valRent.ToString();
                this.lbSalBru.Text = cSal.salBruto.ToString();
                this.lbSalNetoA.Text = cSal.salNetoA.ToString();
                //this.lbCadena.Text = cSal.Cadena.ToString();
                this.grbCalcular.Visible = true;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
