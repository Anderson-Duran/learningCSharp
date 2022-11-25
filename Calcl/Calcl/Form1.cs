namespace Calcl
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        
        string number;
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button1.Text;
            textBox1.Text = number;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button2.Text;
            textBox1.Text = number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button3.Text;
            textBox1.Text = number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button4.Text;
            textBox1.Text = number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button5.Text;
            textBox1.Text = number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button6.Text;
            textBox1.Text = number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button7.Text;
            textBox1.Text = number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button8.Text;
            textBox1.Text = number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button9.Text;
            textBox1.Text = number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculadora";
            number += button10.Text;
            textBox1.Text = number;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            number += btn_dot.Text;
            textBox1.Text = number;
        }

        string result;
        double numberDoubleSum;
        double numberDoubleSub;
        double numberDoubleDivide;
        double numberDoubleMult;

        private void btn_sum_Click(object sender, EventArgs e)       //FUNÇÃO SOMAR
        {
            numberDoubleSum += Convert.ToDouble(number);
            number = "";
            textBox1.Clear();
        }

       

        private void btn_sub_Click(object sender, EventArgs e)       //FUNÇÃO SUBTRAIR
        {
            numberDoubleSub -= Convert.ToDouble(number);
            number = "";
            textBox1.Clear();
        }

        private void btn_split_Click(object sender, EventArgs e)     //FUNÇÃO DIVIDIR
        {
            double n1, n2;
            n1 = n2 = 0;
            
            numberDoubleDivide = Convert.ToDouble(number);
            if (c == 0)
            {
                n1 = numberDoubleDivide;
            }
            else
            {
                n2 = numberDoubleDivide;
                numberDoubleDivide = n1 / n2;
            }
            number = "";
            textBox1.Clear();
        }

        private void btn_mult_Click(object sender, EventArgs e)     //FUNÇÃO MULTIPLICAR
        {
            if (c == 0)
            {
                numberDoubleMult = Convert.ToDouble(number);
                c++;
            }
            else
            {
                numberDoubleMult *= Convert.ToDouble(number);
            }
            number = "";
            textBox1.Clear();
            
            
        }
        private void btn_result_Click(object sender, EventArgs e)   //FUNÇÃO RESULTADO
        {
            if (numberDoubleSum > 0)
            {
                numberDoubleSum += Convert.ToDouble(number);
                number = "";
                textBox1.Clear();
                result += Convert.ToString(numberDoubleSum);
                textBox1.Text = result;
                numberDoubleSum = 0;
                result = "";
            }
            else if (numberDoubleSub < 0)
            {
                numberDoubleSub -= -(Convert.ToDouble(number));
                numberDoubleSub *= (-1);
                number = "";
                textBox1.Clear();
                result += Convert.ToString(numberDoubleSub);
                textBox1.Text = result;
                numberDoubleSub = 0;
                result = "";
            }
            else if (numberDoubleDivide > 0)
            {
                numberDoubleDivide /= Convert.ToDouble(number);
                number = "";
                textBox1.Clear();
                result += Convert.ToString(numberDoubleDivide);
                textBox1.Text = result;
                numberDoubleDivide = 0;
                result = "";
                c = 0;
            }
            else if (numberDoubleMult > 0)
            {
                numberDoubleMult *= Convert.ToDouble(number);
                number = "";
                textBox1.Clear();
                result += Convert.ToString(numberDoubleMult);
                textBox1.Text = result;
                numberDoubleMult = 0;
                result = "";
                c = 0;
            }
            else
            {
                numberDoubleSum = numberDoubleSub = numberDoubleDivide = numberDoubleMult = 0;
                label1.Text = "Valor Inválido!";
                result = "";
                textBox1.Text = "";
                c = 0;
            }
        }
    }
}