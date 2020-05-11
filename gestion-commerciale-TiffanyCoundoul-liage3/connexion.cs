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

namespace gestion_commerciale_TiffanyCoundoul_liage3
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C339597\COUNDOULT;Initial Catalog=Gestioncommerciale;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Utilisateur where Login = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                article mm = new article();
                mm.Show();
            }
            else
                MessageBox.Show(" please enter correct login and password", "alert" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                


        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription mm = new Inscription();
            mm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
