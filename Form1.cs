namespace CST_150_ActivityOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Activity 1 has been very fun. Please tell us if you enjoyed doing activity 1.");

        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for submitting your feedback");
        }
    }
}