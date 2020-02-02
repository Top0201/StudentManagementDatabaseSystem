using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Database
{
    public partial class course_info : Form
    {
        MySqlConnection con;
        user_page page;
        AutoSizeForm auto;
        public course_info(MySqlConnection con)
        {
            this.con = con;
            auto = new AutoSizeForm();
            InitializeComponent();
        }

        //关闭窗口事件
        private void windowClose(object sender, EventArgs e)
        {

        }

        private void course_info_Load(object sender, EventArgs e)
        {
            auto.controlInitial(this);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            page = new user_page(con);
            this.Hide();
            page.ShowDialog();
        }

        //检查输入信息合法性
        private bool validate()
        {
            if (course_id.Text.ToString().Length != 7)
            {
                MessageBox.Show("请输入正确格式的课程号！如2017000");
                return false;
            }
            return true;

            
        }
        //添加记录
        private void add_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }

            MySqlCommand command = con.CreateCommand();
            string sql = "insert into course values('{0}','{1}','{2}',{3},{4},{5})";
            

            if (cancel.Text=="")
            {
                command.CommandText =
                    string.Format(sql, course_id.Text, name.Text
                    , teacher.Text, double.Parse(credit.Text), int.Parse(grade.Text), "null");
                
            }

            else
            {
                command.CommandText =
                   string.Format(sql, course_id.Text, name.Text
                   , teacher.Text, double.Parse(credit.Text), int.Parse(grade.Text), int.Parse(cancel.Text));

            }
            

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            //MessageBox.Show(command.CommandText);
        }

        //修改记录
        private void update_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }

            string sql = "update course set cid='{0}',cname='{1}',tname='{2}',credit={3},fit_year={4},cancle_year={5}";
            string where = " where cid='{0}'";

            MySqlCommand command = con.CreateCommand();
            try
            {
                //取消年份是否为空
                if(cancel.Text=="")
                {
                    command.CommandText =
                        string.Format(sql,course_id.Text, name.Text, teacher.Text, double.Parse(credit.Text), int.Parse(grade.Text), "null") +
                        string.Format(where, course_id.Text);


                }

                else
                {
                    command.CommandText =
                        string.Format(sql,course_id.Text, name.Text, teacher.Text, double.Parse(credit.Text), int.Parse(grade.Text), int.Parse(cancel.Text)) +
                        string.Format(where, course_id.Text);

                }
                

                command.ExecuteNonQuery();
                MessageBox.Show("更新成功！");
            }

            catch(Exception  exp)
            {
                MessageBox.Show(exp.Message);
            }
            //MessageBox.Show(command.CommandText);
        }

        //删除记录
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = string.Format("delete from course where cid='{0}'", course_id.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            catch(Exception  exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //显示查询结果表格
        private void showTable(string sql)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                this.dataGridView1.DataSource = table;

            }
            catch(Exception  exp)
            {
                MessageBox.Show(exp.Message);
            }
            

        }

        //查询记录
        private void select_Click(object sender, EventArgs e)
        {
            string sql = "select * from course";
            string where = "";

            //课程号和课程名组合查询
            if(s_cid.Text!="" && s_name.Text!="")
            {
                where = string.Format(" where cid='{0}' and cname='{1}'", s_cid.Text, s_name.Text);
                sql += where;
            }
            //课程号查询
            else if(s_cid.Text!="")
            {
                where = string.Format(" where cid='{0}'", s_cid.Text);
                sql += where;
            }
            //课程名查询
            else if(s_name.Text!="")
            {
                where = string.Format(" where cname='{0}'", s_name.Text);
                sql += where;
            }

            else if(s_cid.Text=="" && s_name.Text=="")
            {
                MessageBox.Show("请输入课程号或者课程名进行查询！");
                return;
            }

            //MessageBox.Show(sql);
            try
            {
                showTable(sql);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        
           
        }

        private void select_all_Click(object sender, EventArgs e)
        {
            string sql = "select * from course";
            try
            {
                showTable(sql);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void s_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                con.Close();
                Application.ExitThread();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void course_info_ResizeEnd(object sender, EventArgs e)
        {
            auto.controlAutoSize(this);
        }
    }
}
