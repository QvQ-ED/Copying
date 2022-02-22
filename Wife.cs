using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Wife
    {
        //数据成员
        private string name;

        private string sex;
        //字段
        private int age;

        //属性
        public String Name
        {
            set 
            {
                this.name = value;
            }

            get 
            {
                return this.name;
            }
        }

        public int Age
        {
            set
            {
                this.age = value;
            }

            get 
            {
                return age;
            }
        }

        //方法成员
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }
        public void A()
        {
            int [ ] a = new int[5];
        }

        public Wife(string name, int age)
       {
            this.name = name;
            this.age = age;
       }

      
    }
 

   
}
