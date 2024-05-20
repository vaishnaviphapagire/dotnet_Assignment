namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Date d = new Date();
            d.display();
            d.accept();
            d.display();*/
;
            Date d1= new Date(1991,1,1);
            d1.display();
            Date d2= new Date(1990,12,31);
            d2.display();
            Console.WriteLine("Date d1-d2:"+(d1-d2));
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
            bool b=isValidDate(year, month, day);
            Console.WriteLine(b);
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


        public int year {
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

        public void display()
        {
            Console.WriteLine("Date:" + year + "/" + month + "/" + day);
        }

        public static float operator-(Date d1, Date d2){
           /* int diffm;
            if(d1.year < d2.year)
            {
                 diffm = (12 - d1.month)+d2.month;
              
            }
            else
            {
                 diffm=(12 - d2.month)+d1.month;
            }
            int diffy = Math.Abs(d1.year - d2.year);
            Console.WriteLine();
            return  diffy;*/
            return Math.Abs(d1.year - d2.year);
            }

        private static Boolean isValidDate(int y,int m,int d)
        {
            if(m==1||m==3|| m == 5 || m == 7 || m ==8  || m == 10 || m == 12)
            {
                return d<=31&&d>0;
            }else if( m == 4 || m == 6 || m == 9 || m == 11 )
            {
                return d <= 30 && d > 0;
            }
            else if(m==2)
            {
                if (y%4==0)
                {
                    if( (y % 100 != 0 || y % 400 == 0))
                    {
                        return d <= 29 && d > 0;
                    }
                    else
                    {
                        return d <= 28 && d > 0;
                    }
                    
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
