namespace Projeto_PAP
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmasTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.TurmasTableAdapter();
            this.diretor_TurmaTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Diretor_TurmaTableAdapter();
            this.turmaDiretorTurmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDiretorTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diretorTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaDiretorTurmaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(512, 249);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.turmasBindingSource;
            this.comboBox1.DisplayMember = "Turma";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID_Turma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turma";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTurmaDataGridViewTextBoxColumn,
            this.turmaDataGridViewTextBoxColumn,
            this.iDDiretorTurmaDataGridViewTextBoxColumn,
            this.diretorTurmaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.turmaDiretorTurmaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.database1DataSet;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
            // 
            // diretor_TurmaTableAdapter
            // 
            this.diretor_TurmaTableAdapter.ClearBeforeFill = true;
            // 
            // turmaDiretorTurmaBindingSource
            // 
            this.turmaDiretorTurmaBindingSource.DataMember = "Turma_DiretorTurma";
            this.turmaDiretorTurmaBindingSource.DataSource = this.database1DataSet;
            // 
            // iDTurmaDataGridViewTextBoxColumn
            // 
            this.iDTurmaDataGridViewTextBoxColumn.DataPropertyName = "ID_Turma";
            this.iDTurmaDataGridViewTextBoxColumn.HeaderText = "ID_Turma";
            this.iDTurmaDataGridViewTextBoxColumn.Name = "iDTurmaDataGridViewTextBoxColumn";
            this.iDTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTurmaDataGridViewTextBoxColumn.Visible = false;
            // 
            // turmaDataGridViewTextBoxColumn
            // 
            this.turmaDataGridViewTextBoxColumn.DataPropertyName = "Turma";
            this.turmaDataGridViewTextBoxColumn.HeaderText = "Turma";
            this.turmaDataGridViewTextBoxColumn.Name = "turmaDataGridViewTextBoxColumn";
            this.turmaDataGridViewTextBoxColumn.Visible = false;
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
            this.diretorTurmaDataGridViewTextBoxColumn.HeaderText = "Diretor_Turma";
            this.diretorTurmaDataGridViewTextBoxColumn.Name = "diretorTurmaDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 249);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaDiretorTurmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private Database1DataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private Database1DataSetTableAdapters.Diretor_TurmaTableAdapter diretor_TurmaTableAdapter;
        private System.Windows.Forms.BindingSource turmaDiretorTurmaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDiretorTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diretorTurmaDataGridViewTextBoxColumn;
    }
}