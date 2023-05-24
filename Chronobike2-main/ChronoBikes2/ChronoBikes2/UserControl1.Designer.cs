namespace ChronoBikes2
{
    partial class UserControl1
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
            this.signINPANEL = new System.Windows.Forms.Panel();
            this.newaccount = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.LinkLabel();
            this.forgotpass = new System.Windows.Forms.LinkLabel();
            this.submit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.signIN = new System.Windows.Forms.Label();
            this.signINPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // signINPANEL
            // 
            this.signINPANEL.BackColor = System.Drawing.SystemColors.Control;
            this.signINPANEL.Controls.Add(this.newaccount);
            this.signINPANEL.Controls.Add(this.register);
            this.signINPANEL.Controls.Add(this.forgotpass);
            this.signINPANEL.Controls.Add(this.submit);
            this.signINPANEL.Controls.Add(this.textBox2);
            this.signINPANEL.Controls.Add(this.textBox1);
            this.signINPANEL.Controls.Add(this.pass);
            this.signINPANEL.Controls.Add(this.email);
            this.signINPANEL.Controls.Add(this.signIN);
            this.signINPANEL.Location = new System.Drawing.Point(3, 3);
            this.signINPANEL.Name = "signINPANEL";
            this.signINPANEL.Size = new System.Drawing.Size(302, 388);
            this.signINPANEL.TabIndex = 3;
            // 
            // newaccount
            // 
            this.newaccount.AutoSize = true;
            this.newaccount.Location = new System.Drawing.Point(63, 348);
            this.newaccount.Name = "newaccount";
            this.newaccount.Size = new System.Drawing.Size(125, 13);
            this.newaccount.TabIndex = 8;
            this.newaccount.Text = "Don\'t have an account? ";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Location = new System.Drawing.Point(194, 348);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(46, 13);
            this.register.TabIndex = 7;
            this.register.TabStop = true;
            this.register.Text = "Register";
            // 
            // forgotpass
            // 
            this.forgotpass.AutoSize = true;
            this.forgotpass.LinkColor = System.Drawing.Color.Black;
            this.forgotpass.Location = new System.Drawing.Point(175, 238);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(92, 13);
            this.forgotpass.TabIndex = 6;
            this.forgotpass.TabStop = true;
            this.forgotpass.Text = "Forgot Password?";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(101, 276);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(102, 46);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(29, 196);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(78, 16);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(29, 113);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 16);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // signIN
            // 
            this.signIN.AutoSize = true;
            this.signIN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIN.Location = new System.Drawing.Point(29, 36);
            this.signIN.Name = "signIN";
            this.signIN.Size = new System.Drawing.Size(174, 16);
            this.signIN.TabIndex = 0;
            this.signIN.Text = "Sign in to your account";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.signINPANEL);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(308, 393);
            this.signINPANEL.ResumeLayout(false);
            this.signINPANEL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signINPANEL;
        private System.Windows.Forms.Label newaccount;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.LinkLabel forgotpass;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label signIN;
    }
}
