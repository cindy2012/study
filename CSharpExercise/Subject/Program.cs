using System;
using System.Collections;
using System.Collections.Generic;

namespace Subject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WeatherData WD = new WeatherData();
            ObserverA A = new ObserverA(WD);
            ObserverB B = new ObserverB(WD);
            WD.NotifyObserve();
        }

        public interface SubjectBase
        {
            void RegisterObserve(ObserveBase ob);
            void RemoveObserve(ObserveBase ob);
            void NotifyObserve();
        }

        public interface ObserveBase
        {
            void Update();
        }

        public class WeatherData : SubjectBase
        {
            private IList<ObserveBase> observeList =new List<ObserveBase>();
            public void NotifyObserve()
            {
                foreach (var item in observeList)
                    item.Update();
            }

            public void RegisterObserve(ObserveBase ob)
            {
                this.observeList.Add(ob);
            }

            public void RemoveObserve(ObserveBase ob)
            {
                this.observeList.Remove(ob);
            }
        }

        public class ObserverA : ObserveBase
        {
            SubjectBase s;
            public ObserverA(SubjectBase ss)
            {
                this.s = ss;
                s.RegisterObserve(this);
            }
            public void Update()
            {
                Console.WriteLine("ObserverA 已更新");
            }
        }

        public class ObserverB : ObserveBase
        {
            SubjectBase s;
            public ObserverB(SubjectBase ss)
            {
                this.s = ss;
                s.RegisterObserve(this);
            }
            public void Update()
            {
                Console.WriteLine("Observerb 已更新");
            }
        }
    }
}
