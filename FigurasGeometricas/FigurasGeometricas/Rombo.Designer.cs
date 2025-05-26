namespace FigurasGeometricas
{
    partial class Rombo
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
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDiagonalMenor = new System.Windows.Forms.Label();
            this.txtDiagonalMenor = new System.Windows.Forms.TextBox();
            this.txtDiagonalMayor = new System.Windows.Forms.TextBox();
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.grbPicture = new System.Windows.Forms.GroupBox();
            this.picBoxGrafico = new System.Windows.Forms.PictureBox();
            this.grbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLado.Location = new System.Drawing.Point(235, 100);
            this.lblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(117, 20);
            this.lblLado.TabIndex = 87;
            this.lblLado.Text = "Ingrese el lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(439, 100);
            this.txtLado.Margin = new System.Windows.Forms.Padding(2);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(106, 20);
            this.txtLado.TabIndex = 86;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(365, 222);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(135, 20);
            this.txtPerimetro.TabIndex = 85;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(365, 193);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(135, 20);
            this.txtArea.TabIndex = 84;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerimetro.Location = new System.Drawing.Point(283, 219);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(81, 20);
            this.lblPerimetro.TabIndex = 83;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Location = new System.Drawing.Point(287, 193);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 82;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(365, 141);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 29);
            this.btnCalcular.TabIndex = 81;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDiagonalMenor
            // 
            this.lblDiagonalMenor.AutoSize = true;
            this.lblDiagonalMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonalMenor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiagonalMenor.Location = new System.Drawing.Point(235, 60);
            this.lblDiagonalMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagonalMenor.Name = "lblDiagonalMenor";
            this.lblDiagonalMenor.Size = new System.Drawing.Size(196, 20);
            this.lblDiagonalMenor.TabIndex = 80;
            this.lblDiagonalMenor.Text = "Ingrese la diagonal menor:";
            // 
            // txtDiagonalMenor
            // 
            this.txtDiagonalMenor.Location = new System.Drawing.Point(439, 60);
            this.txtDiagonalMenor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiagonalMenor.Name = "txtDiagonalMenor";
            this.txtDiagonalMenor.Size = new System.Drawing.Size(106, 20);
            this.txtDiagonalMenor.TabIndex = 79;
            // 
            // txtDiagonalMayor
            // 
            this.txtDiagonalMayor.Location = new System.Drawing.Point(439, 24);
            this.txtDiagonalMayor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiagonalMayor.Name = "txtDiagonalMayor";
            this.txtDiagonalMayor.Size = new System.Drawing.Size(106, 20);
            this.txtDiagonalMayor.TabIndex = 78;
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.AutoSize = true;
            this.lblBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaseMayor.Location = new System.Drawing.Point(235, 21);
            this.lblBaseMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(194, 20);
            this.lblBaseMayor.TabIndex = 77;
            this.lblBaseMayor.Text = "Ingrese la diagonal mayor:";
            // 
            // grbPicture
            // 
            this.grbPicture.Controls.Add(this.picBoxGrafico);
            this.grbPicture.Location = new System.Drawing.Point(104, 266);
            this.grbPicture.Name = "grbPicture";
            this.grbPicture.Size = new System.Drawing.Size(633, 267);
            this.grbPicture.TabIndex = 88;
            this.grbPicture.TabStop = false;
            this.grbPicture.Text = "Grafico";
            // 
            // picBoxGrafico
            // 
            this.picBoxGrafico.Location = new System.Drawing.Point(7, 19);
            this.picBoxGrafico.Name = "picBoxGrafico";
            this.picBoxGrafico.Size = new System.Drawing.Size(620, 240);
            this.picBoxGrafico.TabIndex = 0;
            this.picBoxGrafico.TabStop = false;
            // 
            // Rombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.grbPicture);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDiagonalMenor);
            this.Controls.Add(this.txtDiagonalMenor);
            this.Controls.Add(this.txtDiagonalMayor);
            this.Controls.Add(this.lblBaseMayor);
            this.Name = "Rombo";
            this.Text = "Rombo";
            this.grbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDiagonalMenor;
        private System.Windows.Forms.TextBox txtDiagonalMenor;
        private System.Windows.Forms.TextBox txtDiagonalMayor;
        private System.Windows.Forms.Label lblBaseMayor;
        private System.Windows.Forms.GroupBox grbPicture;
        private System.Windows.Forms.PictureBox picBoxGrafico;
    }
}