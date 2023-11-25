namespace ProektPo3
{
    partial class GotovoeProdukciForm
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
            System.Windows.Forms.Label naimenovanieLabel;
            System.Windows.Forms.Label edinica_izmereniaLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label sumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GotovoeProdukciForm));
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.gotovoe_produkciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gotovoe_produkciTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.gotovoe_produkciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gotovoe_produkciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.naimenovanieTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.edinicaizmereniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edinica_izmereniaTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter();
            this.edinica_izmereniaTableAdapter1 = new ProektPo3.MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter();
            this.budjetTableAdapter1 = new ProektPo3.MebelDataSetTableAdapters.BudjetTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            naimenovanieLabel = new System.Windows.Forms.Label();
            edinica_izmereniaLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoe_produkciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoe_produkciBindingNavigator)).BeginInit();
            this.gotovoe_produkciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edinicaizmereniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(287, 133);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // naimenovanieLabel
            // 
            naimenovanieLabel.AutoSize = true;
            naimenovanieLabel.Location = new System.Drawing.Point(287, 159);
            naimenovanieLabel.Name = "naimenovanieLabel";
            naimenovanieLabel.Size = new System.Drawing.Size(78, 13);
            naimenovanieLabel.TabIndex = 9;
            naimenovanieLabel.Text = "Naimenovanie:";
            // 
            // edinica_izmereniaLabel
            // 
            edinica_izmereniaLabel.AutoSize = true;
            edinica_izmereniaLabel.Location = new System.Drawing.Point(287, 185);
            edinica_izmereniaLabel.Name = "edinica_izmereniaLabel";
            edinica_izmereniaLabel.Size = new System.Drawing.Size(92, 13);
            edinica_izmereniaLabel.TabIndex = 11;
            edinica_izmereniaLabel.Text = "Edinica izmerenia:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(287, 211);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 13;
            countLabel.Text = "Count:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(287, 237);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 15;
            sumLabel.Text = "Sum:";
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(312, 368);
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
            // gotovoe_produkciBindingSource
            // 
            this.gotovoe_produkciBindingSource.DataMember = "Gotovoe_produkci";
            this.gotovoe_produkciBindingSource.DataSource = this.mebelDataSet;
            // 
            // gotovoe_produkciTableAdapter
            // 
            this.gotovoe_produkciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudjetTableAdapter = null;
            this.tableAdapterManager.DoljnostiTableAdapter = null;
            this.tableAdapterManager.Edinica_izmereniaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Gotovoe_produkciTableAdapter = this.gotovoe_produkciTableAdapter;
            this.tableAdapterManager.IngridientyTableAdapter = null;
            this.tableAdapterManager.Prodaja_produkciTableAdapter = null;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // gotovoe_produkciBindingNavigator
            // 
            this.gotovoe_produkciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gotovoe_produkciBindingNavigator.BindingSource = this.gotovoe_produkciBindingSource;
            this.gotovoe_produkciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gotovoe_produkciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gotovoe_produkciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gotovoe_produkciBindingNavigatorSaveItem});
            this.gotovoe_produkciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gotovoe_produkciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gotovoe_produkciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gotovoe_produkciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gotovoe_produkciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gotovoe_produkciBindingNavigator.Name = "gotovoe_produkciBindingNavigator";
            this.gotovoe_produkciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gotovoe_produkciBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.gotovoe_produkciBindingNavigator.TabIndex = 7;
            this.gotovoe_produkciBindingNavigator.Text = "bindingNavigator1";
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
            // gotovoe_produkciBindingNavigatorSaveItem
            // 
            this.gotovoe_produkciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gotovoe_produkciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gotovoe_produkciBindingNavigatorSaveItem.Image")));
            this.gotovoe_produkciBindingNavigatorSaveItem.Name = "gotovoe_produkciBindingNavigatorSaveItem";
            this.gotovoe_produkciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gotovoe_produkciBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.gotovoe_produkciBindingNavigatorSaveItem.Click += new System.EventHandler(this.gotovoe_produkciBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gotovoe_produkciBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(385, 130);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(165, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // naimenovanieTextBox
            // 
            this.naimenovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gotovoe_produkciBindingSource, "Naimenovanie", true));
            this.naimenovanieTextBox.Location = new System.Drawing.Point(385, 156);
            this.naimenovanieTextBox.Name = "naimenovanieTextBox";
            this.naimenovanieTextBox.Size = new System.Drawing.Size(165, 20);
            this.naimenovanieTextBox.TabIndex = 10;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gotovoe_produkciBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(385, 208);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(165, 20);
            this.countTextBox.TabIndex = 14;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gotovoe_produkciBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(385, 234);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(165, 20);
            this.sumTextBox.TabIndex = 16;
            // 
            // edinicaizmereniaBindingSource
            // 
            this.edinicaizmereniaBindingSource.DataMember = "Edinica_izmerenia";
            this.edinicaizmereniaBindingSource.DataSource = this.mebelDataSet;
            // 
            // edinica_izmereniaTableAdapter
            // 
            this.edinica_izmereniaTableAdapter.ClearBeforeFill = true;
            // 
            // edinica_izmereniaTableAdapter1
            // 
            this.edinica_izmereniaTableAdapter1.ClearBeforeFill = true;
            // 
            // budjetTableAdapter1
            // 
            this.budjetTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gotovoe_produkciBindingSource, "Edinica_izmerenia", true));
            this.comboBox1.DataSource = this.edinicaizmereniaBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID";
            // 
            // GotovoeProdukciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(naimenovanieLabel);
            this.Controls.Add(this.naimenovanieTextBox);
            this.Controls.Add(edinica_izmereniaLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.gotovoe_produkciBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "GotovoeProdukciForm";
            this.Text = "GotovoeProdukciForm";
            this.Load += new System.EventHandler(this.GotovoeProdukciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoe_produkciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gotovoe_produkciBindingNavigator)).EndInit();
            this.gotovoe_produkciBindingNavigator.ResumeLayout(false);
            this.gotovoe_produkciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edinicaizmereniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource gotovoe_produkciBindingSource;
        private MebelDataSetTableAdapters.Gotovoe_produkciTableAdapter gotovoe_produkciTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gotovoe_produkciBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gotovoe_produkciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox naimenovanieTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.BindingSource edinicaizmereniaBindingSource;
        private MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter edinica_izmereniaTableAdapter;
        private MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter edinica_izmereniaTableAdapter1;
        private MebelDataSetTableAdapters.BudjetTableAdapter budjetTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}