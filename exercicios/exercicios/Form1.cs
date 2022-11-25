namespace exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //EXERCÍCIOS 1
        private void button1_Click(object sender, EventArgs e)
        {
            int age1 = Int16.Parse(textBox1.Text);
            int age2 = Int16.Parse(textBox2.Text);
            int age3 = Int16.Parse(textBox3.Text);

            int media = (age1 + age2 + age3) / 3;
            
            
            MessageBox.Show($"A média de idades é : {media}");
        }

        //EXERCÍCIOS 2

        private void button2_Click(object sender, EventArgs e)
        {
            double a,b,c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            double delta = b * b - 4 * a * c;

            double a1, a2;
           
                    
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);
               
            

            MessageBox.Show($"x1 = {a1} , x2 = {a2}");
        }
    }
}