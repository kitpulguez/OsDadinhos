
namespace OsDadinhos
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.btUnJugador = new System.Windows.Forms.Button();
            this.btComoJugar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUnJugador
            // 
            this.btUnJugador.Location = new System.Drawing.Point(93, 106);
            this.btUnJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUnJugador.Name = "btUnJugador";
            this.btUnJugador.Size = new System.Drawing.Size(82, 25);
            this.btUnJugador.TabIndex = 0;
            this.btUnJugador.Text = "Jugar";
            this.btUnJugador.UseVisualStyleBackColor = true;
            this.btUnJugador.Click += new System.EventHandler(this.BtUnJugador);
            // 
            // btComoJugar
            // 
            this.btComoJugar.Location = new System.Drawing.Point(93, 158);
            this.btComoJugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btComoJugar.Name = "btComoJugar";
            this.btComoJugar.Size = new System.Drawing.Size(114, 24);
            this.btComoJugar.TabIndex = 2;
            this.btComoJugar.Text = "Cómo jugar";
            this.btComoJugar.UseVisualStyleBackColor = true;
            this.btComoJugar.Click += new System.EventHandler(this.BtComoJugar);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(93, 253);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(82, 22);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.BtSalir);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.Location = new System.Drawing.Point(340, 23);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(198, 45);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Os dadinhos";
            // 
            // btRanking
            // 
            this.btRanking.Location = new System.Drawing.Point(93, 204);
            this.btRanking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRanking.Name = "btRanking";
            this.btRanking.Size = new System.Drawing.Size(82, 24);
            this.btRanking.TabIndex = 5;
            this.btRanking.Text = "Ranking";
            this.btRanking.UseVisualStyleBackColor = true;
            this.btRanking.Click += new System.EventHandler(this.BtRanking_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(970, 533);
            this.Controls.Add(this.btRanking);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btComoJugar);
            this.Controls.Add(this.btUnJugador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(986, 572);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(986, 572);
            this.Name = "MenuInicio";
            this.Text = "Os Dadinhos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUnJugador;
        private System.Windows.Forms.Button btComoJugar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btRanking;
    }
}

