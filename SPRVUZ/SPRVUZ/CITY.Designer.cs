namespace SPRVUZ
{
    partial class CITY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CITY));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grayTXT1 = new SPRVUZ.GrayTXT();
            this.Serch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.городаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vUZBDDataSet = new SPRVUZ.VUZBDDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ADd = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDгородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиегородаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городаTableAdapter = new SPRVUZ.VUZBDDataSetTableAdapters.ГородаTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BACKBUT = new System.Windows.Forms.Button();
            this.UPDATEBUT = new System.Windows.Forms.Button();
            this.ClearBUT = new System.Windows.Forms.Button();
            this.DELBUT = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.OTmena = new System.Windows.Forms.Button();
            this.ADDD = new System.Windows.Forms.Button();
            this.NAMECity = new SPRVUZ.GrayTXT();
            this.IDCITY = new SPRVUZ.GrayTXT();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUZBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.grayTXT1);
            this.panel1.Controls.Add(this.Serch);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 35);
            this.panel1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ID города",
            "Название города"});
            this.comboBox2.Location = new System.Drawing.Point(13, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // grayTXT1
            // 
            this.grayTXT1.Cue = "Вбейте название города или ID";
            this.grayTXT1.Location = new System.Drawing.Point(177, 9);
            this.grayTXT1.Name = "grayTXT1";
            this.grayTXT1.Size = new System.Drawing.Size(190, 20);
            this.grayTXT1.TabIndex = 4;
            // 
            // Serch
            // 
            this.Serch.Location = new System.Drawing.Point(373, 9);
            this.Serch.Name = "Serch";
            this.Serch.Size = new System.Drawing.Size(62, 21);
            this.Serch.TabIndex = 3;
            this.Serch.Text = "Поиск";
            this.Serch.UseVisualStyleBackColor = true;
            this.Serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.городаBindingSource;
            this.comboBox1.DisplayMember = "Название_города";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(455, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_города";
            // 
            // городаBindingSource
            // 
            this.городаBindingSource.DataMember = "Города";
            this.городаBindingSource.DataSource = this.vUZBDDataSet;
            // 
            // vUZBDDataSet
            // 
            this.vUZBDDataSet.DataSetName = "VUZBDDataSet";
            this.vUZBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.городаBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.ADd});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 338);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(664, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ADd
            // 
            this.ADd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ADd.Image = ((System.Drawing.Image)(resources.GetObject("ADd.Image")));
            this.ADd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ADd.Name = "ADd";
            this.ADd.Size = new System.Drawing.Size(63, 22);
            this.ADd.Text = "Добавить";
            this.ADd.Click += new System.EventHandler(this.ADd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDгородаDataGridViewTextBoxColumn,
            this.названиегородаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.городаBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 303);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDгородаDataGridViewTextBoxColumn
            // 
            this.iDгородаDataGridViewTextBoxColumn.DataPropertyName = "ID_города";
            this.iDгородаDataGridViewTextBoxColumn.HeaderText = "ID_города";
            this.iDгородаDataGridViewTextBoxColumn.Name = "iDгородаDataGridViewTextBoxColumn";
            // 
            // названиегородаDataGridViewTextBoxColumn
            // 
            this.названиегородаDataGridViewTextBoxColumn.DataPropertyName = "Название_города";
            this.названиегородаDataGridViewTextBoxColumn.HeaderText = "Название_города";
            this.названиегородаDataGridViewTextBoxColumn.Name = "названиегородаDataGridViewTextBoxColumn";
            this.названиегородаDataGridViewTextBoxColumn.Width = 300;
            // 
            // городаTableAdapter
            // 
            this.городаTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BACKBUT);
            this.panel2.Controls.Add(this.UPDATEBUT);
            this.panel2.Controls.Add(this.ClearBUT);
            this.panel2.Controls.Add(this.DELBUT);
            this.panel2.Controls.Add(this.Change);
            this.panel2.Controls.Add(this.OTmena);
            this.panel2.Controls.Add(this.ADDD);
            this.panel2.Controls.Add(this.NAMECity);
            this.panel2.Controls.Add(this.IDCITY);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(485, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 303);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // BACKBUT
            // 
            this.BACKBUT.Location = new System.Drawing.Point(7, 212);
            this.BACKBUT.Name = "BACKBUT";
            this.BACKBUT.Size = new System.Drawing.Size(165, 23);
            this.BACKBUT.TabIndex = 8;
            this.BACKBUT.Text = "На главную";
            this.BACKBUT.UseVisualStyleBackColor = true;
            this.BACKBUT.Click += new System.EventHandler(this.BACKBUT_Click);
            // 
            // UPDATEBUT
            // 
            this.UPDATEBUT.Location = new System.Drawing.Point(7, 170);
            this.UPDATEBUT.Name = "UPDATEBUT";
            this.UPDATEBUT.Size = new System.Drawing.Size(165, 23);
            this.UPDATEBUT.TabIndex = 7;
            this.UPDATEBUT.Text = "Обновить";
            this.UPDATEBUT.UseVisualStyleBackColor = true;
            this.UPDATEBUT.Click += new System.EventHandler(this.UPDATEBUT_Click);
            // 
            // ClearBUT
            // 
            this.ClearBUT.Location = new System.Drawing.Point(7, 129);
            this.ClearBUT.Name = "ClearBUT";
            this.ClearBUT.Size = new System.Drawing.Size(165, 23);
            this.ClearBUT.TabIndex = 6;
            this.ClearBUT.Text = "Очистить поля";
            this.ClearBUT.UseVisualStyleBackColor = true;
            this.ClearBUT.Click += new System.EventHandler(this.ClearBUT_Click);
            // 
            // DELBUT
            // 
            this.DELBUT.Location = new System.Drawing.Point(97, 85);
            this.DELBUT.Name = "DELBUT";
            this.DELBUT.Size = new System.Drawing.Size(75, 23);
            this.DELBUT.TabIndex = 5;
            this.DELBUT.Text = "Удалить";
            this.DELBUT.UseVisualStyleBackColor = true;
            this.DELBUT.Click += new System.EventHandler(this.DELBUT_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(7, 86);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // OTmena
            // 
            this.OTmena.Location = new System.Drawing.Point(97, 46);
            this.OTmena.Name = "OTmena";
            this.OTmena.Size = new System.Drawing.Size(75, 23);
            this.OTmena.TabIndex = 3;
            this.OTmena.Text = "Отмена";
            this.OTmena.UseVisualStyleBackColor = true;
            this.OTmena.Click += new System.EventHandler(this.OTmena_Click);
            // 
            // ADDD
            // 
            this.ADDD.Location = new System.Drawing.Point(7, 46);
            this.ADDD.Name = "ADDD";
            this.ADDD.Size = new System.Drawing.Size(74, 23);
            this.ADDD.TabIndex = 2;
            this.ADDD.Text = "Добавить";
            this.ADDD.UseVisualStyleBackColor = true;
            this.ADDD.Click += new System.EventHandler(this.ADDD_Click);
            // 
            // NAMECity
            // 
            this.NAMECity.Cue = "Название города";
            this.NAMECity.Dock = System.Windows.Forms.DockStyle.Top;
            this.NAMECity.Location = new System.Drawing.Point(0, 20);
            this.NAMECity.Name = "NAMECity";
            this.NAMECity.Size = new System.Drawing.Size(179, 20);
            this.NAMECity.TabIndex = 1;
            // 
            // IDCITY
            // 
            this.IDCITY.Cue = "ID города";
            this.IDCITY.Dock = System.Windows.Forms.DockStyle.Top;
            this.IDCITY.Location = new System.Drawing.Point(0, 0);
            this.IDCITY.Name = "IDCITY";
            this.IDCITY.Size = new System.Drawing.Size(179, 20);
            this.IDCITY.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 303);
            this.panel3.TabIndex = 10;
            // 
            // CITY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 363);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Name = "CITY";
            this.Text = "Города";
            this.Load += new System.EventHandler(this.CITY_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUZBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Serch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VUZBDDataSet vUZBDDataSet;
        private System.Windows.Forms.BindingSource городаBindingSource;
        private VUZBDDataSetTableAdapters.ГородаTableAdapter городаTableAdapter;
        private GrayTXT grayTXT1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripButton ADd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OTmena;
        private System.Windows.Forms.Button ADDD;
        private GrayTXT NAMECity;
        private GrayTXT IDCITY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button DELBUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDгородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегородаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ClearBUT;
        private System.Windows.Forms.Button UPDATEBUT;
        private System.Windows.Forms.Button BACKBUT;
    }
}