using CleanCodeWithDP.AbstractFactory;
using CleanCodeWithDP.Stragery;
using System;
using System.Collections.Generic;
using MySqlConnector;

namespace CleanCodeWithDP
{
    using CleanCodeWithDP.Flyweight;
    using IocWithNTier;
    using Proxy;
    using ProxyWithBank;
    using CompositePattern;
    using StrategyVer2;
    using CleanCodeWithDP.Decorator;
    using CleanCodeWithDP.State;
    using AbstractFactoryVer2;
    using Template;
    using TemplateVer2;
    using TemplateVer3;
    using Adapter;
    using ChainOfReposibility;

    class Program
    {
        private static AbstractPlatform configurationPlatform()
        {
            AbstractPlatform _platform;
            IGUIFactory _gUIFactory;
            string _osName = Environment.OSVersion.ToString();

            if (_osName.Contains("mac"))
            {
                _gUIFactory = new MacOSFactory();
                _platform = new AbstractPlatform(_gUIFactory);
            }
            else
            {
                _gUIFactory = new WindowsFactory();
                _platform = new AbstractPlatform(_gUIFactory);
            }
            return _platform;
        }
        private static MySqlConnection _sqlConnection;
        static void Main(string[] args)
        {
            AbstractPlatform _platform = configurationPlatform();
            _platform.Paint();
            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Stragery ===============================");
            var reports = new List<DeveloperReport>
        {
            new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
            new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
            new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
            new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
        };

            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");

            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");

            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== IoC ===============================");
            BussinessLogic _bussinessLogic = new BussinessLogic();
            _bussinessLogic.Task1();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Flyweight ===============================");

            // The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            factory.listFlyweights();

            addCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            addCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.listFlyweights();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Proxy ===============================");

            MathProxy _mathProxy = new MathProxy();
            Console.Write("Input num1 and num2: ");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {_mathProxy.Add(x, y)}");
            Console.WriteLine($"{x} - {y} = {_mathProxy.Sub(x, y)}");
            Console.WriteLine($"{x} * {y} = {_mathProxy.Mul(x, y)}");
            Console.WriteLine($"{x} / {y} = {_mathProxy.Div(x, y)}");

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== ProxyWithBank ===============================");

            Credit _credit = new Credit();
            bool Income = false;
            _credit.Cash(400, ref Income);

            Income = true;
            Console.WriteLine($"Income {_credit.Cash(5000000.0, ref Income)} vnd");

            Income = false;
            Console.WriteLine($"Outcome {_credit.Cash(100000.0, ref Income)} vnd");

            _credit.CheckAccount();

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------- Transfer ----------------------------------");
            Console.WriteLine("----------------------------------- Local -------------------------------------");
            Income = false;
            _credit.LocalTransfer(6000000.0, "VND", "01231111441", "8912121231", ref Income);

            Income = true;
            Console.WriteLine($" Income local: " +
                $"{_credit.LocalTransfer(700000.0, "VND", "719273981723", "1125412311", ref Income)}");
            _credit.CheckAccount();

            Income = false;
            Console.WriteLine($" Outcome local: " +
                $"{_credit.LocalTransfer(70000.0, "VND", "719273981723", "1125412311", ref Income)}");
            _credit.CheckAccount();
            Console.WriteLine("----------------------------------- Overcome ----------------------------------");
            Income = true;
            Console.WriteLine($"Income overcome: " +
                $"{_credit.OvercomeTransfer(500, "USD", "VND", "113311131", "719273981723", ref Income)} VND");
            _credit.CheckAccount();

            Income = false;
            Console.WriteLine($"Outcome overcome TWD: " +
                $"{_credit.OvercomeTransfer(5000000.0, "VND", "TWD", "719273981723", "115533315441", ref Income)} TWD");
            _credit.CheckAccount();

            Console.WriteLine("================================ CompositePattern =====================================");
            CompositePattern.IEmployee employee_0000 = new Cashier(0, "Thu Tran", 7000000);
            CompositePattern.IEmployee employee_0001 = new Cashier(1, "Khoi Nguyen", 7000000);
            CompositePattern.IEmployee employee_0010 = new BankManager(0, "Ning Chang", 9000000);

            employee_0010.Add(employee_0000);
            employee_0010.Add(employee_0001);
            employee_0010.Print();
            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Stragery - Ver2 ===============================");
            SortedList _studentRecords = new SortedList();
            _studentRecords.Add("Samual");
            _studentRecords.Add("Jimmy");
            _studentRecords.Add("Sandra");
            _studentRecords.Add("Vivek");
            _studentRecords.Add("Anna");
            Console.WriteLine("------------------------------------------------------------------------------------");
            _studentRecords.SetSortStrategy(new QuickSort());
            _studentRecords.Sort();
            Console.WriteLine("------------------------------------------------------------------------------------");
            _studentRecords.SetSortStrategy(new ShellSort());
            _studentRecords.Sort();
            Console.WriteLine("------------------------------------------------------------------------------------");
            _studentRecords.SetSortStrategy(new MergeSort());
            _studentRecords.Sort();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Decorator ===============================");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Book _book0000 = new Book("Worley", "Inside ASP.NET", 10);
            _book0000.Display();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Video _video0000 = new Video("Winifred Hervey", "Steve Harvey Show", 1, 512);
            _video0000.Display();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Borrowable _borrower0000 = new Borrowable(_book0000);
            _borrower0000.BorrowItem("Khoi Nguyen Tan");
            _borrower0000.BorrowItem("Ning Chang");
            Borrowable _borrower0001 = new Borrowable(_video0000);
            _borrower0001.BorrowItem("Thu Tran");
            _borrower0001.BorrowItem("Nguyen Lam Bao Ngoc");

            _borrower0000.Display();
            _borrower0001.Display();

            AlertStateContext stateContext = new AlertStateContext();
            stateContext.alert();
            stateContext.alert();
            stateContext.SetState(new Silent());
            stateContext.alert();
            stateContext.alert();
            stateContext.alert();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== AbstractFactoryVer2 ===============================");
            Console.WriteLine("-------------------------------------------------------------------------------");

            ///client class 
            AnimalWorld animalWorld = new AnimalWorld(new AmericaFactory());
            animalWorld.AnimalEatOthers();
            animalWorld = new AnimalWorld(new AfricaFactory());
            animalWorld.AnimalEatOthers();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Template ===============================");
            Console.WriteLine("-------------------------------------------------------------------------------");

            Game game = new Cricket();
            game.Play();
            game = new Football();
            game.Play();

            DataAccessObject dataAccessObject = new Categories();
            dataAccessObject.Run();
            dataAccessObject = new Products();
            dataAccessObject.Run();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Adapter ===============================");
            Console.WriteLine("-------------------------------------------------------------------------------");
            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXMLToJson();

            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== Template Ver 3 ===============================");
            Console.WriteLine("-------------------------------------------------------------------------------");

            DAO @object = new Person();
            @object.Connect();
            @object.GetAll();
            @object.Process();
            @object.Disconnect();


            Console.WriteLine("===========================================================================");
            Console.WriteLine("================================== ChainOfReposibility ===============================");
            Console.WriteLine("-------------------------------------------------------------------------------");
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
        }

        public static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nClient: Adding a car to database.");

            var flyweight = factory.GetFlyweight(new Car
            {
                Color = car.Color,
                Model = car.Model,
                Company = car.Company
            });

            // The client code either stores or calculates extrinsic state and
            // passes it to the flyweight's methods.
            flyweight.Operation(car);
        }

    }
}
