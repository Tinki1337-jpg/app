namespace MyApp
{
    partial class Form7
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
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.успеваемость_студентаDataSet = new MyApp.Успеваемость_студентаDataSet();
            this.посещаемостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.успеваемость_студентаDataSet2 = new MyApp.Успеваемость_студентаDataSet2();
            this.посещаемостьTableAdapter = new MyApp.Успеваемость_студентаDataSet2TableAdapters.ПосещаемостьTableAdapter();
            this.студентыTableAdapter = new MyApp.Успеваемость_студентаDataSetTableAdapters.СтудентыTableAdapter();
            this.студентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.студентыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодстудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.студентыBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количествоПропусковDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посещаемостьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.успеваемость_студентаDataSet3 = new MyApp.Успеваемость_студентаDataSet3();
            this.студентыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.посещаемостьTableAdapter1 = new MyApp.Успеваемость_студентаDataSet3TableAdapters.ПосещаемостьTableAdapter();
            this.студентыTableAdapter1 = new MyApp.Успеваемость_студентаDataSet3TableAdapters.СтудентыTableAdapter();
            this.студентыBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.дисциплиныTableAdapter = new MyApp.Успеваемость_студентаDataSetTableAdapters.ДисциплиныTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещаемостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещаемостьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.успеваемость_студентаDataSet;
            // 
            // успеваемость_студентаDataSet
            // 
            this.успеваемость_студентаDataSet.DataSetName = "Успеваемость_студентаDataSet";
            this.успеваемость_студентаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посещаемостьBindingSource
            // 
            this.посещаемостьBindingSource.DataMember = "Посещаемость";
            this.посещаемостьBindingSource.DataSource = this.успеваемость_студентаDataSet2;
            // 
            // успеваемость_студентаDataSet2
            // 
            this.успеваемость_студентаDataSet2.DataSetName = "Успеваемость_студентаDataSet2";
            this.успеваемость_студентаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // посещаемостьTableAdapter
            // 
            this.посещаемостьTableAdapter.ClearBeforeFill = true;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // студентыBindingSource1
            // 
            this.студентыBindingSource1.DataMember = "Студенты";
            this.студентыBindingSource1.DataSource = this.успеваемость_студентаDataSet;
            // 
            // студентыBindingSource2
            // 
            this.студентыBindingSource2.DataMember = "Студенты";
            this.студентыBindingSource2.DataSource = this.успеваемость_студентаDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодстудентаDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.количествоПропусковDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.посещаемостьBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодстудентаDataGridViewTextBoxColumn
            // 
            this.кодстудентаDataGridViewTextBoxColumn.DataPropertyName = "Кодстудента";
            this.кодстудентаDataGridViewTextBoxColumn.HeaderText = "Кодстудента";
            this.кодстудентаDataGridViewTextBoxColumn.Name = "кодстудентаDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Кодстудента";
            this.Column1.DataSource = this.студентыBindingSource5;
            this.Column1.DisplayMember = "ФИО";
            this.Column1.HeaderText = "ФИО студента";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "КодСтудента";
            // 
            // студентыBindingSource5
            // 
            this.студентыBindingSource5.DataMember = "Студенты";
            this.студентыBindingSource5.DataSource = this.успеваемость_студентаDataSet;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Коддисциплины";
            this.Column2.DataSource = this.дисциплиныBindingSource;
            this.Column2.DisplayMember = "НазваниеДисциплины";
            this.Column2.HeaderText = "Дисциплина";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "КодДисциплины";
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.успеваемость_студентаDataSet;
            // 
            // количествоПропусковDataGridViewTextBoxColumn
            // 
            this.количествоПропусковDataGridViewTextBoxColumn.DataPropertyName = "Количество пропусков";
            this.количествоПропусковDataGridViewTextBoxColumn.HeaderText = "Количество пропусков";
            this.количествоПропусковDataGridViewTextBoxColumn.Name = "количествоПропусковDataGridViewTextBoxColumn";
            // 
            // посещаемостьBindingSource1
            // 
            this.посещаемостьBindingSource1.DataMember = "Посещаемость";
            this.посещаемостьBindingSource1.DataSource = this.успеваемость_студентаDataSet3;
            // 
            // успеваемость_студентаDataSet3
            // 
            this.успеваемость_студентаDataSet3.DataSetName = "Успеваемость_студентаDataSet3";
            this.успеваемость_студентаDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource3
            // 
            this.студентыBindingSource3.DataMember = "Студенты";
            this.студентыBindingSource3.DataSource = this.успеваемость_студентаDataSet3;
            // 
            // посещаемостьTableAdapter1
            // 
            this.посещаемостьTableAdapter1.ClearBeforeFill = true;
            // 
            // студентыTableAdapter1
            // 
            this.студентыTableAdapter1.ClearBeforeFill = true;
            // 
            // студентыBindingSource4
            // 
            this.студентыBindingSource4.DataMember = "Студенты";
            this.студентыBindingSource4.DataSource = this.успеваемость_студентаDataSet;
            // 
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Внести изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Посещаемость";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещаемостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещаемостьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Успеваемость_студентаDataSet2 успеваемость_студентаDataSet2;
        private System.Windows.Forms.BindingSource посещаемостьBindingSource;
        private Успеваемость_студентаDataSet2TableAdapters.ПосещаемостьTableAdapter посещаемостьTableAdapter;
        private Успеваемость_студентаDataSet успеваемость_студентаDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private Успеваемость_студентаDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.BindingSource студентыBindingSource1;
        private System.Windows.Forms.BindingSource студентыBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Успеваемость_студентаDataSet3 успеваемость_студентаDataSet3;
        private System.Windows.Forms.BindingSource посещаемостьBindingSource1;
        private Успеваемость_студентаDataSet3TableAdapters.ПосещаемостьTableAdapter посещаемостьTableAdapter1;
        private System.Windows.Forms.BindingSource студентыBindingSource3;
        private Успеваемость_студентаDataSet3TableAdapters.СтудентыTableAdapter студентыTableAdapter1;
        private System.Windows.Forms.BindingSource студентыBindingSource4;
        private System.Windows.Forms.BindingSource студентыBindingSource5;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private Успеваемость_студентаDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодстудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПропусковDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}