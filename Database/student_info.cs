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

namespace Database
{
    public partial class student_info : Form
    {
        MySqlConnection con;
        user_page page;
        AutoSizeForm auto;
        public student_info(MySqlConnection con)
        {
            this.con = con;
            auto = new AutoSizeForm();
            InitializeComponent();
        }

        //关闭窗口事件
        private void windowClose(object sender, EventArgs e)
        {

        }


        //点击返回按钮
        private void return1_Click(object sender, EventArgs e)
        {
            page = new user_page(con);
            this.Hide();
            page.ShowDialog();
        }

        private void student_info_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        //查询表格在dataGridView中显示
        private DataTable getMessage(string sql)
        {
            try
            {
                MySqlDataAdapter adapter= new MySqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                this.dataGridView1.DataSource = table;
                return table;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return null;
            

        }

        //点击查询按钮事件处理
        private void select_Click(object sender, EventArgs e)
        {

            string sql = "select * from students";
            string where = "";
           
            //学号和姓名组合查询
            if (s_name.Text.ToString() != "" && s_number.Text.ToString() != "")
            {
                where = string.Format(" where sid='{0}'", s_number.Text) +
                    string.Format(" and sname='{0}'", s_name.Text);
                sql += where;
            }
            //使用学号查询
            else if (s_number.Text.ToString() != "")
            {
                where = string.Format(" where sid='{0}'", s_number.Text);
                sql += where;
            }
            //使用姓名查询
            else if (s_name.Text.ToString() != "")
            {
                where = string.Format(" where sname='{0}'", s_name.Text);
                sql += where;
            }
            else
            {
                MessageBox.Show("请输入学号或姓名进行信息查询！");
                return;
            }

            //显示查询信息
            getMessage(sql);
            
        }

        //点击修改按钮
        private void update_Click(object sender, EventArgs e)
        {
            //检查输入信息合法性
            if(!validate())
            {
                return;
            }
            //更新语句
            string sql = "update students set class_id={0}," +
                "sid='{1}',sname='{2}',sex='{3}',age={4},grade={5}";
            MySqlCommand command = con.CreateCommand();
            command.CommandText =
                string.Format(sql, int.Parse(class_id.Text), number.Text, name.Text, sex.Text,
                int.Parse(age.Text), int.Parse(grade.Text)) + string.Format(" where sid='{0}'", number.Text);

            try
            {
               
                command.ExecuteNonQuery();
                MessageBox.Show("更新成功！");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //检查信息是否合法函数
        private bool validate()
        {
            //检查学号
            if (number.Text.ToString().Length != 10)
            {
                MessageBox.Show("请输入正确格式的学号！如3017218000");
                return false;
            }
            int temp = 0;
            Boolean convert = int.TryParse(age.Text.ToString(), out temp);
            //检查年龄
            if(convert==false || temp<10 || temp>50)
            {
                MessageBox.Show("请输入正确的年龄范围！10--50之间");
                return false;
            }

            return true;


        }

        //点击添加记录按钮
        private void add_Click(object sender, EventArgs e)
        {
            //检查信息合法性
            if (!validate())
            {
                return;
            }

            //执行操作
            MySqlCommand command = con.CreateCommand();
            command.CommandText =
                string.Format("insert into students values({0},'{1}','{2}','{3}',{4},{5})",
                int.Parse(class_id.Text), number.Text, name.Text, sex.Text, int.Parse(age.Text), int.Parse(grade.Text));

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //查找全部信息
        private void select_all_Click(object sender, EventArgs e)
        {
            string sql = "select * from students";
            getMessage(sql);
        }

        //删除信息
        private void delete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = con.CreateCommand();
            command.CommandText = string.Format("delete from students where sid='{0}'", number.Text);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //关闭窗口事件
        private void student_info_FormClosed(object sender, FormClosedEventArgs e)
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

        //窗体缩放控件自适应改变大小
        private void student_info_ResizeEnd(object sender, EventArgs e)
        {
            auto.controlAutoSize(this);
        }
    }
}
        



