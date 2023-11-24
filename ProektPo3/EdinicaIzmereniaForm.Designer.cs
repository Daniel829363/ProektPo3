namespace ProektPo3
{
    partial class EdinicaIzmereniaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdinicaIzmereniaForm));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label naimenovanieLabel;
            this.backtoform2 = new System.Windows.Forms.Button();
            this.mebelDataSet = new ProektPo3.MebelDataSet();
            this.edinica_izmereniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edinica_izmereniaTableAdapter = new ProektPo3.MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter();
            this.tableAdapterManager = new ProektPo3.MebelDataSetTableAdapters.TableAdapterManager();
            this.edinica_izmereniaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.edinica_izmereniaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.naimenovanieTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            naimenovanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edinica_izmereniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edinica_izmereniaBindingNavigator)).BeginInit();
            this.edinica_izmereniaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(317, 378);
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
            // edinica_izmereniaBindingSource
            // 
            this.edinica_izmereniaBindingSource.DataMember = "Edinica_izmerenia";
            this.edinica_izmereniaBindingSource.DataSource = this.mebelDataSet;
            // 
            // edinica_izmereniaTableAdapter
            // 
            this.edinica_izmereniaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudjetTableAdapter = null;
            this.tableAdapterManager.DoljnostiTableAdapter = null;
            this.tableAdapterManager.Edinica_izmereniaTableAdapter = this.edinica_izmereniaTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Gotovoe_produkciTableAdapter = null;
            this.tableAdapterManager.IngridientyTableAdapter = null;
            this.tableAdapterManager.Prodaja_produkciTableAdapter = null;
            this.tableAdapterManager.Proizvodstvo_produkciTableAdapter = null;
            this.tableAdapterManager.SyrieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProektPo3.MebelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zakupka_syriaTableAdapter = null;
            // 
            // edinica_izmereniaBindingNavigator
            // 
            this.edinica_izmereniaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.edinica_izmereniaBindingNavigator.BindingSource = this.edinica_izmereniaBindingSource;
            this.edinica_izmereniaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.edinica_izmereniaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.edinica_izmereniaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.edinica_izmereniaBindingNavigatorSaveItem});
            this.edinica_izmereniaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.edinica_izmereniaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.edinica_izmereniaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.edinica_izmereniaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.edinica_izmereniaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.edinica_izmereniaBindingNavigator.Name = "edinica_izmereniaBindingNavigator";
            this.edinica_izmereniaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.edinica_izmereniaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.edinica_izmereniaBindingNavigator.TabIndex = 7;
            this.edinica_izmereniaBindingNavigator.Text = "bindingNavigator1";
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
            // edinica_izmereniaBindingNavigatorSaveItem
            // 
            this.edinica_izmereniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edinica_izmereniaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("edinica_izmereniaBindingNavigatorSaveItem.Image")));
            this.edinica_izmereniaBindingNavigatorSaveItem.Name = "edinica_izmereniaBindingNavigatorSaveItem";
            this.edinica_izmereniaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.edinica_izmereniaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.edinica_izmereniaBindingNavigatorSaveItem.Click += new System.EventHandler(this.edinica_izmereniaBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(299, 150);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.edinica_izmereniaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(383, 147);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // naimenovanieLabel
            // 
            naimenovanieLabel.AutoSize = true;
            naimenovanieLabel.Location = new System.Drawing.Point(299, 176);
            naimenovanieLabel.Name = "naimenovanieLabel";
            naimenovanieLabel.Size = new System.Drawing.Size(78, 13);
            naimenovanieLabel.TabIndex = 9;
            naimenovanieLabel.Text = "Naimenovanie:";
            // 
            // naimenovanieTextBox
            // 
            this.naimenovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.edinica_izmereniaBindingSource, "Naimenovanie", true));
            this.naimenovanieTextBox.Location = new System.Drawing.Point(383, 173);
            this.naimenovanieTextBox.Name = "naimenovanieTextBox";
            this.naimenovanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.naimenovanieTextBox.TabIndex = 10;
            // 
            // EdinicaIzmereniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(naimenovanieLabel);
            this.Controls.Add(this.naimenovanieTextBox);
            this.Controls.Add(this.edinica_izmereniaBindingNavigator);
            this.Controls.Add(this.backtoform2);
            this.Name = "EdinicaIzmereniaForm";
            this.Text = "EdinicaIzmereniaForm";
            this.Load += new System.EventHandler(this.EdinicaIzmereniaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mebelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edinica_izmereniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edinica_izmereniaBindingNavigator)).EndInit();
            this.edinica_izmereniaBindingNavigator.ResumeLayout(false);
            this.edinica_izmereniaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backtoform2;
        private MebelDataSet mebelDataSet;
        private System.Windows.Forms.BindingSource edinica_izmereniaBindingSource;
        private MebelDataSetTableAdapters.Edinica_izmereniaTableAdapter edinica_izmereniaTableAdapter;
        private MebelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator edinica_izmereniaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton edinica_izmereniaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox naimenovanieTextBox;
    }
}