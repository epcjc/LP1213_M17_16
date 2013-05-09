namespace M17
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baseDadosDataSet = new M17.BaseDadosDataSet();
            this.encarregadoEducaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encarregado_EducaçãoTableAdapter = new M17.BaseDadosDataSetTableAdapters.Encarregado_EducaçãoTableAdapter();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encarregadoEducaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encarregadoEducaçãoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alunoDataGridViewTextBoxColumn,
            this.encarregadoEducaçãoDataGridViewTextBoxColumn,
            this.contatoEEDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.encarregadoEducaçãoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // baseDadosDataSet
            // 
            this.baseDadosDataSet.DataSetName = "BaseDadosDataSet";
            this.baseDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encarregadoEducaçãoBindingSource
            // 
            this.encarregadoEducaçãoBindingSource.DataMember = "Encarregado_Educação";
            this.encarregadoEducaçãoBindingSource.DataSource = this.baseDadosDataSet;
            // 
            // encarregado_EducaçãoTableAdapter
            // 
            this.encarregado_EducaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            // 
            // encarregadoEducaçãoDataGridViewTextBoxColumn
            // 
            this.encarregadoEducaçãoDataGridViewTextBoxColumn.DataPropertyName = "Encarregado_Educação";
            this.encarregadoEducaçãoDataGridViewTextBoxColumn.HeaderText = "Encarregado_Educação";
            this.encarregadoEducaçãoDataGridViewTextBoxColumn.Name = "encarregadoEducaçãoDataGridViewTextBoxColumn";
            // 
            // contatoEEDataGridViewTextBoxColumn
            // 
            this.contatoEEDataGridViewTextBoxColumn.DataPropertyName = "Contato_EE";
            this.contatoEEDataGridViewTextBoxColumn.HeaderText = "Contato_EE";
            this.contatoEEDataGridViewTextBoxColumn.Name = "contatoEEDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encarregadoEducaçãoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BaseDadosDataSet baseDadosDataSet;
        private System.Windows.Forms.BindingSource encarregadoEducaçãoBindingSource;
        private BaseDadosDataSetTableAdapters.Encarregado_EducaçãoTableAdapter encarregado_EducaçãoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encarregadoEducaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}