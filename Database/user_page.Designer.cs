namespace Database
{
    partial class user_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RadioButton();
            this.course = new System.Windows.Forms.RadioButton();
            this.students = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.course);
            this.panel1.Controls.Add(this.students);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 451);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Location = new System.Drawing.Point(646, 389);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 35);
            this.exit.TabIndex = 3;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.info.Location = new System.Drawing.Point(291, 262);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(179, 28);
            this.info.TabIndex = 2;
            this.info.Text = "选课成绩管理";
            this.info.UseVisualStyleBackColor = true;
            this.info.CheckedChanged += new System.EventHandler(this.info_CheckedChanged);
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.course.Location = new System.Drawing.Point(291, 180);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(179, 28);
            this.course.TabIndex = 1;
            this.course.Text = "课程信息管理";
            this.course.UseVisualStyleBackColor = true;
            this.course.CheckedChanged += new System.EventHandler(this.course_CheckedChanged);
            // 
            // students
            // 
            this.students.AutoSize = true;
            this.students.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.students.Location = new System.Drawing.Point(291, 98);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(179, 28);
            this.students.TabIndex = 0;
            this.students.Text = "学生信息管理";
            this.students.UseVisualStyleBackColor = true;
            this.students.CheckedChanged += new System.EventHandler(this.students_CheckedChanged);
            // 
            // user_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "user_page";
            this.Text = "学生选课管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.user_page_FormClosed);
            this.Load += new System.EventHandler(this.user_page_Load);
            this.ResizeEnd += new System.EventHandler(this.user_page_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton info;
        private System.Windows.Forms.RadioButton course;
        private System.Windows.Forms.RadioButton students;
    }
}