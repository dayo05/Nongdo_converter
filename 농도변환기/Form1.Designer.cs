
namespace 농도변환기
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.FromDropDownList = new System.Windows.Forms.ComboBox();
            this.ToDropDownList = new System.Windows.Forms.ComboBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(36, 55);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(100, 23);
            this.FromTextBox.TabIndex = 2;
            this.FromTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // FromDropDownList
            // 
            this.FromDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromDropDownList.FormattingEnabled = true;
            this.FromDropDownList.Location = new System.Drawing.Point(142, 55);
            this.FromDropDownList.Name = "FromDropDownList";
            this.FromDropDownList.Size = new System.Drawing.Size(46, 23);
            this.FromDropDownList.TabIndex = 3;
            this.FromDropDownList.SelectedIndexChanged += new System.EventHandler(this.FromDropDownList_SelectedIndexChanged);
            // 
            // ToDropDownList
            // 
            this.ToDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToDropDownList.FormattingEnabled = true;
            this.ToDropDownList.Location = new System.Drawing.Point(142, 122);
            this.ToDropDownList.Name = "ToDropDownList";
            this.ToDropDownList.Size = new System.Drawing.Size(46, 23);
            this.ToDropDownList.TabIndex = 5;
            this.ToDropDownList.SelectedIndexChanged += new System.EventHandler(this.ToDropDownList_SelectedIndexChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(70, 170);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(36, 125);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(36, 15);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "NULL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 220);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ToDropDownList);
            this.Controls.Add(this.FromDropDownList);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "농도변환기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.ComboBox FromDropDownList;
        private System.Windows.Forms.ComboBox ToDropDownList;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

