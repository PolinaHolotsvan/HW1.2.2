namespace HW1._2._2
{
    public partial class Form1 : Form
    {
        private double _n { get; set; }
        private void Responce()
        {
            if (textBox1.Text == "") MessageBox.Show("�� �� ����� �����!");
            else
            {
                try
                {

                    _n = double.Parse(textBox1.Text);
                    MessageBox.Show($"�� ����� ����� {_n}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�� ����������� ����� �����!");
                }
                finally
                {
                    textBox1.Clear();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Responce();
        }
    }
}
