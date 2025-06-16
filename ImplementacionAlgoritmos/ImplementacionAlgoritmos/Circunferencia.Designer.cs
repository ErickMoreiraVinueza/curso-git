namespace ImplementacionAlgoritmos
{
    partial class Circunferencia
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picLienzo = new System.Windows.Forms.PictureBox();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Resetear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.SystemColors.Info;
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(47, 212);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(186, 32);
            this.btnDibujar.TabIndex = 7;
            this.btnDibujar.Text = "Graficar";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Radio:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picLienzo);
            this.groupBox3.Location = new System.Drawing.Point(283, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(331, 337);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // picLienzo
            // 
            this.picLienzo.Location = new System.Drawing.Point(13, 17);
            this.picLienzo.Margin = new System.Windows.Forms.Padding(2);
            this.picLienzo.Name = "picLienzo";
            this.picLienzo.Size = new System.Drawing.Size(310, 306);
            this.picLienzo.TabIndex = 0;
            this.picLienzo.TabStop = false;
            // 
            // txtCentroY
            // 
            this.txtCentroY.Location = new System.Drawing.Point(108, 81);
            this.txtCentroY.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(76, 20);
            this.txtCentroY.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Centro X:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(108, 131);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(2);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(76, 20);
            this.txtRadio.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Centro Y:";
            // 
            // txtCentroX
            // 
            this.txtCentroX.Location = new System.Drawing.Point(108, 35);
            this.txtCentroX.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(76, 20);
            this.txtCentroX.TabIndex = 8;
            // 
            // Circunferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtCentroY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCentroX);
            this.Name = "Circunferencia";
            this.Text = "Circunferencia";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picLienzo;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCentroX;
    }
}