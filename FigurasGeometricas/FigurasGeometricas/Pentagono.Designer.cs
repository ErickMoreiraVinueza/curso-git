namespace FigurasGeometricas
{
    partial class Pentagono
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
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.grbPicture = new System.Windows.Forms.GroupBox();
            this.picBoxGrafico = new System.Windows.Forms.PictureBox();
            this.grbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(342, 197);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(135, 20);
            this.txtPerimetro.TabIndex = 94;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(342, 168);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(135, 20);
            this.txtArea.TabIndex = 93;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerimetro.Location = new System.Drawing.Point(261, 194);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(81, 20);
            this.lblPerimetro.TabIndex = 92;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Location = new System.Drawing.Point(264, 168);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 91;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(342, 116);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 29);
            this.btnCalcular.TabIndex = 90;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLado.Location = new System.Drawing.Point(242, 64);
            this.lblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(117, 20);
            this.lblLado.TabIndex = 89;
            this.lblLado.Text = "Ingrese el lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(410, 64);
            this.txtLado.Margin = new System.Windows.Forms.Padding(2);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(106, 20);
            this.txtLado.TabIndex = 88;
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApotema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApotema.Location = new System.Drawing.Point(242, 24);
            this.lblApotema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(150, 20);
            this.lblApotema.TabIndex = 87;
            this.lblApotema.Text = "Ingrese la apotema:";
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(410, 24);
            this.txtApotema.Margin = new System.Windows.Forms.Padding(2);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(106, 20);
            this.txtApotema.TabIndex = 86;
            // 
            // grbPicture
            // 
            this.grbPicture.Controls.Add(this.picBoxGrafico);
            this.grbPicture.Location = new System.Drawing.Point(68, 238);
            this.grbPicture.Name = "grbPicture";
            this.grbPicture.Size = new System.Drawing.Size(633, 286);
            this.grbPicture.TabIndex = 95;
            this.grbPicture.TabStop = false;
            this.grbPicture.Text = "Grafico";
            // 
            // picBoxGrafico
            // 
            this.picBoxGrafico.Location = new System.Drawing.Point(7, 19);
            this.picBoxGrafico.Name = "picBoxGrafico";
            this.picBoxGrafico.Size = new System.Drawing.Size(620, 261);
            this.picBoxGrafico.TabIndex = 0;
            this.picBoxGrafico.TabStop = false;
            // 
            // Pentagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(762, 536);
            this.Controls.Add(this.grbPicture);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblApotema);
            this.Controls.Add(this.txtApotema);
            this.Name = "Pentagono";
            this.Text = "Pentagono";
            this.grbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.GroupBox grbPicture;
        private System.Windows.Forms.PictureBox picBoxGrafico;
    }
}