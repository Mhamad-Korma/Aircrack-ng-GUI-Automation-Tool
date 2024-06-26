using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HandshakeProject
{
    public partial class dataShowForm : Form
    {
        public dataShowForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataShowForm_Load(object sender, EventArgs e)
        {
            fill();
        }

        public string conString = "Data Source=.;Initial Catalog=HandshakeProject;Integrated Security=True";

        private void fill()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "Select * From Network";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[1], ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fill();
        }
    }
}
