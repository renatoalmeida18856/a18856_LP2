using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class RegioesF : UserControl
    {
        public RegioesF()
        {
            InitializeComponent();
        }

        private void RegioesF_Load(object sender, EventArgs e)
        {

        }

        Regiao r = new Regiao();

        private void button2_Click(object sender, EventArgs e)
        {
            r.Nome = textBox5.Text;
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
    }
}
