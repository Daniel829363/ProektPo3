namespace ProektPo3
{
    partial class BudjetForm
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
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label label1;
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.backtoform2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            sumLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Location = new System.Drawing.Point(326, 59);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(31, 13);
            sumLabel.TabIndex = 3;
            sumLabel.Text = "Sum:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Enabled = false;
            this.sumTextBox.Location = new System.Drawing.Point(363, 56);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 4;
            // 
            // backtoform2
            // 
            this.backtoform2.Location = new System.Drawing.Point(515, 337);
            this.backtoform2.Name = "backtoform2";
            this.backtoform2.Size = new System.Drawing.Size(193, 60);
            this.backtoform2.TabIndex = 5;
            this.backtoform2.Text = "Назад в главную форму";
            this.backtoform2.UseVisualStyleBackColor = true;
            this.backtoform2.Click += new System.EventHandler(this.backtoform2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(265, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 13);
            label1.TabIndex = 8;
            label1.Text = "Сумма добавления:";
            // 
            // BudjetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backtoform2);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumTextBox);
            this.Name = "BudjetForm";
            this.Text = "budjet";
            this.Load += new System.EventHandler(this.BudjetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Button backtoform2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}