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
    public partial class Form15 : Form
    {
        public void atualizarDataGrid()
        {
            this.professoresTableAdapter.Fill(this.escolaDataSet.Professores);
            this.professoresDataGridView.Refresh();
        }
        
        
        public Form15()
        {
            InitializeComponent();
        }

       

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escolaDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escolaDataSet.Professores);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
            this.Close();
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escolaDataSet);
            atualizarDataGrid();
        }
    }
}
