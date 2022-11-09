using PhysicValuesLib;

namespace WindowsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConverterManager converterManager = new ConverterManager();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (string)listBox1.SelectedItem;
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox2.Items.AddRange(converterManager.GetMeasureList(str).ToArray());
            listBox3.Items.AddRange(converterManager.GetMeasureList(str).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(converterManager.GetPhysicValuesList().ToArray());
            listBox1.SelectedIndex = 0;
            string str = (string)listBox1.SelectedItem;
            listBox2.Items.AddRange(converterManager.GetMeasureList(str).ToArray());
            listBox3.Items.AddRange(converterManager.GetMeasureList(str).ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            string physicValue = (string)listBox1.SelectedItem;
            string from = (string)listBox2.SelectedItem;
            string to = (string)listBox3.SelectedItem;
            textBox2.Text = converterManager.GetConvertedValue(physicValue, value, from, to).ToString();
        }
    }
}