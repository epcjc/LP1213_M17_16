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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Enc_Educação' table. You can move, or remove it, as needed.
            this.enc_EducaçãoTableAdapter.FillEncEducação(this.database1DataSet1.Enc_Educação);
            // TODO: This line of code loads data into the 'database1DataSet.Enc_Educação' table. You can move, or remove it, as needed.
            // this.enc_EducaçãoTableAdapter.FillEncEducação(this.database1DataSet.Enc_Educação);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.enc_EducaçãoTableAdapter.FillEncEducação(this.database1DataSet.Enc_Educação);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
