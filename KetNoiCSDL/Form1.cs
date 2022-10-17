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
namespace KetNoiCSDL
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= Data Source=.\\SQLEXPRESS;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().ToString() + "\\DataBase\\" +
                "DuLieu.mdf;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            string sql = "Select * From tblChatLieu";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            tb.Dispose();
            da.Dispose();
            con.Close();
        }
    }
}
