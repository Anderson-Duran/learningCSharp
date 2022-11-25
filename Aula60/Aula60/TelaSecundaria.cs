using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class TelaSecundaria : Form
    {
        public TelaSecundaria(string v)
        {
            InitializeComponent();

            tb_tela.Text = v;
        }
    }
}
