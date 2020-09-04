using System;

namespace ChainofReposibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Client ha = new Client(5);
            Employee employee = new Employee();
            TeamLead teamLead = new TeamLead();
            Manager manager = new Manager();
            CEO ceo = new CEO();
            employee.SetNext(teamLead).SetNext(manager).SetNext(ceo);
           var result= ha.CreateRequest(employee);
            Console.WriteLine(result);
            Console.ReadKey();
           
        }
    }
}
