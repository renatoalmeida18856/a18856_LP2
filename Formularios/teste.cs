using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class teste : UserControl
    {
        public teste()
        {
            InitializeComponent();
        }

        Regiao r = new Regiao();

        private void button1_Click(object sender, EventArgs e)
        {
            r.Nome = "teste";
            r.Populacao = 2;
            bool sucess = r.Insert(r);
            if (sucess)
            {
                MessageBox.Show("Regiao adicionada com sucesso.");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro por favor tente novamente!");
            }
        }

        private void teste_Load(object sender, EventArgs e)
        {

        }
    }
}
