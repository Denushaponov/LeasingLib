using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DataBase
    {
        public List<Customer> Customers { get; set; }
        public List<LeasingPark> LeasingParks { get; set; }
        public List<Order> Orders { get; set; }
        public List<Car> Cars { get; set; }
    }



    public class LeasingPark
    {
        public string Location { get; set; }
        public List<Car> Cars { get; set; }
    }

    public class Order
    {
        public Guid Id = Guid.NewGuid();
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public bool IsActive { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime FulPaymentDate { get; set; }
    }

    public class Car
    {
        public Guid Id = Guid.NewGuid();
        public string Model { get; set; }
        public Price Price { get; set; }
        public string Location { get; set; }
        public string ReleaseYear { get; set; }
        public int Millage { get; set; }
        public bool IsAvailible { get; set; }
    }

    public class Customer:Person
    {
        
        public string Phone { get; set; }
        public string Location { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Person
    {
        public Guid Id = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Price
    {
        public int FullPrice { get; set; }
        public int FirstPayment { get; set; }
        public int MonthlyPayment { get; set; }
    }


}
