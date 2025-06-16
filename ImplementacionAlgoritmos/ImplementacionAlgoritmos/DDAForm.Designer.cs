namespace ImplementacionAlgoritmos
{
    partial class DDAForm
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
            this.listPuntos = new System.Windows.Forms.ListBox();
            this.picGrafico = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.txtYi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPuntos
            // 
            this.listPuntos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listPuntos.FormattingEnabled = true;
            this.listPuntos.Location = new System.Drawing.Point(12, 12);
            this.listPuntos.Name = "listPuntos";
            this.listPuntos.Size = new System.Drawing.Size(201, 563);
            this.listPuntos.TabIndex = 22;
            // 
            // picGrafico
            // 
            this.picGrafico.Location = new System.Drawing.Point(6, 19);
            this.picGrafico.Name = "picGrafico";
            this.picGrafico.Size = new System.Drawing.Size(538, 400);
            this.picGrafico.TabIndex = 0;
            this.picGrafico.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(411, 115);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picGrafico);
            this.groupBox1.Location = new System.Drawing.Point(238, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 426);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(449, 69);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 20);
            this.txtYf.TabIndex = 18;
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(449, 25);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(100, 20);
            this.txtYi.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yi";
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(276, 61);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 20);
            this.txtXf.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Xf";
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(276, 27);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 20);
            this.txtXi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Yf";
            // 
            // DDAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listPuntos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYf);
            this.Controls.Add(this.txtYi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.label1);
            this.Name = "DDAForm";
            this.Text = "DDAForm";
            ((System.ComponentModel.ISupportInitialize)(this.picGrafico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPuntos;
        private System.Windows.Forms.PictureBox picGrafico;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}