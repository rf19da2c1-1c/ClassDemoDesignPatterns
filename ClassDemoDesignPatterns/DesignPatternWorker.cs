using System;
using ClassDemoDesignPatterns.patterns.factory;
using ClassDemoDesignPatterns.patterns.singleton;

namespace ClassDemoDesignPatterns
{
    internal class DesignPatternWorker
    {
        public void Start()
        {
            DemoFactoryMethod();

            //DemoSingleton();

            DemoAbstractFactory();

            DemoAdaptor();

            DemoFacade();

            DemoProxy();
        }

        private void DemoFactoryMethod()
        {
            AbstractDemoFactory facDK = DemoFactoryGenerator.GetFactory(true);

            IDemoFactory obj = facDK.GetClass("polite");
            obj.Print("peter");

            obj = facDK.GetClass("friendly");
            obj.Print("peter");


            // på engelsk
            AbstractDemoFactory facUk = DemoFactoryGenerator.GetFactory(false);
            IDemoFactory objUk = facUk.GetClass("polite");
            objUk.Print("peter");
        }

        private void DemoSingleton()
        {
            NoteKatalog k1 = NoteKatalog.Instans;
            k1.Add("Ny note");
            Console.WriteLine(k1);

            NoteKatalog k2 =  NoteKatalog.Instans;
            k2.Add("endnu note");
            Console.WriteLine(k2);

        }

        private void DemoAbstractFactory()
        {
            

        }

        private void DemoAdaptor()
        {
            

        }

        private void DemoFacade()
        {
            

        }

        private void DemoProxy()
        {
            

        }
    }
}