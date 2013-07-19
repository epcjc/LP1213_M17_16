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
    public partial class Pesquisar_Professor : Form
    {
        public Pesquisar_Professor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Pesquisar_Professor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escolaDataSet.Professores);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.professoresTableAdapter.FillByPesProfessores(this.escolaDataSet.Professores, this.textBox1.Text);
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);

        }
    }
}
