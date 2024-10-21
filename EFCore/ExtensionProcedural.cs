namespace LinQTest
{
    public class ExtensionProcedural
    {
        public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();
            foreach (var employee in employees)
            {
                if (employee.FirstName.ToLowerInvariant().StartsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }
        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null) return;
            Console.WriteLine();
            Console.WriteLine("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
            Console.WriteLine($"|        {title.PadRight(32, ' ')}|");
            Console.WriteLine("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }

    }
}
