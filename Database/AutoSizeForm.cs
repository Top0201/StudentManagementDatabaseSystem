using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Database
{
    //管理控件布局的类
    class AutoSizeForm
    {
        //控件的初始位置信息
        public struct controlLoc
        {
            public int left;
            public int top;
            public int width;
            public int height;
            public float font_s;
        }

        //存储控件名及其位置的字典
        public Dictionary<String, controlLoc> oldControl = new Dictionary<string, controlLoc>();
        //控件号
        int con_num = 0;

        //记录窗体和其控件的初始位置和大小
        public void controlInitial(Control control)
        {
            //声明控件位置结构体变量
            controlLoc loc;
            loc.left = control.Left;
            loc.top = control.Top;
            loc.height = control.Height;
            loc.width = control.Width;
            loc.font_s = control.Font.Size;

            //将控件插入字典中
            insertDictionary(control.Name, loc);

            //窗体内其余控件可能又嵌套控件，递归调用
            addControl(control);
        }
        
        //添加控件到字典中
        private void insertDictionary(String name,controlLoc loc)
        {
            Dictionary<String, controlLoc> temp = new Dictionary<string, controlLoc>();
            bool flag = false;

            //遍历,将重复名控件标记
            foreach(var pair in oldControl)
            {
                if(pair.Key.ToString()==name)
                {
                    temp.Add(name, loc);
                    flag = true;
                }
            }

            //当没有重复控件时，直接添加控件
            if(flag==false)
            {
                oldControl.Add(name, loc);
            }

            //遍历temp数组，将重复控件在old字典中更新
            foreach(var value in temp)
            {
                oldControl.Remove(value.Key.ToString());
                oldControl.Add(value.Key, value.Value);
            }

            //释放temp字典
            temp.Clear();
        }
        public void addControl(Control con)

        {
            controlLoc loc0;
            loc0.left = con.Left;
            loc0.top = con.Top;
            loc0.width = con.Width;
            loc0.height = con.Height;
            loc0.font_s = con.Font.Size;
            insertDictionary(con.Name, loc0);

            //对传进参数的控件进行循环检查，遍历其嵌套控件
            foreach (Control c in con.Controls)
            {
                controlLoc loc;
                loc.left = c.Left;
                loc.top = c.Top;
                loc.width = c.Width;
                loc.height = c.Height;
                loc.font_s = c.Font.Size;

                //插入字典中
                insertDictionary(c.Name, loc);

                //若con中子控件还有嵌套控件，递归调用
                if(c.Controls.Count>0)
                {
                    addControl(c);
                }
            }
        }

        //控件自适应大小方法
        public void controlAutoSize(Control con)
        {
            //?
            if (con_num == 0)
            {
                addControl(con);
            }

            //得到当前缩放比例
            float ws = (float)con.Width / oldControl[con.Name].width;
            float hs = (float)con.Height / oldControl[con.Name].height;

            con_num = 1;//0位窗体本身，窗体中控件从1开始
            autoScaleControl(con, ws, hs);

        }

        //控件自动缩放大小，在controlAutoSize中调用，将方法封装
        private void autoScaleControl(Control con, float ws, float hs)
        {
            int con_l, con_t, con_w, con_h;

            //遍历con的子空间
            foreach(Control c in con.Controls)
            {
                con_l = oldControl[c.Name].left;
                con_t = oldControl[c.Name].top;
                con_w = oldControl[c.Name].width;
                con_h = oldControl[c.Name].height;

                //得到当前调整后的控件大小
                c.Left = (int)(con_l * ws);
                c.Top = (int)(con_t * hs);
                c.Width = (int)(con_w * ws);
                c.Height = (int)(con_h * hs);

                //调整控件字体,font.size是只读的，必须重新new控件的字体对象实例
                c.Font = new Font(c.Font.FontFamily, oldControl[c.Name].font_s * ws);
                //累加序号
                con_num++;

                //递归改变控件的子控件的大小
                if(c.Controls.Count>0)
                {
                    autoScaleControl(c, ws, hs);
                }
            
            }

            //缩放该控件本身
            con_l = oldControl[con.Name].left;
            con_t = oldControl[con.Name].top;
            con_w = oldControl[con.Name].width;
            con_h = oldControl[con.Name].height;

            con.Left = (int)(con_l * ws);
            con.Top = (int)(con_t * hs);
            con.Width = (int)(con_w * ws);
            con.Height = (int)(con_h * hs);

        }

    }
}
