namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Islem 1 Calisti");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Islem 2 Calisti");
        }
    }
}
