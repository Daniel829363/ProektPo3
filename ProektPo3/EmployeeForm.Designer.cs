namespace ProektPo3
{
    partial class EmployeeForm
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label doljnostLabel;
            System.Windows.Forms.Label okladLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ProektPo3.MebelDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.okladTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.doljnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doljnostiTableAdapter = new ProektPo3.MebelDataSetTableAdapters.DoljnostiTableAdapter();
            this.doljnostComboBox = new System.Windows.Forms.ComboBox();
            this.doljnostiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            doljnostLabel = new System.Windows.Forms.Label();
            okladLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(313, 136);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(313, 162);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(27, 13);
            fIOLabel.TabIndex = 9;
            fIOLabel.Text = "FIO:";
            // 
            // doljnostLabel
            // 
            doljnostLabel.AutoSize = true;
            doljnostLabel.Location = new System.Drawing.Point(313, 188);
            doljnostLabel.Name = "doljnostLabel";
            doljnostLabel.Size = new System.Drawing.Size(48, 13);
            doljnostLabel.TabIndex = 11;
            doljnostLabel.Text = "Doljnost:";
            // 
            // okladLabel
            // 
            okladLabel.AutoSize = true;
            okladLabel.Location = new System.Drawing.Point(313, 214);
            okladLabel.Name = "okladLabel";
            okladLabel.Size = new System.Drawing.Size(38, 13);
            okladLabel.TabIndex = 13;
            okladLabel.Text = "Oklad:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(313, 240);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 15;
            adresLabel.Text = "Adres:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(313, 266);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(47, 13);
            numberLabel.TabIndex = 17;
            numberLabel.Text = "Number:";
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(305, 378);
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
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.mebelDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudjetTableAdapter = null;
            this.tableAdapterManager.DoljnostiTableAdapter = null;
            this.tableAdapterManager.Edinica_izmereniaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.Gotovoe_produkciTableAdapter = null;
            this.tableAdapterManager.IngridientyTableAdapter = null;
            this.tableAdapterManager.Prodaja_produkciTableAdapter = null;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.employeeBindingNavigator.TabIndex = 7;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
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
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(367, 133);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(149, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(367, 159);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(149, 20);
            this.fIOTextBox.TabIndex = 10;
            // 
            // okladTextBox
            // 
            this.okladTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Oklad", true));
            this.okladTextBox.Location = new System.Drawing.Point(367, 211);
            this.okladTextBox.Name = "okladTextBox";
            this.okladTextBox.Size = new System.Drawing.Size(149, 20);
            this.okladTextBox.TabIndex = 14;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(367, 237);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(149, 20);
            this.adresTextBox.TabIndex = 16;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(367, 263);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(149, 20);
            this.numberTextBox.TabIndex = 18;
            // 
            // doljnostiBindingSource
            // 
            this.doljnostiBindingSource.DataMember = "Doljnosti";
            this.doljnostiBindingSource.DataSource = this.mebelDataSet;
            // 
            // doljnostiTableAdapter
            // 
            this.doljnostiTableAdapter.ClearBeforeFill = true;
            // 
            // doljnostComboBox
            // 
            this.doljnostComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doljnostiBindingSource, "doljnost", true));
            this.doljnostComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "Doljnost", true));
            this.doljnostComboBox.DataSource = this.doljnostiBindingSource1;
            this.doljnostComboBox.DisplayMember = "doljnost";
            this.doljnostComboBox.FormattingEnabled = true;
            this.doljnostComboBox.Location = new System.Drawing.Point(367, 184);
            this.doljnostComboBox.Name = "doljnostComboBox";
            this.doljnostComboBox.Size = new System.Drawing.Size(149, 21);
            this.doljnostComboBox.TabIndex = 19;
            this.doljnostComboBox.ValueMember = "ID";
            // 
            // doljnostiBindingSource1
            // 
            this.doljnostiBindingSource1.DataMember = "Doljnosti";
            this.doljnostiBindingSource1.DataSource = this.mebelDataSet;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.doljnostComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(doljnostLabel);
            this.Controls.Add(okladLabel);
            this.Controls.Add(this.okladTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MebelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox okladTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.BindingSource doljnostiBindingSource;
        private MebelDataSetTableAdapters.DoljnostiTableAdapter doljnostiTableAdapter;
        private System.Windows.Forms.ComboBox doljnostComboBox;
        private System.Windows.Forms.BindingSource doljnostiBindingSource1;
    }
}