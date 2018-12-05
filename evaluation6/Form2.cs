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
using System.IO;
using System.Drawing.Imaging;
namespace evaluation6
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Source\Repos\evaluation6\evaluation6\eval6.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                img.Text = openFileDialog1.FileName;
             pictureBox1.ImageLocation = img.Text;
          // pictureBox1.Image = Convert.ToSByte(openFileDialog1.FileName);
        }

        private void upload_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            Byte[] mypic = File.ReadAllBytes(openFileDialog1.FileName);
            cmd.CommandText = "Insert into evaluate values('" + id.Text + "','" + name.Text + "','" + sec.Text + "','" + branch.Text + "','" + date.Text + "','" + pictureBox1.Image + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saved");

        }

        private void show_Click(object sender, EventArgs e)
        {
            //   string con = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string cmd = "Select Id,name,section,branch,date_of_birth from evaluate  where Id='" + id.Text+"'"; 
            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            //  SqlCommandBuilder cb = new SqlCommandBuilder(dp);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGridView1.DataSource = bs;
            

        }

        private void showimg_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select picture from evaluate where Id='" + id.Text + "'", con);
            DataTable d = new DataTable();
            da.Fill(d);
            Byte[] p = new byte[0];
            p = (byte[])d.Rows[0][0];

            MemoryStream ms = new MemoryStream(p);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
