using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using File = System.IO.File;

namespace HandshakeProject
{
    public partial class handshakeForm : Form
    {
        public handshakeForm()
        {
            InitializeComponent();
        }

        private void handshakeUpload_Click(object sender, EventArgs e)
        {

        }




        string handshake;
        string wordlist;

        // handshake browse button
        private void uploadBrowseBtn_Click(object sender, EventArgs e)
        {
            browseHandshakeFileDialog.Filter = "Handshake|*.cap";
            browseHandshakeFileDialog.InitialDirectory = "C:\\Users\\96176\\Downloads";
            browseHandshakeFileDialog.Title = "Choose .cap file";
            browseHandshakeFileDialog.ShowDialog();

            String path = browseHandshakeFileDialog.FileName;
            textBox2.Text = path;
            handshake = textBox2.Text;
        }

        // wordlist browse button
        private void uploadWordlistBrowseBtn_Click(object sender, EventArgs e)
        {
            browseWordlistFileDialog.Filter = "Text File|*.txt";
            // choo 2awal page byefta7 3laya l browse
            browseWordlistFileDialog.InitialDirectory = "C:\\Users\\96176\\Downloads";
            //l name li byetla3 fo2
            browseWordlistFileDialog.Title = "Choose your wordlist";
            //byefta7 l dialog (li howe l browse wyn bet na2e)
            browseWordlistFileDialog.ShowDialog();
            
            String path = browseWordlistFileDialog.FileName;
            textBox3.Text = path;
            wordlist = textBox3.Text;

        }


        // Find Password button
        private void submitBtn_Click(object sender, EventArgs e)
        {

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/k aircrack-ng--avx " + handshake + " -w " + wordlist + " -l C:\\Users\\96176\\Desktop\\PasswordFound";
            Process.Start(ps);
            

            //2eza badde 2a3mel clear lal textbox bas y5alles
            //textBox2.Clear();
            //textBox3.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        // Create wordlist button
        private void button1_Click(object sender, EventArgs e)
        {
            // Hide this form
            this.Hide();
            generateWordlistForm f2 = new generateWordlistForm();
            
            // show form2
            f2.ShowDialog();

            // close form2
            f2 = null;
            //show form1
            this.Show();


        }

        public string conString = "Data Source=.;Initial Catalog=HandshakeProject;Integrated Security=True";

        // save button
        private void saveBtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Network(Name,Password,Handshake,Wordlist)values('" + networkName.Text.ToString() + "','" + networkPassword.Text.ToString() + "','" + handshake.ToString() + "','" + wordlist.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Network added Successfully!");

            }
        }

        private void openSavedNtwrkBtn_Click(object sender, EventArgs e)
        {
            // Hide this form
            this.Hide();
            dataShowForm f3 = new dataShowForm();

            // show form2
            f3.ShowDialog();

            // close form2
            f3 = null;

            //show form1
            this.Show();
        }

        private void networkPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\96176\Desktop\PasswordFound";
            

            if (File.Exists(path))
            {
                StreamReader stream = new StreamReader(path);
                string fileData = stream.ReadToEnd();
                networkPassword.Text = fileData.ToString();
                stream.Close();
            }

            

        }
    }
}
