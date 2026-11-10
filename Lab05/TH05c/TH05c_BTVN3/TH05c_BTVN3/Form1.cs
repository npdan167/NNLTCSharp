namespace TH05c_BTVN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                trvDanhBa.Nodes.Add(c.ToString());
            }
            trvDanhBa.Nodes[1].Nodes.Add("Bình, Ngô Thanh");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fn = txtFN.Text;
            string ln = txtLN.Text;

            foreach (TreeNode node in trvDanhBa.Nodes)
            {
                if (node.Text == fn.Substring(0, 1))
                {
                    node.Nodes.Add(fn + ", " + ln);
                    node.Expand();
                    break;
                }
            }

            txtFN.Clear();
            txtLN.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
