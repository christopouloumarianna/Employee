using System;

namespace oriented
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give a name");
            string name = Console.ReadLine();
            Console.WriteLine("Give a lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Give address");
            string address = Console.ReadLine();

            Console.WriteLine("Give age");
            int age = int.Parse(Console.ReadLine());

            doSmthg();
            //Person person;
            Person person = new Person(name, lastname, address, age);
            //person.name = name;
            //person.address = address;
            //person.age = age;

            Console.WriteLine(person.ToString());

            Employee employee = new Employee("thodoris", "antypas", "athina", 19, 999);
            employee.AssignBook(new Book("56", "bible", "vas", "gutenberg", 789, 2004, true));
            Console.WriteLine(employee);

        }

        static void doSmthg()
        {
            Person p = new Person("georgios", "nikolaou", "athina", 32);
            Console.WriteLine(p.name);


            Book biblioNeo = new Book("12345", "anemodarmena", "thodoris", "kleidarithmos", 126, 2004, true);
            p.AssignBook(biblioNeo);
            Console.WriteLine(p);





        }
        class Book
        {
            string _isbn;
            string _title;
            string _author;
            string _publisher;

            int _numberOfPagers;
            int _publishYear;
            bool _availability;



            public Book()
            {

            }
            public Book(string isbn, string title, string author, string publisher, int numberOfPagers, int publishYear, bool availability)
            {
                _isbn = isbn;
                _title = title;
                _author = author;
                _publisher = publisher;

                _numberOfPagers = numberOfPagers;
                _publishYear = publishYear;
                _availability = availability;

            }
            public override string ToString()
            {
                return "isbn=" + _isbn + "title=" + _title + "author=" + _author + "publisher=" + _publisher + "numberOfPagers=" +
                    _numberOfPagers + "publishYear=" + _publishYear + "availability=" + _availability;
            }
            public void Rent()
            {
                _availability = false;
            }
            public void ReturnBack()
            {
                _availability = true;
            }


        }
        class Person
        {
            string _firstName;
            string _lastName;
            string _address;
            int _age;
            Book personalBook;
            public void AssignBook(Book book)
            {
                personalBook = book;
            }


            public string name
            {
                get { return _firstName + " " + _lastName; }
            }

            //public string address { get; set; }
            //public int age { get; set; }
            public Person()
            {

            }
            public Person(string firstName, string lastName, string address, int age)
            {
                _firstName = firstName;
                _lastName = lastName;
                _address = address;
                _age = age;
            }

            //public void setName(String newName)
            //{
            //    name = newName;
            //}

            public override string ToString()
            {
                return "Person name=" + name + "Person address=" + _address + "Person age" + _age + "Personal Book=" + personalBook;
            }
            public void increaseAge()
            {
                _age++;
            }
        }

        class Employee : Person
        {
            double salary;
            public Employee()
            {

            }
            public Employee(string firstName, string lastName, string address, int age, double salary) : base(firstName, lastName, address, age)
            {
                this.salary = salary;
            }



            public override string ToString()
            {
                return base.ToString() + "salary=" + salary;
            }
        }
    }
}

