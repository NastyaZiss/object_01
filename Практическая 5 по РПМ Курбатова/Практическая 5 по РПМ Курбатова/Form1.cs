using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Практическая_5_по_РПМ_Курбатова
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int proiz1 = 1, proiz2 = 1, T;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            try
            {
                uint n = Convert.ToUInt32(textBox2.Text);
                for (int i = 0; i < n; i++)
                {
                    int a = rand.Next(-100, 100);
                    listBox1.Items.Add(a);
                    if (a < 0)
                    {
                        proiz1 *= a;
                    }
                    if((a % 2) != 0)
                    {
                        proiz2 *= a;
                    }
                }  
            }
            catch (FormatException)
            {
                MessageBox.Show("Отсутствует или ошибочное значение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                uint n = Convert.ToUInt32(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Отсутствует или ошибочное значение");
            }
            if (proiz1 > proiz2)
            {
                T = 1;
            }
            else
            {
                T = 0;
            }
            textBox1.Text = T.ToString();
        }
    }
}