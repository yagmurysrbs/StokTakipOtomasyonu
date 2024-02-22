namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Aktar = new ToolStripMenuItem();
            tabPage3 = new TabPage();
            button13 = new Button();
            button12 = new Button();
            button8 = new Button();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            KAYDET = new Button();
            dataGridView3 = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            button7 = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button6 = new Button();
            label5 = new Label();
            Sil = new Button();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            tabPage1 = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            VeriEkleme = new TabControl();
            tabPage4 = new TabPage();
            comboBox1 = new ComboBox();
            dataGridView4 = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            VeriEkleme.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Aktar });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 28);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // Aktar
            // 
            Aktar.Name = "Aktar";
            Aktar.Size = new Size(132, 24);
            Aktar.Text = "Düzenle";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button13);
            tabPage3.Controls.Add(button12);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(KAYDET);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(maskedTextBox1);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(dateTimePicker1);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(Sil);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(button5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1916, 812);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "VeriEkleme";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1240, 20);
            button13.Name = "button13";
            button13.Size = new Size(251, 55);
            button13.TabIndex = 38;
            button13.Text = "Tabloyu Excele Aktar";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(1240, 140);
            button12.Name = "button12";
            button12.Size = new Size(251, 64);
            button12.TabIndex = 37;
            button12.Text = "FAST REPORT";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1240, 79);
            button8.Name = "button8";
            button8.Size = new Size(251, 58);
            button8.TabIndex = 36;
            button8.Text = "Sqlden Excele aktar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1759, 140);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 35;
            label7.Text = "TOPLAM";
            label7.Click += label7_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1696, 168);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(212, 27);
            textBox7.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(700, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 27);
            textBox4.TabIndex = 28;
            textBox4.TextChanged += textBox4_TextChanged_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(419, 168);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(77, 27);
            textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(700, 28);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(242, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 27);
            textBox3.TabIndex = 7;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(148, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button11
            // 
            button11.Location = new Point(972, 150);
            button11.Name = "button11";
            button11.Size = new Size(236, 54);
            button11.TabIndex = 33;
            button11.Text = "Bakiyesi Sıfır Olanlar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(972, 86);
            button10.Name = "button10";
            button10.Size = new Size(236, 58);
            button10.TabIndex = 32;
            button10.Text = "Bakiyesi Borç Olanlar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(972, 25);
            button9.Name = "button9";
            button9.Size = new Size(236, 55);
            button9.TabIndex = 31;
            button9.Text = "Bakiyesi Alacak Olanlar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // KAYDET
            // 
            KAYDET.Location = new Point(502, 161);
            KAYDET.Name = "KAYDET";
            KAYDET.Size = new Size(126, 43);
            KAYDET.TabIndex = 27;
            KAYDET.Text = "KAYDET";
            KAYDET.UseVisualStyleBackColor = true;
            KAYDET.Click += button8_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.ContextMenuStrip = contextMenuStrip1;
            dataGridView3.GridColor = SystemColors.ButtonHighlight;
            dataGridView3.Location = new Point(3, 504);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1917, 312);
            dataGridView3.TabIndex = 21;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            dataGridView3.CellEnter += dataGridView3_CellEnter;
            dataGridView3.CellValueChanged += dataGridView3_CellValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(148, 130);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(289, 27);
            maskedTextBox1.TabIndex = 20;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button7
            // 
            button7.Location = new Point(499, 115);
            button7.Name = "button7";
            button7.Size = new Size(126, 42);
            button7.TabIndex = 19;
            button7.Text = "Yenile";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 167);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 16;
            label6.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(154, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button6
            // 
            button6.Location = new Point(499, 66);
            button6.Name = "button6";
            button6.Size = new Size(126, 45);
            button6.TabIndex = 14;
            button6.Text = "Güncelleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(663, 3);
            label5.Name = "label5";
            label5.Size = new Size(293, 22);
            label5.TabIndex = 13;
            label5.Text = "Silinecek Müsteri Numarasını Giriniz:";
            label5.Click += label5_Click;
            // 
            // Sil
            // 
            Sil.Location = new Point(700, 61);
            Sil.Name = "Sil";
            Sil.Size = new Size(242, 32);
            Sil.TabIndex = 11;
            Sil.Text = "Sil";
            Sil.UseVisualStyleBackColor = true;
            Sil.Click += Sil_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ContextMenuStrip = contextMenuStrip1;
            dataGridView2.GridColor = Color.Salmon;
            dataGridView2.Location = new Point(3, 210);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1905, 288);
            dataGridView2.TabIndex = 10;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellEnter += dataGridView2_CellEnter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 133);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 9;
            label4.Text = "Telefon N.";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 95);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 54);
            label2.Name = "label2";
            label2.Size = new Size(39, 28);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 1;
            label1.Text = "Müsteri No";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(499, 20);
            button5.Name = "button5";
            button5.Size = new Size(126, 42);
            button5.TabIndex = 0;
            button5.Text = "EKLE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1916, 812);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Veri Listeleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(785, 323);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(347, 58);
            button4.Name = "button4";
            button4.Size = new Size(180, 59);
            button4.TabIndex = 0;
            button4.Text = "datalistele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1916, 812);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bağlantı İşlemleri";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(285, 126);
            button1.Name = "button1";
            button1.Size = new Size(238, 59);
            button1.TabIndex = 0;
            button1.Text = "Bağlantı Aç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(287, 204);
            button2.Name = "button2";
            button2.Size = new Size(236, 62);
            button2.TabIndex = 1;
            button2.Text = "Bağlantı Kapat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(287, 281);
            button3.Name = "button3";
            button3.Size = new Size(238, 63);
            button3.TabIndex = 2;
            button3.Text = "Bağlantı Durumu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // VeriEkleme
            // 
            VeriEkleme.Controls.Add(tabPage1);
            VeriEkleme.Controls.Add(tabPage2);
            VeriEkleme.Controls.Add(tabPage3);
            VeriEkleme.Controls.Add(tabPage4);
            VeriEkleme.Dock = DockStyle.Fill;
            VeriEkleme.Location = new Point(0, 0);
            VeriEkleme.Name = "VeriEkleme";
            VeriEkleme.SelectedIndex = 0;
            VeriEkleme.Size = new Size(1924, 845);
            VeriEkleme.SizeMode = TabSizeMode.FillToRight;
            VeriEkleme.TabIndex = 3;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1916, 812);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Stok Takip";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 52);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(1004, 586);
            dataGridView4.TabIndex = 11;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            dataGridView4.CellMouseDoubleClick += dataGridView4_CellMouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1924, 845);
            Controls.Add(VeriEkleme);
            ForeColor = Color.BlueViolet;
            Name = "Form1";
            Text = "p";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            VeriEkleme.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Aktar;
        private TabPage tabPage3;
        private Button button13;
        private Button button12;
        private Button button8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button KAYDET;
        private DataGridView dataGridView3;
        private MaskedTextBox maskedTextBox1;
        private Button button7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private Label label5;
        private Button Sil;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button5;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button4;
        private TabPage tabPage1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabControl VeriEkleme;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private ComboBox comboBox1;
    }
}