namespace winfrom1.View
{
    partial class praktikPbo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(praktikPbo));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BtnLgn = new Button();
            BtnCancel = new Button();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(94, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(BtnLgn);
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(170, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnLgn
            // 
            BtnLgn.BackColor = Color.LightSkyBlue;
            BtnLgn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLgn.Location = new Point(199, 341);
            BtnLgn.Name = "BtnLgn";
            BtnLgn.Size = new Size(111, 41);
            BtnLgn.TabIndex = 1;
            BtnLgn.Text = "Login";
            BtnLgn.UseVisualStyleBackColor = false;
            BtnLgn.Click += BtnLgn_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.DarkRed;
            BtnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.ForeColor = SystemColors.ButtonHighlight;
            BtnCancel.Location = new Point(51, 341);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(111, 41);
            BtnCancel.TabIndex = 7;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(146, 292);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(164, 27);
            TbPassword.TabIndex = 6;
            // 
            // TbUsername
            // 
            TbUsername.Location = new Point(146, 227);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(164, 27);
            TbUsername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 163);
            label4.Name = "label4";
            label4.Size = new Size(132, 31);
            label4.TabIndex = 4;
            label4.Text = "FORM LOGIN";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseCompatibleTextRendering = true;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 292);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 227);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 139);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 1;
            label1.Text = "PPMB 2025";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // praktikPbo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.windows_chan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "praktikPbo";
            Text = "praktikPbo";
            Load += praktikPbo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }   

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox TbPassword;
        private TextBox TbUsername;
        private Button BtnLgn;
        private Button BtnCancel;
    }
}