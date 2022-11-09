namespace SimpleProject
{
    public class Passport
    {
        
        protected string firstName;
        protected string lastName;
        protected int    human_age;
        protected string adress;
        protected string City;
        protected string State;
        protected string Country;
        protected string take;
        protected string date_of_take;

        
    }
    public class FPasport : Passport
    {
        string National;
        string id;

        public FPasport(string fName, string lName,int age,string city,string country,
            string date,string national,string id_code)
       
        {
            firstName = fName;
            lastName = lName;
            human_age = age;
            City = city;
            Country = country;
            date_of_take= date;
            National = national;
            id = id_code;
        }
        public void Print()
        {
            Console.WriteLine($"Фамилия: {lastName}\nИмя: { firstName}\nВозраст:" +
                $"{ human_age}\nМесто регистрации:{ City}\nСтрана рождения:{ Country}" +
                $"\nГражданство:{ National}\nДата выдачи заграничного паспорта:{ date_of_take} " +
                $"\nID:{ id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FPasport employee = new FPasport("John",
            "Doe", 25,"Tyumen","Russia","01.01.1990","RF","qwertyu12345");
            employee.Print();
        }
    }
}