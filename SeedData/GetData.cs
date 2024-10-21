using SeedData.Models;

namespace SeedData
{
    public static class GetData
    {
        static void Main(string[] args)
        {
            GetCustomers();
            GetCategories();
        }
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 101, Name = "ahmed mohmed", Age = 30, IsActive = true, JoinDate = new DateTime(2022, 10, 15), CategoryId = 1, SpendAverage = 1500.9m, Telephone = 123456789 });
            customers.Add(new Customer { Id = 102, Name = "salah ahmed", Age = 32, IsActive = false, JoinDate = new DateTime(2023, 1, 3), CategoryId = 1, SpendAverage = 2500.9m, Telephone = 987654321 });
            customers.Add(new Customer { Id = 103, Name = "mahoude samy", Age = 22, IsActive = true, JoinDate = new DateTime(2023, 5, 17), CategoryId = 2, SpendAverage = 3000.0m, Telephone = 741852963 });
            customers.Add(new Customer { Id = 104, Name = "mostafa kamel", Age = 27, IsActive = true, JoinDate = new DateTime(2022, 8, 30), CategoryId = 1, SpendAverage = 4500.11m, Telephone = 369852147 });
            customers.Add(new Customer { Id = 105, Name = "seed nabil", Age = 48, IsActive = true, JoinDate = new DateTime(2023, 2, 27), CategoryId = 1, SpendAverage = 2000.0m, Telephone = 102365214 });
            customers.Add(new Customer { Id = 106, Name = "fareed sif", Age = 18, IsActive = true, JoinDate = new DateTime(2022, 11, 8), CategoryId = 1, SpendAverage = 8110.9m, Telephone = 14256363 });
            customers.Add(new Customer { Id = 107, Name = "abdelrahman", Age = 31, IsActive = false, JoinDate = new DateTime(2022, 12, 24), CategoryId = 1, SpendAverage = 1900.0m, Telephone = 259874689 });
            customers.Add(new Customer { Id = 108, Name = "sayed kabaka", Age = 39, IsActive = true, JoinDate = new DateTime(2023, 4, 8), CategoryId = 2, SpendAverage = 1800.4m, Telephone = 123698789 });
            customers.Add(new Customer { Id = 109, Name = "nora hazem", Age = 25, IsActive = false, JoinDate = new DateTime(2023, 10, 31), CategoryId = 1, SpendAverage = 1250.6m, Telephone = 121111189 });
            customers.Add(new Customer { Id = 110, Name = "samy tony", Age = 29, IsActive = true, JoinDate = new DateTime(2023, 8, 18), CategoryId = 1, SpendAverage = 1854.9m, Telephone = 122222289 });
            customers.Add(new Customer { Id = 111, Name = "ahmed galal", Age = 37, IsActive = true, JoinDate = new DateTime(2023, 7, 12), CategoryId = 2, SpendAverage = 9632.2m, Telephone = 123333339 });
            return customers;
        }
        public static List<CustomerCategory> GetCategories()
        {
            List<CustomerCategory> categories = new List<CustomerCategory>();
            categories.Add(new CustomerCategory() { Id = 1, Name = "normal" });
            categories.Add(new CustomerCategory() { Id = 2, Name = "VIP" });
            return categories;
        }

    }
}