using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commerciale_TiffanyCoundoul_liage3
{
    public partial class article : Form
    {
        private GestionService services = new GestionService();

        public article()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void article_Load(object sender, EventArgs e)
        {
            services.listerArticle(dtgvArticle);

        }
    }

    internal class GestionService
    {
    }
}
