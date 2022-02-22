using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class User
    {
        //字段

       public string loginId;

        //属性
        public string LoginId
        {
            get 
            { return this.loginId; }
            set 
            { this.loginId = value; }
        }

        public string password;
        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        //构造函数

        public User()
        {
            
        }

        public User(string loginId, string pwd)
        {
            this.loginId = loginId;
            this.password = pwd;
        }

        //方法
       public void PrintUser()
        {
            Console.WriteLine("账号：{0} 密码：{}", loginId, password);
        }
    }
}
