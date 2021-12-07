using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DarkRoast dr = new DarkRoast("审配咖啡");
            ConcreteDecoratorA ca = new ConcreteDecoratorA(dr);
            ConcreteDecoratorB cb = new ConcreteDecoratorB(ca);
            Console.WriteLine("购买产品：" + cb.GetDescription());
            Console.WriteLine("一共消费："+cb.Cost()); 
        }

        /// <summary>
        /// 所有组件基类
        /// </summary>
        abstract class BaseComponent
        {
            protected string Description;
          
            public BaseComponent()
            { }
            public abstract string GetDescription();
           
            public abstract float Cost();
        }

        /// <summary>
        /// 装饰者基类
        /// </summary>
        abstract class BaseDecorator:BaseComponent
        {
            
        }

        class ConcreteDecoratorA : BaseDecorator
        {
            BaseComponent component;
            public ConcreteDecoratorA(BaseComponent component)
            {
                this.component = component;
            }
            public override string GetDescription()
            {
                return component.GetDescription() + " : ConcreteDecoratorA";
            }
            public override float Cost()
            {
                return component.Cost() + 2f;
            }
        }
        class ConcreteDecoratorB:BaseDecorator
        {
            BaseComponent component;
            public ConcreteDecoratorB(BaseComponent component)
            {
                this.component = component;
            }
            public override string GetDescription()
            {
                return component.GetDescription() + " : ConcreteDecoratorB";
            }
            public override float Cost()
            {
                return component.Cost() + 0.9f;
            }
        }

        class DarkRoast : BaseComponent//被装饰的类
        { 
            public DarkRoast(string des)
           {
                this.Description = des;
                
            }
            public override string GetDescription()
            {
                return this.Description ;
            }
            public override float Cost()
            {
                return 3f;
            }
        }
    }
}
