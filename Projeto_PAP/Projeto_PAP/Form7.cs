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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void diretor_TurmaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diretor_TurmaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Diretor_Turma' table. You can move, or remove it, as needed.
            this.diretor_TurmaTableAdapter.Fill(this.database1DataSet.Diretor_Turma);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.diretor_TurmaTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text);
            MessageBox.Show("Inserido com Sucesso");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        



        
    }
}
