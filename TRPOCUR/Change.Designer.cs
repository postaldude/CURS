
namespace TRPOCUR
{
    partial class Change
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кОкнуРегистрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_for_data = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_for_Select = new System.Windows.Forms.NumericUpDown();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Choose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_for_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_for_Select)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 466);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clarendon Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сотрудники";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.кОкнуРегистрацииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.выгрузитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.просмотрДанныхToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // выгрузитьToolStripMenuItem
            // 
            this.выгрузитьToolStripMenuItem.Name = "выгрузитьToolStripMenuItem";
            this.выгрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выгрузитьToolStripMenuItem.Text = "Выгрузить";
            this.выгрузитьToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбранныйToolStripMenuItem,
            this.всеToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // выбранныйToolStripMenuItem
            // 
            this.выбранныйToolStripMenuItem.Name = "выбранныйToolStripMenuItem";
            this.выбранныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбранныйToolStripMenuItem.Text = "Выбранный";
            this.выбранныйToolStripMenuItem.Click += new System.EventHandler(this.выбранныйToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всеToolStripMenuItem.Text = "Все";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.всеToolStripMenuItem_Click);
            // 
            // просмотрДанныхToolStripMenuItem
            // 
            this.просмотрДанныхToolStripMenuItem.Name = "просмотрДанныхToolStripMenuItem";
            this.просмотрДанныхToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.просмотрДанныхToolStripMenuItem.Text = "Просмотр данных";
            this.просмотрДанныхToolStripMenuItem.Click += new System.EventHandler(this.просмотрДанныхToolStripMenuItem_Click);
            // 
            // кОкнуРегистрацииToolStripMenuItem
            // 
            this.кОкнуРегистрацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem,
            this.входToolStripMenuItem});
            this.кОкнуРегистрацииToolStripMenuItem.Name = "кОкнуРегистрацииToolStripMenuItem";
            this.кОкнуРегистрацииToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.кОкнуРегистрацииToolStripMenuItem.Text = "Выйти";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияСотрудникаToolStripMenuItem,
            this.регистрацияАдминистратораToolStripMenuItem});
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            // 
            // регистрацияСотрудникаToolStripMenuItem
            // 
            this.регистрацияСотрудникаToolStripMenuItem.Name = "регистрацияСотрудникаToolStripMenuItem";
            this.регистрацияСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.регистрацияСотрудникаToolStripMenuItem.Text = "Регистрация сотрудника";
            this.регистрацияСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.регистрацияСотрудникаToolStripMenuItem_Click);
            // 
            // регистрацияАдминистратораToolStripMenuItem
            // 
            this.регистрацияАдминистратораToolStripMenuItem.Name = "регистрацияАдминистратораToolStripMenuItem";
            this.регистрацияАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.регистрацияАдминистратораToolStripMenuItem.Text = "Регистрация администратора";
            this.регистрацияАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.регистрацияАдминистратораToolStripMenuItem_Click);
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.входToolStripMenuItem.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(492, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во данных:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(492, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выбор данных:";
            // 
            // numericUpDown_for_data
            // 
            this.numericUpDown_for_data.Location = new System.Drawing.Point(603, 43);
            this.numericUpDown_for_data.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_for_data.Name = "numericUpDown_for_data";
            this.numericUpDown_for_data.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_for_data.TabIndex = 8;
            this.numericUpDown_for_data.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_for_Select
            // 
            this.numericUpDown_for_Select.Location = new System.Drawing.Point(603, 74);
            this.numericUpDown_for_Select.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_for_Select.Name = "numericUpDown_for_Select";
            this.numericUpDown_for_Select.Size = new System.Drawing.Size(94, 20);
            this.numericUpDown_for_Select.TabIndex = 9;
            this.numericUpDown_for_Select.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(713, 40);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 10;
            this.button_Create.Text = "Создать";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Choose
            // 
            this.button_Choose.Location = new System.Drawing.Point(713, 74);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(75, 23);
            this.button_Choose.TabIndex = 11;
            this.button_Choose.Text = "Выбрать";
            this.button_Choose.UseVisualStyleBackColor = true;
            this.button_Choose.Click += new System.EventHandler(this.button_Choose_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.button_Choose);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.numericUpDown_for_Select);
            this.Controls.Add(this.numericUpDown_for_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 626);
            this.MinimumSize = new System.Drawing.Size(816, 626);
            this.Name = "Change";
            this.Text = "Change";
            this.Shown += new System.EventHandler(this.Change_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_for_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_for_Select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кОкнуРегистрацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_for_data;
        private System.Windows.Forms.NumericUpDown numericUpDown_for_Select;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДанныхToolStripMenuItem;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Choose;
        private System.Windows.Forms.ToolStripMenuItem регистрацияСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьToolStripMenuItem;
    }
}