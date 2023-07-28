
namespace Punto4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.grbCalcular = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSeg = new System.Windows.Forms.Label();
            this.lbRet = new System.Windows.Forms.Label();
            this.lbSalBru = new System.Windows.Forms.Label();
            this.lbSalNetoA = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCadena = new System.Windows.Forms.Label();
            this.grbCalcular.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(215, 99);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese el valor del peso hoy:";
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(618, 52);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(100, 20);
            this.txtValorP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese su salario:";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(618, 99);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 20);
            this.txtSal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese su antiguedad:";
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(215, 146);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(49, 20);
            this.txtAños.TabIndex = 9;
            // 
            // grbCalcular
            // 
            this.grbCalcular.Controls.Add(this.lbSalNetoA);
            this.grbCalcular.Controls.Add(this.lbSalBru);
            this.grbCalcular.Controls.Add(this.lbRet);
            this.grbCalcular.Controls.Add(this.lbSeg);
            this.grbCalcular.Controls.Add(this.label9);
            this.grbCalcular.Controls.Add(this.label8);
            this.grbCalcular.Controls.Add(this.label7);
            this.grbCalcular.Controls.Add(this.label6);
            this.grbCalcular.Location = new System.Drawing.Point(40, 183);
            this.grbCalcular.Name = "grbCalcular";
            this.grbCalcular.Size = new System.Drawing.Size(544, 190);
            this.grbCalcular.TabIndex = 10;
            this.grbCalcular.TabStop = false;
            this.grbCalcular.Text = "Su salario es:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seguridad Social:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Retenciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Salario Bruto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Salario Neto Anual:";
            // 
            // lbSeg
            // 
            this.lbSeg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSeg.Location = new System.Drawing.Point(242, 23);
            this.lbSeg.Name = "lbSeg";
            this.lbSeg.Size = new System.Drawing.Size(244, 23);
            this.lbSeg.TabIndex = 4;
            // 
            // lbRet
            // 
            this.lbRet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRet.Location = new System.Drawing.Point(242, 67);
            this.lbRet.Name = "lbRet";
            this.lbRet.Size = new System.Drawing.Size(244, 23);
            this.lbRet.TabIndex = 5;
            // 
            // lbSalBru
            // 
            this.lbSalBru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSalBru.Location = new System.Drawing.Point(242, 109);
            this.lbSalBru.Name = "lbSalBru";
            this.lbSalBru.Size = new System.Drawing.Size(244, 23);
            this.lbSalBru.TabIndex = 6;
            // 
            // lbSalNetoA
            // 
            this.lbSalNetoA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSalNetoA.Location = new System.Drawing.Point(242, 154);
            this.lbSalNetoA.Name = "lbSalNetoA";
            this.lbSalNetoA.Size = new System.Drawing.Size(244, 23);
            this.lbSalNetoA.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(149, 391);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(306, 391);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 40);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(458, 391);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(103, 40);
            this.btnTerminar.TabIndex = 13;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Calculo Salarios";
            // 
            // lbCadena
            // 
            this.lbCadena.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCadena.Location = new System.Drawing.Point(605, 183);
            this.lbCadena.Name = "lbCadena";
            this.lbCadena.Size = new System.Drawing.Size(133, 190);
            this.lbCadena.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(755, 452);
            this.Controls.Add(this.lbCadena);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbCalcular);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Su salario es:";
            this.grbCalcular.ResumeLayout(false);
            this.grbCalcular.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAños;
        private System.Windows.Forms.GroupBox grbCalcular;
        private System.Windows.Forms.Label lbSalNetoA;
        private System.Windows.Forms.Label lbSalBru;
        private System.Windows.Forms.Label lbRet;
        private System.Windows.Forms.Label lbSeg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCadena;
    }
}

