namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_vehicle.Text == "" || tb_year.Text == "")
            {
                MessageBox.Show("Digite um Veículo e seu ano");
            }
            else
            {
                //USANDO STRING

                //string nameCaptalized;
                //tb_vehicle.Focus();
                //nameCaptalized = tb_vehicle.Text;
                //nameCaptalized = char.ToUpper(nameCaptalized[0]) + nameCaptalized.Substring(1);
                //tb_vehicleList.Text += nameCaptalized + ", ";

                //PASSANDO OS CALORES DIRETOS

                //tb_vehicle.Focus();
                //tb_vehicleList.Text += char.ToUpper((tb_vehicle.Text)[0]) + tb_vehicle.Text.Substring(1) + ", ";

                //USANDO LISTA

                List<string> list = new List<string>();
                list.Add(tb_vehicle.Text + " / ");
                list.Add(tb_year.Text + ", ");
                
                for (int i = 0; i < list.Count; i++)
                {
                    tb_vehicleList.Text +=char.ToUpper(list[i][0]) + list[i].Substring(1);
                }
            }
            tb_vehicle.Clear();
            tb_year.Clear();    
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_vehicleList.Clear();
            tb_vehicle.Focus();
        }
    }
}