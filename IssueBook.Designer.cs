
namespace Library
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchStudButton = new System.Windows.Forms.Button();
            this.enterEnrollField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookNameField = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.studNameField = new System.Windows.Forms.TextBox();
            this.enrollmentField = new System.Windows.Forms.TextBox();
            this.departmentField = new System.Windows.Forms.TextBox();
            this.studSemesterField = new System.Windows.Forms.TextBox();
            this.studContactField = new System.Windows.Forms.TextBox();
            this.studEmailField = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.issueButton = new System.Windows.Forms.Button();
            this.bookNameBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 157);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(569, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выдача книг";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.searchStudButton);
            this.panel2.Controls.Add(this.enterEnrollField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 566);
            this.panel2.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(183, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 46);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(39, 466);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(121, 46);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchStudButton
            // 
            this.searchStudButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchStudButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchStudButton.Location = new System.Drawing.Point(85, 328);
            this.searchStudButton.Name = "searchStudButton";
            this.searchStudButton.Size = new System.Drawing.Size(180, 37);
            this.searchStudButton.TabIndex = 3;
            this.searchStudButton.Text = "Поиск студента";
            this.searchStudButton.UseVisualStyleBackColor = true;
            this.searchStudButton.Click += new System.EventHandler(this.searchStudButton_Click);
            // 
            // enterEnrollField
            // 
            this.enterEnrollField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterEnrollField.Location = new System.Drawing.Point(50, 275);
            this.enterEnrollField.Name = "enterEnrollField";
            this.enterEnrollField.Size = new System.Drawing.Size(241, 27);
            this.enterEnrollField.TabIndex = 2;
            this.enterEnrollField.TextChanged += new System.EventHandler(this.enterEnrollField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите номер регистрации";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(428, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(428, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(428, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 11;
            this.label5.Text = "Студенческий\r\n семестр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(428, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Факультет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(428, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер регистрации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(428, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Имя студента";
            // 
            // bookNameField
            // 
            this.bookNameField.AutoSize = true;
            this.bookNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookNameField.Location = new System.Drawing.Point(428, 616);
            this.bookNameField.Name = "bookNameField";
            this.bookNameField.Size = new System.Drawing.Size(155, 25);
            this.bookNameField.TabIndex = 14;
            this.bookNameField.Text = "Название книги";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(428, 684);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Дата выдачи книги";
            // 
            // studNameField
            // 
            this.studNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studNameField.Location = new System.Drawing.Point(643, 200);
            this.studNameField.Name = "studNameField";
            this.studNameField.ReadOnly = true;
            this.studNameField.Size = new System.Drawing.Size(327, 27);
            this.studNameField.TabIndex = 16;
            // 
            // enrollmentField
            // 
            this.enrollmentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enrollmentField.Location = new System.Drawing.Point(643, 264);
            this.enrollmentField.Name = "enrollmentField";
            this.enrollmentField.ReadOnly = true;
            this.enrollmentField.Size = new System.Drawing.Size(327, 27);
            this.enrollmentField.TabIndex = 17;
            // 
            // departmentField
            // 
            this.departmentField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentField.Location = new System.Drawing.Point(643, 330);
            this.departmentField.Name = "departmentField";
            this.departmentField.ReadOnly = true;
            this.departmentField.Size = new System.Drawing.Size(327, 27);
            this.departmentField.TabIndex = 18;
            // 
            // studSemesterField
            // 
            this.studSemesterField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studSemesterField.Location = new System.Drawing.Point(643, 399);
            this.studSemesterField.Name = "studSemesterField";
            this.studSemesterField.ReadOnly = true;
            this.studSemesterField.Size = new System.Drawing.Size(327, 27);
            this.studSemesterField.TabIndex = 19;
            // 
            // studContactField
            // 
            this.studContactField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studContactField.Location = new System.Drawing.Point(643, 472);
            this.studContactField.Name = "studContactField";
            this.studContactField.ReadOnly = true;
            this.studContactField.Size = new System.Drawing.Size(327, 27);
            this.studContactField.TabIndex = 20;
            // 
            // studEmailField
            // 
            this.studEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studEmailField.Location = new System.Drawing.Point(643, 543);
            this.studEmailField.Name = "studEmailField";
            this.studEmailField.ReadOnly = true;
            this.studEmailField.Size = new System.Drawing.Size(327, 27);
            this.studEmailField.TabIndex = 21;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(643, 684);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(327, 28);
            this.dateTimePicker.TabIndex = 23;
            // 
            // issueButton
            // 
            this.issueButton.BackColor = System.Drawing.Color.Thistle;
            this.issueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issueButton.Location = new System.Drawing.Point(793, 752);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(177, 44);
            this.issueButton.TabIndex = 24;
            this.issueButton.Text = "Выдать книгу";
            this.issueButton.UseVisualStyleBackColor = false;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // bookNameBox
            // 
            this.bookNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookNameBox.FormattingEnabled = true;
            this.bookNameBox.Location = new System.Drawing.Point(643, 615);
            this.bookNameBox.Name = "bookNameBox";
            this.bookNameBox.Size = new System.Drawing.Size(327, 28);
            this.bookNameBox.TabIndex = 26;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1024, 808);
            this.Controls.Add(this.bookNameBox);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.studEmailField);
            this.Controls.Add(this.studContactField);
            this.Controls.Add(this.studSemesterField);
            this.Controls.Add(this.departmentField);
            this.Controls.Add(this.enrollmentField);
            this.Controls.Add(this.studNameField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bookNameField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button searchStudButton;
        private System.Windows.Forms.TextBox enterEnrollField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bookNameField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studNameField;
        private System.Windows.Forms.TextBox enrollmentField;
        private System.Windows.Forms.TextBox departmentField;
        private System.Windows.Forms.TextBox studSemesterField;
        private System.Windows.Forms.TextBox studContactField;
        private System.Windows.Forms.TextBox studEmailField;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.ComboBox bookNameBox;
    }
}