namespace Компания_ЖизньФарм
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_aptekiDataSet = new Компания_ЖизньФарм.BD_aptekiDataSet();
            this.tovarTableAdapter = new Компания_ЖизньФарм.BD_aptekiDataSetTableAdapters.TovarTableAdapter();
            this.add_click = new System.Windows.Forms.Button();
            this.delete_click = new System.Windows.Forms.Button();
            this.redactor_click = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_aptekiDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.наименованиеТовараDataGridViewTextBoxColumn,
            this.описаниеТовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // наименованиеТовараDataGridViewTextBoxColumn
            // 
            this.наименованиеТовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.Name = "наименованиеТовараDataGridViewTextBoxColumn";
            // 
            // описаниеТовараDataGridViewTextBoxColumn
            // 
            this.описаниеТовараDataGridViewTextBoxColumn.DataPropertyName = "Описание товара";
            this.описаниеТовараDataGridViewTextBoxColumn.HeaderText = "Описание товара";
            this.описаниеТовараDataGridViewTextBoxColumn.Name = "описаниеТовараDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.bD_aptekiDataSet;
            // 
            // bD_aptekiDataSet
            // 
            this.bD_aptekiDataSet.DataSetName = "BD_aptekiDataSet";
            this.bD_aptekiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // add_click
            // 
            this.add_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_click.Location = new System.Drawing.Point(12, 359);
            this.add_click.Name = "add_click";
            this.add_click.Size = new System.Drawing.Size(247, 37);
            this.add_click.TabIndex = 2;
            this.add_click.Text = "Добавить данные";
            this.add_click.UseVisualStyleBackColor = true;
            this.add_click.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_click
            // 
            this.delete_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_click.Location = new System.Drawing.Point(265, 359);
            this.delete_click.Name = "delete_click";
            this.delete_click.Size = new System.Drawing.Size(247, 37);
            this.delete_click.TabIndex = 3;
            this.delete_click.Text = "Удалить данные";
            this.delete_click.UseVisualStyleBackColor = true;
            this.delete_click.Click += new System.EventHandler(this.delete_click_Click);
            // 
            // redactor_click
            // 
            this.redactor_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redactor_click.Location = new System.Drawing.Point(520, 359);
            this.redactor_click.Name = "redactor_click";
            this.redactor_click.Size = new System.Drawing.Size(247, 37);
            this.redactor_click.TabIndex = 4;
            this.redactor_click.Text = "Редактировать данные";
            this.redactor_click.UseVisualStyleBackColor = true;
            this.redactor_click.Click += new System.EventHandler(this.redactor_click_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНазадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяНазадToolStripMenuItem
            // 
            this.вернутьсяНазадToolStripMenuItem.Name = "вернутьсяНазадToolStripMenuItem";
            this.вернутьсяНазадToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.вернутьсяНазадToolStripMenuItem.Text = "Вернуться назад";
            this.вернутьсяНазадToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНазадToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 410);
            this.ControlBox = false;
            this.Controls.Add(this.redactor_click);
            this.Controls.Add(this.delete_click);
            this.Controls.Add(this.add_click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_aptekiDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_aptekiDataSet bD_aptekiDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private BD_aptekiDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button add_click;
        private System.Windows.Forms.Button delete_click;
        private System.Windows.Forms.Button redactor_click;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНазадToolStripMenuItem;
    }
}