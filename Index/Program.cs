namespace Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apple = new Company(new Person[]
            {
                new Person("Bill"),
                new Person("Gates"),
                new Person("Stiev"),
                new Person("Jobs")
            });
            try
            {
                Console.WriteLine(apple[0].Name);
                // Console.WriteLine(apple.personal[0].Name);
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{i + 1} Person: {apple[i].Name}, Id = {apple[i].Id}");
                }
                apple["Jobs"] = 777;
                Console.WriteLine($"Get person Jobs Id = {apple["Jobs"]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Person
    {
        public string Name { get; }
        public int Id { get; set; }        
        public Person(string name)
        {
            Name = name;
            
            Id = (new Random()).Next(100, 1000);
        }
    }
    class Company
    {
        Person[] personal;
        public Company(Person[] people)
        {
            personal = people;
        }

        public Person this[int index]
        {
            get
            {
                if (index >= 0 && personal.Length > index)
                    return personal[index]; // то возвращаем объект Person по индексу
                else
                    throw new IndexOutOfRangeException("Bounds Alert!!!"); // иначе генерируем исключение
            }
            set
            {
                if (index >= 0 && personal.Length > index)
                    personal[index] = value;
            }
        }
        public int this[string index] // перегруженный индексатор
        {
            get
            {
                foreach (var person in personal)
                {
                    if (person.Name == index) return person.Id;
                    
                }
                throw new IndexOutOfRangeException("No such name of person");
            }
            set
            {
                foreach (var person in personal)
                {
                    if (person.Name == index) person.Id = value;

                }
                //throw new IndexOutOfRangeException("No such name of person");
            }
        }
    }
}