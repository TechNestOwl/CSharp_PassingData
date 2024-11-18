
//Gill Guimaraes
// Lab #7


using System.Drawing.Text;
using System.Numerics;

namespace PassingData
{
    public partial class Form1 : Form
    {

        // global var for result
        private static int globalResult;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public int maxReturn(int num1, int num2, int num3)
        {
            int maxValue;
            if (num1 >= num2 && num1 >= num3)
            {
                maxValue = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maxValue = num2;
            }
            else
            {
                maxValue = num3;
            }
            return maxValue;
        }

        public void maxGlobal(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                globalResult = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                globalResult = num2;
            }
            else
            {
                globalResult = num3;
            }
        }
        public void maxRef(int num1, int num2, int num3, ref int result)
        {
            int maxValue;
            if (num1 >= num2 && num1 >= num3)
            {
                maxValue = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                maxValue = num2;
            }
            else
            {
                maxValue = num3;
            }
            result = maxValue;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {


            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            int result = maxReturn(num1, num2, num3);

            textBox4.Text = result.ToString();
        }


        private void globalBtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            maxGlobal(num1, num2, num3);
            textBox4.Text = globalResult.ToString();
        }

        private void referenceBtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            int result = 0;

            maxRef(num1, num2, num3, ref result);
            textBox4.Text = result.ToString();
        }
    }
}