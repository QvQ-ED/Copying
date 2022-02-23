using System;

namespace _1
{
    class Program
    {
        static void Fun2(ref int[] a)
        {
            a = new int []{ 2 };
        }

        private static Wife GetWifeByMinimumAge(Wife[] wives)
        {
            Wife minWife = wives[0];
            for (int i = 1; i < wives.Length; i++)
            {//wife类的一维数组
                if (minWife.Age > wives[i].Age)
                {
                    minWife = wives[i];
                }
            }
            return minWife;//返回索引
        }

        static void Main1(string[] args)
        {
            int[] a2 = new int[] { 1 };
            Fun2(ref a2);
            Console.WriteLine(a2[0]);

            Wife[] wifeArray = new Wife[5] ;

            wifeArray[0] = new Wife("01", 1);
            wifeArray[1] = new Wife("02", 2);
            wifeArray[2] = new Wife("03", 3);
            wifeArray[3] = new Wife("04", 4);
            wifeArray[4] = new Wife("05", 5);

            Wife min = GetWifeByMinimumAge(wifeArray);
            //练习1 查找age最小的wife （返回wife对象）
        }

        //综合练习1
        private static void Main()
        {
            User user01 = new User();
            //数组初始化必须指定大小
            //User[] userArray = new User[?];
            //读写元素 必须通过 索引
            //userArray[?]=user01;

            //需求
            UserList list = new UserList(3);
            User u1 = new User("1", "1");
            User u2 = new User("2", "2");
            User u3 = new User("3", "3");

            list.Add(u1);
            list.Add(u2);
            list.Add(u3);

            for (int i = 0; i < list.Count; i++)
            {
                User user = list.GetElement(i);
                user.PrintUser();
            }
        }

    }
}
