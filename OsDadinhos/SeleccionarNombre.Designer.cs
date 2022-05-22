
namespace OsDadinhos
{
    partial class SeleccionarNombre
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
            this.lbElegirNombre = new System.Windows.Forms.Label();
            this.tbElegirNombreJugador = new System.Windows.Forms.TextBox();
            this.BtConfirmarNombreJugador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbElegirNombre
            // 
            this.lbElegirNombre.AutoSize = true;
            this.lbElegirNombre.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbElegirNombre.Location = new System.Drawing.Point(101, 38);
            this.lbElegirNombre.Name = "lbElegirNombre";
            this.lbElegirNombre.Size = new System.Drawing.Size(200, 31);
            this.lbElegirNombre.TabIndex = 0;
            this.lbElegirNombre.Text = "Escribe tu nombre";
            // 
            // tbElegirNombreJugador
            // 
            this.tbElegirNombreJugador.Location = new System.Drawing.Point(145, 104);
            this.tbElegirNombreJugador.Name = "tbElegirNombreJugador";
            this.tbElegirNombreJugador.Size = new System.Drawing.Size(100, 23);
            this.tbElegirNombreJugador.TabIndex = 1;
            // 
            // BtConfirmarNombreJugador
            // 
            this.BtConfirmarNombreJugador.Location = new System.Drawing.Point(155, 182);
            this.BtConfirmarNombreJugador.Name = "BtConfirmarNombreJugador";
            this.BtConfirmarNombreJugador.Size = new System.Drawing.Size(75, 23);
            this.BtConfirmarNombreJugador.TabIndex = 2;
            this.BtConfirmarNombreJugador.Text = "Aceptar";
            this.BtConfirmarNombreJugador.UseVisualStyleBackColor = true;
            this.BtConfirmarNombreJugador.Click += new System.EventHandler(this.BtConfirmarNombreJugador_Click);
            // 
            // SeleccionarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 258);
            this.Controls.Add(this.BtConfirmarNombreJugador);
            this.Controls.Add(this.tbElegirNombreJugador);
            this.Controls.Add(this.lbElegirNombre);
            this.Name = "SeleccionarNombre";
            this.Text = "Elegir nombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbElegirNombre;
        private System.Windows.Forms.TextBox tbElegirNombreJugador;
        private System.Windows.Forms.Button BtConfirmarNombreJugador;
    }
}