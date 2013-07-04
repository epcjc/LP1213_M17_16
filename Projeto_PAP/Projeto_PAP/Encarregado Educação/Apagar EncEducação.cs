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
    public partial class Apagar_EncEducação : Form
    {
        public Apagar_EncEducação()
        {
            InitializeComponent();
        }

        private void encarregado_EducacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregado_EducacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Apagar_EncEducação_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Encarregado_Educacao' table. You can move, or remove it, as needed.
            this.encarregado_EducacaoTableAdapter.Fill(this.database1DataSet.Encarregado_Educacao);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.encarregado_EducacaoTableAdapter.DeleteEncEducação(Convert.ToInt16(this.comboBox1.SelectedValue));
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
