using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet.Encarregado_Educação' table. You can move, or remove it, as needed.
            //this.encarregado_EducaçãoTableAdapter.FillEncEducação(this.baseDadosDataSet.Encarregado_Educação);
            // TODO: This line of code loads data into the 'baseDadosDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.baseDadosDataSet.Alunos);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.encarregado_EducaçãoTableAdapter.FillEncEducação(this.baseDadosDataSet.Encarregado_Educação);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
