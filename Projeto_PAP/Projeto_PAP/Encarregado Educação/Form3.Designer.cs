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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet = new Projeto_PAP.Database1DataSet();
            this.encarregado_EducacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.iDAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encarregadoEducacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAvisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoEncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.aluno_EncTableAdapter = new Projeto_PAP.Database1DataSetTableAdapters.Aluno_EncTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encarregado_EducacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoEncBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escola Profissional Centro Juvenil de Campanhã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encarregado_EducacaoDataGridView
            // 
            this.encarregado_EducacaoDataGridView.AllowUserToAddRows = false;
            this.encarregado_EducacaoDataGridView.AllowUserToDeleteRows = false;
            this.encarregado_EducacaoDataGridView.AutoGenerateColumns = false;
            this.encarregado_EducacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encarregado_EducacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlunoDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.iDEEDataGridViewTextBoxColumn,
            this.encarregadoEducacaoDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.viaContactoDataGridViewTextBoxColumn,
            this.dataAvisoDataGridViewTextBoxColumn});
            this.encarregado_EducacaoDataGridView.DataSource = this.alunoEncBindingSource;
            this.encarregado_EducacaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encarregado_EducacaoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.encarregado_EducacaoDataGridView.Name = "encarregado_EducacaoDataGridView";
            this.encarregado_EducacaoDataGridView.ReadOnly = true;
            this.encarregado_EducacaoDataGridView.Size = new System.Drawing.Size(769, 268);
            this.encarregado_EducacaoDataGridView.TabIndex = 12;
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
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viaContactoDataGridViewTextBoxColumn
            // 
            this.viaContactoDataGridViewTextBoxColumn.DataPropertyName = "Via_Contacto";
            this.viaContactoDataGridViewTextBoxColumn.HeaderText = "Via Contacto";
            this.viaContactoDataGridViewTextBoxColumn.Name = "viaContactoDataGridViewTextBoxColumn";
            this.viaContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAvisoDataGridViewTextBoxColumn
            // 
            this.dataAvisoDataGridViewTextBoxColumn.DataPropertyName = "Data_Aviso";
            this.dataAvisoDataGridViewTextBoxColumn.HeaderText = "Data Aviso";
            this.dataAvisoDataGridViewTextBoxColumn.Name = "dataAvisoDataGridViewTextBoxColumn";
            this.dataAvisoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alunoEncBindingSource
            // 
            this.alunoEncBindingSource.DataMember = "Aluno_Enc";
            this.alunoEncBindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Voltar ao Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Inserir Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(122, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Listar/Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Location = new System.Drawing.Point(360, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(769, 389);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 17;
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
            this.splitContainer2.Panel1.Controls.Add(this.encarregado_EducacaoDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(769, 332);
            this.splitContainer2.SplitterDistance = 268;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 38);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.Location = new System.Drawing.Point(241, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 38);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(769, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // aluno_EncTableAdapter
            // 
            this.aluno_EncTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 389);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Encarregados de Educação";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encarregado_EducacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoEncBindingSource)).EndInit();
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

        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.DataGridView encarregado_EducacaoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource alunoEncBindingSource;
        private Database1DataSetTableAdapters.Aluno_EncTableAdapter aluno_EncTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encarregadoEducacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAvisoDataGridViewTextBoxColumn;

    }
}