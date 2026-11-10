using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH05C
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboDanToc.Items.Clear();

            cboDanToc.Items.Add("Kinh");
            cboDanToc.Items.Add("Hoa");
            cboDanToc.Items.Add("K'Me");
            cboDanToc.Items.Add("H'Mong");
            cboDanToc.Items.Add("Khác");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
