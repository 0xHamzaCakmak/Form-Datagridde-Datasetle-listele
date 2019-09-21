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

namespace Datagridwiew_orneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Bilgi;Integrated Security=True");
        private void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglantı);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster("select * from Kişiler");
        }
    }
}
