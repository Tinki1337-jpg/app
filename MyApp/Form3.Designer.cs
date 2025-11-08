namespace MyApp
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
            this.кодДисциплиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДисциплиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.факультетыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.успеваемость_студентаDataSet = new MyApp.Успеваемость_студентаDataSet();
            this.часыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дисциплиныTableAdapter = new MyApp.Успеваемость_студентаDataSetTableAdapters.ДисциплиныTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.факультетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультетыTableAdapter = new MyApp.Успеваемость_студентаDataSetTableAdapters.ФакультетыTableAdapter();
            this.успеваемость_студентаDataSet1 = new MyApp.Успеваемость_студентаDataSet();
            this.успеваемость_студентаDataSet11 = new MyApp.Успеваемость_студентаDataSet1();
            this.факультетыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.факультетыTableAdapter1 = new MyApp.Успеваемость_студентаDataSet1TableAdapters.ФакультетыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДисциплиныDataGridViewTextBoxColumn,
            this.названиеДисциплиныDataGridViewTextBoxColumn,
            this.Column1,
            this.часыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дисциплиныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодДисциплиныDataGridViewTextBoxColumn
            // 
            this.кодДисциплиныDataGridViewTextBoxColumn.DataPropertyName = "КодДисциплины";
            this.кодДисциплиныDataGridViewTextBoxColumn.HeaderText = "КодДисциплины";
            this.кодДисциплиныDataGridViewTextBoxColumn.Name = "кодДисциплиныDataGridViewTextBoxColumn";
            // 
            // названиеДисциплиныDataGridViewTextBoxColumn
            // 
            this.названиеДисциплиныDataGridViewTextBoxColumn.DataPropertyName = "НазваниеДисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn.HeaderText = "НазваниеДисциплины";
            this.названиеДисциплиныDataGridViewTextBoxColumn.Name = "названиеДисциплиныDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "КодФаукльтета";
            this.Column1.DataSource = this.факультетыBindingSource1;
            this.Column1.DisplayMember = "Наименование";
            this.Column1.HeaderText = "Факультет";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "Кодфакультета";
            // 
            // факультетыBindingSource1
            // 
            this.факультетыBindingSource1.DataMember = "Факультеты";
            this.факультетыBindingSource1.DataSource = this.успеваемость_студентаDataSet;
            // 
            // успеваемость_студентаDataSet
            // 
            this.успеваемость_студентаDataSet.DataSetName = "Успеваемость_студентаDataSet";
            this.успеваемость_студентаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // часыDataGridViewTextBoxColumn
            // 
            this.часыDataGridViewTextBoxColumn.DataPropertyName = "Часы";
            this.часыDataGridViewTextBoxColumn.HeaderText = "Часы";
            this.часыDataGridViewTextBoxColumn.Name = "часыDataGridViewTextBoxColumn";
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.успеваемость_студентаDataSet;
            // 
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // факультетыBindingSource
            // 
            this.факультетыBindingSource.DataMember = "Факультеты";
            this.факультетыBindingSource.DataSource = this.успеваемость_студентаDataSet;
            // 
            // факультетыTableAdapter
            // 
            this.факультетыTableAdapter.ClearBeforeFill = true;
            // 
            // успеваемость_студентаDataSet1
            // 
            this.успеваемость_студентаDataSet1.DataSetName = "Успеваемость_студентаDataSet";
            this.успеваемость_студентаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // успеваемость_студентаDataSet11
            // 
            this.успеваемость_студентаDataSet11.DataSetName = "Успеваемость_студентаDataSet1";
            this.успеваемость_студентаDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // факультетыBindingSource2
            // 
            this.факультетыBindingSource2.DataMember = "Факультеты";
            this.факультетыBindingSource2.DataSource = this.успеваемость_студентаDataSet11;
            // 
            // факультетыTableAdapter1
            // 
            this.факультетыTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Успеваемость_студентаDataSet успеваемость_студентаDataSet;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private Успеваемость_студентаDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource факультетыBindingSource;
        private Успеваемость_студентаDataSetTableAdapters.ФакультетыTableAdapter факультетыTableAdapter;
        private System.Windows.Forms.BindingSource факультетыBindingSource1;
        private Успеваемость_студентаDataSet успеваемость_студентаDataSet1;
        private Успеваемость_студентаDataSet1 успеваемость_студентаDataSet11;
        private System.Windows.Forms.BindingSource факультетыBindingSource2;
        private Успеваемость_студентаDataSet1TableAdapters.ФакультетыTableAdapter факультетыTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыDataGridViewTextBoxColumn;
    }
}