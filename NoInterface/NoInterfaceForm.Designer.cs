﻿namespace NoInterface
{
    partial class NoInterfaceForm
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
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 1;
            label1.Text = "NoInterface";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 449);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 404);
            button1.Name = "button1";
            button1.Size = new Size(174, 33);
            button1.TabIndex = 0;
            button1.Text = "Add a Tab";
            button1.UseVisualStyleBackColor = true;
            // 
            // NoInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "NoInterfaceForm";
            Text = "NoInterface";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}
