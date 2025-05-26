namespace FigurasGeometricas
{
    partial class Romboide
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
            this.lblLadoLat = new System.Windows.Forms.Label();
            this.txtLadoLateral = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.grbPicture = new System.Windows.Forms.GroupBox();
            this.picBoxGrafico = new System.Windows.Forms.PictureBox();
            this.grbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLadoLat
            // 
            this.lblLadoLat.AutoSize = true;
            this.lblLadoLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoLat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLadoLat.Location = new System.Drawing.Point(272, 97);
            this.lblLadoLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLadoLat.Name = "lblLadoLat";
            this.lblLadoLat.Size = new System.Drawing.Size(164, 20);
            this.lblLadoLat.TabIndex = 105;
            this.lblLadoLat.Text = "Ingrese el lado lateral:";
            // 
            // txtLadoLateral
            // 
            this.txtLadoLateral.Location = new System.Drawing.Point(444, 100);
            this.txtLadoLateral.Margin = new System.Windows.Forms.Padding(2);
            this.txtLadoLateral.Name = "txtLadoLateral";
            this.txtLadoLateral.Size = new System.Drawing.Size(106, 20);
            this.txtLadoLateral.TabIndex = 104;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAltura.Location = new System.Drawing.Point(272, 59);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(127, 20);
            this.lblAltura.TabIndex = 103;
            this.lblAltura.Text = "Ingrese la altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(444, 59);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(106, 20);
            this.txtAltura.TabIndex = 102;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(378, 224);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(135, 20);
            this.txtPerimetro.TabIndex = 101;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(378, 195);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(135, 20);
            this.txtArea.TabIndex = 100;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerimetro.Location = new System.Drawing.Point(297, 221);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(81, 20);
            this.lblPerimetro.TabIndex = 99;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArea.Location = new System.Drawing.Point(300, 195);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 20);
            this.lblArea.TabIndex = 98;
            this.lblArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(378, 143);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 29);
            this.btnCalcular.TabIndex = 97;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(444, 22);
            this.txtBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(106, 20);
            this.txtBase.TabIndex = 96;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBase.Location = new System.Drawing.Point(272, 22);
            this.lblBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(122, 20);
            this.lblBase.TabIndex = 95;
            this.lblBase.Text = "Ingrese la base:";
            // 
            // grbPicture
            // 
            this.grbPicture.Controls.Add(this.picBoxGrafico);
            this.grbPicture.Location = new System.Drawing.Point(104, 258);
            this.grbPicture.Name = "grbPicture";
            this.grbPicture.Size = new System.Drawing.Size(633, 286);
            this.grbPicture.TabIndex = 106;
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
            // Romboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(782, 564);
            this.Controls.Add(this.grbPicture);
            this.Controls.Add(this.lblLadoLat);
            this.Controls.Add(this.txtLadoLateral);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Name = "Romboide";
            this.Text = "Romboide";
            this.grbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoLat;
        private System.Windows.Forms.TextBox txtLadoLateral;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.GroupBox grbPicture;
        private System.Windows.Forms.PictureBox picBoxGrafico;
    }
}