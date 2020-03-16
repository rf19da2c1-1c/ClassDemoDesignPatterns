using System;
using ClassDemoDesignPatterns.patterns.adaptor;
using ClassDemoDesignPatterns.patterns.facade;
using ClassDemoDesignPatterns.patterns.factory;
using ClassDemoDesignPatterns.patterns.proxy;
using ClassDemoDesignPatterns.patterns.singleton;

namespace ClassDemoDesignPatterns
{
    internal class DesignPatternWorker
    {
        public void Start()
        {
            //DemoFactoryMethod();

            //DemoSingleton();

            //DemoAbstractFactory();

            //DemoAdaptor();

            //DemoFacade();

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
            // se factory

        }

        private void DemoAdaptor()
        {
            IAdaptor adap = new Adaptor();

            string nystr = adap.Request("peter");
            Console.WriteLine(nystr);

            IAdaptor adap2 = new Adaptor2();
            string nystr2 = adap2.Request("peter");
            Console.WriteLine(nystr2);


        }

        private void DemoFacade()
        {
            Facade facade = new Facade();

            facade.NyNote("Husk at købe ind");
            facade.NytIndkøb("Gær");
            Console.WriteLine($"Du skal købe { string.Join("\n", facade.HvadSkalJegKøbe()) }");

        }

        private void DemoProxy()
        {
            IDemoProxy proxy = new RealProxy();

            proxy.IndsætString("Peter");
            proxy.IndsætString("Jakob");
            proxy.IndsætString("Vibeke");
            proxy.IndsætString("Mohammed");

            foreach (string s in proxy.Hent())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("    EFTER PROXY ");

            // SWC
            IDemoProxy proxy2 = new ProxyKlasse("SWC");

            proxy2.IndsætString("Peter");
            proxy2.IndsætString("Mohammed");

            foreach (string s in proxy2.Hent())
            {
                Console.WriteLine(s);
            }



        }
    }
}