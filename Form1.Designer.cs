namespace Database1
{
    partial class Form1
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
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerDateBegin = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.ItemHeight = 20;
            this.listBoxWorkers.Location = new System.Drawing.Point(26, 12);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(312, 204);
            this.listBoxWorkers.TabIndex = 0;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkers_SelectedIndexChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(148, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(230, 26);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data zatrudnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wynagrodzenei";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kierownik";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(148, 35);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(230, 26);
            this.textBoxLastName.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.27161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.72839F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDateBegin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSalary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxManager, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(344, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 167);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dateTimePickerDateBegin
            // 
            this.dateTimePickerDateBegin.Location = new System.Drawing.Point(148, 67);
            this.dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            this.dateTimePickerDateBegin.Size = new System.Drawing.Size(230, 26);
            this.dateTimePickerDateBegin.TabIndex = 2;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.DecimalPlaces = 2;
            this.numericUpDownSalary.Location = new System.Drawing.Point(148, 99);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSalary.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(230, 26);
            this.numericUpDownSalary.TabIndex = 7;
            this.numericUpDownSalary.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(148, 131);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(22, 21);
            this.checkBoxManager.TabIndex = 8;
            this.checkBoxManager.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(344, 185);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(103, 34);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Dodaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(453, 185);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 34);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxWorkers);
            this.Name = "Form1";
            this.Text = "Database for workers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBegin;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}

