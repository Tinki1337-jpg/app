namespace MyApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.успеваемость_студентаDataSet = new MyApp.Успеваемость_студентаDataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new MyApp.Успеваемость_студентаDataSetTableAdapters.СтудентыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.оценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиTableAdapter = new MyApp.Успеваемость_студентаDataSetTableAdapters.ОценкиTableAdapter();
            this.студентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.оценкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.студентыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttun4 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.студентыОценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыОценкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // успеваемость_студентаDataSet
            // 
            this.успеваемость_студентаDataSet.DataSetName = "Успеваемость_студентаDataSet";
            this.успеваемость_студентаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.успеваемость_студентаDataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Студенты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Дисциплины";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Группы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // оценкиBindingSource
            // 
            this.оценкиBindingSource.DataMember = "Оценки";
            this.оценкиBindingSource.DataSource = this.успеваемость_студентаDataSet;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // студентыBindingSource1
            // 
            this.студентыBindingSource1.DataMember = "Студенты";
            this.студентыBindingSource1.DataSource = this.успеваемость_студентаDataSet;
            // 
            // оценкиBindingSource1
            // 
            this.оценкиBindingSource1.DataMember = "Оценки";
            this.оценкиBindingSource1.DataSource = this.успеваемость_студентаDataSet;
            // 
            // студентыBindingSource2
            // 
            this.студентыBindingSource2.DataMember = "Студенты";
            this.студентыBindingSource2.DataSource = this.успеваемость_студентаDataSet;
            // 
            // buttun4
            // 
            this.buttun4.Location = new System.Drawing.Point(291, 271);
            this.buttun4.Name = "buttun4";
            this.buttun4.Size = new System.Drawing.Size(197, 47);
            this.buttun4.TabIndex = 4;
            this.buttun4.Text = "Оценки";
            this.buttun4.UseVisualStyleBackColor = true;
            this.buttun4.Click += new System.EventHandler(this.buttun4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Факультеты";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // студентыОценкиBindingSource
            // 
            this.студентыОценкиBindingSource.DataMember = "СтудентыОценки";
            this.студентыОценкиBindingSource.DataSource = this.студентыBindingSource;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(291, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "Посещаемость";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttun4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Успеваемость студентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.успеваемость_студентаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оценкиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыОценкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Успеваемость_студентаDataSet успеваемость_студентаDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private Успеваемость_студентаDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource оценкиBindingSource;
        private Успеваемость_студентаDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.BindingSource студентыBindingSource1;
        private System.Windows.Forms.BindingSource студентыОценкиBindingSource;
        private System.Windows.Forms.BindingSource студентыBindingSource2;
        private System.Windows.Forms.BindingSource оценкиBindingSource1;
        private System.Windows.Forms.Button buttun4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

