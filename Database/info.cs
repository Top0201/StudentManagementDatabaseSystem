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
    public partial class info : Form
    {
        //数据库连接
        MySqlConnection con;
        //主页面
        user_page page;
        //控件缩放类
        AutoSizeForm auto = new AutoSizeForm();
        

        public info(MySqlConnection con)
        {
            this.con = con;
           
            InitializeComponent();
        }

        //窗体加载时初始化添加控件
        private void info_Load(object sender, EventArgs e)
        {
            auto.controlInitial(this);
        }

        //窗体变化时绑定事件
        private void resize(object sender,EventArgs e)
        {
            auto.controlAutoSize(this);
        }

        private void windowClose(object sender,EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //检查学生选课合法性
        private bool TrueYear(string s_id,string c_id)
        {
            string sql1 = "select grade from students " + string.Format("where sid='{0}'", s_id);
            string sql2 = "select fit_year,cancle_year from course " +
                string.Format("where cid='{0}'", c_id);
                
            MySqlCommand command;
            MySqlDataReader reader;
            string grade = "";
            string fit_year = "";
            string cancle_year = "";

            try
            {
                command = new MySqlCommand(sql1, con);
                reader = command.ExecuteReader();
                if(reader.Read())
                {
                    grade = reader["grade"].ToString();
                
                }
                reader.Close();

                command = new MySqlCommand(sql2, con);
                reader = command.ExecuteReader();
                if(reader.Read())
                {
                    fit_year = reader["fit_year"].ToString();
                    cancle_year = reader["cancle_year"].ToString();

                }
                
                reader.Close();
                

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            
            //选课年份>课程取消年份且课程适合年级要相互对应
            if(grade.CompareTo(fit_year)==0 || grade.CompareTo(fit_year)>0)
            {
                if(cancle_year=="")
                {
                    return true;
                }

                else if(int.Parse(choose_year.Text)<int.Parse(cancle_year))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;

            
        }

        
        //检查信息输入合法性
        private bool validate()
        {
            if(sid.Text.ToString().Length!=10)
            {
                MessageBox.Show("请输入正确格式的学号！如3017218000");
                return false;
            }
            if(cid.Text.ToString().Length!=7)
            {
                MessageBox.Show("请输入正确格式的课程号！如2017000");
                return false;
            }
            if(TrueYear(sid.Text.ToString(),cid.Text.ToString())==false)
            {
                MessageBox.Show("请确认选课年级是否匹配和课程是否已取消！");
                return false;
            }

            double temp;
            bool istrue = double.TryParse(mark.Text, out temp);
            if(istrue==false)
            {
                MessageBox.Show("请输入成绩的正确类型！");
                return false;
            }

            return true;
            
        }
        
        //添加记录
        private void add_Click(object sender, EventArgs e)
        {
            if(validate()==false)
            {
                return;
            }

            string sql = "insert into info values('{0}','{1}',{2},{3})";
            
            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = string.Format(sql, sid.Text, cid.Text, int.Parse(choose_year.Text), double.Parse(mark.Text));
                command.ExecuteNonQuery();


                //MessageBox.Show(command.CommandText);
                MessageBox.Show("添加成功！");
                
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void return_main_Click(object sender, EventArgs e)
        {
            page = new user_page(con);
            this.Hide();
            page.ShowDialog();
        }
        //修改记录
        private void update_Click(object sender, EventArgs e)
        {
            if(validate()==false)
            {
                return;
            }

            string sql = "update info set sid='{0}',cid='{1}',choose_year={2},mark={3}";
            string where = " where sid='{0}' and cid='{1}' and choose_year={2}";

            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = string.Format(sql, sid.Text, cid.Text, int.Parse(choose_year.Text), double.Parse(mark.Text)) 
                    + string.Format(where, sid.Text,cid.Text,int.Parse(choose_year.Text));

                command.ExecuteNonQuery();
                //MessageBox.Show(command.CommandText);
                MessageBox.Show("修改成功！");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        //删除记录
        private void delete_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }
            string sql = "delete from info where sid='{0}' and cid='{1}' and choose_year={2}";

            try
            {
                MySqlCommand command = con.CreateCommand();
                command.CommandText = string.Format(sql, sid.Text, cid.Text,int.Parse(choose_year.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("删除成功!");
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void getTable(string sql)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        


        private void select_all_Click(object sender, EventArgs e)
        {
            string sql = "select * from info";
            try
            {
                getTable(sql);
                
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        //查询记录
        private void select_Click(object sender, EventArgs e)
        {
            string sql = "select * from info";
            string where = "";
            if (s_sid.Text != "" && s_cid.Text != "")
            {
                where = string.Format(" where sid='{0}' and cid='{1}'", s_sid.Text, s_cid.Text);

            }

            else if (s_sname.Text != "" && s_cname.Text != "")
            {
                string temp = " where sid in(select students.sid from students where sname='{0}') " +
                    "and cid in(select cid from course where cname='{1}')";
                where = string.Format(temp, s_sname.Text, s_cname.Text);
            }

            else if(s_sid.Text!="")
            {
                where = string.Format(" where sid='{0}'", s_cid.Text);
            }

            else if(s_cid.Text!="")
            {
                where = string.Format(" where cid='{0}'", s_cid.Text);
            }
            

            else if(s_cid.Text=="" && s_sid.Text=="" && s_cname.Text=="" && s_sname.Text=="")
            {
                MessageBox.Show("请输入指定信息进行查询！");
                return;
                
            }
            try
            {
                string command = sql + where;
                //MessageBox.Show(command);
                getTable(command);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        //计算加权平均成绩
        private void average_mark_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select i.sid,s.sname,round(sum(i.mark*c.credit)/sum(c.credit),2) as average_mark ";
            string condition = "from info i, course c,students s " +
                "where i.cid=c.cid and i.sid=s.sid " + "group by i.sid order by i.sid";

            string temp = sql + condition;
            //MessageBox.Show(temp);
            try
            {
                getTable(temp);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
                
        }


        //计算每个课程的平均成绩
        private void cou_average_mark_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select i.cid as cid,c.cname as name,round(sum(mark)/count(*),2) as course_average_mark ";
            string condition = "from info i,course c where i.cid=c.cid " +
                "group by i.cid order by i.cid";

            string temp = sql + condition;
            //MessageBox.Show(temp);
            try
            {
                getTable(temp);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        //班级的科目平均分?
        private void c_average_mark_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select s.class_id,i.cid,c.cname,round(sum(i.mark)/count(*),2) as course_average_mark ";
            string condition = "from students s, course c,info i " +
                "where s.sid=i.sid and c.cid=i.cid " + "group by s.class_id,i.cid order by s.class_id,i.cid";

            string temp = sql + condition;

            //MessageBox.Show(temp);

            try
            {
                getTable(temp);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }

        //每个课程的成绩分布
        private void cou_mark_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "select i.cid,c.cname,sum(case when mark<60 then 1 else 0 end) as failed," +
                "sum(case when mark>=60 and mark<=69 then 1 else 0 end) as '60-69'," +
                "sum(case when mark>=70 and mark<=79 then 1 else 0 end) as '70-79'," +
                "sum(case when mark>=80 and mark<=89 then 1 else 0 end) as '80-89'," +
                "sum(case when mark>=90 and mark<=99 then 1 else 0 end) as '90-99'," +
                "sum(case when mark=100 then 1 else 0 end) as 100_excellent";
            string condition = " from info i,course c where i.cid=c.cid" +
                " group by i.cid order by i.cid";

            string temp = sql + condition;

            try
            {
                getTable(temp);
                //MessageBox.Show(temp);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }

        private void info_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
