namespace Компания_ЖизньФарм
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
            this.bD_aptekiDataSet = new Компания_ЖизньФарм.BD_aptekiDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new Компания_ЖизньФарм.BD_aptekiDataSetTableAdapters.TovarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bD_aptekiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_aptekiDataSet
            // 
            this.bD_aptekiDataSet.DataSetName = "BD_aptekiDataSet";
            this.bD_aptekiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.bD_aptekiDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компания \"ЖизньФарм\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Выход";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(6, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Товары";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(6, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сотрудники";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(6, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 37);
            this.button6.TabIndex = 9;
            this.button6.Text = "Клиенты";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(6, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(258, 37);
            this.button7.TabIndex = 10;
            this.button7.Text = "Заказы";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 231);
            this.ControlBox = false;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компания \"ЖизньФарм\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_aptekiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BD_aptekiDataSet bD_aptekiDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private BD_aptekiDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

