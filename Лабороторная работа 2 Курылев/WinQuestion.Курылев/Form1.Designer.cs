namespace WinQuestion.Курылев
{
    partial class Form1
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
            this.btnyes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(82, 75);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(77, 39);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Да";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вы довольны своей зарплатой?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(171, 75);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(77, 39);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "Нет";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.button3_Click);
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 157);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Насущный вопрос";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnno;
    }
}

