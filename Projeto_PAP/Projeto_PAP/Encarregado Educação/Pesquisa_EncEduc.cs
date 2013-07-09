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
    public partial class Pesquisa_EncEduc : Form
    {
        public Pesquisa_EncEduc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void encarregado_EducacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregado_EducacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Pesquisa_EncEduc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Encarregado_Educacao' table. You can move, or remove it, as needed.
            this.encarregado_EducacaoTableAdapter.Fill(this.database1DataSet.Encarregado_Educacao);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.encarregado_EducacaoTableAdapter.FillByPesEncEduc(this.database1DataSet.Encarregado_Educacao, this.textBox1.Text);
        }
    }
}
