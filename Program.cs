public class Employee
{
    public int ID {get;set;}
    public string Name {get;set;}
    public string LastName {get;set;}
    public string RFC {get;set;}
    public DateTime BornDate {get;set;}
    public EmployeeStatus Status {get;set;}    

    public enum EmployeeStatus
    {
        NotSet,
        Active,
        Inactive
    }
    static void Main(string[] args)
    {
        // Say hello!
        Console.WriteLine("Hello there!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1= Add employees to list");

        var action = Console.ReadLine();

        switch(action)
        {
            case "1":
            Fetch.FetchData();
            break;
        }

    }
}