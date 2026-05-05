using System.ComponentModel;

namespace winfrom1.ViewPraktikPbo
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            label1Dashboard = new Label();
            DgUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // label1Dashboard
            // 
            label1Dashboard.AutoSize = true;
            label1Dashboard.BackColor = Color.Transparent;
            label1Dashboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1Dashboard.ForeColor = SystemColors.ButtonFace;
            label1Dashboard.Location = new Point(45, 47);
            label1Dashboard.Name = "label1Dashboard";
            label1Dashboard.Size = new Size(279, 46);
            label1Dashboard.TabIndex = 0;
            label1Dashboard.Text = "Selamat Datang";
            label1Dashboard.Click += label1_Click;
            // 
            // DgUser
            // 
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(12, 119);
            DgUser.Name = "DgUser";
            DgUser.RowHeadersWidth = 51;
            DgUser.Size = new Size(776, 297);
            DgUser.TabIndex = 1;
            DgUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(DgUser);
            Controls.Add(label1Dashboard);
            Name = "FormDashboard";
            Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1Dashboard;
        private DataGridView DgUser;


       
    }

    public class User
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string Asal { get; set; }



        public User(string nama, int umur, string asal)
        {
            this.Nama = nama;
            this.Umur = umur;
            this.Asal = asal;
        }
    }
}
