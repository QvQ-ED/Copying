using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class UserList
    {
       public User[] data = null;

        public UserList() 
        {
            data = new User[8];//8个user对象
        }

        public UserList(int capacity)
        {//类的嵌套，看作是一个数据类型
            data = new User[capacity];
        }

        public void Add(User value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i].loginId = value.loginId;
                data[i].password = value.password;
                //这里的value不是数值，相当于一个user类型的对象，回归传参最基础的用法
            }
        }

        public User GetElement(int index)
        {
            return data[index];
        }

    }
}
