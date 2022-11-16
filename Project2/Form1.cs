namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked) frm_TrangChu1.BringToFront();
        }

        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked) frm_Dashboard1.BringToFront();
        }

        private void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked) frm_Quanlinguoidung1.BringToFront();
        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked) frm_Hethong1.BringToFront();
        }

        private void siticoneButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton5.Checked) frm_Caidat1.BringToFront();
        }
    }
}