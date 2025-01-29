namespace Desktop_Calculater
{
    public partial class Form1 : Form
    {
        int opernadvalue1, opernadvalue2, result;
        public Form1()
        {
            InitializeComponent();
        }


        private void plus(object sender, EventArgs e)
        {
            opernadvalue1 = int.Parse(operand1.Text);
            opernadvalue2 = int.Parse(operand2.Text);
            result = opernadvalue1 + opernadvalue2;
            answer.Text = result.ToString();

        }

        private void minus(object sender, EventArgs e)
        {
            opernadvalue1 = int.Parse(operand1.Text);
            opernadvalue2 = int.Parse(operand2.Text);

            result = opernadvalue1 - opernadvalue2;

            answer.Text = result.ToString();
        }

        private void mymultiply(object sender, EventArgs e)
        {
            opernadvalue1 = int.Parse(operand1.Text);
            opernadvalue2 = int.Parse(operand2.Text);

            result = opernadvalue1 * opernadvalue2;

            answer.Text = result.ToString();
        }

        private void mydivide(object sender, EventArgs e)
        {
            opernadvalue1 = int.Parse(operand1.Text);
            opernadvalue2 = int.Parse(operand2.Text);

            result = opernadvalue1 / opernadvalue2;

            answer.Text = result.ToString();
        }
    }
}
