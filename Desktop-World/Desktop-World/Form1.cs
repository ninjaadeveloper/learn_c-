namespace Desktop_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked on button");
            string username = uname.Text;
            string useremail = uemail.Text;
            //MessageBox.Show(username);
            showname.Text = username;
            showemail.Text = useremail;
        }
    }
}
