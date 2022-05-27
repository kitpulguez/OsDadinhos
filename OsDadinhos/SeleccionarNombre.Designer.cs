
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
            this.LbErrorNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbElegirNombre
            // 
            this.lbElegirNombre.AutoSize = true;
            this.lbElegirNombre.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbElegirNombre.Location = new System.Drawing.Point(115, 51);
            this.lbElegirNombre.Name = "lbElegirNombre";
            this.lbElegirNombre.Size = new System.Drawing.Size(248, 40);
            this.lbElegirNombre.TabIndex = 0;
            this.lbElegirNombre.Text = "Escribe tu nombre";
            // 
            // tbElegirNombreJugador
            // 
            this.tbElegirNombreJugador.Location = new System.Drawing.Point(166, 139);
            this.tbElegirNombreJugador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbElegirNombreJugador.Name = "tbElegirNombreJugador";
            this.tbElegirNombreJugador.Size = new System.Drawing.Size(114, 27);
            this.tbElegirNombreJugador.TabIndex = 1;
            // 
            // BtConfirmarNombreJugador
            // 
            this.BtConfirmarNombreJugador.Location = new System.Drawing.Point(177, 243);
            this.BtConfirmarNombreJugador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtConfirmarNombreJugador.Name = "BtConfirmarNombreJugador";
            this.BtConfirmarNombreJugador.Size = new System.Drawing.Size(86, 31);
            this.BtConfirmarNombreJugador.TabIndex = 2;
            this.BtConfirmarNombreJugador.Text = "Aceptar";
            this.BtConfirmarNombreJugador.UseVisualStyleBackColor = true;
            this.BtConfirmarNombreJugador.Click += new System.EventHandler(this.BtConfirmarNombreJugador_Click);
            // 
            // LbErrorNombre
            // 
            this.LbErrorNombre.AutoSize = true;
            this.LbErrorNombre.Location = new System.Drawing.Point(57, 170);
            this.LbErrorNombre.Name = "LbErrorNombre";
            this.LbErrorNombre.Size = new System.Drawing.Size(50, 20);
            this.LbErrorNombre.TabIndex = 3;
            this.LbErrorNombre.Text = "label1";
            this.LbErrorNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SeleccionarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 344);
            this.Controls.Add(this.LbErrorNombre);
            this.Controls.Add(this.BtConfirmarNombreJugador);
            this.Controls.Add(this.tbElegirNombreJugador);
            this.Controls.Add(this.lbElegirNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SeleccionarNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir nombre";
            this.Load += new System.EventHandler(this.SeleccionarNombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbElegirNombre;
        private System.Windows.Forms.TextBox tbElegirNombreJugador;
        private System.Windows.Forms.Button BtConfirmarNombreJugador;
        private System.Windows.Forms.Label LbErrorNombre;
    }
}