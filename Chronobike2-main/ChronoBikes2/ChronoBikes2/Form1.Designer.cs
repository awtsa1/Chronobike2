namespace ChronoBikes2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signinBTN = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.signupBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControl21 = new ChronoBikes2.UserControl2();
            this.userControl11 = new ChronoBikes2.UserControl1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.signupBTN);
            this.panel1.Controls.Add(this.signinBTN);
            this.panel1.Location = new System.Drawing.Point(644, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 34);
            this.panel1.TabIndex = 0;
            // 
            // signinBTN
            // 
            this.signinBTN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinBTN.Location = new System.Drawing.Point(11, 3);
            this.signinBTN.Name = "signinBTN";
            this.signinBTN.Size = new System.Drawing.Size(99, 28);
            this.signinBTN.TabIndex = 0;
            this.signinBTN.Text = "Sign in";
            this.signinBTN.UseVisualStyleBackColor = true;
            this.signinBTN.Click += new System.EventHandler(this.signinBTN_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Futura Maxi CG Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(60, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 22);
            this.title.TabIndex = 1;
            this.title.Text = "Chrono Bikes";
            // 
            // signupBTN
            // 
            this.signupBTN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBTN.Location = new System.Drawing.Point(116, 3);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.Size = new System.Drawing.Size(99, 28);
            this.signupBTN.TabIndex = 1;
            this.signupBTN.Text = "Sign up";
            this.signupBTN.UseVisualStyleBackColor = true;
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 49);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 39);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 522);
            this.panel3.TabIndex = 5;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(185, 53);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(553, 487);
            this.userControl21.TabIndex = 4;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(290, 114);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(308, 393);
            this.userControl11.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 574);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Chrono Bikes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signupBTN;
        private System.Windows.Forms.Button signinBTN;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private UserControl1 userControl11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl2 userControl21;
        private System.Windows.Forms.Panel panel3;
    }
}

