namespace ProektPo3
{
    partial class ProizvodstvoProdukciForm
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
            System.Windows.Forms.Label produkciLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label employeeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProizvodstvoProdukciForm));
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.proizvodstvo_produkciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodstvo_produkciTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Proizvodstvo_produkciTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.proizvodstvo_produkciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.proizvodstvo_produkciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produkciComboBox = new System.Windows.Forms.ComboBox();
            this.gotovoeprodukciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gotovoe_produkciTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProektPo3.MebelDataSetTableAdapters.EmployeeTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            produkciLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            employeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodstvo_produkciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodstvo_produkciBindingNavigator)).BeginInit();
            this.proizvodstvo_produkciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoeprodukciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(275, 144);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // produkciLabel
            // 
            produkciLabel.AutoSize = true;
            produkciLabel.Location = new System.Drawing.Point(275, 170);
            produkciLabel.Name = "produkciLabel";
            produkciLabel.Size = new System.Drawing.Size(52, 13);
            produkciLabel.TabIndex = 9;
            produkciLabel.Text = "Produkci:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(275, 196);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 11;
            countLabel.Text = "Count:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(275, 223);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 13;
            dataLabel.Text = "Data:";
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Location = new System.Drawing.Point(275, 248);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new System.Drawing.Size(56, 13);
            employeeLabel.TabIndex = 15;
            employeeLabel.Text = "Employee:";
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(319, 378);
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
            // proizvodstvo_produkciBindingSource
            // 
            this.proizvodstvo_produkciBindingSource.DataMember = "Proizvodstvo_produkci";
            this.proizvodstvo_produkciBindingSource.DataSource = this.mebelDataSet;
            // 
            // proizvodstvo_produkciTableAdapter
            // 
            this.proizvodstvo_produkciTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Prodaja_produkciTableAdapter = null;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = this.proizvodstvo_produkciTableAdapter;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // proizvodstvo_produkciBindingNavigator
            // 
            this.proizvodstvo_produkciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proizvodstvo_produkciBindingNavigator.BindingSource = this.proizvodstvo_produkciBindingSource;
            this.proizvodstvo_produkciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proizvodstvo_produkciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proizvodstvo_produkciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proizvodstvo_produkciBindingNavigatorSaveItem});
            this.proizvodstvo_produkciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proizvodstvo_produkciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proizvodstvo_produkciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proizvodstvo_produkciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proizvodstvo_produkciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proizvodstvo_produkciBindingNavigator.Name = "proizvodstvo_produkciBindingNavigator";
            this.proizvodstvo_produkciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proizvodstvo_produkciBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.proizvodstvo_produkciBindingNavigator.TabIndex = 7;
            this.proizvodstvo_produkciBindingNavigator.Text = "bindingNavigator1";
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
            // proizvodstvo_produkciBindingNavigatorSaveItem
            // 
            this.proizvodstvo_produkciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proizvodstvo_produkciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvodstvo_produkciBindingNavigatorSaveItem.Image")));
            this.proizvodstvo_produkciBindingNavigatorSaveItem.Name = "proizvodstvo_produkciBindingNavigatorSaveItem";
            this.proizvodstvo_produkciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proizvodstvo_produkciBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.proizvodstvo_produkciBindingNavigatorSaveItem.Click += new System.EventHandler(this.proizvodstvo_produkciBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodstvo_produkciBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(337, 141);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodstvo_produkciBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(337, 193);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 20);
            this.countTextBox.TabIndex = 12;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.proizvodstvo_produkciBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(337, 219);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 14;
            // 
            // produkciComboBox
            // 
            this.produkciComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodstvo_produkciBindingSource, "Produkci", true));
            this.produkciComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proizvodstvo_produkciBindingSource, "Produkci", true));
            this.produkciComboBox.DataSource = this.gotovoeprodukciBindingSource;
            this.produkciComboBox.DisplayMember = "Naimenovanie";
            this.produkciComboBox.FormattingEnabled = true;
            this.produkciComboBox.Location = new System.Drawing.Point(337, 166);
            this.produkciComboBox.Name = "produkciComboBox";
            this.produkciComboBox.Size = new System.Drawing.Size(200, 21);
            this.produkciComboBox.TabIndex = 16;
            this.produkciComboBox.ValueMember = "ID";
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
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodstvo_produkciBindingSource, "Employee", true));
            this.employeeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proizvodstvo_produkciBindingSource, "Employee", true));
            this.employeeComboBox.DataSource = this.employeeBindingSource;
            this.employeeComboBox.DisplayMember = "FIO";
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(337, 245);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeeComboBox.TabIndex = 17;
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
            // ProizvodstvoProdukciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.produkciComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(produkciLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(employeeLabel);
            this.Controls.Add(this.proizvodstvo_produkciBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "ProizvodstvoProdukciForm";
            this.Text = "ProizvodstvoProdukciForm";
            this.Load += new System.EventHandler(this.ProizvodstvoProdukciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodstvo_produkciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodstvo_produkciBindingNavigator)).EndInit();
            this.proizvodstvo_produkciBindingNavigator.ResumeLayout(false);
            this.proizvodstvo_produkciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoeprodukciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource proizvodstvo_produkciBindingSource;
        private MebelDataSetTableAdapters.Proizvodstvo_produkciTableAdapter proizvodstvo_produkciTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proizvodstvo_produkciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proizvodstvo_produkciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox produkciComboBox;
        private System.Windows.Forms.BindingSource gotovoeprodukciBindingSource;
        private MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter gotovoe_produkciTableAdapter;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MebelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}