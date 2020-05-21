using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios;

namespace Teste_1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
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
