namespace ReplaceSqlParameters
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
            this.richTextBoxSql = new System.Windows.Forms.RichTextBox();
            this.richTextBoxParameters = new System.Windows.Forms.RichTextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sql";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parameters";
            // 
            // richTextBoxSql
            // 
            this.richTextBoxSql.Location = new System.Drawing.Point(32, 93);
            this.richTextBoxSql.Name = "richTextBoxSql";
            this.richTextBoxSql.Size = new System.Drawing.Size(574, 372);
            this.richTextBoxSql.TabIndex = 2;
            this.richTextBoxSql.Text = "";
            // 
            // richTextBoxParameters
            // 
            this.richTextBoxParameters.Location = new System.Drawing.Point(726, 95);
            this.richTextBoxParameters.Name = "richTextBoxParameters";
            this.richTextBoxParameters.Size = new System.Drawing.Size(631, 370);
            this.richTextBoxParameters.TabIndex = 3;
            this.richTextBoxParameters.Text = "";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(505, 769);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(330, 87);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(67, 540);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(1295, 168);
            this.richTextBoxResult.TabIndex = 6;
            this.richTextBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 889);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.richTextBoxParameters);
            this.Controls.Add(this.richTextBoxSql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxSql;
        private RichTextBox richTextBoxParameters;
        private Button replaceButton;
        private Label label3;
        private RichTextBox richTextBoxResult;
    }
}