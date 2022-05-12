
namespace RendimentoVeicular.View
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimentos = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.tbxKM = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.tbxRendimentos = new System.Windows.Forms.TextBox();
            this.tbxConsumo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(112, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(521, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo De Combustivel ";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(146, 127);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(28, 15);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "KM:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(146, 212);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "Litros";
            this.lblLitros.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRendimentos
            // 
            this.lblRendimentos.AutoSize = true;
            this.lblRendimentos.Location = new System.Drawing.Point(539, 127);
            this.lblRendimentos.Name = "lblRendimentos";
            this.lblRendimentos.Size = new System.Drawing.Size(126, 15);
            this.lblRendimentos.TabIndex = 3;
            this.lblRendimentos.Text = "Rendimento-KM/litros";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(539, 212);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(118, 15);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Consumo - Litos/KM";
            // 
            // tbxKM
            // 
            this.tbxKM.Location = new System.Drawing.Point(112, 158);
            this.tbxKM.Name = "tbxKM";
            this.tbxKM.Size = new System.Drawing.Size(100, 23);
            this.tbxKM.TabIndex = 5;
            // 
            // tbxLitros
            // 
            this.tbxLitros.Location = new System.Drawing.Point(112, 246);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(100, 23);
            this.tbxLitros.TabIndex = 6;
            // 
            // tbxRendimentos
            // 
            this.tbxRendimentos.Location = new System.Drawing.Point(539, 158);
            this.tbxRendimentos.Name = "tbxRendimentos";
            this.tbxRendimentos.Size = new System.Drawing.Size(126, 23);
            this.tbxRendimentos.TabIndex = 7;
            // 
            // tbxConsumo
            // 
            this.tbxConsumo.Location = new System.Drawing.Point(539, 246);
            this.tbxConsumo.Name = "tbxConsumo";
            this.tbxConsumo.Size = new System.Drawing.Size(126, 23);
            this.tbxConsumo.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(268, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(238, 51);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RendimentoVeicular.Properties.Resources.gas_86324__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(209, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxConsumo);
            this.Controls.Add(this.tbxRendimentos);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxKM);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRendimentos);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Sistema de consumo de Combustivel";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimentos;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox tbxKM;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.TextBox tbxRendimentos;
        private System.Windows.Forms.TextBox tbxConsumo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}