namespace Projeto_PAP
{
    partial class frmOcorrenciaPorAluno
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Projeto_PAP.Database1DataSet1();
            this.alunosOcorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.alunosOcorrenciaTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.AlunosOcorrenciaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOcorrenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFactosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNotificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDisciplinarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKOcorrenciaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKOcorrenciaTestemunhasAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.AlunoTableAdapter();
            this.ocorrenciaTestemunhasTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter();
            this.ocorrenciaTableAdapter = new Projeto_PAP.Database1DataSet1TableAdapters.OcorrenciaTableAdapter();
            this.tableAdapterManager = new Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosOcorrenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOcorrenciaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOcorrenciaTestemunhasAlunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.alunoBindingSource;
            this.comboBox1.DisplayMember = "Aluno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_Aluno";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosOcorrenciaBindingSource
            // 
            this.alunosOcorrenciaBindingSource.DataMember = "AlunosOcorrencia";
            this.alunosOcorrenciaBindingSource.DataSource = this.database1DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluno:";
            // 
            // alunosOcorrenciaTableAdapter
            // 
            this.alunosOcorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOcorrenciaDataGridViewTextBoxColumn,
            this.dataFactosDataGridViewTextBoxColumn,
            this.instrutorDataGridViewTextBoxColumn,
            this.dataNotificacaoDataGridViewTextBoxColumn,
            this.medidaDisciplinarDataGridViewTextBoxColumn,
            this.estado});
            this.dataGridView1.DataSource = this.fKOcorrenciaAlunoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 93);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // iDOcorrenciaDataGridViewTextBoxColumn
            // 
            this.iDOcorrenciaDataGridViewTextBoxColumn.DataPropertyName = "ID_Ocorrencia";
            this.iDOcorrenciaDataGridViewTextBoxColumn.HeaderText = "ID_Ocorrencia";
            this.iDOcorrenciaDataGridViewTextBoxColumn.Name = "iDOcorrenciaDataGridViewTextBoxColumn";
            this.iDOcorrenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFactosDataGridViewTextBoxColumn
            // 
            this.dataFactosDataGridViewTextBoxColumn.DataPropertyName = "Data_Factos";
            this.dataFactosDataGridViewTextBoxColumn.HeaderText = "Data_Factos";
            this.dataFactosDataGridViewTextBoxColumn.Name = "dataFactosDataGridViewTextBoxColumn";
            // 
            // instrutorDataGridViewTextBoxColumn
            // 
            this.instrutorDataGridViewTextBoxColumn.DataPropertyName = "Instrutor";
            this.instrutorDataGridViewTextBoxColumn.HeaderText = "Instrutor";
            this.instrutorDataGridViewTextBoxColumn.Name = "instrutorDataGridViewTextBoxColumn";
            // 
            // dataNotificacaoDataGridViewTextBoxColumn
            // 
            this.dataNotificacaoDataGridViewTextBoxColumn.DataPropertyName = "Data_Notificacao";
            this.dataNotificacaoDataGridViewTextBoxColumn.HeaderText = "Data_Notificacao";
            this.dataNotificacaoDataGridViewTextBoxColumn.Name = "dataNotificacaoDataGridViewTextBoxColumn";
            // 
            // medidaDisciplinarDataGridViewTextBoxColumn
            // 
            this.medidaDisciplinarDataGridViewTextBoxColumn.DataPropertyName = "Medida_Disciplinar";
            this.medidaDisciplinarDataGridViewTextBoxColumn.HeaderText = "Medida_Disciplinar";
            this.medidaDisciplinarDataGridViewTextBoxColumn.Name = "medidaDisciplinarDataGridViewTextBoxColumn";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            // 
            // fKOcorrenciaAlunoBindingSource
            // 
            this.fKOcorrenciaAlunoBindingSource.DataMember = "FK_Ocorrencia_Aluno";
            this.fKOcorrenciaAlunoBindingSource.DataSource = this.alunoBindingSource;
            // 
            // fKOcorrenciaTestemunhasAlunoBindingSource
            // 
            this.fKOcorrenciaTestemunhasAlunoBindingSource.DataMember = "FK_OcorrenciaTestemunhas_Aluno";
            this.fKOcorrenciaTestemunhasAlunoBindingSource.DataSource = this.alunoBindingSource;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // ocorrenciaTestemunhasTableAdapter
            // 
            this.ocorrenciaTestemunhasTableAdapter.ClearBeforeFill = true;
            // 
            // ocorrenciaTableAdapter
            // 
            this.ocorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Diretor_TurmaTableAdapter = null;
            this.tableAdapterManager.Medida_DisciplinarTableAdapter = null;
            this.tableAdapterManager.OcorrenciaTableAdapter = this.ocorrenciaTableAdapter;
            this.tableAdapterManager.OcorrenciaTestemunhasTableAdapter = this.ocorrenciaTestemunhasTableAdapter;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.TurmasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_PAP.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmOcorrenciaPorAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmOcorrenciaPorAluno";
            this.Text = "Ocorrencia Por Aluno";
            this.Load += new System.EventHandler(this.frmOcorrenciaPorAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosOcorrenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOcorrenciaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOcorrenciaTestemunhasAlunoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource alunosOcorrenciaBindingSource;
        private Database1DataSet1TableAdapters.AlunosOcorrenciaTableAdapter alunosOcorrenciaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private Database1DataSet1TableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.BindingSource fKOcorrenciaTestemunhasAlunoBindingSource;
        private Database1DataSet1TableAdapters.OcorrenciaTestemunhasTableAdapter ocorrenciaTestemunhasTableAdapter;
        private System.Windows.Forms.BindingSource fKOcorrenciaAlunoBindingSource;
        private Database1DataSet1TableAdapters.OcorrenciaTableAdapter ocorrenciaTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOcorrenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFactosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNotificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDisciplinarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}