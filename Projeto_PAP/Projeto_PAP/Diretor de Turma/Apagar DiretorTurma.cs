using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class Apagar_DiretorTurma : Form
    {
        public Apagar_DiretorTurma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.diretor_TurmaTableAdapter.DeleteDiretorTurma(Convert.ToInt16(this.comboBox1.SelectedValue));
                MessageBox.Show("Eliminado com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void diretor_TurmaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diretor_TurmaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Apagar_DiretorTurma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Diretor_Turma' table. You can move, or remove it, as needed.
            this.diretor_TurmaTableAdapter.Fill(this.database1DataSet.Diretor_Turma);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
