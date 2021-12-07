using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class A 
    {
        protected int x;//访问仅限于此类或派生自此类的类。
        private protected int y;//访问仅限此类或当前程序集的此类的派生类
        protected internal int z;//访问仅限此类、从此类中派生的类，或者其他程序集中的此类的派生类。
        internal int h;//访问仅限当前程序集
        void t()
        {
            x = 1;
            y = 9;
            z = 0;
        }
    }
    public class B:A
    {
        private int m;

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        

        void tmain()
        {
            A a = new A();
            a.h = 1;
            a.z = 9;
            B bb = new B();
            bb.x = 1;
            bb.y = 7;
            bb.z = 8;
            
        }
    }

   
    public class C:A
    {
        static int k;
        int j;
        public C()
        {
            x = 2;
            y = 1;
            z = 1;
        }
        void TEST()
        {
            A a = new A();
            B b = new B();
            C c = new C();
            y = 2;
            c.x = 1;//只有A的派生类C可以访问到成员a，由于在类C中，实例b无法访问成员a
            //a.a; 被protect修饰符修饰的成员只能在其派生类的内部访问
            
        }
        static void TMian()
        {
            k = 2;
           //静态方法只能访问静态成员，无法访问实例成员y   ,实例方法可以访问static修饰的成员和实例成员 
        }
    }
}
