namespace winfrom1
{
    partial class datagridcs
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
            dataGridView1 = new DataGridView();
            btnTmbh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1792, 419);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTmbh
            // 
            btnTmbh.BackColor = Color.ForestGreen;
            btnTmbh.FlatStyle = FlatStyle.Flat;
            btnTmbh.ForeColor = Color.Wheat;
            btnTmbh.Location = new Point(1174, 1);
            btnTmbh.Name = "btnTmbh";
            btnTmbh.Size = new Size(124, 29);
            btnTmbh.TabIndex = 1;
            btnTmbh.Text = "TAMBAH DATA";
            btnTmbh.UseVisualStyleBackColor = true;
            btnTmbh.Click += btnTmbh_Click;
            // 
            // datagridcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1818, 450);
            Controls.Add(btnTmbh);
            Controls.Add(dataGridView1);
            Name = "datagridcs";
            Text = "datagridcs";
            Load += datagridcs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        //btntmbhdata
        private Button btnTmbh;
        public DataGridView dataGridView1;
    }

    //public class Mahasiswa
    //{
    //    public string Nim { get; set; }
    //    public string Nama { get; set; }
    //    public string Alamat { get; set; }
    //    public DateOnly TglLahir{ get; set;}
    //    public string Dateonly { get; set; }
    //    public string ProgramStudi { get; set; }
    //    public decimal UKT { get; set; }
    //    public Boolean isActive { get; set; }
    //}
}