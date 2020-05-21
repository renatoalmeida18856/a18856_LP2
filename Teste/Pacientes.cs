using System;
using System.Data;
using System.Windows.Forms;

namespace Formularios
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        //Inicializar a classe

        Paciente p = new Paciente();

        private void UserControl1_Load(object sender, EventArgs e)
        {
            DataTable db = p.Select();
            dataGridView2.DataSource = db;
        }

        public void Clear()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /// <summary>
            /// Envia o formulario para a base de dados
            /// </summary>
            bool ValidPrimeiro = false;
            bool ValidUltimo = false;


            if (textBox5.Text != "")
            {
                p.PrimeiroNome = textBox5.Text;
                ValidPrimeiro = true;
            }
            else
            {
                ValidPrimeiro = false;
                MessageBox.Show("Preencha o campo primeiro nome.");
            }

            if (textBox4.Text != "")
            {
                ValidUltimo = true;
                p.UltimoNome = textBox4.Text;
            }
            else
            {
                ValidUltimo = false;

                MessageBox.Show("Preencha o campo último nome.");
            }

            p.Morada = textBox1.Text;
            p.Genero = comboBox1.Text;
            p.DataNasc = dateTimePicker1.Value;
            p.Infetado = checkBox1.Checked;

            // REVER
            p.Regiao = 1;

            bool sucess = p.Insert(p);
            if (sucess && ValidPrimeiro && ValidUltimo)
            {
                MessageBox.Show("Paciente Adicionado com sucesso.");
                Clear();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro por favor tente novamente!");
            }

            DataTable db = p.Select();
            dataGridView2.DataSource = db;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Obter os dados para poder editar 
            int rowIndex = e.RowIndex;

            textBox4.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            textBox1.Text = dataGridView2.Rows[rowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
            if (dataGridView2.Rows[rowIndex].Cells[7].Value.ToString() == "1")
            { checkBox1.Checked = true; }
            else { checkBox1.Checked = false; }

        }
    }
}
