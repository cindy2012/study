using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DuckA da = new DuckA();
            da.SetFly(new FlyWithSwing());
            da.SetQuack(new Quack());
            da.Display();
            da.performFly();
            da.performQuack();
            da.Swim();
            
        }
    }
    /// <summary>
    /// 将功能相似但实现方式不同的行为抽象出来，放在单独的类中，通过算法类的组合组成一组行为
    /// </summary>
    
    interface Ifly
    {
        void Fly();
    }
    interface IQuack
    {
        void Quack();
    }
    ///定义专门的行为类
    class FlyWithSwing:Ifly
    {
        public void Fly()
        {
            Console.WriteLine("用翅膀飞");
        }        
    }
    class CannotFly : Ifly
    {
        public void Fly()
        {
            Console.WriteLine("不会飞");
        }
    }
    class Quack : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine("呱呱叫");
        }
    }

    class Zhi : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine("吱吱叫叫");
        }
    }
    class Yaba : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("不会叫");
        }
    }

    abstract class Duck
    {
        Ifly flybehavior;
        IQuack quackBehavior;
        public void Swim()
        {
            Console.WriteLine("我会游泳");
        }
        public abstract void Display();

        public void SetFly(Ifly flybehavior)
        {
            this.flybehavior = flybehavior;
        }

        public void SetQuack(IQuack quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
        public void performFly()
        {
            flybehavior.Fly();
        }

        /**
         * 呱呱叫行为
         */
        public void performQuack()
        {
            quackBehavior.Quack();
        }
    }

    class DuckA : Duck
    {
        public override void Display()
        {
            Console.WriteLine("鸭子A"); 
        }
    }
}
