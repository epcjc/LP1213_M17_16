namespace M17
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSet = new M17.BaseDadosDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.alunosTableAdapter = new M17.BaseDadosDataSetTableAdapters.AlunosTableAdapter();
            this.alunosAlunoOcorrênciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluno_OcorrênciaTableAdapter = new M17.BaseDadosDataSetTableAdapters.Aluno_OcorrênciaTableAdapter();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretorTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encEducaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaçõesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testemunhasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOcorrenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosAlunoOcorrênciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.alunosBindingSource;
            this.comboBox1.DisplayMember = "Aluno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID";
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.baseDadosDataSet;
            // 
            // baseDadosDataSet
            // 
            this.baseDadosDataSet.DataSetName = "BaseDadosDataSet";
            this.baseDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aluno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alunoDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.diretorTurmaDataGridViewTextBoxColumn,
            this.encEducaçãoDataGridViewTextBoxColumn,
            this.observaçõesDataGridViewTextBoxColumn,
            this.testemunhasDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.resultadoFinalDataGridViewTextBoxColumn,
            this.iDAlunoDataGridViewTextBoxColumn,
            this.iDOcorrenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunosAlunoOcorrênciaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 182);
            this.dataGridView1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(659, 261);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 5;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // alunosAlunoOcorrênciaBindingSource
            // 
            this.alunosAlunoOcorrênciaBindingSource.DataMember = "Alunos_Aluno_Ocorrência";
            this.alunosAlunoOcorrênciaBindingSource.DataSource = this.alunosBindingSource;
            // 
            // aluno_OcorrênciaTableAdapter
            // 
            this.aluno_OcorrênciaTableAdapter.ClearBeforeFill = true;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // diretorTurmaDataGridViewTextBoxColumn
            // 
            this.diretorTurmaDataGridViewTextBoxColumn.DataPropertyName = "Diretor_Turma";
            this.diretorTurmaDataGridViewTextBoxColumn.HeaderText = "Diretor_Turma";
            this.diretorTurmaDataGridViewTextBoxColumn.Name = "diretorTurmaDataGridViewTextBoxColumn";
            // 
            // encEducaçãoDataGridViewTextBoxColumn
            // 
            this.encEducaçãoDataGridViewTextBoxColumn.DataPropertyName = "Enc_Educação";
            this.encEducaçãoDataGridViewTextBoxColumn.HeaderText = "Enc_Educação";
            this.encEducaçãoDataGridViewTextBoxColumn.Name = "encEducaçãoDataGridViewTextBoxColumn";
            // 
            // observaçõesDataGridViewTextBoxColumn
            // 
            this.observaçõesDataGridViewTextBoxColumn.DataPropertyName = "Observações";
            this.observaçõesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observaçõesDataGridViewTextBoxColumn.Name = "observaçõesDataGridViewTextBoxColumn";
            // 
            // testemunhasDataGridViewTextBoxColumn
            // 
            this.testemunhasDataGridViewTextBoxColumn.DataPropertyName = "Testemunhas";
            this.testemunhasDataGridViewTextBoxColumn.HeaderText = "Testemunhas";
            this.testemunhasDataGridViewTextBoxColumn.Name = "testemunhasDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // resultadoFinalDataGridViewTextBoxColumn
            // 
            this.resultadoFinalDataGridViewTextBoxColumn.DataPropertyName = "Resultado_Final";
            this.resultadoFinalDataGridViewTextBoxColumn.HeaderText = "Resultado_Final";
            this.resultadoFinalDataGridViewTextBoxColumn.Name = "resultadoFinalDataGridViewTextBoxColumn";
            // 
            // iDAlunoDataGridViewTextBoxColumn
            // 
            this.iDAlunoDataGridViewTextBoxColumn.DataPropertyName = "ID_Aluno";
            this.iDAlunoDataGridViewTextBoxColumn.HeaderText = "ID_Aluno";
            this.iDAlunoDataGridViewTextBoxColumn.Name = "iDAlunoDataGridViewTextBoxColumn";
            // 
            // iDOcorrenciaDataGridViewTextBoxColumn
            // 
            this.iDOcorrenciaDataGridViewTextBoxColumn.DataPropertyName = "ID_Ocorrencia";
            this.iDOcorrenciaDataGridViewTextBoxColumn.HeaderText = "ID_Ocorrencia";
            this.iDOcorrenciaDataGridViewTextBoxColumn.Name = "iDOcorrenciaDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(659, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alunosAlunoOcorrênciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BaseDadosDataSet baseDadosDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private BaseDadosDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.BindingSource alunosAlunoOcorrênciaBindingSource;
        private BaseDadosDataSetTableAdapters.Aluno_OcorrênciaTableAdapter aluno_OcorrênciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diretorTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encEducaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaçõesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testemunhasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOcorrenciaDataGridViewTextBoxColumn;


    }
}