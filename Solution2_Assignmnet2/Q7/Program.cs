using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Date date = new Date(2000, 3, 2);
            date.display();
            Console.WriteLine(date.ToString());
            Date date1 = new Date(1234, 3, 2);
            date1.display();
            Console.WriteLine(DateTime.Now);
            Person p = new Person("Sid", 'm', date, "Pune");
            p.displayPerson();
            Person p1 = new Person();
            p1.acceptPerson();
            p1.displayPerson();
            Console.WriteLine();

        }

    }
    public class Person
    {
        private String name;
        private char gender;
        private Date birth;
        private String address;

        public Person()
        {
            name = null;
            gender = 'n';
            birth = new Date();
            address = null;

        }
        public Person(String name, char gender, Date birth, String address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;

        }

        public String getName()
        {
            return name;
        }
        public char getGender()
        {
            return gender;
        }
        public String getAddress()
        {
            return address;
        }
        public Date getBirth()
        {
            return birth;
        }
        public void setName(String n)
        {
            name = n;
        }
        public void setGender(char c)
        {
            gender = c;
        }
        public void setAddress(String a)
        {
            address = a;
        }
        public void setBirth(Date d)
        {
            birth = d;
        }
        public static int calculateAge(Date birth)
        {
            return DateTime.Now.Year - birth.year;
        }

        public void displayPerson()
        {
            Console.WriteLine("Name-" + name + "\ngender-" + gender + "\nbirth date-" + birth.ToString() + "\naddress-" + address + "\nAge-" + calculateAge(birth));
        }
        public String ToString()
        {
            return "Name-" + name + "\ngender-" + gender + "\nbirth date-" + birth + "\naddress-" + address + "\nAge-" + calculateAge(birth);
        }

        public void acceptPerson()
        {
            Console.WriteLine("Enter name-");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender-");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter date of birth-");
            birth.accept();
            Console.WriteLine("enter address-");
            address = Console.ReadLine();
            // Age = calculateAge();
        }

    }

    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date()
        {
            _year = 1999;
            _month = 1;
            _day = 1;
        }

        public Date(int year, int month, int day)
        {
            if (isValidDate(year, month, day))
            {
                _year = year;
                _month = month;
                _day = day;
            }
            else
            {
                Console.WriteLine("enter valid date variables!");
            }
        }

        public int day
        {
            get { return _day; }
            set { _day = value; }
        }

        public int month
        {
            get { return _month; }
            set { _month = value; }
        }


        public int year
        {
            get { return _year; }
            set { _year = value; }
        }

        public void accept()
        {
            Console.WriteLine("Enter year:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day:");
            int d = Convert.ToInt32(Console.ReadLine());
            if (isValidDate(y, m, d))
            {
                _year = y; _month = m; _day = d;
            }
            else
            {
                Console.WriteLine("enter valid date variables!");
            }
        }
        public string ToString()
        {
            return _day + "/" + _month + "/" + _year;
        }
        public void display()
        {
            Console.WriteLine("Date:" + year + "/" + month + "/" + day);
        }

        public static float operator -(Date d1, Date d2)
        {
            return Math.Abs(d1.year - d2.year);
        }

        private Boolean isValidDate(int y, int m, int d)
        {
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                return d <= 31 && d > 0;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                return d <= 30 && d > 0;
            }
            else if (m == 2)
            {
                if (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0))
                {
                    return (d <= 29 && d > 0);
                }
                else
                {
                    return d <= 28 && d > 0;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

