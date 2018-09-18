namespace GraphF
{
    partial class GraphForm
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.RemoveBtn = new System.Windows.Forms.RadioButton();
            this.AddBtn = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NodeBtn = new System.Windows.Forms.RadioButton();
            this.EdgeBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedOut = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GetCycles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(245, 27);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(679, 411);
            this.Picture.TabIndex = 6;
            this.Picture.TabStop = false;
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseDown);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.Location = new System.Drawing.Point(6, 42);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(68, 17);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.Checked = true;
            this.AddBtn.Location = new System.Drawing.Point(6, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 17);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.TabStop = true;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.OpenToolStripMenuItem.Text = "открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveToolStripMenuItem.Text = "сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Граф(*.dat)|*.dat|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Граф(*.dat)|*.dat|Все файлы|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.RemoveBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // SelectBtn
            // 
            this.SelectBtn.AutoSize = true;
            this.SelectBtn.Location = new System.Drawing.Point(6, 66);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(69, 17);
            this.SelectBtn.TabIndex = 6;
            this.SelectBtn.Text = "Выбрать";
            this.SelectBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NodeBtn);
            this.groupBox2.Controls.Add(this.EdgeBtn);
            this.groupBox2.Location = new System.Drawing.Point(96, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(67, 102);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // NodeBtn
            // 
            this.NodeBtn.AutoSize = true;
            this.NodeBtn.Checked = true;
            this.NodeBtn.Location = new System.Drawing.Point(6, 19);
            this.NodeBtn.Name = "NodeBtn";
            this.NodeBtn.Size = new System.Drawing.Size(51, 17);
            this.NodeBtn.TabIndex = 4;
            this.NodeBtn.TabStop = true;
            this.NodeBtn.Text = "Узел";
            this.NodeBtn.UseVisualStyleBackColor = true;
            // 
            // EdgeBtn
            // 
            this.EdgeBtn.AutoSize = true;
            this.EdgeBtn.Location = new System.Drawing.Point(6, 42);
            this.EdgeBtn.Name = "EdgeBtn";
            this.EdgeBtn.Size = new System.Drawing.Size(56, 17);
            this.EdgeBtn.TabIndex = 5;
            this.EdgeBtn.Text = "Ребро";
            this.EdgeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Выбраны";
            // 
            // SelectedOut
            // 
            this.SelectedOut.AutoSize = true;
            this.SelectedOut.Location = new System.Drawing.Point(68, 133);
            this.SelectedOut.Name = "SelectedOut";
            this.SelectedOut.Size = new System.Drawing.Size(10, 13);
            this.SelectedOut.TabIndex = 12;
            this.SelectedOut.Text = " ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 171);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(66, 23);
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GetCycles
            // 
            this.GetCycles.Location = new System.Drawing.Point(84, 171);
            this.GetCycles.Name = "GetCycles";
            this.GetCycles.Size = new System.Drawing.Size(98, 23);
            this.GetCycles.TabIndex = 16;
            this.GetCycles.Text = "Найти циклы";
            this.GetCycles.UseVisualStyleBackColor = true;
            this.GetCycles.Click += new System.EventHandler(this.GetWayBtn_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.GetCycles);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SelectedOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Picture);
            this.Name = "GraphForm";
            this.Text = "Найти все циклы, не содержащие выделенных вершин";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.RadioButton RemoveBtn;
        private System.Windows.Forms.RadioButton AddBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NodeBtn;
        private System.Windows.Forms.RadioButton EdgeBtn;
        private System.Windows.Forms.RadioButton SelectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectedOut;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button GetCycles;
    }
}

