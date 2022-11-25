namespace calcuParams
{
    public partial class Form1 : Form
    {
        //VARIAVEIS GLOBAIS
        double numero;
        double resultado;
        int counter = 0;
        bool adicao;
        
        
        
        //FUNÇÃO SOMAR

        public double soma(params double[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                resultado += num[i];
            }
            return resultado;
        }



        //PROGRAMA PRINCIPAL

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_1.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_2.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_3.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_4.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_5.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_6.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_7.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_8.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_9.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_dot.Text;
            numero = Convert.ToDouble(textBox1.Text);
        }
        public void btn_Soma_Click(object sender, EventArgs e)
        {
            double result;
            adicao = true;
            
            if (counter == 0)
            {
                lb_1.Text = textBox1.Text + "+";
                textBox1.Clear();
                resultado = soma(numero);
                counter++;
            }
            else if (counter > 0)
            {
                lb_1.Text += textBox1.Text + "+";
                textBox1.Clear();
                resultado = soma(numero);
                label1.Text = resultado.ToString();
            }
                        

        }

        public void btn_Resultado_Click(object sender, EventArgs e)
        {
            if (adicao == true)
            {
                lb_1.Text += textBox1.Text + "";
                textBox1.Clear();
                resultado = soma(numero);
                label1.Text = resultado.ToString();
                counter = 0;
            }



            textBox1.Text = label1.Text;
            label1.Text = "";
        }

        
    }
}