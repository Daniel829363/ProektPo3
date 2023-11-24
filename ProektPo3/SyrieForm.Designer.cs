namespace ProektPo3
{
    partial class SyrieForm
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
            System.Windows.Forms.Label naimenovanie_materialaLabel;
            System.Windows.Forms.Label edinica_izmereniaLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label sumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyrieForm));
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.syrieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syrieTableAdapter = new ProektPo3.MebelDataSetTableAdapters.SyrieTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.syrieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.syrieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.naimenovanie_materialaTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.edinica_izmereniaComboBox = new System.Windows.Forms.ComboBox();
            this.edinicaizmereniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edinica_izmereniaTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            naimenovanie_materialaLabel = new System.Windows.Forms.Label();
            edinica_izmereniaLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingNavigator)).BeginInit();
            this.syrieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edinicaizmereniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(274, 145);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // naimenovanie_materialaLabel
            // 
            naimenovanie_materialaLabel.AutoSize = true;
            naimenovanie_materialaLabel.Location = new System.Drawing.Point(274, 171);
            naimenovanie_materialaLabel.Name = "naimenovanie_materialaLabel";
            naimenovanie_materialaLabel.Size = new System.Drawing.Size(123, 13);
            naimenovanie_materialaLabel.TabIndex = 9;
            naimenovanie_materialaLabel.Text = "Naimenovanie materiala:";
            // 
            // edinica_izmereniaLabel
            // 
            edinica_izmereniaLabel.AutoSize = true;
            edinica_izmereniaLabel.Location = new System.Drawing.Point(274, 197);
            edinica_izmereniaLabel.Name = "edinica_izmereniaLabel";
            edinica_izmereniaLabel.Size = new System.Drawing.Size(92, 13);
            edinica_izmereniaLabel.TabIndex = 11;
            edinica_izmereniaLabel.Text = "Edinica izmerenia:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(274, 223);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 13;
            countLabel.Text = "Count:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(274, 249);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 15;
            sumLabel.Text = "Sum:";
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(294, 378);
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
            // syrieBindingSource
            // 
            this.syrieBindingSource.DataMember = "Syrie";
            this.syrieBindingSource.DataSource = this.mebelDataSet;
            // 
            // syrieTableAdapter
            // 
            this.syrieTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = this.syrieTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // syrieBindingNavigator
            // 
            this.syrieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.syrieBindingNavigator.BindingSource = this.syrieBindingSource;
            this.syrieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.syrieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.syrieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.syrieBindingNavigatorSaveItem});
            this.syrieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.syrieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.syrieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.syrieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.syrieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.syrieBindingNavigator.Name = "syrieBindingNavigator";
            this.syrieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.syrieBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.syrieBindingNavigator.TabIndex = 7;
            this.syrieBindingNavigator.Text = "bindingNavigator1";
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
            // syrieBindingNavigatorSaveItem
            // 
            this.syrieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.syrieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("syrieBindingNavigatorSaveItem.Image")));
            this.syrieBindingNavigatorSaveItem.Name = "syrieBindingNavigatorSaveItem";
            this.syrieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.syrieBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.syrieBindingNavigatorSaveItem.Click += new System.EventHandler(this.syrieBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syrieBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(403, 142);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // naimenovanie_materialaTextBox
            // 
            this.naimenovanie_materialaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syrieBindingSource, "Naimenovanie_materiala", true));
            this.naimenovanie_materialaTextBox.Location = new System.Drawing.Point(403, 168);
            this.naimenovanie_materialaTextBox.Name = "naimenovanie_materialaTextBox";
            this.naimenovanie_materialaTextBox.Size = new System.Drawing.Size(200, 20);
            this.naimenovanie_materialaTextBox.TabIndex = 10;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syrieBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(403, 220);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 20);
            this.countTextBox.TabIndex = 14;
            // 
            // sumTextBox
            // 
            this.sumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syrieBindingSource, "Sum", true));
            this.sumTextBox.Location = new System.Drawing.Point(403, 246);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(200, 20);
            this.sumTextBox.TabIndex = 16;
            // 
            // edinica_izmereniaComboBox
            // 
            this.edinica_izmereniaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syrieBindingSource, "Edinica_izmerenia", true));
            this.edinica_izmereniaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.syrieBindingSource, "Edinica_izmerenia", true));
            this.edinica_izmereniaComboBox.DataSource = this.edinicaizmereniaBindingSource;
            this.edinica_izmereniaComboBox.DisplayMember = "Naimenovanie";
            this.edinica_izmereniaComboBox.FormattingEnabled = true;
            this.edinica_izmereniaComboBox.Location = new System.Drawing.Point(403, 194);
            this.edinica_izmereniaComboBox.Name = "edinica_izmereniaComboBox";
            this.edinica_izmereniaComboBox.Size = new System.Drawing.Size(200, 21);
            this.edinica_izmereniaComboBox.TabIndex = 17;
            this.edinica_izmereniaComboBox.ValueMember = "ID";
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
            // SyrieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.edinica_izmereniaComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(naimenovanie_materialaLabel);
            this.Controls.Add(this.naimenovanie_materialaTextBox);
            this.Controls.Add(edinica_izmereniaLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.syrieBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "SyrieForm";
            this.Text = "SyrieForm";
            this.Load += new System.EventHandler(this.SyrieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syrieBindingNavigator)).EndInit();
            this.syrieBindingNavigator.ResumeLayout(false);
            this.syrieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edinicaizmereniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource syrieBindingSource;
        private MebelDataSetTableAdapters.SyrieTableAdapter syrieTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator syrieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton syrieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox naimenovanie_materialaTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.ComboBox edinica_izmereniaComboBox;
        private System.Windows.Forms.BindingSource edinicaizmereniaBindingSource;
        private MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter edinica_izmereniaTableAdapter;
    }
}