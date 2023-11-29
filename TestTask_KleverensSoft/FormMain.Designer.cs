namespace TestTask_KleverensSoft
{
    partial class FormMain
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
            this.Task1 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Task1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Task1.Location = new System.Drawing.Point(0, 0);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(1197, 97);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Задание  #1";
            this.Task1.UseVisualStyleBackColor = false;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Task2
            // 
            this.Task2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Task2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task2.Location = new System.Drawing.Point(0, 139);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(1197, 97);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Задание  #2";
            this.Task2.UseVisualStyleBackColor = false;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task3
            // 
            this.Task3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Task3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Task3.Location = new System.Drawing.Point(0, 282);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(1197, 97);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Задание  #3";
            this.Task3.UseVisualStyleBackColor = false;
            this.Task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1197, 379);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание компании ООО Клеверенс Софт";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.Button Task3;
    }
}

