using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class UserList//用户集合类
    {
        //字段 属性 构造函数 方法
        private User[] data = null;
        private int currentIndex;
        
        public int Count
        {
            get { return currentIndex; }


        }

        public UserList()
        {
            data = new User[8];//8个user对象
        }

        public UserList(int capacity)
        {//类的嵌套，看作是一个数据类型
            data = new User[capacity];
        }

        private void CheckCapacity()
        {
            //判断是否超出容量
            if (currentIndex >= data.Length)
            {
                User[] newData = new User[data.Length * 2];//扩容
                data.CopyTo(newData, 0);//拷贝
                data = newData;
            }
        }
        public void Add(User value)
        {
            CheckCapacity();
            data[currentIndex++] = value;
           
                //这里的value不是数值，相当于一个user类型的对象，回归传参最基础的用法
            }
        }

        public User GetElement(int index)
        {
            return this.data[index];
        }

    }
}
