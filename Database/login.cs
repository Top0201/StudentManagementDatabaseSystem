using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Database
{

    public partial class login : Form
    {
        public MySqlConnection Con { get; set; }
        user_page page;

        AutoSizeForm auto;
        public login()
        {
            InitializeComponent();
            auto = new AutoSizeForm();
        }

        //界面加载连接数据库
        private void login_Load(object sender, EventArgs e)
        {
            auto.controlInitial(this);

            string s = "server=localhost;user=root;password=17113255qkl;" +
                "database=course_select_system;sslMode=none;";
            Con = new MySqlConnection(s);
            try
            {
                Con.Open();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        //private void windowClose(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Con.Close();
        //        Application.ExitThread();
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show(exp.Message);
        //    }
        //}

        //点击登陆时事件处理  
        private void yes_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader reader;
            bool flag = false;
            
            try
            { 
                //MessageBox.Show("success");
                string select = "select username,password from users";

                //从数据库中打开users表格
                command = new MySqlCommand(select, Con);

                //得到查询结果，
                reader = command.ExecuteReader();

                //read()方法每次读取一行，循环遍历数据表
                while(reader.Read())
                {
                    string user = reader["username"].ToString();
                    string pwd = reader["password"].ToString();
                    if(username.Text.ToString()==user.Trim() && password.Text.ToString()==pwd.Trim())
                    {
                                                                    
                        flag = true;
                          
                    }
                    
                }
                if(flag)
                {
                    //关闭数据表读取操作
                    reader.Close();
                    //新窗体实例化
                    page = new user_page(Con);

                    //当前窗体隐藏
                    this.Hide();
                    page.ShowDialog();
                }
                else
                {
                    MessageBox.Show("用户名或密码输入错误！");
                    reader.Close();
                    //清空控件内容
                    username.Clear();
                    password.Clear();
                    //设置该控件为光标焦点
                    username.Focus();
                }
                                    
            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        //点击登陆时事件处理
        private void register_Click(object sender, EventArgs e)
        {
            
            try

            {
                if(username.Text!="" && password.Text!="")
                {
                    MySqlCommand command = Con.CreateCommand();
                    command.CommandText = string.Format("insert into users values('{0}','{1}')", username.Text, password.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("注册成功！");

                    page = new user_page(Con);
                    this.Hide();
                    page.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请输入用户名和密码！");
                }
                
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        //点击取消时清空文本框输入信息
        private void no_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
        }

        //点击退出按钮退出程序
        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出学生选课管理系统！");
            try
            {
                Con.Close();
                Application.ExitThread();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //关闭窗口时断开数据库连接
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Con.Close();
                Application.ExitThread();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //窗口缩放控件自适应
        private void login_ResizeEnd(object sender, EventArgs e)
        {
            auto.controlAutoSize(this);
        }
    }
}
