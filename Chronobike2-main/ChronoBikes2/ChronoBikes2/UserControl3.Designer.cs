namespace ChronoBikes2
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderNOW = new System.Windows.Forms.Button();
            this.smallinfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frames = new System.Windows.Forms.Button();
            this.tires = new System.Windows.Forms.Button();
            this.wheels = new System.Windows.Forms.Button();
            this.seats = new System.Windows.Forms.Button();
            this.handleBAR = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.smallinfo);
            this.panel1.Controls.Add(this.orderNOW);
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 188);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // orderNOW
            // 
            this.orderNOW.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNOW.Location = new System.Drawing.Point(48, 74);
            this.orderNOW.Name = "orderNOW";
            this.orderNOW.Size = new System.Drawing.Size(197, 37);
            this.orderNOW.TabIndex = 1;
            this.orderNOW.Text = "Order Now!";
            this.orderNOW.UseVisualStyleBackColor = true;
            // 
            // smallinfo
            // 
            this.smallinfo.AutoSize = true;
            this.smallinfo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallinfo.Location = new System.Drawing.Point(43, 35);
            this.smallinfo.Name = "smallinfo";
            this.smallinfo.Size = new System.Drawing.Size(351, 25);
            this.smallinfo.TabIndex = 1;
            this.smallinfo.Text = "Start customizing your bike now";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(498, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frames
            // 
            this.frames.BackColor = System.Drawing.SystemColors.Control;
            this.frames.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frames.Location = new System.Drawing.Point(221, 232);
            this.frames.Name = "frames";
            this.frames.Size = new System.Drawing.Size(120, 37);
            this.frames.TabIndex = 5;
            this.frames.Text = "Frames";
            this.frames.UseVisualStyleBackColor = false;
            // 
            // tires
            // 
            this.tires.BackColor = System.Drawing.SystemColors.Control;
            this.tires.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tires.Location = new System.Drawing.Point(54, 232);
            this.tires.Name = "tires";
            this.tires.Size = new System.Drawing.Size(120, 37);
            this.tires.TabIndex = 7;
            this.tires.Text = "Tires";
            this.tires.UseVisualStyleBackColor = false;
            // 
            // wheels
            // 
            this.wheels.BackColor = System.Drawing.SystemColors.Control;
            this.wheels.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheels.Location = new System.Drawing.Point(709, 232);
            this.wheels.Name = "wheels";
            this.wheels.Size = new System.Drawing.Size(120, 37);
            this.wheels.TabIndex = 8;
            this.wheels.Text = "Wheels";
            this.wheels.UseVisualStyleBackColor = false;
            // 
            // seats
            // 
            this.seats.BackColor = System.Drawing.SystemColors.Control;
            this.seats.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats.Location = new System.Drawing.Point(392, 232);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(120, 37);
            this.seats.TabIndex = 8;
            this.seats.Text = "Seats";
            this.seats.UseVisualStyleBackColor = false;
            // 
            // handleBAR
            // 
            this.handleBAR.BackColor = System.Drawing.SystemColors.Control;
            this.handleBAR.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleBAR.Location = new System.Drawing.Point(557, 232);
            this.handleBAR.Name = "handleBAR";
            this.handleBAR.Size = new System.Drawing.Size(120, 37);
            this.handleBAR.TabIndex = 9;
            this.handleBAR.Text = "Handle Bars";
            this.handleBAR.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.handleBAR);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.wheels);
            this.Controls.Add(this.tires);
            this.Controls.Add(this.frames);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(870, 519);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label smallinfo;
        private System.Windows.Forms.Button orderNOW;
        private System.Windows.Forms.Button frames;
        private System.Windows.Forms.Button tires;
        private System.Windows.Forms.Button wheels;
        private System.Windows.Forms.Button seats;
        private System.Windows.Forms.Button handleBAR;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
