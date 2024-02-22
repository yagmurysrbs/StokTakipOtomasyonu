using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;



        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string pass = textBox2.Text;
            con = new SqlConnection("Data Source=YAGMUR;Initial Catalog=Müsteri;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Table_2 where admin='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                
                Form1 frm = new Form1();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }

            con.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Control;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }
    }
}


