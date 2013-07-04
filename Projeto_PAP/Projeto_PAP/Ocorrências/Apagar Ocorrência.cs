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
    public partial class Apagar_Ocorrência : Form
    {
        public Apagar_Ocorrência()
        {
            InitializeComponent();
        }

        private void ocorrenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ocorrenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Apagar_Ocorrência_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.Fill(this.database1DataSet.Ocorrencia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ocorrenciaTableAdapter.DeleteOcorrência(Convert.ToInt16(this.comboBox1.SelectedValue));
                MessageBox.Show("Eliminado com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
