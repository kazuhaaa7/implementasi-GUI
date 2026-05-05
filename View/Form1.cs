namespace winfrom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(45, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "WEEKEND INI MAU KEMANAKAH ANDA?";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(19, 120);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "NGODENG";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(19, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(157, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "PERGI BERKENCAN";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(19, 60);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(143, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "PERGI KE PANTAI";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 13);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "AKTIVITAS";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(692, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "SUBMIT";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(691, 108);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(84, 24);
            radioButton5.TabIndex = 3;
            radioButton5.TabStop = true;
            radioButton5.Text = "CANCEL";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(501, 354);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 3;
            button1.Text = "SELESAIKAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(364, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "BATALKAN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 360);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "nama";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            BackgroundImage = Properties.Resources.windows_chan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1172, 465);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "coba coba dlu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ambil nama dri textbox
            string nama = textBox1.Text;

            //validasi
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Silahkan masukkan nama terebih dahulu", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //cari radiobutton yg dipilih
            string aktiviitas = "";
            if (radioButton1.Checked)
            {
                aktiviitas = "PERGI KE PANTAI";
            }
            else if (radioButton2.Checked)
            {
                aktiviitas = "PERGI BERKENCAN";
            }
            else if (radioButton3.Checked)
            {
                aktiviitas = "NGODENG";
            }
            else
            {
                //tidak ada radiobutton yg dipilih

                MessageBox.Show("Silahkan pilih aktivitas anda terebih dahulu", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ubah output label
            label1.Text = $"{nama}, anda memilih {aktiviitas}";



        }

        private void button2_Click(object sender, EventArgs e) // klo ini ga pernmanen cm pas udah di klik aja
        {
            label1.Text = "PEMILIHAN DIBATALKAN";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //bakalan otomatis keganti text yg ada di radiobutton, untuk mengganti text yg ada di label
        {
            label1.Text = radioButton1.Text;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
