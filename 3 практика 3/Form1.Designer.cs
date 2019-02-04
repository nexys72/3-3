namespace _3_практика_3
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.облакаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лесToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.полеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снегToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.птицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дождьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.машинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рычковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.облакаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.лесToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы с рисунками|*.jpg;*.jpeg;*.gif;*.bmp\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисункиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // рисункиToolStripMenuItem
            // 
            this.рисункиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.облакаToolStripMenuItem,
            this.лесToolStripMenuItem,
            this.полеToolStripMenuItem,
            this.снегToolStripMenuItem,
            this.птицыToolStripMenuItem,
            this.дождьToolStripMenuItem,
            this.машинаToolStripMenuItem,
            this.рычковToolStripMenuItem});
            this.рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            this.рисункиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // облакаToolStripMenuItem
            // 
            this.облакаToolStripMenuItem.Name = "облакаToolStripMenuItem";
            this.облакаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.облакаToolStripMenuItem.Text = "Облака";
            this.облакаToolStripMenuItem.Click += new System.EventHandler(this.облакаToolStripMenuItem_Click);
            // 
            // лесToolStripMenuItem
            // 
            this.лесToolStripMenuItem.Name = "лесToolStripMenuItem";
            this.лесToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.лесToolStripMenuItem.Text = "лес";
            this.лесToolStripMenuItem.Click += new System.EventHandler(this.лесToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem1.Text = "выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // полеToolStripMenuItem
            // 
            this.полеToolStripMenuItem.Name = "полеToolStripMenuItem";
            this.полеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.полеToolStripMenuItem.Text = "поле";
            this.полеToolStripMenuItem.Click += new System.EventHandler(this.полеToolStripMenuItem_Click);
            // 
            // снегToolStripMenuItem
            // 
            this.снегToolStripMenuItem.Name = "снегToolStripMenuItem";
            this.снегToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.снегToolStripMenuItem.Text = "снег";
            this.снегToolStripMenuItem.Click += new System.EventHandler(this.снегToolStripMenuItem_Click);
            // 
            // птицыToolStripMenuItem
            // 
            this.птицыToolStripMenuItem.Name = "птицыToolStripMenuItem";
            this.птицыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.птицыToolStripMenuItem.Text = "птицы";
            this.птицыToolStripMenuItem.Click += new System.EventHandler(this.птицыToolStripMenuItem_Click);
            // 
            // дождьToolStripMenuItem
            // 
            this.дождьToolStripMenuItem.Name = "дождьToolStripMenuItem";
            this.дождьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.дождьToolStripMenuItem.Text = "дождь";
            this.дождьToolStripMenuItem.Click += new System.EventHandler(this.дождьToolStripMenuItem_Click);
            // 
            // машинаToolStripMenuItem
            // 
            this.машинаToolStripMenuItem.Name = "машинаToolStripMenuItem";
            this.машинаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.машинаToolStripMenuItem.Text = "машина";
            this.машинаToolStripMenuItem.Click += new System.EventHandler(this.машинаToolStripMenuItem_Click);
            // 
            // рычковToolStripMenuItem
            // 
            this.рычковToolStripMenuItem.Name = "рычковToolStripMenuItem";
            this.рычковToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рычковToolStripMenuItem.Text = "рычков";
            this.рычковToolStripMenuItem.Click += new System.EventHandler(this.рычковToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.облакаToolStripMenuItem1,
            this.лесToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // облакаToolStripMenuItem1
            // 
            this.облакаToolStripMenuItem1.Name = "облакаToolStripMenuItem1";
            this.облакаToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.облакаToolStripMenuItem1.Text = "облака";
            this.облакаToolStripMenuItem1.Click += new System.EventHandler(this.облакаToolStripMenuItem1_Click);
            // 
            // лесToolStripMenuItem1
            // 
            this.лесToolStripMenuItem1.Name = "лесToolStripMenuItem1";
            this.лесToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.лесToolStripMenuItem1.Text = "лес";
            this.лесToolStripMenuItem1.Click += new System.EventHandler(this.лесToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Электронный альбом";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem облакаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лесToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem облакаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem лесToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снегToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem птицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дождьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem машинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рычковToolStripMenuItem;
    }
}

