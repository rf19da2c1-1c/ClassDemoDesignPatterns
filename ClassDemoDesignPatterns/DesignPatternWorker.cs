using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using ClassDemoDesignPatterns.patterns.adaptor;
using ClassDemoDesignPatterns.patterns.decorator;
using ClassDemoDesignPatterns.patterns.facade;
using ClassDemoDesignPatterns.patterns.factory;
using ClassDemoDesignPatterns.patterns.observer;
using ClassDemoDesignPatterns.patterns.proxy;
using ClassDemoDesignPatterns.patterns.singleton;
using ClassDemoDesignPatterns.patterns.strategy;
using ClassDemoDesignPatterns.patterns.template;
using IComponent = ClassDemoDesignPatterns.patterns.decorator.IComponent;

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

            //DemoProxy();

            //DemoDecorator();

            //DemoObserver();

            //DemoTemplate();

            DemoStrategy();


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


        private void DemoDecorator()
        {
            // konkrete
            IComponent component = new ConcreteComponent();
            Console.WriteLine(component.DoSomething("peter"));

            // decorerer med Hr
            IComponent comp2 = new DecoratorKlasse(component);
            Console.WriteLine(comp2.DoSomething("peter"));


            // Decorerer med Levinsky
            IComponent comp3a = new DecoratorKlasse2(component);
            Console.WriteLine(comp3a.DoSomething("peter"));

            IComponent comp3b = new DecoratorKlasse2(comp2);
            Console.WriteLine(comp3b.DoSomething("peter"));


        }

        private void DemoObserver()
        {
            // I am observer
            ObservableObject obj = new ObservableObject(3,"text");
            obj.Text = "Peter";

            obj.PropertyChanged += (s, args) =>
            {
                Console.WriteLine($"the changed property is {args.PropertyName}");
                Console.WriteLine($"New values is \n{s}");
            };

            // alternativ
            //obj.PropertyChanged += Update;

            obj.Text = "Jakob";
        }

        protected void Update(object obj, PropertyChangedEventArgs args)
        {
            Console.WriteLine($"the changed property is {args.PropertyName}");
            Console.WriteLine($"New values is \n{obj}");
        }

        private void DemoTemplate()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Jakob",
                "Vibeke",
                "Mohammed"
            };

            AbstractTemplateClass obj = new SubTemplate1();
            obj.InsertTemplateMethod(data);
            Console.WriteLine("Template ::");
            Console.WriteLine(obj);

            AbstractTemplateClass obj2 = new SubTemplate2();
            obj2.InsertTemplateMethod(data);
            Console.WriteLine("Template ::");
            Console.WriteLine(obj2);

        }
        private void DemoStrategy()
        {
            List<String> data = new List<string>()
            {
                "peter",
                "jakob",
                "vibeke",
                "mohammed"
            };

            // close to Pattern
            ContextClass context1 = new ContextClass();
            context1.InsertStrategyMethod(data, new StrategyClass());
            Console.WriteLine("Strategy #1 ::");
            Console.WriteLine(context1);

            
            // Close to the C# way of doing
            ContextClassMoreCSharpLike context2 = new ContextClassMoreCSharpLike();
            context2.StrategyMethod = (s) => { return "hej " + s.ToUpper(); };
            context2.InsertStrategyMethod(data);
            Console.WriteLine("Strategy #2 ::");
            Console.WriteLine(context2);
            
        }
    }
}