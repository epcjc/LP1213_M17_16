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
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoOcorrenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(215, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Voltar";
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
            this.ocorrenciaDataGridView.AllowUserToAddRows = false;
            this.ocorrenciaDataGridView.AllowUserToDeleteRows = false;
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
            this.ocorrenciaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocorrenciaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ocorrenciaDataGridView.Name = "ocorrenciaDataGridView";
            this.ocorrenciaDataGridView.ReadOnly = true;
            this.ocorrenciaDataGridView.Size = new System.Drawing.Size(987, 223);
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
            this.alunoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.professorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Obs.";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testemunhasDataGridViewTextBoxColumn
            // 
            this.testemunhasDataGridViewTextBoxColumn.DataPropertyName = "Testemunhas";
            this.testemunhasDataGridViewTextBoxColumn.HeaderText = "Testemunhas";
            this.testemunhasDataGridViewTextBoxColumn.Name = "testemunhasDataGridViewTextBoxColumn";
            this.testemunhasDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.encarregadoEducacaoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.diretorTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultadoFinalDataGridViewTextBoxColumn
            // 
            this.resultadoFinalDataGridViewTextBoxColumn.DataPropertyName = "Resultado_Final";
            this.resultadoFinalDataGridViewTextBoxColumn.HeaderText = "Resultado Final";
            this.resultadoFinalDataGridViewTextBoxColumn.Name = "resultadoFinalDataGridViewTextBoxColumn";
            this.resultadoFinalDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(987, 60);
            this.label10.TabIndex = 23;
            this.label10.Text = "Escola Profissional Centro Juvenil de Campanhã";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(109, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(987, 349);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 28;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ocorrenciaDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(987, 285);
            this.splitContainer2.SplitterDistance = 223;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(987, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 36);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(987, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 349);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.Text = "Ocorrências";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoOcorrenciaBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}