namespace PYATAYALABA
{
    partial class fond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fond));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sumPozh = new System.Windows.Forms.Label();
            this.textSUM = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-121, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sumPozh
            // 
            this.sumPozh.AutoSize = true;
            this.sumPozh.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumPozh.ForeColor = System.Drawing.Color.White;
            this.sumPozh.Location = new System.Drawing.Point(12, 452);
            this.sumPozh.Name = "sumPozh";
            this.sumPozh.Size = new System.Drawing.Size(192, 23);
            this.sumPozh.TabIndex = 36;
            this.sumPozh.Text = "Сумма пожертвования:";
            // 
            // textSUM
            // 
            this.textSUM.BackColor = System.Drawing.Color.Black;
            this.textSUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSUM.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSUM.ForeColor = System.Drawing.Color.White;
            this.textSUM.Location = new System.Drawing.Point(209, 450);
            this.textSUM.Margin = new System.Windows.Forms.Padding(2);
            this.textSUM.Name = "textSUM";
            this.textSUM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSUM.Size = new System.Drawing.Size(164, 32);
            this.textSUM.TabIndex = 37;
            // 
            // l1
            // 
            this.l1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.l1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l1.FlatAppearance.BorderSize = 0;
            this.l1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.ForeColor = System.Drawing.Color.SpringGreen;
            this.l1.Location = new System.Drawing.Point(377, 450);
            this.l1.Margin = new System.Windows.Forms.Padding(2);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(266, 32);
            this.l1.TabIndex = 38;
            this.l1.Text = "Отправить";
            this.l1.UseVisualStyleBackColor = false;
            this.l1.Click += new System.EventHandler(this.l1_Click);
            // 
            // fond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(654, 490);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.textSUM);
            this.Controls.Add(this.sumPozh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fond";
            this.Text = "fond";
            this.Load += new System.EventHandler(this.fond_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sumPozh;
        private System.Windows.Forms.TextBox textSUM;
        private System.Windows.Forms.Button l1;
    }
}