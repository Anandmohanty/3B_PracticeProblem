using static _3B_PracticeProblem.TypeOfConstructor;

namespace _3B_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! To Practice Problem");

            TypeOfConstructor typeOfConstructor = new TypeOfConstructor();

            TypeOfConstructor parameterConstructor = new TypeOfConstructor("Mahesh", 30);

            TypeOfConstructor copyConstructor = new TypeOfConstructor(parameterConstructor);

            TypeOfConstructor.SampleMessage();

            //ExampleOfPrivetClass exampleOfPrivetClass = new ExampleOfPrivetClass(); // we can not create instance of this class due to Private Constructor
            ExampleOfPrivetClass.employeeName = "Gangurde";
            Console.WriteLine(ExampleOfPrivetClass.DisplayDetails());

            //Interface//
            BankManager bankManager = new BankManager();
            bankManager.GetBankDetails();
        }
    }
}