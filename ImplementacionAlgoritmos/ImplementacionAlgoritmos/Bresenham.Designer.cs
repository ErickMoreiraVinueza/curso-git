namespace ImplementacionAlgoritmos
{
    partial class Bresenham
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuntoFinal = new System.Windows.Forms.TextBox();
            this.txtPuntoInicial = new System.Windows.Forms.TextBox();
            this.listPuntos = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.pictureBox);
            this.groupBox3.Location = new System.Drawing.Point(267, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(449, 423);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(21, 26);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(404, 367);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.btnResetear);
            this.groupBox1.Controls.Add(this.btnBresenham);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPuntoFinal);
            this.groupBox1.Controls.Add(this.txtPuntoInicial);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(241, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectas";
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Yellow;
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(73, 168);
            this.btnResetear.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(91, 26);
            this.btnResetear.TabIndex = 7;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnBresenham
            // 
            this.btnBresenham.BackColor = System.Drawing.Color.LightBlue;
            this.btnBresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenham.Location = new System.Drawing.Point(37, 135);
            this.btnBresenham.Margin = new System.Windows.Forms.Padding(2);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(162, 29);
            this.btnBresenham.TabIndex = 5;
            this.btnBresenham.Text = "Bresenham";
            this.btnBresenham.UseVisualStyleBackColor = false;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Punto final (\"x,y\")";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punto inicial (\"x,y\")";
            // 
            // txtPuntoFinal
            // 
            this.txtPuntoFinal.BackColor = System.Drawing.Color.White;
            this.txtPuntoFinal.Location = new System.Drawing.Point(136, 84);
            this.txtPuntoFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuntoFinal.Name = "txtPuntoFinal";
            this.txtPuntoFinal.Size = new System.Drawing.Size(70, 20);
            this.txtPuntoFinal.TabIndex = 1;
            // 
            // txtPuntoInicial
            // 
            this.txtPuntoInicial.BackColor = System.Drawing.Color.White;
            this.txtPuntoInicial.Location = new System.Drawing.Point(44, 84);
            this.txtPuntoInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuntoInicial.Name = "txtPuntoInicial";
            this.txtPuntoInicial.Size = new System.Drawing.Size(70, 20);
            this.txtPuntoInicial.TabIndex = 0;
            // 
            // listPuntos
            // 
            this.listPuntos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listPuntos.FormattingEnabled = true;
            this.listPuntos.Location = new System.Drawing.Point(16, 231);
            this.listPuntos.Name = "listPuntos";
            this.listPuntos.Size = new System.Drawing.Size(201, 563);
            this.listPuntos.TabIndex = 23;
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 802);
            this.Controls.Add(this.listPuntos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bresenham";
            this.Text = "Bresenham";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuntoFinal;
        private System.Windows.Forms.TextBox txtPuntoInicial;
        private System.Windows.Forms.ListBox listPuntos;
    }
}