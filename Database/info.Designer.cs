namespace Database
{
    partial class info
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
            this.select_all = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.s_cname = new System.Windows.Forms.TextBox();
            this.s_cid = new System.Windows.Forms.TextBox();
            this.s_sname = new System.Windows.Forms.TextBox();
            this.s_sid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cou_average_mark = new System.Windows.Forms.RadioButton();
            this.cou_mark = new System.Windows.Forms.RadioButton();
            this.c_average_mark = new System.Windows.Forms.RadioButton();
            this.average_mark = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.return_main = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.choose_year = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.TextBox();
            this.cid = new System.Windows.Forms.TextBox();
            this.sid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.course_select_systemDataSet1 = new Database.course_select_systemDataSet();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_select_systemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.select_all);
            this.panel1.Controls.Add(this.select);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.return_main);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.choose_year);
            this.panel1.Controls.Add(this.mark);
            this.panel1.Controls.Add(this.cid);
            this.panel1.Controls.Add(this.sid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 660);
            this.panel1.TabIndex = 0;
            // 
            // select_all
            // 
            this.select_all.BackColor = System.Drawing.Color.WhiteSmoke;
            this.select_all.Location = new System.Drawing.Point(743, 536);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(152, 37);
            this.select_all.TabIndex = 17;
            this.select_all.Text = "查找全部";
            this.select_all.UseVisualStyleBackColor = false;
            this.select_all.Click += new System.EventHandler(this.select_all_Click);
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.WhiteSmoke;
            this.select.Location = new System.Drawing.Point(743, 472);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(152, 39);
            this.select.TabIndex = 16;
            this.select.Text = "查找";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.s_cname);
            this.panel3.Controls.Add(this.s_cid);
            this.panel3.Controls.Add(this.s_sname);
            this.panel3.Controls.Add(this.s_sid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(375, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 213);
            this.panel3.TabIndex = 15;
            // 
            // s_cname
            // 
            this.s_cname.Location = new System.Drawing.Point(122, 160);
            this.s_cname.Name = "s_cname";
            this.s_cname.Size = new System.Drawing.Size(129, 31);
            this.s_cname.TabIndex = 8;
            // 
            // s_cid
            // 
            this.s_cid.Location = new System.Drawing.Point(122, 116);
            this.s_cid.Name = "s_cid";
            this.s_cid.Size = new System.Drawing.Size(129, 31);
            this.s_cid.TabIndex = 7;
            // 
            // s_sname
            // 
            this.s_sname.Location = new System.Drawing.Point(122, 75);
            this.s_sname.Name = "s_sname";
            this.s_sname.Size = new System.Drawing.Size(129, 31);
            this.s_sname.TabIndex = 6;
            // 
            // s_sid
            // 
            this.s_sid.Location = new System.Drawing.Point(122, 32);
            this.s_sid.Name = "s_sid";
            this.s_sid.Size = new System.Drawing.Size(129, 31);
            this.s_sid.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "课程名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "课程号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "姓  名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "学  号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "信息查找";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cou_average_mark);
            this.panel2.Controls.Add(this.cou_mark);
            this.panel2.Controls.Add(this.c_average_mark);
            this.panel2.Controls.Add(this.average_mark);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(15, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 213);
            this.panel2.TabIndex = 14;
            // 
            // cou_average_mark
            // 
            this.cou_average_mark.AutoSize = true;
            this.cou_average_mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cou_average_mark.Font = new System.Drawing.Font("宋体", 9F);
            this.cou_average_mark.Location = new System.Drawing.Point(12, 152);
            this.cou_average_mark.Name = "cou_average_mark";
            this.cou_average_mark.Size = new System.Drawing.Size(193, 22);
            this.cou_average_mark.TabIndex = 15;
            this.cou_average_mark.TabStop = true;
            this.cou_average_mark.Text = "每个课程的平均成绩";
            this.cou_average_mark.UseVisualStyleBackColor = true;
            this.cou_average_mark.Click += new System.EventHandler(this.cou_average_mark_CheckedChanged);
            // 
            // cou_mark
            // 
            this.cou_mark.AutoSize = true;
            this.cou_mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cou_mark.Font = new System.Drawing.Font("宋体", 9F);
            this.cou_mark.Location = new System.Drawing.Point(12, 113);
            this.cou_mark.Name = "cou_mark";
            this.cou_mark.Size = new System.Drawing.Size(193, 22);
            this.cou_mark.TabIndex = 15;
            this.cou_mark.TabStop = true;
            this.cou_mark.Text = "每个课程的成绩分布";
            this.cou_mark.UseVisualStyleBackColor = true;
            this.cou_mark.Click += new System.EventHandler(this.cou_mark_CheckedChanged);
            // 
            // c_average_mark
            // 
            this.c_average_mark.AutoSize = true;
            this.c_average_mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_average_mark.Font = new System.Drawing.Font("宋体", 9F);
            this.c_average_mark.Location = new System.Drawing.Point(12, 75);
            this.c_average_mark.Name = "c_average_mark";
            this.c_average_mark.Size = new System.Drawing.Size(193, 22);
            this.c_average_mark.TabIndex = 15;
            this.c_average_mark.TabStop = true;
            this.c_average_mark.Text = "每个班级的平均成绩";
            this.c_average_mark.UseVisualStyleBackColor = true;
            this.c_average_mark.Click += new System.EventHandler(this.c_average_mark_CheckedChanged);
            // 
            // average_mark
            // 
            this.average_mark.AutoSize = true;
            this.average_mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.average_mark.Font = new System.Drawing.Font("宋体", 9F);
            this.average_mark.Location = new System.Drawing.Point(12, 36);
            this.average_mark.Name = "average_mark";
            this.average_mark.Size = new System.Drawing.Size(193, 22);
            this.average_mark.TabIndex = 15;
            this.average_mark.TabStop = true;
            this.average_mark.Text = "每个学生的平均成绩";
            this.average_mark.UseVisualStyleBackColor = true;
            this.average_mark.Click += new System.EventHandler(this.average_mark_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "信息统计";
            // 
            // return_main
            // 
            this.return_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.return_main.Location = new System.Drawing.Point(743, 599);
            this.return_main.Name = "return_main";
            this.return_main.Size = new System.Drawing.Size(152, 37);
            this.return_main.TabIndex = 13;
            this.return_main.Text = "返回主界面";
            this.return_main.UseVisualStyleBackColor = false;
            this.return_main.Click += new System.EventHandler(this.return_main_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Location = new System.Drawing.Point(743, 410);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(152, 36);
            this.delete.TabIndex = 12;
            this.delete.Text = "删除记录";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.update.Location = new System.Drawing.Point(743, 348);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(152, 36);
            this.update.TabIndex = 11;
            this.update.Text = "修改记录";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add.Location = new System.Drawing.Point(743, 289);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(152, 36);
            this.add.TabIndex = 10;
            this.add.Text = "添加记录";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // choose_year
            // 
            this.choose_year.Location = new System.Drawing.Point(785, 202);
            this.choose_year.Name = "choose_year";
            this.choose_year.Size = new System.Drawing.Size(152, 31);
            this.choose_year.TabIndex = 9;
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(785, 144);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(152, 31);
            this.mark.TabIndex = 8;
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(785, 89);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(152, 31);
            this.cid.TabIndex = 7;
            // 
            // sid
            // 
            this.sid.Location = new System.Drawing.Point(785, 34);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(152, 31);
            this.sid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "选择年份";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "分  数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "课程号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "学  号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(647, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // course_select_systemDataSet1
            // 
            this.course_select_systemDataSet1.DataSetName = "course_select_systemDataSet";
            this.course_select_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(978, 659);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "info";
            this.Text = "选课成绩管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.info_FormClosed);
            this.Load += new System.EventHandler(this.info_Load);
            this.ResizeEnd += new System.EventHandler(this.resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_select_systemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox choose_year;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_main;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cou_average_mark;
        private System.Windows.Forms.RadioButton cou_mark;
        private System.Windows.Forms.RadioButton c_average_mark;
        private System.Windows.Forms.RadioButton average_mark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button select_all;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox s_cname;
        private System.Windows.Forms.TextBox s_cid;
        private System.Windows.Forms.TextBox s_sname;
        private System.Windows.Forms.TextBox s_sid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private course_select_systemDataSet course_select_systemDataSet1;
    }
}