namespace ArrayProcessForm
{
    partial class ArrayProcessForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterButton = new System.Windows.Forms.Button();
            this.NumberInputTextBox = new System.Windows.Forms.TextBox();
            this.NumbersListBox = new System.Windows.Forms.ListBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.NumberInputLabel = new System.Windows.Forms.Label();
            this.NumberListLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(100, 24);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(0);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 22);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Ввод";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // NumberInputTextBox
            // 
            this.NumberInputTextBox.Location = new System.Drawing.Point(12, 25);
            this.NumberInputTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NumberInputTextBox.MaxLength = 4;
            this.NumberInputTextBox.Name = "NumberInputTextBox";
            this.NumberInputTextBox.Size = new System.Drawing.Size(87, 20);
            this.NumberInputTextBox.TabIndex = 1;
            this.NumberInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberInputTextBox_KeyPress);
            // 
            // NumbersListBox
            // 
            this.NumbersListBox.FormattingEnabled = true;
            this.NumbersListBox.Location = new System.Drawing.Point(12, 64);
            this.NumbersListBox.Name = "NumbersListBox";
            this.NumbersListBox.Size = new System.Drawing.Size(87, 134);
            this.NumbersListBox.TabIndex = 2;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(100, 63);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 163);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "Обработать";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // NumberInputLabel
            // 
            this.NumberInputLabel.AutoSize = true;
            this.NumberInputLabel.Location = new System.Drawing.Point(12, 9);
            this.NumberInputLabel.Name = "NumberInputLabel";
            this.NumberInputLabel.Size = new System.Drawing.Size(90, 13);
            this.NumberInputLabel.TabIndex = 5;
            this.NumberInputLabel.Text = "Вводимое число";
            // 
            // NumberListLabel
            // 
            this.NumberListLabel.AutoSize = true;
            this.NumberListLabel.Location = new System.Drawing.Point(12, 48);
            this.NumberListLabel.Name = "NumberListLabel";
            this.NumberListLabel.Size = new System.Drawing.Size(76, 13);
            this.NumberListLabel.TabIndex = 6;
            this.NumberListLabel.Text = "Список чисел";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 201);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(87, 24);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // ArrayProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 234);
            this.Controls.Add(this.NumberListLabel);
            this.Controls.Add(this.NumberInputLabel);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.NumbersListBox);
            this.Controls.Add(this.NumberInputTextBox);
            this.Controls.Add(this.EnterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrayProcessForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Обработка массива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox NumberInputTextBox;
        private System.Windows.Forms.ListBox NumbersListBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Label NumberInputLabel;
        private System.Windows.Forms.Label NumberListLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

