namespace Компания_ЖизньФарм
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.redactor_click = new System.Windows.Forms.Button();
            this.delete_click = new System.Windows.Forms.Button();
            this.add_click = new System.Windows.Forms.Button();
            this.bD_aptekiDataSet = new Компания_ЖизньФарм.BD_aptekiDataSet();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new Компания_ЖизньФарм.BD_aptekiDataSetTableAdapters.ZakazTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итоговаяСуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_aptekiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНазадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяНазадToolStripMenuItem
            // 
            this.вернутьсяНазадToolStripMenuItem.Name = "вернутьсяНазадToolStripMenuItem";
            this.вернутьсяНазадToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.вернутьсяНазадToolStripMenuItem.Text = "Вернуться назад";
            this.вернутьсяНазадToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНазадToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.составЗаказаDataGridViewTextBoxColumn,
            this.итоговаяСуммаDataGridViewTextBoxColumn,
            this.пунктВыдачиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 326);
            this.dataGridView1.TabIndex = 8;
            // 
            // redactor_click
            // 
            this.redactor_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redactor_click.Location = new System.Drawing.Point(520, 359);
            this.redactor_click.Name = "redactor_click";
            this.redactor_click.Size = new System.Drawing.Size(247, 37);
            this.redactor_click.TabIndex = 13;
            this.redactor_click.Text = "Редактировать данные";
            this.redactor_click.UseVisualStyleBackColor = true;
            this.redactor_click.Click += new System.EventHandler(this.redactor_click_Click);
            // 
            // delete_click
            // 
            this.delete_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_click.Location = new System.Drawing.Point(265, 359);
            this.delete_click.Name = "delete_click";
            this.delete_click.Size = new System.Drawing.Size(247, 37);
            this.delete_click.TabIndex = 12;
            this.delete_click.Text = "Удалить данные";
            this.delete_click.UseVisualStyleBackColor = true;
            this.delete_click.Click += new System.EventHandler(this.delete_click_Click);
            // 
            // add_click
            // 
            this.add_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_click.Location = new System.Drawing.Point(12, 359);
            this.add_click.Name = "add_click";
            this.add_click.Size = new System.Drawing.Size(247, 37);
            this.add_click.TabIndex = 11;
            this.add_click.Text = "Добавить данные";
            this.add_click.UseVisualStyleBackColor = true;
            this.add_click.Click += new System.EventHandler(this.add_click_Click);
            // 
            // bD_aptekiDataSet
            // 
            this.bD_aptekiDataSet.DataSetName = "BD_aptekiDataSet";
            this.bD_aptekiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.bD_aptekiDataSet;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // составЗаказаDataGridViewTextBoxColumn
            // 
            this.составЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Состав заказа";
            this.составЗаказаDataGridViewTextBoxColumn.HeaderText = "Состав заказа";
            this.составЗаказаDataGridViewTextBoxColumn.Name = "составЗаказаDataGridViewTextBoxColumn";
            // 
            // итоговаяСуммаDataGridViewTextBoxColumn
            // 
            this.итоговаяСуммаDataGridViewTextBoxColumn.DataPropertyName = "Итоговая сумма";
            this.итоговаяСуммаDataGridViewTextBoxColumn.HeaderText = "Итоговая сумма";
            this.итоговаяСуммаDataGridViewTextBoxColumn.Name = "итоговаяСуммаDataGridViewTextBoxColumn";
            // 
            // пунктВыдачиDataGridViewTextBoxColumn
            // 
            this.пунктВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Пункт выдачи";
            this.пунктВыдачиDataGridViewTextBoxColumn.HeaderText = "Пункт выдачи";
            this.пунктВыдачиDataGridViewTextBoxColumn.Name = "пунктВыдачиDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.ControlBox = false;
            this.Controls.Add(this.redactor_click);
            this.Controls.Add(this.delete_click);
            this.Controls.Add(this.add_click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_aptekiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНазадToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button redactor_click;
        private System.Windows.Forms.Button delete_click;
        private System.Windows.Forms.Button add_click;
        private BD_aptekiDataSet bD_aptekiDataSet;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private BD_aptekiDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn составЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итоговаяСуммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктВыдачиDataGridViewTextBoxColumn;
    }
}