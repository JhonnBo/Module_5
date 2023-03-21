namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[2];
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student();
                Console.WriteLine("Введите имя: ");
                st[i].Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                st[i].Surname = Console.ReadLine();
                Console.WriteLine("Введите город: ");
                st[i].City = Console.ReadLine();
                Console.WriteLine("Введите возраст: ");
                st[i].Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите средний балл: ");
                st[i].Average = Convert.ToDouble(Console.ReadLine());
                // st[i].Code = 100; // свойство Code только для чтения
                //Console.WriteLine("Введите год рождения: ");
                //st[i].Year = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", st[i].Code, st[i].Name, st[i].Surname, st[i].Age, st[i].Average, st[i].City);
            }
        }
    }
    class Student
    {

        static int counter = 0;
        public Student() // Конструктор класса
        {
            this.id_code = counter++;
        }

        string name;
        public string Name // Свойство
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
            }
        }

        string surname;
        public string Surname // Свойство
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != "")
                    surname = value;
            }
        }

        int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
            }
        } // Свойство

        int id_code;
        public int Code // Властивість тільки для читання
        {
            get
            {
                return id_code;
            }
        }

        double avg;
        public double Average
        {
            get
            {
                return avg;
            }
            set
            {
                if (value >= 0 && value <= 12)
                    avg = value;
            }
        } // Свойство

        public string City { get; set; } // Автоматическое свойство

        //private int year; 

        //public int Year  // Властивість тільки для запису
        //{

        //    set { year = value; }
        //}

    }
}