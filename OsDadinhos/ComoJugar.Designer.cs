
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalirInstrucciones
            // 
            this.btSalirInstrucciones.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalirInstrucciones.Location = new System.Drawing.Point(547, 662);
            this.btSalirInstrucciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalirInstrucciones.Name = "btSalirInstrucciones";
            this.btSalirInstrucciones.Size = new System.Drawing.Size(144, 49);
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
            this.lbInstrucciones.Location = new System.Drawing.Point(36, 118);
            this.lbInstrucciones.MaximumSize = new System.Drawing.Size(1409, 0);
            this.lbInstrucciones.Name = "lbInstrucciones";
            this.lbInstrucciones.Size = new System.Drawing.Size(1407, 544);
            this.lbInstrucciones.TabIndex = 1;
            this.lbInstrucciones.Text = resources.GetString("lbInstrucciones.Text");
            this.lbInstrucciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instrucciones";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ComoJugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OsDadinhos.Properties.Resources.menuWallpaper1;
            this.ClientSize = new System.Drawing.Size(1316, 766);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInstrucciones);
            this.Controls.Add(this.btSalirInstrucciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
    }
}