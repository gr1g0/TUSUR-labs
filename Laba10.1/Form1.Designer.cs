namespace ТЕст_занятие
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            textBoxLength = new TextBox();
            button1 = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 69);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 69);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 69);
            label3.Name = "label2";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "length";
            // 
            // texBoxWidth
            // 
            textBoxWidth.Location = new Point(100, 107);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(125, 27);
            textBoxWidth.TabIndex = 3;
            // 
            // texBoxWidth
            // 
            textBoxHeight.Location = new Point(300, 107);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(125, 27);
            textBoxHeight.TabIndex = 4;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(500, 107);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(125, 27);
            textBoxLength.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(74, 183);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(74, 254);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(45, 20);
            labelResult.TabIndex = 7;
            labelResult.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(textBoxWidth);
            Controls.Add(textBoxLength);
            Controls.Add(textBoxHeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Parallelepiped";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxWidth;
        private TextBox textBoxLength;
        private TextBox textBoxHeight;
        private Button button1;
        private Label labelResult;
    }
}
