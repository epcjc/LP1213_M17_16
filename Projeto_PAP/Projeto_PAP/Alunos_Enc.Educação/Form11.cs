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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);

        }

        
    }
}
