namespace TestTask_KleverensSoft
{
    partial class FormTask1
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
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxCompressed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessingCompress = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.ProcessingDeCompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(397, 12);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(356, 157);
            this.textBoxOriginal.TabIndex = 0;
            // 
            // textBoxCompressed
            // 
            this.textBoxCompressed.Location = new System.Drawing.Point(397, 281);
            this.textBoxCompressed.Multiline = true;
            this.textBoxCompressed.Name = "textBoxCompressed";
            this.textBoxCompressed.Size = new System.Drawing.Size(356, 157);
            this.textBoxCompressed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходная строка    ---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обработанная строка  ---";
            // 
            // ProcessingCompress
            // 
            this.ProcessingCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProcessingCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessingCompress.Location = new System.Drawing.Point(397, 175);
            this.ProcessingCompress.Name = "ProcessingCompress";
            this.ProcessingCompress.Size = new System.Drawing.Size(107, 50);
            this.ProcessingCompress.TabIndex = 4;
            this.ProcessingCompress.Text = "Сделать Компрессию";
            this.ProcessingCompress.UseVisualStyleBackColor = false;
            this.ProcessingCompress.Click += new System.EventHandler(this.ProcessingCompress_Click);
            // 
            // CleanAll
            // 
            this.CleanAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CleanAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanAll.Location = new System.Drawing.Point(521, 175);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(107, 50);
            this.CleanAll.TabIndex = 5;
            this.CleanAll.Text = "Очистить всё";
            this.CleanAll.UseVisualStyleBackColor = false;
            this.CleanAll.Click += new System.EventHandler(this.CleanAll_Click);
            // 
            // ProcessingDeCompress
            // 
            this.ProcessingDeCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ProcessingDeCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessingDeCompress.Location = new System.Drawing.Point(646, 175);
            this.ProcessingDeCompress.Name = "ProcessingDeCompress";
            this.ProcessingDeCompress.Size = new System.Drawing.Size(107, 50);
            this.ProcessingDeCompress.TabIndex = 6;
            this.ProcessingDeCompress.Text = "Сделать Декомпрессию";
            this.ProcessingDeCompress.UseVisualStyleBackColor = false;
            this.ProcessingDeCompress.Click += new System.EventHandler(this.ProcessingDeCompress_Click);
            // 
            // FormTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestTask_KleverensSoft.Properties.Resources.rose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProcessingDeCompress);
            this.Controls.Add(this.CleanAll);
            this.Controls.Add(this.ProcessingCompress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompressed);
            this.Controls.Add(this.textBoxOriginal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTask1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание #1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxCompressed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProcessingCompress;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button ProcessingDeCompress;
    }
}