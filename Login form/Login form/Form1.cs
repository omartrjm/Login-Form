namespace Login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
           

            int id = Convert.ToInt32(input);


             if (id <= 0)
            {
                MessageBox.Show("it can't be under 1");
            }
            else if (id > 10)
            {
                MessageBox.Show("it can't be above 10");
            }
            else
            {
                MessageBox.Show("Welcome employee number " + id);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
