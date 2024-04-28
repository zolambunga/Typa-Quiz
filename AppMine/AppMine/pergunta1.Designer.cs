namespace AppMine
{
    partial class pergunta1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElon = new System.Windows.Forms.Button();
            this.btnDrac = new System.Windows.Forms.Button();
            this.btnTesla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEVEL 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppMine.Properties.Resources.nikola_tesla;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(258, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 274);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(440, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESTE É:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnElon
            // 
            this.btnElon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnElon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElon.Location = new System.Drawing.Point(258, 366);
            this.btnElon.Name = "btnElon";
            this.btnElon.Size = new System.Drawing.Size(419, 34);
            this.btnElon.TabIndex = 3;
            this.btnElon.Text = "Elon Musk";
            this.btnElon.UseVisualStyleBackColor = false;
            this.btnElon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDrac
            // 
            this.btnDrac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDrac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrac.Location = new System.Drawing.Point(258, 422);
            this.btnDrac.Name = "btnDrac";
            this.btnDrac.Size = new System.Drawing.Size(419, 34);
            this.btnDrac.TabIndex = 4;
            this.btnDrac.Text = "Drácula";
            this.btnDrac.UseVisualStyleBackColor = false;
            this.btnDrac.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTesla
            // 
            this.btnTesla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesla.Location = new System.Drawing.Point(258, 475);
            this.btnTesla.Name = "btnTesla";
            this.btnTesla.Size = new System.Drawing.Size(419, 34);
            this.btnTesla.TabIndex = 5;
            this.btnTesla.Text = "Nikola Tesla";
            this.btnTesla.UseVisualStyleBackColor = false;
            this.btnTesla.Click += new System.EventHandler(this.button3_Click);
            // 
            // pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Controls.Add(this.btnTesla);
            this.Controls.Add(this.btnDrac);
            this.Controls.Add(this.btnElon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Name = "pergunta1";
            this.Size = new System.Drawing.Size(951, 577);
            this.Load += new System.EventHandler(this.pergunta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElon;
        private System.Windows.Forms.Button btnDrac;
        private System.Windows.Forms.Button btnTesla;
    }
}
