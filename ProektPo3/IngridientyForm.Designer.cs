namespace ProektPo3
{
    partial class IngridientyForm
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
            System.Windows.Forms.Label podukciaLabel;
            System.Windows.Forms.Label syrieLabel;
            System.Windows.Forms.Label countLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngridientyForm));
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.ingridientyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingridientyTableAdapter = new ProektPo3.MebelDataSetTableAdapters.IngridientyTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.ingridientyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ingridientyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.gotovoeprodukciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syrieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mebelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gotovoe_produkciTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter();
            this.syrieTableAdapter = new ProektPo3.MebelDataSetTableAdapters.SyrieTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            podukciaLabel = new System.Windows.Forms.Label();
            syrieLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientyBindingNavigator)).BeginInit();
            this.ingridientyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoeprodukciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(303, 132);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // podukciaLabel
            // 
            podukciaLabel.AutoSize = true;
            podukciaLabel.Location = new System.Drawing.Point(303, 158);
            podukciaLabel.Name = "podukciaLabel";
            podukciaLabel.Size = new System.Drawing.Size(55, 13);
            podukciaLabel.TabIndex = 9;
            podukciaLabel.Text = "Podukcia:";
            // 
            // syrieLabel
            // 
            syrieLabel.AutoSize = true;
            syrieLabel.Location = new System.Drawing.Point(303, 184);
            syrieLabel.Name = "syrieLabel";
            syrieLabel.Size = new System.Drawing.Size(33, 13);
            syrieLabel.TabIndex = 11;
            syrieLabel.Text = "Syrie:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(303, 210);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 13;
            countLabel.Text = "Count:";
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(298, 369);
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
            // ingridientyBindingSource
            // 
            this.ingridientyBindingSource.DataMember = "Ingridienty";
            this.ingridientyBindingSource.DataSource = this.mebelDataSet;
            // 
            // ingridientyTableAdapter
            // 
            this.ingridientyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudjetTableAdapter = null;
            this.tableAdapterManager.DoljnostiTableAdapter = null;
            this.tableAdapterManager.Edinica_izmereniaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Gotovoe_produkciTableAdapter = null;
            this.tableAdapterManager.IngridientyTableAdapter = this.ingridientyTableAdapter;
            this.tableAdapterManager.Prodaja_produkciTableAdapter = null;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // ingridientyBindingNavigator
            // 
            this.ingridientyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingridientyBindingNavigator.BindingSource = this.ingridientyBindingSource;
            this.ingridientyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingridientyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingridientyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ingridientyBindingNavigatorSaveItem});
            this.ingridientyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingridientyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingridientyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingridientyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingridientyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingridientyBindingNavigator.Name = "ingridientyBindingNavigator";
            this.ingridientyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingridientyBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ingridientyBindingNavigator.TabIndex = 7;
            this.ingridientyBindingNavigator.Text = "bindingNavigator1";
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
            // ingridientyBindingNavigatorSaveItem
            // 
            this.ingridientyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingridientyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingridientyBindingNavigatorSaveItem.Image")));
            this.ingridientyBindingNavigatorSaveItem.Name = "ingridientyBindingNavigatorSaveItem";
            this.ingridientyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ingridientyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ingridientyBindingNavigatorSaveItem.Click += new System.EventHandler(this.ingridientyBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingridientyBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(364, 129);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(164, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingridientyBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(364, 207);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(164, 20);
            this.countTextBox.TabIndex = 14;
            // 
            // gotovoeprodukciBindingSource
            // 
            this.gotovoeprodukciBindingSource.DataMember = "Gotovoe_produkci";
            this.gotovoeprodukciBindingSource.DataSource = this.mebelDataSet;
            // 
            // syrieBindingSource
            // 
            this.syrieBindingSource.DataMember = "Syrie";
            this.syrieBindingSource.DataSource = this.mebelDataSetBindingSource;
            // 
            // mebelDataSetBindingSource
            // 
            this.mebelDataSetBindingSource.DataSource = this.mebelDataSet;
            this.mebelDataSetBindingSource.Position = 0;
            // 
            // gotovoe_produkciTableAdapter
            // 
            this.gotovoe_produkciTableAdapter.ClearBeforeFill = true;
            // 
            // syrieTableAdapter
            // 
            this.syrieTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingridientyBindingSource, "Podukcia", true));
            this.comboBox1.DataSource = this.gotovoeprodukciBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(364, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ingridientyBindingSource, "Syrie", true));
            this.comboBox2.DataSource = this.syrieBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie_materiala";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(364, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "ID";
            // 
            // IngridientyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(podukciaLabel);
            this.Controls.Add(syrieLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.ingridientyBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "IngridientyForm";
            this.Text = "IngridientyForm";
            this.Load += new System.EventHandler(this.IngridientyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientyBindingNavigator)).EndInit();
            this.ingridientyBindingNavigator.ResumeLayout(false);
            this.ingridientyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoeprodukciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource ingridientyBindingSource;
        private MebelDataSetTableAdapters.IngridientyTableAdapter ingridientyTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingridientyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ingridientyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.BindingSource gotovoeprodukciBindingSource;
        private MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter gotovoe_produkciTableAdapter;
        private System.Windows.Forms.BindingSource mebelDataSetBindingSource;
        private System.Windows.Forms.BindingSource syrieBindingSource;
        private MebelDataSetTableAdapters.SyrieTableAdapter syrieTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}