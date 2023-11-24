namespace ProektPo3
{
    partial class DoljnostiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoljnostiForm));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label doljnostLabel;
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.doljnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doljnostiTableAdapter = new ProektPo3.MebelDataSetTableAdapters.DoljnostiTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.doljnostiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.doljnostiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.doljnostTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            doljnostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingNavigator)).BeginInit();
            this.doljnostiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(284, 366);
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
            // doljnostiBindingSource
            // 
            this.doljnostiBindingSource.DataMember = "Doljnosti";
            this.doljnostiBindingSource.DataSource = this.mebelDataSet;
            // 
            // doljnostiTableAdapter
            // 
            this.doljnostiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudjetTableAdapter = null;
            this.tableAdapterManager.DoljnostiTableAdapter = this.doljnostiTableAdapter;
            this.tableAdapterManager.Edinica_izmereniaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Gotovoe_produkciTableAdapter = null;
            this.tableAdapterManager.IngridientyTableAdapter = null;
            this.tableAdapterManager.Prodaja_produkciTableAdapter = null;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // doljnostiBindingNavigator
            // 
            this.doljnostiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doljnostiBindingNavigator.BindingSource = this.doljnostiBindingSource;
            this.doljnostiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doljnostiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doljnostiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doljnostiBindingNavigatorSaveItem});
            this.doljnostiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doljnostiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doljnostiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doljnostiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doljnostiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doljnostiBindingNavigator.Name = "doljnostiBindingNavigator";
            this.doljnostiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doljnostiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.doljnostiBindingNavigator.TabIndex = 7;
            this.doljnostiBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // doljnostiBindingNavigatorSaveItem
            // 
            this.doljnostiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doljnostiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doljnostiBindingNavigatorSaveItem.Image")));
            this.doljnostiBindingNavigatorSaveItem.Name = "doljnostiBindingNavigatorSaveItem";
            this.doljnostiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.doljnostiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.doljnostiBindingNavigatorSaveItem.Click += new System.EventHandler(this.doljnostiBindingNavigatorSaveItem_Click_2);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(301, 188);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doljnostiBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(353, 185);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // doljnostLabel
            // 
            doljnostLabel.AutoSize = true;
            doljnostLabel.Location = new System.Drawing.Point(301, 214);
            doljnostLabel.Name = "doljnostLabel";
            doljnostLabel.Size = new System.Drawing.Size(46, 13);
            doljnostLabel.TabIndex = 9;
            doljnostLabel.Text = "doljnost:";
            // 
            // doljnostTextBox
            // 
            this.doljnostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doljnostiBindingSource, "doljnost", true));
            this.doljnostTextBox.Location = new System.Drawing.Point(353, 211);
            this.doljnostTextBox.Name = "doljnostTextBox";
            this.doljnostTextBox.Size = new System.Drawing.Size(100, 20);
            this.doljnostTextBox.TabIndex = 10;
            // 
            // DoljnostiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(doljnostLabel);
            this.Controls.Add(this.doljnostTextBox);
            this.Controls.Add(this.doljnostiBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "DoljnostiForm";
            this.Text = "DoljnostiForm";
            this.Load += new System.EventHandler(this.DoljnostiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostiBindingNavigator)).EndInit();
            this.doljnostiBindingNavigator.ResumeLayout(false);
            this.doljnostiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource doljnostiBindingSource;
        private MebelDataSetTableAdapters.DoljnostiTableAdapter doljnostiTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doljnostiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doljnostiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox doljnostTextBox;
    }
}