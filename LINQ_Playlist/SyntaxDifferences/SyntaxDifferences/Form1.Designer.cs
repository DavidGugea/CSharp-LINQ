namespace SyntaxDifferences
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
            this.ListBox_Numbers = new System.Windows.Forms.ListBox();
            this.QueryExpressionSyntax_Button = new System.Windows.Forms.Button();
            this.ExtensionMethodSyntax_Button = new System.Windows.Forms.Button();
            this.GemischteSyntax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_Numbers
            // 
            this.ListBox_Numbers.FormattingEnabled = true;
            this.ListBox_Numbers.Location = new System.Drawing.Point(12, 9);
            this.ListBox_Numbers.Name = "ListBox_Numbers";
            this.ListBox_Numbers.Size = new System.Drawing.Size(136, 264);
            this.ListBox_Numbers.TabIndex = 0;
            // 
            // QueryExpressionSyntax_Button
            // 
            this.QueryExpressionSyntax_Button.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryExpressionSyntax_Button.Location = new System.Drawing.Point(191, 33);
            this.QueryExpressionSyntax_Button.Name = "QueryExpressionSyntax_Button";
            this.QueryExpressionSyntax_Button.Size = new System.Drawing.Size(147, 34);
            this.QueryExpressionSyntax_Button.TabIndex = 1;
            this.QueryExpressionSyntax_Button.Text = "Abfrage mit Query Expression Syntax\r\n";
            this.QueryExpressionSyntax_Button.UseVisualStyleBackColor = false;
            this.QueryExpressionSyntax_Button.Click += new System.EventHandler(this.QueryExpressionSyntax_Button_Click);
            // 
            // ExtensionMethodSyntax_Button
            // 
            this.ExtensionMethodSyntax_Button.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionMethodSyntax_Button.Location = new System.Drawing.Point(191, 87);
            this.ExtensionMethodSyntax_Button.Name = "ExtensionMethodSyntax_Button";
            this.ExtensionMethodSyntax_Button.Size = new System.Drawing.Size(147, 34);
            this.ExtensionMethodSyntax_Button.TabIndex = 2;
            this.ExtensionMethodSyntax_Button.Text = "Abfrage mit Extension Method Syntax\r\n";
            this.ExtensionMethodSyntax_Button.UseVisualStyleBackColor = true;
            this.ExtensionMethodSyntax_Button.Click += new System.EventHandler(this.ExtensionMethodSyntax_Button_Click);
            // 
            // GemischteSyntax
            // 
            this.GemischteSyntax.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemischteSyntax.Location = new System.Drawing.Point(191, 148);
            this.GemischteSyntax.Name = "GemischteSyntax";
            this.GemischteSyntax.Size = new System.Drawing.Size(147, 34);
            this.GemischteSyntax.TabIndex = 3;
            this.GemischteSyntax.Text = "Gemischte Syntax\r\n";
            this.GemischteSyntax.UseVisualStyleBackColor = true;
            this.GemischteSyntax.Click += new System.EventHandler(this.GemischteSyntax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 281);
            this.Controls.Add(this.GemischteSyntax);
            this.Controls.Add(this.ExtensionMethodSyntax_Button);
            this.Controls.Add(this.QueryExpressionSyntax_Button);
            this.Controls.Add(this.ListBox_Numbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Numbers;
        private System.Windows.Forms.Button QueryExpressionSyntax_Button;
        private System.Windows.Forms.Button ExtensionMethodSyntax_Button;
        private System.Windows.Forms.Button GemischteSyntax;
    }
}

