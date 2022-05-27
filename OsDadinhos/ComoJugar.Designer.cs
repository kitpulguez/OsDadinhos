
namespace OsDadinhos
{
    partial class ComoJugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComoJugar));
            this.btSalirInstrucciones = new System.Windows.Forms.Button();
            this.lbInstrucciones = new System.Windows.Forms.Label();
            this.lbInstruccionesTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalirInstrucciones
            // 
            this.btSalirInstrucciones.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalirInstrucciones.Location = new System.Drawing.Point(625, 883);
            this.btSalirInstrucciones.Name = "btSalirInstrucciones";
            this.btSalirInstrucciones.Size = new System.Drawing.Size(165, 65);
            this.btSalirInstrucciones.TabIndex = 0;
            this.btSalirInstrucciones.Text = "Salir";
            this.btSalirInstrucciones.UseVisualStyleBackColor = true;
            this.btSalirInstrucciones.Click += new System.EventHandler(this.BtSalirInstrucciones);
            // 
            // lbInstrucciones
            // 
            this.lbInstrucciones.AutoSize = true;
            this.lbInstrucciones.BackColor = System.Drawing.Color.Black;
            this.lbInstrucciones.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInstrucciones.ForeColor = System.Drawing.Color.White;
            this.lbInstrucciones.Location = new System.Drawing.Point(41, 157);
            this.lbInstrucciones.MaximumSize = new System.Drawing.Size(1610, 0);
            this.lbInstrucciones.Name = "lbInstrucciones";
            this.lbInstrucciones.Size = new System.Drawing.Size(1603, 697);
            this.lbInstrucciones.TabIndex = 1;
            this.lbInstrucciones.Text = resources.GetString("lbInstrucciones.Text");
            // 
            // lbInstruccionesTitulo
            // 
            this.lbInstruccionesTitulo.AutoSize = true;
            this.lbInstruccionesTitulo.BackColor = System.Drawing.Color.Gray;
            this.lbInstruccionesTitulo.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInstruccionesTitulo.Location = new System.Drawing.Point(506, 47);
            this.lbInstruccionesTitulo.Name = "lbInstruccionesTitulo";
            this.lbInstruccionesTitulo.Size = new System.Drawing.Size(336, 66);
            this.lbInstruccionesTitulo.TabIndex = 2;
            this.lbInstruccionesTitulo.Text = "Instrucciones";
            // 
            // ComoJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OsDadinhos.Properties.Resources.menuWallpaper1;
            this.ClientSize = new System.Drawing.Size(1504, 1021);
            this.Controls.Add(this.lbInstruccionesTitulo);
            this.Controls.Add(this.lbInstrucciones);
            this.Controls.Add(this.btSalirInstrucciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComoJugar";
            this.Text = "Como jugar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComoJugar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalirInstrucciones;
        private System.Windows.Forms.Label lbInstrucciones;
        private System.Windows.Forms.Label lbInstruccionesTitulo;
    }
}