namespace Projeto_PAP
{
    partial class Form3
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
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alunoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.AlunoTableAdapter();
            this.database1DataSet1 = new Projeto_PAP.Database1DataSet();
            this.encEducaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enc_EducaçãoTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Enc_EducaçãoTableAdapter();
            this.iDAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encarregadoEducacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encEducaçãoBindingSource)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(565, 261);
            this.splitContainer1.SplitterDistance = 71;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.alunoBindingSource;
            this.comboBox1.DisplayMember = "Aluno";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID_Aluno";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlunoDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.iDEEDataGridViewTextBoxColumn,
            this.encarregadoEducacaoDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.encEducaçãoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encEducaçãoBindingSource
            // 
            this.encEducaçãoBindingSource.DataMember = "Enc_Educação";
            this.encEducaçãoBindingSource.DataSource = this.database1DataSet1;
            // 
            // enc_EducaçãoTableAdapter
            // 
            this.enc_EducaçãoTableAdapter.ClearBeforeFill = true;
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
            this.alunoDataGridViewTextBoxColumn.Visible = false;
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
            this.encarregadoEducacaoDataGridViewTextBoxColumn.HeaderText = "Encarregado_Educacao";
            this.encarregadoEducacaoDataGridViewTextBoxColumn.Name = "encarregadoEducacaoDataGridViewTextBoxColumn";
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encEducaçãoBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private Database1DataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource encEducaçãoBindingSource;
        private Database1DataSetTableAdapters.Enc_EducaçãoTableAdapter enc_EducaçãoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encarregadoEducacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
    }
}