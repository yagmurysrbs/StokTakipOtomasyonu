
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using ClosedXML.Excel;
using FastReport;
using FastReport.Export.Pdf;
using FastReport.DevComponents.DotNetBar.Controls;
using System.Diagnostics;
using FastReport.DevComponents.DotNetBar;
using DocumentFormat.OpenXml.Vml;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
//using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Presentation;
//using Microsoft.Office.Interop.Excel;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {


        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        private DataSet dataSet = new DataSet();
        private System.Windows.Forms.Timer searchTimer = new System.Windows.Forms.Timer();
        private const int searchDelay = 500; // 500 ms gecikme
        public Form1()
        {
            InitializeComponent();
            dataGridView3.CellFormatting += DataGridView3_CellFormatting;
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;
            dataGridView2.CellMouseDown += DataGridView2_CellMouseDown;
            contextMenuStrip1.Items["Aktar"].Click += AktarToolStripMenuItem_Click;
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;

            dataGridView2.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView2_CellDoubleClick);
            LoadStokGrupCombobox(comboBox1);
            LoadDataGridView();
        }



        void MusteriGetir()
        {
            baglanti = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From Table_3", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();

            //int[] disabledColumnIndices = { 9 };

            //foreach (int columnIndex in disabledColumnIndices)
            //{
            //    dataGridView3.Columns[columnIndex].ReadOnly = true;
            //}
            LoadStokGrupCombobox(comboBox1);


        }
        private void DataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // H�crenin bulundu�u s�tunun indeksini kontrol edin
            int targetColumnIndex = 2; // Yaz� rengini de�i�tirmek istedi�iniz s�tunun indeksi
            int targeColumIndex = 1;

            if (e.ColumnIndex == targetColumnIndex)
            {
                // H�crenin metin rengini de�i�tirin
                e.CellStyle.ForeColor = Color.Red; // Yeni yaz� rengini burada belirtin

            }
            if (e.ColumnIndex == targeColumIndex)
            {
                // H�crenin metin rengini de�i�tirin
                e.CellStyle.ForeColor = Color.DarkGreen; // Yeni yaz� rengini burada belirtin

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            MessageBox.Show("ba�lan�ld�.");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Close();
            MessageBox.Show("veri taban� baglant� kesildi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baglanti.State.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT*FROM Table_3";
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)


        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Table_3(Ad,Soyad,tarih,tel,yas) VALUES(@Ad,@Soyad,@tarih,@tel,@yas)", baglanti);
            //komut.Parameters.AddWithValue("@No", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@yas", textBox6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("M�steri basariyla eklendi.");

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Table_3 WHERE No=@No";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox5.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("M�steri basariyla silindi.");
            textBox5.Clear();
            SqlCommand ad = new SqlCommand();
            ad.CommandText = ("SELECT * FROM Table_3");
            ad.Connection = baglanti;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ad);
            DataTable tablo1 = new DataTable();
            dataAdapter.Fill(tablo1);
            dataGridView2.DataSource = tablo1;

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark;
            int yas;
            int yas1;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
            yas1 = yas / 365;
            textBox6.Text = yas1.ToString();

        }
        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                int mNo = Convert.ToInt32(selectedRow.Cells[0].Value);
                Console.WriteLine("Selected No from DataGridView2: " + mNo);
                SelectMatchingRowInDataGridView3(mNo);
            }
        }

        private void SelectMatchingRowInDataGridView3(int No)
        {

            dataGridView3.ClearSelection();
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                int mNo = Convert.ToInt32(row.Cells[0].Value);

                if (mNo == No)
                {
                    row.Selected = true;
                    Console.WriteLine("Matching No found: " + mNo);
                    break;
                }
            }
        }

        private void DataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView2.ClearSelection();
                dataGridView2.Rows[e.RowIndex].Selected = true;

                contextMenuStrip1.Show(dataGridView2, e.Location);
            }
        }

        private void AktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // �lk �nce, se�ilen sat�r�n gerekli h�cresinin indeksi ge�erli mi diye kontrol edin
                if (selectedRow.Cells.Count > 0 && selectedRow.Cells[0].Value != null)
                {
                    int mNo = Convert.ToInt32(selectedRow.Cells[0].Value);
                    Console.WriteLine("DataGridView2'den Se�ilen No: " + mNo);

                    using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
                    {
                        connection.Open();

                        // Di�er kodlar

                        string selectQuery = "SELECT * FROM Table_4 WHERE M�steriNo = @M�steriNo";
                        using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@M�steriNo", mNo);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dtTable4 = new DataTable();
                            da.Fill(dtTable4);

                            // E�le�en kay�t yoksa, yeni kay�t ekle
                            if (dtTable4.Rows.Count == 0)
                            {
                                string insertQuery = "INSERT INTO Table_4 (M�steriNo) VALUES (@M�steriNo)";
                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                                {
                                    insertCmd.Parameters.AddWithValue("@M�steriNo", mNo);
                                    insertCmd.ExecuteNonQuery();
                                }

                                // Yeni kay�t eklendi�inde dtTable4 yeniden doldurulmal�d�r
                                da.Fill(dtTable4);
                            }









                            // Verileri data3 DataGridView'ine y�kle
                            dataGridView3.DataSource = dtTable4;


                        }


                    }
                }
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Table_3 Set Ad=@Ad,Soyad=@Soyad,tarih=@tarih,tel=@tel,yas=@yas Where No=@No";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@yas", textBox6.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            MusteriGetir();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)


        {
            using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
            {
                connection.Open();

                // Di�er kodlar
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    decimal borc = Convert.ToDecimal(row.Cells["Bor�"].Value);
                    decimal alacak = Convert.ToDecimal(row.Cells["Alacak"].Value);
                    string aciklama = row.Cells["A��klama"].Value != null ? row.Cells["A��klama"].Value.ToString() : string.Empty;

                    // Bakiyeyi hesapla (Bakiye = Alacak - Bor�)
                    decimal bakiye = alacak - borc;

                    // Bakiye h�cresini g�ncelle
                    row.Cells["Bakiye"].Value = bakiye;

                    DateTime tarih = DateTime.Now;
                    // G�ncellemeleri veritaban�na kaydet
                    string updateQuery = "UPDATE Table_4 SET Bor� = @Bor�, Alacak = @Alacak, Bakiye = @Bakiye, A��klama = @A��klama,Tarih=@Tarih WHERE M�steriNo = @M�steriNo";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@Bor�", Convert.ToInt32(borc));
                        updateCmd.Parameters.AddWithValue("@Alacak", Convert.ToInt32(alacak));
                        updateCmd.Parameters.AddWithValue("@Bakiye", Convert.ToInt32(bakiye));
                        updateCmd.Parameters.Add("@A��klama", SqlDbType.VarChar, 50).Value = aciklama;
                        updateCmd.Parameters.AddWithValue("@Tarih", tarih);
                        // MusteriNo de�erini burada ayarlamal�s�n�z (�rne�in row.Cells["MusteriNo"].Value)
                        // updateCmd.Parameters.AddWithValue("@M�steriNo", row.Cells["M�steriNo"]);
                        int musteriNo = Convert.ToInt32(row.Cells["M�steriNo"].Value);
                        updateCmd.Parameters.AddWithValue("@M�steriNo", musteriNo);
                        updateCmd.ExecuteNonQuery();
                    }
                }


                // G�ncelleme i�lemi tamamland�ktan sonra verileri �ekip DataGridView'e y�kle
                string selectQuery = "SELECT * FROM Table_4";
                using (SqlDataAdapter da = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dtTable4 = new DataTable();
                    da.Fill(dtTable4);
                    dataGridView3.DataSource = dtTable4;
                }

            }


        }



        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Aktar.Click -= AktarToolStripMenuItem_Click; // �nceki eventi temizle
            Aktar.Click += AktarToolStripMenuItem_Click; // Yeni eventi ekleyin
            if (contextMenuStrip1.SourceControl == dataGridView2)
            {
                Aktar.Enabled = true; // dataGridView2 �zerindeyse Aktar se�ene�i etkin

            }
            else
            {
                Aktar.Enabled = false; // Di�er durumda Aktar se�ene�i devre d���

            }




        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // �lk �nce, se�ilen sat�r�n gerekli h�cresinin indeksi ge�erli mi diye kontrol edin
                if (selectedRow.Cells.Count > 0 && selectedRow.Cells[0].Value != null)
                {
                    int mNo = Convert.ToInt32(selectedRow.Cells[0].Value);
                    Console.WriteLine("DataGridView2'den Se�ilen No: " + mNo);

                    using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
                    {
                        connection.Open();

                        // Di�er kodlar

                        string selectQuery = "SELECT * FROM Table_4 WHERE M�steriNo = @M�steriNo";
                        using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@M�steriNo", mNo);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dtTable4 = new DataTable();
                            da.Fill(dtTable4);

                            // E�le�en kay�t yoksa, yeni kay�t ekle
                            if (dtTable4.Rows.Count == 0)
                            {
                                string insertQuery = "INSERT INTO Table_4 (M�steriNo) VALUES (@M�steriNo)";
                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                                {
                                    insertCmd.Parameters.AddWithValue("@M�steriNo", mNo);
                                    insertCmd.ExecuteNonQuery();
                                }

                                // Yeni kay�t eklendi�inde dtTable4 yeniden doldurulmal�d�r
                                da.Fill(dtTable4);
                            }









                            // Verileri data3 DataGridView'ine y�kle
                            dataGridView3.DataSource = dtTable4;


                        }


                    }
                }
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
            {
                connection.Open();

                // Table_3 ve Table_4'� M�steriNo alan�na g�re birle�tirerek gerekli alanlar� se�
                string selectQuery = "SELECT T3.No, T3.Ad, T3.Soyad, T3.Tarih, T3.Yas, T3.Tel, T4.Bakiye " +
                                     "FROM Table_3 AS T3 " +
                                     "INNER JOIN Table_4 AS T4 ON T3.No = T4.M�steriNo " +
                                     "WHERE T4.Bakiye > 0";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(selectCmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                        dataGridView2.Columns["Bakiye"].DefaultCellStyle.Format = "C2";

                        decimal totalBakiye = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            decimal bakiye = Convert.ToDecimal(row["Bakiye"]);
                            totalBakiye += bakiye;
                        }

                        // Toplam bakiyeyi TextBox'a yazd�r
                        textBox7.Text = totalBakiye.ToString("C2");











                    }


                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {


            using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
            {
                connection.Open();

                // Table_3 ve Table_4'� M�steriNo alan�na g�re birle�tirerek gerekli alanlar� se�
                string selectQuery = "SELECT T3.No, T3.Ad, T3.Soyad, T3.Tarih, T3.Yas, T3.Tel, T4.Bakiye " +
                                     "FROM Table_3 AS T3 " +
                                     "INNER JOIN Table_4 AS T4 ON T3.No = T4.M�steriNo " +
                                     "WHERE T4.Bakiye < 0";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(selectCmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                        dataGridView2.Columns["Bakiye"].DefaultCellStyle.Format = "C2";

                        decimal totalBakiye = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            decimal bakiye = Convert.ToDecimal(row["Bakiye"]);
                            totalBakiye += bakiye;
                        }

                        // Toplam bakiyeyi TextBox'a yazd�r

                        textBox7.Text = totalBakiye.ToString("C2");



                    }
                }
            }
        }


        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
            {
                connection.Open();

                // Table_3 ve Table_4'� M�steriNo alan�na g�re birle�tirerek gerekli alanlar� se�
                string selectQuery = "SELECT T3.No, T3.Ad, T3.Soyad, T3.Tarih, T3.Yas, T3.Tel, T4.Bakiye " +
                                     "FROM Table_3 AS T3 " +
                                     "INNER JOIN Table_4 AS T4 ON T3.No = T4.M�steriNo " +
                                     "WHERE T4.Bakiye = 0";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(selectCmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                        dataGridView2.Columns["Bakiye"].DefaultCellStyle.Format = "C2";

                        decimal totalBakiye = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            decimal bakiye = Convert.ToDecimal(row["Bakiye"]);
                            totalBakiye += bakiye;
                        }

                        // Toplam bakiyeyi TextBox'a yazd�r
                        textBox7.Text = totalBakiye.ToString("C2");




                    }
                }
            }


        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

            string adSoyad = textBox4.Text.Trim();

            using (SqlConnection connection = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT * FROM Table_3 WHERE Ad LIKE @ad OR Soyad LIKE @soyad";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ad", "%" + adSoyad + "%");
                    cmd.Parameters.AddWithValue("@soyad", "%" + adSoyad + "%");

                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    DataTable tablo = new DataTable();
                    adap.Fill(tablo);

                    dataGridView2.DataSource = tablo;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click_2(object sender, EventArgs e)
        {

            // SQL ba�lant� dizesi
            string connectionString = "Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True";

            // SQL sorgusu
            string query = "SELECT * FROM table_3";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Excel dosyas�n� olu�tur
                    using (var workbook = new XLWorkbook())
                    {
                        // Verileri Excel �al��ma sayfas�na aktar
                        var worksheet = workbook.Worksheets.Add("Veriler");
                        worksheet.Cell(1, 1).InsertTable(dataTable);

                        // Dosyay� kaydet
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Excel Dosyas�|*.xlsx";
                        saveFileDialog.Title = "Excel Dosyas�n� Kaydet";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.EXE", saveFileDialog.FileName);

                        }
                    }
                }








            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Verileri bir DataTable'a aktar�n
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            // DataTable'� kullanarak Excel dosyas� olu�turun
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(dataTable, "Veriler");

                // Excel dosyas�n� kaydetmek i�in bir ileti�im kutusu g�ster
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Dosyas�|*.xlsx";
                saveFileDialog.Title = "Excel Dosyas�n� Kaydet";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);

                    // Excel dosyas�n� a�
                    OpenExcel(saveFileDialog.FileName);
                }
            }

        }
        private void OpenExcel(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {


                Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.EXE", filePath);


            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataGridView()
        {
            baglanti = new SqlConnection("Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True");

            baglanti.Open();

            // SQL sorgusu olu�turun
            string query = "SELECT SiraNo, KartKodu, Ad, Fiyat, Barkod,StokGrupID FROM StokKart";
            SqlCommand cmd = new SqlCommand(query, baglanti);

            // SqlDataReader ile verileri okuyun
            SqlDataReader reader = cmd.ExecuteReader();

            // Yeni bir DataTable olu�turun
            DataTable dataTable = new DataTable();
            dataTable.Load(reader); // SqlDataReader'dan DataTable'a veri aktar�m�

            // DataGridView kontrol�n�n DataSource �zelli�ine verileri ata
            dataGridView4.DataSource = dataTable;
            baglanti.Close();



        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private void LoadStokGrupCombobox(System.Windows.Forms.ComboBox comboBox)
        {
            // Stok gruplar�n� ComboBox'a y�kleme i�lemi
            string connectionString = "Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT GrupID, GrupAdi FROM StokGrup";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int grupID = reader.GetInt32(0);
                    string grupAdi = reader.GetString(1);

                    comboBox.Items.Add(new ComboBoxItem { Text = grupAdi, Value = grupID });
                }
            }

        }




        private DataGridViewRow selectedRow = null;
        private Form editForm = new Form();
        private bool comboboxLoaded = false;
        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBox1.Items.Clear();
            if (!comboboxLoaded)
            {
               LoadStokGrupCombobox(comboBox1);
                comboboxLoaded = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Se�ilen h�crenin verilerini al�n
                selectedRow = dataGridView4.Rows[e.RowIndex];
                string siraNo = selectedRow.Cells["SiraNo"].Value.ToString();
                string kartKodu = selectedRow.Cells["KartKodu"].Value.ToString();
                string ad = selectedRow.Cells["Ad"].Value.ToString();
                string fiyat = selectedRow.Cells["Fiyat"].Value.ToString();
                string barkod = selectedRow.Cells["Barkod"].Value.ToString();
                int stokGrupID = Convert.ToInt32(selectedRow.Cells["StokGrupID"].Value);

                // Form'u ayarlay�n
                editForm.Text = "Veri D�zenleme";
                editForm.Size = new System.Drawing.Size(400, 350); // Form'un boyutunu ayarlay�n
                editForm.StartPosition = FormStartPosition.CenterScreen; // Form'u ekran�n ortas�na konumland�r�n

                // Kart Kodu TextBox'�
                Label kartKoduLabel = new Label();
                kartKoduLabel.Text = "Kart Kodu:";
                kartKoduLabel.Top = 20;
                kartKoduLabel.Left = 20;
                kartKoduLabel.Parent = editForm;

                System.Windows.Forms.TextBox kartKoduTextBox = new System.Windows.Forms.TextBox();
                kartKoduTextBox.Text = kartKodu;
                kartKoduTextBox.Top = 20;
                kartKoduTextBox.Left = 120;
                kartKoduTextBox.Width = 250;
                kartKoduTextBox.Parent = editForm;

                // Ad TextBox'�
                Label adLabel = new Label();
                adLabel.Text = "Ad:";
                adLabel.Top = 60;
                adLabel.Left = 20;
                adLabel.Parent = editForm;

                System.Windows.Forms.TextBox adTextBox = new System.Windows.Forms.TextBox();
                adTextBox.Text = ad;
                adTextBox.Top = 60;
                adTextBox.Left = 120;
                adTextBox.Width = 250;
                adTextBox.Parent = editForm;

                // Fiyat TextBox'�
                Label fiyatLabel = new Label();
                fiyatLabel.Text = "Fiyat:";
                fiyatLabel.Top = 100;
                fiyatLabel.Left = 20;
                fiyatLabel.Parent = editForm;

                System.Windows.Forms.TextBox fiyatTextBox = new System.Windows.Forms.TextBox();
                fiyatTextBox.Text = fiyat;
                fiyatTextBox.Top = 100;
                fiyatTextBox.Left = 120;
                fiyatTextBox.Width = 250;
                fiyatTextBox.Parent = editForm;

                // Barkod TextBox'�
                Label barkodLabel = new Label();
                barkodLabel.Text = "Barkod:";
                barkodLabel.Top = 140;
                barkodLabel.Left = 20;
                barkodLabel.Parent = editForm;

                System.Windows.Forms.TextBox barkodTextBox = new System.Windows.Forms.TextBox();
                barkodTextBox.Text = barkod;
                barkodTextBox.Top = 140;
                barkodTextBox.Left = 120;
                barkodTextBox.Width = 250;
                barkodTextBox.Parent = editForm;
                // Stok Grup ComboBox'�
                Label stokGrupLabel = new Label();
                stokGrupLabel.Text = "Stok Grup:";
                stokGrupLabel.Top = 180;
                stokGrupLabel.Left = 20;
                stokGrupLabel.Parent = editForm;

                // ComboBox ile Stok Gruplar�
                System.Windows.Forms.ComboBox combobox= new System.Windows.Forms.ComboBox();
                comboBox1.Top = 180;
                comboBox1.Left = 120;
                comboBox1.Width = 250;
                comboBox1.Parent = editForm;

                // Stok gruplar�n� ComboBox'a y�kleme i�lemi


                // Se�ilen Stok Grup'unu ComboBox'ta g�sterme
                foreach (ComboBoxItem item in comboBox1.Items)
                {
                    if (item.Value == stokGrupID)
                    {
                        comboBox1.SelectedItem = item;
                        break;
                    }
                }

                // Kaydet butonu
                System.Windows.Forms.Button saveButton = new System.Windows.Forms.Button();
                saveButton.Text = "Kaydet";
                saveButton.Top = 250;
                saveButton.Left = 19;
                saveButton.Width = 300;
                saveButton.Parent = editForm;
                saveButton.Click += SaveButton_Click;

                // TextBox'lar� se�in
                kartKoduTextBox.Select();
                kartKoduTextBox.SelectAll();

                // Form'u g�sterin
                editForm.ShowDialog();
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Text"; // G�r�nt�lenecek �zellik
            comboBox1.ValueMember = "Value"; // De�er olarak al�nacak �zellik


            if (selectedRow != null)
            {
                // Kullan�c�n�n girdi�i verileri al�
                string newKartKodu = editForm.Controls[1].Text;
                string newAd = editForm.Controls[3].Text;
                string newBarkod = editForm.Controls[7].Text;
                int newStokGrupID = ((ComboBoxItem)comboBox1.SelectedItem).Value;// ComboBox'tan yeni stok grubunu al
                decimal newFiyat = decimal.Parse(editForm.Controls[5].Text);



                try
                {
                    string connectionString = "Data Source=YAGMUR;Initial Catalog=M�steri;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE StokKart SET KartKodu = @NewKartKodu, Ad = @NewAd, Fiyat = @NewFiyat, Barkod = @NewBarkod, StokGrupID = @NewStokGrupID WHERE SiraNo = @SiraNo";
                        SqlCommand cmd = new SqlCommand(updateQuery, connection);

                        cmd.Parameters.AddWithValue("@NewKartKodu", newKartKodu);
                        cmd.Parameters.AddWithValue("@NewAd", newAd);
                        cmd.Parameters.AddWithValue("@NewFiyat", newFiyat);
                        cmd.Parameters.AddWithValue("@NewBarkod", newBarkod);
                        cmd.Parameters.AddWithValue("@NewStokGrupID", newStokGrupID);
                        cmd.Parameters.AddWithValue("@SiraNo", Convert.ToInt32(selectedRow.Cells["SiraNo"].Value));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veriler ba�ar�yla g�ncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Veri g�ncelleme i�lemi ba�ar�s�z oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView4.DataSource = null; // DataGridView'i temizleyin
                LoadDataGridView();
                // Form'u kapat�n
                editForm.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}






































