namespace Choices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addItemToList()
        {
            string s = textBox1.Text;
            listBox1.Items.Add(s);
            textBox1.Text = "";
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addItemToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Data.setItems(listBox1.Items);

            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addItemToList();
        }
    }
}
