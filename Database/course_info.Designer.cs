namespace Database
{
    partial class course_info
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.select_all = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.s_name = new System.Windows.Forms.TextBox();
            this.s_cid = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.teacher = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.course_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.select_all);
            this.panel1.Controls.Add(this.select);
            this.panel1.Controls.Add(this.s_name);
            this.panel1.Controls.Add(this.s_cid);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.grade);
            this.panel1.Controls.Add(this.credit);
            this.panel1.Controls.Add(this.teacher);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.course_id);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 718);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(248, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "课程名";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "课程号";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(709, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "任课教师";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(709, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "取消年份";
            this.label5.SizeChanged += new System.EventHandler(this.course_info_ResizeEnd);
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(718, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "年  级";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(718, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "学  分";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(718, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "课程名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(718, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "课程号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // select_all
            // 
            this.select_all.BackColor = System.Drawing.Color.WhiteSmoke;
            this.select_all.Location = new System.Drawing.Point(541, 643);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(145, 44);
            this.select_all.TabIndex = 22;
            this.select_all.Text = "查找全部";
            this.select_all.UseVisualStyleBackColor = false;
            this.select_all.Click += new System.EventHandler(this.select_all_Click);
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.WhiteSmoke;
            this.select.Location = new System.Drawing.Point(541, 571);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(145, 42);
            this.select.TabIndex = 21;
            this.select.Text = "查找";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(350, 598);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(121, 39);
            this.s_name.TabIndex = 20;
            this.s_name.TextChanged += new System.EventHandler(this.s_name_TextChanged);
            // 
            // s_cid
            // 
            this.s_cid.Location = new System.Drawing.Point(105, 594);
            this.s_cid.Name = "s_cid";
            this.s_cid.Size = new System.Drawing.Size(124, 39);
            this.s_cid.TabIndex = 18;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Location = new System.Drawing.Point(839, 637);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(184, 56);
            this.exit.TabIndex = 16;
            this.exit.Text = "返回主界面";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Location = new System.Drawing.Point(839, 558);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(184, 55);
            this.delete.TabIndex = 15;
            this.delete.Text = "删除记录";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.update.Location = new System.Drawing.Point(839, 481);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(184, 56);
            this.update.TabIndex = 14;
            this.update.Text = "修改记录";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add.Location = new System.Drawing.Point(839, 401);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(184, 59);
            this.add.TabIndex = 13;
            this.add.Text = "添加记录";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(839, 267);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(182, 39);
            this.cancel.TabIndex = 12;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(839, 210);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(182, 39);
            this.grade.TabIndex = 10;
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(839, 152);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(184, 39);
            this.credit.TabIndex = 8;
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(839, 328);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(182, 39);
            this.teacher.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(839, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 39);
            this.name.TabIndex = 4;
            // 
            // course_id
            // 
            this.course_id.Location = new System.Drawing.Point(839, 40);
            this.course_id.Name = "course_id";
            this.course_id.Size = new System.Drawing.Size(182, 39);
            this.course_id.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(672, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // course_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 718);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "course_info";
            this.Text = "课程信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.course_info_FormClosed);
            this.Load += new System.EventHandler(this.course_info_Load);
            this.SizeChanged += new System.EventHandler(this.course_info_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox course_id;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cancel;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button select_all;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox s_cid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}