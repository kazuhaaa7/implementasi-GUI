namespace winfrom1
{
    public partial class FormEntrData2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrData2));
            label1 = new Label();
            label2 = new Label();
            NAMA = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbNim = new TextBox();
            tbNama = new TextBox();
            tbAlamat = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbProdi = new ComboBox();
            nudUKT = new NumericUpDown();
            cbisActive = new CheckBox();
            buttonSv = new Button();
            buttonCnc = new Button();
            ((System.ComponentModel.ISupportInitialize)nudUKT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 32);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "FORM ENTRY DATA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Location = new Point(54, 90);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "NIM";
            label2.Click += label2_Click;
            // 
            // NAMA
            // 
            NAMA.AutoSize = true;
            NAMA.Location = new Point(54, 139);
            NAMA.Name = "NAMA";
            NAMA.Size = new Size(53, 20);
            NAMA.TabIndex = 2;
            NAMA.Text = "NAMA";
            NAMA.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 227);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "TGL LAHIR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 188);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "ALAMAT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 270);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 4;
            label6.Text = "PROGAM STUDI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 319);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 5;
            label7.Text = "BESAR UKT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 370);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 6;
            label8.Text = "STATUS";
            // 
            // tbNim
            // 
            tbNim.Location = new Point(236, 91);
            tbNim.Name = "tbNim";
            tbNim.Size = new Size(125, 27);
            tbNim.TabIndex = 7;
            tbNim.TextChanged += tbNim_TextChanged;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(236, 139);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(125, 27);
            tbNama.TabIndex = 8;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(236, 181);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(125, 27);
            tbAlamat.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // cbProdi
            // 
            cbProdi.FormattingEnabled = true;
            cbProdi.Items.AddRange(new object[] { "SISTEM INFORMASI", "INFORMATIKA", "TEKNOLOGI INFORMASI" });
            cbProdi.Location = new Point(236, 270);
            cbProdi.Name = "cbProdi";
            cbProdi.Size = new Size(151, 28);
            cbProdi.TabIndex = 11;
            cbProdi.SelectedIndexChanged += cbProdi_SelectedIndexChanged;
            // 
            // nudUKT
            // 
            nudUKT.Location = new Point(237, 312);
            nudUKT.Name = "nudUKT";
            nudUKT.Size = new Size(150, 27);
            nudUKT.TabIndex = 12;
            // 
            // cbisActive
            // 
            cbisActive.AutoSize = true;
            cbisActive.Location = new Point(237, 366);
            cbisActive.Name = "cbisActive";
            cbisActive.Size = new Size(69, 24);
            cbisActive.TabIndex = 13;
            cbisActive.Text = "AKTIF";
            cbisActive.UseVisualStyleBackColor = true;
            // 
            // buttonSv
            // 
            buttonSv.Location = new Point(435, 412);
            buttonSv.Name = "buttonSv";
            buttonSv.Size = new Size(94, 29);
            buttonSv.TabIndex = 14;
            buttonSv.Text = "SIMPAN";
            buttonSv.UseVisualStyleBackColor = true;
            buttonSv.Click += buttonSv_Click;
            // 
            // buttonCnc
            // 
            buttonCnc.Location = new Point(548, 412);
            buttonCnc.Name = "buttonCnc";
            buttonCnc.Size = new Size(94, 29);
            buttonCnc.TabIndex = 15;
            buttonCnc.Text = "BATAL";
            buttonCnc.UseVisualStyleBackColor = true;
            buttonCnc.Click += buttonCnc_Click;
            // 
            // FormEntrData2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 508);
            Controls.Add(buttonCnc);
            Controls.Add(buttonSv);
            Controls.Add(cbisActive);
            Controls.Add(nudUKT);
            Controls.Add(cbProdi);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbAlamat);
            Controls.Add(tbNama);
            Controls.Add(tbNim);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(NAMA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEntrData2";
            Text = "FORM ENTRY DATA";
            Load += FormEntrData2_Load;
            ((System.ComponentModel.ISupportInitialize)nudUKT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void SetComboBoxProdi() //binding data
        {
            List<Prodi> listProdi = new List<Prodi>();
            listProdi.Add(new Prodi() { kodeProdi = "24101010", namaProdi = "SISTEM INFORMASI" });
            listProdi.Add(new Prodi() { kodeProdi = "24101030", namaProdi = "INFORMATIKA" });
            listProdi.Add(new Prodi() { kodeProdi = "24101020", namaProdi = "TEKNOLOGI INFORMASI" });

            cbProdi.DataSource = listProdi;
            cbProdi.ValueMember = "kodeProdi";
            cbProdi.DisplayMember = "namaProdi";
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label NAMA;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbNim;
        private TextBox tbNama;
        private TextBox tbAlamat;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbProdi;
        private NumericUpDown nudUKT;
        private CheckBox cbisActive;
        private Button buttonSv;
        private Button buttonCnc;


        public class Prodi
        {
            public string kodeProdi { get; set; }
            public string namaProdi { get; set; }
        }
    }
}