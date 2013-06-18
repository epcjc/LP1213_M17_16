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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Diretor_Turma' table. You can move, or remove it, as needed.
            // this.diretor_TurmaTableAdapter.Fill(this.database1DataSet.Diretor_Turma);
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.diretor_TurmaTableAdapter.Fill(this.database1DataSet.Diretor_Turma);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
