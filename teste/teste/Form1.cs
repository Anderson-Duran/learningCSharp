namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mito, lula;
      
        private void btn_1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;
            tb_visor.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
           
            pictureBox1.Image = null;
            tb_visor.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;
            tb_visor.Text += "3";
        }

        private void tb_visor_TextChanged(object sender, EventArgs e)
        {
            if (tb_visor.Text == "22")
            {
                label1.Text = "Bolsonaro";
                pictureBox1.ImageLocation = @"C:\Users\ander\Desktop\Byte Bank\teste\teste\bolso.jpg";
            }
            else if (tb_visor.Text == "13")
            {
                label1.Text = "Ladrão";
                pictureBox1.ImageLocation = @"C:\Users\ander\Desktop\Byte Bank\teste\teste\lula.jpg";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (tb_visor.Text == "22")
            {
                mito += 1;
                qtdMito.Text = "";
                qtdMito.Text += mito;
                label1.Text = "";
                pictureBox1.ImageLocation = @"C:\Users\ander\Desktop\Byte Bank\teste\teste\fim.jpeg";
                if (mito > 3)
                {
                    lula += 1;
                }

            }
            else if (tb_visor.Text == "13")
            {
                lula += 1;
                qtdLula.Text = "";
                qtdLula.Text += lula;
                pictureBox1.ImageLocation = @"C:\Users\ander\Desktop\Byte Bank\teste\teste\fim.jpeg";
                label1.Text = "";
            }
            
            tb_visor.Clear();
        }
    }
}