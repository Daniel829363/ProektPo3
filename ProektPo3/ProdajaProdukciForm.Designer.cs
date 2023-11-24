namespace ProektPo3
{
    partial class ProdajaProdukciForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label produkciaLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label employeeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdajaProdukciForm));
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.prodaja_produkciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodaja_produkciTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Prodaja_produkciTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.prodaja_produkciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prodaja_produkciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produkciaComboBox = new System.Windows.Forms.ComboBox();
            this.gotovoeprodukciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gotovoe_produkciTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProektPo3.MebelDataSetTableAdapters.EmployeeTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            produkciaLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_produkciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_produkciBindingNavigator)).BeginInit();
            this.prodaja_produkciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoeprodukciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(17, 114);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // produkciaLabel
            // 
            produkciaLabel.AutoSize = true;
            produkciaLabel.Location = new System.Drawing.Point(17, 140);
            produkciaLabel.Name = "produkciaLabel";
            produkciaLabel.Size = new System.Drawing.Size(58, 13);
            produkciaLabel.TabIndex = 9;
            produkciaLabel.Text = "Produkcia:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(17, 166);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 11;
            countLabel.Text = "Count:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(17, 192);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 13;
            sumLabel.Text = "Sum:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(17, 219);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 15;
            dataLabel.Text = "Data:";
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Location = new System.Drawing.Point(17, 244);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(56, 13);
            employeeLabel.TabIndex = 17;
            employeeLabel.Text = "Employee:";
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(309, 329);
            this.backtoform2.Name = "backtoform2";
            this.backtoform2.Size = new System.Drawing.Size(193, 60);
            this.backtoform2.TabIndex = 6;
            this.backtoform2.Text = "Назад в главную форму";
            this.backtoform2.UseVisualStyleBackColor = true;
            this.backtoform2.Click += new System.EventHandler(this.backtoform2_Click);
            // 
            // mebelDataSet
            // 
            this.mebelDataSet.DataSetName = "MebelDataSet";
            this.mebelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodaja_produkciBindingSource
            // 
            this.prodaja_produkciBindingSource.DataMember = "Prodaja_produkci";
            this.prodaja_produkciBindingSource.DataSource = this.mebelDataSet;
            // 
            // prodaja_produkciTableAdapter
            // 
            this.prodaja_produkciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudjetTableAdapter = null;
            this.tableAdapterManager.DoljnostiTableAdapter = null;
            this.tableAdapterManager.Edinica_izmereniaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Gotovoe_produkciTableAdapter = null;
            this.tableAdapterManager.IngridientyTableAdapter = null;
            this.tableAdapterManager.Prodaja_produkciTableAdapter = this.prodaja_produkciTableAdapter;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // prodaja_produkciBindingNavigator
            // 
            this.prodaja_produkciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prodaja_produkciBindingNavigator.BindingSource = this.prodaja_produkciBindingSource;
            this.prodaja_produkciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prodaja_produkciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prodaja_produkciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.prodaja_produkciBindingNavigatorSaveItem});
            this.prodaja_produkciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prodaja_produkciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prodaja_produkciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prodaja_produkciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prodaja_produkciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prodaja_produkciBindingNavigator.Name = "prodaja_produkciBindingNavigator";
            this.prodaja_produkciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prodaja_produkciBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.prodaja_produkciBindingNavigator.TabIndex = 7;
            this.prodaja_produkciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // prodaja_produkciBindingNavigatorSaveItem
            // 
            this.prodaja_produkciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prodaja_produkciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prodaja_produkciBindingNavigatorSaveItem.Image")));
            this.prodaja_produkciBindingNavigatorSaveItem.Name = "prodaja_produkciBindingNavigatorSaveItem";
            this.prodaja_produkciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prodaja_produkciBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prodaja_produkciBindingNavigatorSaveItem.Click += new System.EventHandler(this.prodaja_produkciBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaja_produkciBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(81, 111);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaja_produkciBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(81, 163);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 20);
            this.countTextBox.TabIndex = 12;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaja_produkciBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(81, 189);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(200, 20);
            this.sumTextBox.TabIndex = 14;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prodaja_produkciBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(81, 215);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 16;
            // 
            // produkciaComboBox
            // 
            this.produkciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaja_produkciBindingSource, "Produkcia", true));
            this.produkciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prodaja_produkciBindingSource, "Produkcia", true));
            this.produkciaComboBox.DataSource = this.gotovoeprodukciBindingSource;
            this.produkciaComboBox.DisplayMember = "Naimenovanie";
            this.produkciaComboBox.FormattingEnabled = true;
            this.produkciaComboBox.Location = new System.Drawing.Point(81, 136);
            this.produkciaComboBox.Name = "produkciaComboBox";
            this.produkciaComboBox.Size = new System.Drawing.Size(200, 21);
            this.produkciaComboBox.TabIndex = 19;
            this.produkciaComboBox.ValueMember = "ID";
            this.produkciaComboBox.SelectedIndexChanged += new System.EventHandler(this.produkciaComboBox_SelectedIndexChanged);
            // 
            // gotovoeprodukciBindingSource
            // 
            this.gotovoeprodukciBindingSource.DataMember = "Gotovoe_produkci";
            this.gotovoeprodukciBindingSource.DataSource = this.mebelDataSet;
            // 
            // gotovoe_produkciTableAdapter
            // 
            this.gotovoe_produkciTableAdapter.ClearBeforeFill = true;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaja_produkciBindingSource, "Employee", true));
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prodaja_produkciBindingSource, "Employee", true));
            this.employeeComboBox.DataSource = this.employeeBindingSource;
            this.employeeComboBox.DisplayMember = "FIO";
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(79, 241);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(202, 21);
            this.employeeComboBox.TabIndex = 20;
            this.employeeComboBox.ValueMember = "ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.mebelDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodaja_produkciBindingSource, "Count", true));
            this.textBox1.Location = new System.Drawing.Point(302, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 21;
            // 
            // ProdajaProdukciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.produkciaComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(produkciaLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.prodaja_produkciBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "ProdajaProdukciForm";
            this.Text = "ProdajaProdukciForm";
            this.Load += new System.EventHandler(this.ProdajaProdukciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_produkciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodaja_produkciBindingNavigator)).EndInit();
            this.prodaja_produkciBindingNavigator.ResumeLayout(false);
            this.prodaja_produkciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoeprodukciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource prodaja_produkciBindingSource;
        private MebelDataSetTableAdapters.Prodaja_produkciTableAdapter prodaja_produkciTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prodaja_produkciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton prodaja_produkciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox produkciaComboBox;
        private System.Windows.Forms.BindingSource gotovoeprodukciBindingSource;
        private MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter gotovoe_produkciTableAdapter;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MebelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}