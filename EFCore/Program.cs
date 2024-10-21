
namespace LinQTest
{
    internal class Program
    {

        static void Main(string[] args)
        {
            RunExtensionFunction01();
        }
        //old methods 
        private static void RunExtensionProcedural()
        {
            var q1 = ExtensionProcedural.GetEmployeesWithFirstNameStartsWith("Hamada");
            ExtensionProcedural.Print(q1, "Employss with first name starts with mo");
        }
        // modern methods 
        private static void RunExtensionFunction01()
        {
            var list = Repository.LoadEmployees();
            var q = list.Filter(e => e.FirstName.ToLowerInvariant() == "mohammed");
            q.Print("Employss with first name mohammed");
            Console.WriteLine("**************************");
            var q1 = list.Filter(e => e.LastName.StartsWith("ha", StringComparison.OrdinalIgnoreCase));
            q1.Print("Employyees with last Name starts With ha");

            Console.WriteLine("**************************");
            var q3 = list.Filter(e => e.Department == "CS");
            q3.Print("Employees with Dep CS ");
            Console.WriteLine("**************************");
            var q4 = list.Filter(e => e.HasHealthInsurance);
            q4.Print(" With health insurance");
        }
    }
}