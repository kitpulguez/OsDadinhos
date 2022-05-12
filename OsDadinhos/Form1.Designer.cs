
namespace OsDadinhos
{
    partial class frmSumador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCalcularSuma = new System.Windows.Forms.Button();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtPrimerNumero = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResta = new System.Windows.Forms.TextBox();
            this.tbMultiplicacion = new System.Windows.Forms.TextBox();
            this.tbDivision = new System.Windows.Forms.TextBox();
            this.tbResto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCalcularSuma
            // 
            this.btCalcularSuma.Location = new System.Drawing.Point(277, 58);
            this.btCalcularSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalcularSuma.Name = "btCalcularSuma";
            this.btCalcularSuma.Size = new System.Drawing.Size(138, 39);
            this.btCalcularSuma.TabIndex = 0;
            this.btCalcularSuma.Text = "Calcular";
            this.btCalcularSuma.UseVisualStyleBackColor = true;
            this.btCalcularSuma.Click += new System.EventHandler(this.btCalcularSuma_Click);
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.BackColor = System.Drawing.Color.Lime;
            this.lblNumero1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumero1.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblNumero1.Location = new System.Drawing.Point(72, 26);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(89, 17);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Primer numero";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(389, 28);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(99, 15);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Segundo numero";
            // 
            // txtPrimerNumero
            // 
            this.txtPrimerNumero.Location = new System.Drawing.Point(193, 26);
            this.txtPrimerNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNumero.Name = "txtPrimerNumero";
            this.txtPrimerNumero.Size = new System.Drawing.Size(110, 23);
            this.txtPrimerNumero.TabIndex = 3;
            this.txtPrimerNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrimerNumero.TextChanged += new System.EventHandler(this.txtPrimerNumero_TextChanged);
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(303, 129);
            this.tbSuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.ReadOnly = true;
            this.tbSuma.Size = new System.Drawing.Size(110, 23);
            this.tbSuma.TabIndex = 4;
            this.tbSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSuma.TextChanged += new System.EventHandler(this.tbSuma_TextChanged);
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(520, 26);
            this.txtSegundoNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(110, 23);
            this.txtSegundoNumero.TabIndex = 5;
            this.txtSegundoNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Multiplicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Division";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resto";
            // 
            // tbResta
            // 
            this.tbResta.Location = new System.Drawing.Point(303, 171);
            this.tbResta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResta.Name = "tbResta";
            this.tbResta.ReadOnly = true;
            this.tbResta.Size = new System.Drawing.Size(110, 23);
            this.tbResta.TabIndex = 11;
            this.tbResta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMultiplicacion
            // 
            this.tbMultiplicacion.Location = new System.Drawing.Point(303, 209);
            this.tbMultiplicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMultiplicacion.Name = "tbMultiplicacion";
            this.tbMultiplicacion.ReadOnly = true;
            this.tbMultiplicacion.Size = new System.Drawing.Size(110, 23);
            this.tbMultiplicacion.TabIndex = 12;
            this.tbMultiplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDivision
            // 
            this.tbDivision.Location = new System.Drawing.Point(303, 248);
            this.tbDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.ReadOnly = true;
            this.tbDivision.Size = new System.Drawing.Size(110, 23);
            this.tbDivision.TabIndex = 13;
            this.tbDivision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResto
            // 
            this.tbResto.Location = new System.Drawing.Point(303, 283);
            this.tbResto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResto.Name = "tbResto";
            this.tbResto.ReadOnly = true;
            this.tbResto.Size = new System.Drawing.Size(110, 23);
            this.tbResto.TabIndex = 14;
            this.tbResto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmSumador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tbResto);
            this.Controls.Add(this.tbDivision);
            this.Controls.Add(this.tbMultiplicacion);
            this.Controls.Add(this.tbResta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSegundoNumero);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.txtPrimerNumero);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.btCalcularSuma);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSumador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSumador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcularSuma;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtPrimerNumero;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResta;
        private System.Windows.Forms.TextBox tbMultiplicacion;
        private System.Windows.Forms.TextBox tbDivision;
        private System.Windows.Forms.TextBox tbResto;
    }
}

