﻿namespace Database
{
    partial class student_info
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
            this.components = new System.ComponentModel.Container();
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
            this.s_number = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.class_id = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.return1 = new System.Windows.Forms.Button();
            this.course_select_systemDataSet = new Database.course_select_systemDataSet();
            this.courseselectsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_select_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseselectsystemDataSetBindingSource)).BeginInit();
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
            this.panel1.Controls.Add(this.s_number);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.class_id);
            this.panel1.Controls.Add(this.grade);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.sex);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.return1);
            this.panel1.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 821);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(271, 760);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "姓名";
            this.label8.SizeChanged += new System.EventHandler(this.student_info_ResizeEnd);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 760);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "学号";
            this.label7.SizeChanged += new System.EventHandler(this.student_info_ResizeEnd);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(941, 419);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "班级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(941, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "年级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(943, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(940, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(940, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(943, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "学号";
            // 
            // select_all
            // 
            this.select_all.BackColor = System.Drawing.Color.WhiteSmoke;
            this.select_all.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.select_all.Location = new System.Drawing.Point(740, 749);
            this.select_all.Margin = new System.Windows.Forms.Padding(4);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(167, 45);
            this.select_all.TabIndex = 22;
            this.select_all.Text = "查找全部";
            this.select_all.UseVisualStyleBackColor = false;
            this.select_all.Click += new System.EventHandler(this.select_all_Click);
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.WhiteSmoke;
            this.select.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.select.Location = new System.Drawing.Point(549, 751);
            this.select.Margin = new System.Windows.Forms.Padding(4);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(139, 45);
            this.select.TabIndex = 21;
            this.select.Text = "查找";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // s_name
            // 
            this.s_name.Location = new System.Drawing.Point(348, 755);
            this.s_name.Margin = new System.Windows.Forms.Padding(4);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(151, 39);
            this.s_name.TabIndex = 20;
            // 
            // s_number
            // 
            this.s_number.Location = new System.Drawing.Point(81, 751);
            this.s_number.Margin = new System.Windows.Forms.Padding(4);
            this.s_number.Name = "s_number";
            this.s_number.Size = new System.Drawing.Size(165, 39);
            this.s_number.TabIndex = 18;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.delete.Location = new System.Drawing.Point(972, 645);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(216, 51);
            this.delete.TabIndex = 16;
            this.delete.Text = "删除记录";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.update.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.update.Location = new System.Drawing.Point(972, 561);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(215, 56);
            this.update.TabIndex = 15;
            this.update.Text = "修改记录";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.add.Location = new System.Drawing.Point(976, 487);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(212, 51);
            this.add.TabIndex = 14;
            this.add.Text = "添加记录";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // class_id
            // 
            this.class_id.Location = new System.Drawing.Point(1020, 415);
            this.class_id.Margin = new System.Windows.Forms.Padding(4);
            this.class_id.Name = "class_id";
            this.class_id.Size = new System.Drawing.Size(207, 39);
            this.class_id.TabIndex = 13;
            this.class_id.SizeChanged += new System.EventHandler(this.student_info_ResizeEnd);
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(1020, 347);
            this.grade.Margin = new System.Windows.Forms.Padding(4);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(207, 39);
            this.grade.TabIndex = 11;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(1020, 280);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(207, 39);
            this.age.TabIndex = 9;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(1020, 209);
            this.sex.Margin = new System.Windows.Forms.Padding(4);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(207, 39);
            this.sex.TabIndex = 4;
            this.sex.TextChanged += new System.EventHandler(this.sex_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(1020, 140);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(207, 39);
            this.name.TabIndex = 3;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(1020, 68);
            this.number.Margin = new System.Windows.Forms.Padding(4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(207, 39);
            this.number.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(889, 693);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // return1
            // 
            this.return1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.return1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return1.Location = new System.Drawing.Point(976, 723);
            this.return1.Margin = new System.Windows.Forms.Padding(4);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(211, 53);
            this.return1.TabIndex = 0;
            this.return1.Text = "返回主界面";
            this.return1.UseVisualStyleBackColor = false;
            this.return1.Click += new System.EventHandler(this.return1_Click);
            // 
            // course_select_systemDataSet
            // 
            this.course_select_systemDataSet.DataSetName = "course_select_systemDataSet";
            this.course_select_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseselectsystemDataSetBindingSource
            // 
            this.courseselectsystemDataSetBindingSource.DataSource = this.course_select_systemDataSet;
            this.courseselectsystemDataSetBindingSource.Position = 0;
            // 
            // student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 817);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "student_info";
            this.Text = "学生信息管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.student_info_FormClosed);
            this.Load += new System.EventHandler(this.student_info_Load);
            this.SizeChanged += new System.EventHandler(this.student_info_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_select_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseselectsystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button return1;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.DataGridView dataGridView1;
        private course_select_systemDataSet course_select_systemDataSet;
        private System.Windows.Forms.BindingSource courseselectsystemDataSetBindingSource;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox class_id;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.TextBox s_number;
        private System.Windows.Forms.Button select_all;
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