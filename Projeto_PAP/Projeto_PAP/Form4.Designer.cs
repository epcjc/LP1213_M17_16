namespace Projeto_PAP
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
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.AlunoTableAdapter();
            this.ocorrenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.iDOcorrenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testemunhasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encarregadoEducacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDiretorTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretorTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoOcorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aluno_OcorrenciaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Aluno_OcorrenciaTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoOcorrenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(224, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.database1DataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // ocorrenciaDataGridView
            // 
            this.ocorrenciaDataGridView.AutoGenerateColumns = false;
            this.ocorrenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocorrenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOcorrenciaDataGridViewTextBoxColumn,
            this.iDAlunoDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.iDProfessorDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.testemunhasDataGridViewTextBoxColumn,
            this.iDEEDataGridViewTextBoxColumn,
            this.encarregadoEducacaoDataGridViewTextBoxColumn,
            this.iDDiretorTurmaDataGridViewTextBoxColumn,
            this.diretorTurmaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.resultadoFinalDataGridViewTextBoxColumn});
            this.ocorrenciaDataGridView.DataSource = this.alunoOcorrenciaBindingSource;
            this.ocorrenciaDataGridView.Location = new System.Drawing.Point(12, 117);
            this.ocorrenciaDataGridView.Name = "ocorrenciaDataGridView";
            this.ocorrenciaDataGridView.Size = new System.Drawing.Size(963, 220);
            this.ocorrenciaDataGridView.TabIndex = 26;
            // 
            // iDOcorrenciaDataGridViewTextBoxColumn
            // 
            this.iDOcorrenciaDataGridViewTextBoxColumn.DataPropertyName = "ID_Ocorrencia";
            this.iDOcorrenciaDataGridViewTextBoxColumn.HeaderText = "Ocorrência";
            this.iDOcorrenciaDataGridViewTextBoxColumn.Name = "iDOcorrenciaDataGridViewTextBoxColumn";
            this.iDOcorrenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDAlunoDataGridViewTextBoxColumn
            // 
            this.iDAlunoDataGridViewTextBoxColumn.DataPropertyName = "ID_Aluno";
            this.iDAlunoDataGridViewTextBoxColumn.HeaderText = "ID_Aluno";
            this.iDAlunoDataGridViewTextBoxColumn.Name = "iDAlunoDataGridViewTextBoxColumn";
            this.iDAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlunoDataGridViewTextBoxColumn.Visible = false;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            // 
            // iDProfessorDataGridViewTextBoxColumn
            // 
            this.iDProfessorDataGridViewTextBoxColumn.DataPropertyName = "ID_Professor";
            this.iDProfessorDataGridViewTextBoxColumn.HeaderText = "ID_Professor";
            this.iDProfessorDataGridViewTextBoxColumn.Name = "iDProfessorDataGridViewTextBoxColumn";
            this.iDProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProfessorDataGridViewTextBoxColumn.Visible = false;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Obs.";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // testemunhasDataGridViewTextBoxColumn
            // 
            this.testemunhasDataGridViewTextBoxColumn.DataPropertyName = "Testemunhas";
            this.testemunhasDataGridViewTextBoxColumn.HeaderText = "Testemunhas";
            this.testemunhasDataGridViewTextBoxColumn.Name = "testemunhasDataGridViewTextBoxColumn";
            // 
            // iDEEDataGridViewTextBoxColumn
            // 
            this.iDEEDataGridViewTextBoxColumn.DataPropertyName = "ID_EE";
            this.iDEEDataGridViewTextBoxColumn.HeaderText = "ID_EE";
            this.iDEEDataGridViewTextBoxColumn.Name = "iDEEDataGridViewTextBoxColumn";
            this.iDEEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEEDataGridViewTextBoxColumn.Visible = false;
            // 
            // encarregadoEducacaoDataGridViewTextBoxColumn
            // 
            this.encarregadoEducacaoDataGridViewTextBoxColumn.DataPropertyName = "Encarregado_Educacao";
            this.encarregadoEducacaoDataGridViewTextBoxColumn.HeaderText = "Enc. Educação";
            this.encarregadoEducacaoDataGridViewTextBoxColumn.Name = "encarregadoEducacaoDataGridViewTextBoxColumn";
            // 
            // iDDiretorTurmaDataGridViewTextBoxColumn
            // 
            this.iDDiretorTurmaDataGridViewTextBoxColumn.DataPropertyName = "ID_Diretor_Turma";
            this.iDDiretorTurmaDataGridViewTextBoxColumn.HeaderText = "ID_Diretor_Turma";
            this.iDDiretorTurmaDataGridViewTextBoxColumn.Name = "iDDiretorTurmaDataGridViewTextBoxColumn";
            this.iDDiretorTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDiretorTurmaDataGridViewTextBoxColumn.Visible = false;
            // 
            // diretorTurmaDataGridViewTextBoxColumn
            // 
            this.diretorTurmaDataGridViewTextBoxColumn.DataPropertyName = "Diretor_Turma";
            this.diretorTurmaDataGridViewTextBoxColumn.HeaderText = "Diretor Turma";
            this.diretorTurmaDataGridViewTextBoxColumn.Name = "diretorTurmaDataGridViewTextBoxColumn";
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
            this.resultadoFinalDataGridViewTextBoxColumn.HeaderText = "Resultado Final";
            this.resultadoFinalDataGridViewTextBoxColumn.Name = "resultadoFinalDataGridViewTextBoxColumn";
            // 
            // alunoOcorrenciaBindingSource
            // 
            this.alunoOcorrenciaBindingSource.DataMember = "Aluno_Ocorrencia";
            this.alunoOcorrenciaBindingSource.DataSource = this.database1DataSet;
            // 
            // aluno_OcorrenciaTableAdapter
            // 
            this.aluno_OcorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Escola Profissional Centro Juvenil de Campanhã";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ocorrências";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ocorrenciaDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoOcorrenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Database1DataSetTableAdapters.Aluno_OcorrenciaTableAdapter aluno_OcorrenciaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private Database1DataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.DataGridView ocorrenciaDataGridView;
        private System.Windows.Forms.BindingSource alunoOcorrenciaBindingSource;
        private Database1DataSetTableAdapters.Aluno_OcorrenciaTableAdapter aluno_OcorrenciaTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOcorrenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testemunhasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encarregadoEducacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDiretorTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diretorTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}