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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }


        private void encarregado_EducacaoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregado_EducacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Encarregado_Educacao' table. You can move, or remove it, as needed.
            this.encarregado_EducacaoTableAdapter.Fill(this.database1DataSet.Encarregado_Educacao);
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //try
           // {
           //    //this.encarregado_EducacaoTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text);
           //     MessageBox.Show("Inserido com Sucesso");
           //      this.Close();
           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.ToString());
           // }
        }

        private void encarregado_EducacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encarregado_EducacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

      

        
        
    }
}
