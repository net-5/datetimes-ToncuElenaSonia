using System;
using System.Globalization;

namespace DateTimeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentDate();
            AddYears();
            HumanFriendly();
            AddSeconds();
            CurrentTime();
            SixMonthsDate();
            FirstAndLastSecondOfDay();
            DifferenceInSeconds();
            GetAge();
            DaysBeforeAndAfter();
            NumberOfdayBetweenDates();
            PrintYesterdayTodayTomorrow();
            PrintNext5days();
            GetDayBetweenDates();
            FirstMonday();
            SelectAllTheSundays();
            
        }
        //1.	Write a program to display the:
        //a) Current date and time
        //b) Current year
        //c) Month of year
        //d) Week number of the year
        //e) Weekday of the week
        //f) Day of year
        //g) Day of the month
        //h) Day of week
        //j) if the current year is a leap year or not

        public static void CurrentDate()
        {
            DateTime myCurrentDate = DateTime.Now;
            Console.WriteLine($"Current date and time is {myCurrentDate}");
            Console.WriteLine($"Current year is {myCurrentDate.Year}");
            Console.WriteLine($"Current month of year is {myCurrentDate.Month}");
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(myCurrentDate);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Sunday)
            {
                Console.WriteLine($"Week number of the year is {CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(myCurrentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday)}");
            }
            Console.WriteLine($"Weekday of the week is {myCurrentDate.DayOfWeek}");
            Console.WriteLine($"The day of the year is {myCurrentDate.DayOfYear}");
            Console.WriteLine($"The day of the month is {myCurrentDate.Day}");
            Console.WriteLine($"The day of the week is {myCurrentDate.DayOfWeek}");
            if (DateTime.IsLeapYear(myCurrentDate.Year))
            {
                Console.WriteLine("The current year is a leap year!");
            }
            else
            {
                Console.WriteLine("The current year is not a leap year!");
            }
            Console.WriteLine();
        }
        //2.	Write a program to add N year(s) to the current date and display the new date.
        public static void AddYears()
        {
            DateTime myCurrentDate = DateTime.Now;
            Console.WriteLine("How many years do you want to add to the current date?");
            int n = int.Parse(Console.ReadLine());
            DateTime newDate = myCurrentDate.AddYears(n);
            Console.WriteLine($"The new date with {n}  added years is:{newDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine();
        }
        //3.	Write a program to display the date and time in a human-friendly string.
        public static void HumanFriendly()
        {
            DateTime myCurrentDate = DateTime.Now;
            Console.WriteLine($"Today is {myCurrentDate.ToLongDateString()} and the time is {myCurrentDate.ToLongTimeString()}");
            Console.WriteLine();
        }
        //4.	Write a program to add 5 seconds to the current time and print it to the console.
        public static void AddSeconds()
        {
            DateTime myCurrentDate = DateTime.Now;
            DateTime output = myCurrentDate.AddSeconds(5);
            Console.WriteLine($"The current date is {myCurrentDate} and after 5 seconds will be {output}");
            Console.WriteLine();
        }
        //5. Write a program to get current time in milliseconds
        public static void CurrentTime()
        {
            var totalMill = new TimeSpan(DateTime.Now.Ticks).TotalMilliseconds;
            Console.WriteLine($"Current time in miliseconds is:{totalMill}");
            Console.WriteLine();
        }
        //6.	Write a program that calculates the date six months from the current date.
        public static void SixMonthsDate()
        {
            DateTime myCurrentDate = DateTime.Now;
            DateTime sixMonthDate = myCurrentDate.AddMonths(6);
            Console.WriteLine($"The current date is {myCurrentDate} and after 6 months the date will be {sixMonthDate}");
            Console.WriteLine();
        }
        //7.	Write a program to get the first and last second of a day.
        public static void FirstAndLastSecondOfDay()
        {
            DateTime oneDay = new DateTime(1989, 10, 20);
            DateTime startDay = new DateTime(oneDay.Year, oneDay.Month, oneDay.Day);
            DateTime endOfDay = startDay.AddDays(1);
            TimeSpan diff = TimeSpan.FromMilliseconds(1);
            endOfDay -= diff;
            Console.WriteLine($"Start of day is {startDay} and end of day is {endOfDay}");
            Console.WriteLine();
        }
        //8.Write a program to calculate two date difference in seconds.
        public static void DifferenceInSeconds()
        {

            DateTime firstDate = new DateTime(1989, 10, 20);
            DateTime secondDate = DateTime.Now;
            TimeSpan interval = secondDate - firstDate;
            Console.WriteLine($"Difference in seconds is:{interval.TotalSeconds}");
            Console.WriteLine();
        }
        // 9.Given a date of birth, calculate the age of a person.
        //Input: 10, 09, 1989 
        //Output: 29

        public static void GetAge()
        {
            DateTime birthday = new DateTime(1989, 9, 10);
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;

            if ((today.Month < birthday.Month) || (today.Month == birthday.Month && today.Day < birthday.Day))
            {
                age--;
            }
            Console.WriteLine($"Age of person is: {age}");
            Console.WriteLine();
        }
        //10.Write a program to get the dates 30 days before and after from the current date, and display it to the console
        public static void DaysBeforeAndAfter()
        {
            DateTime myCurrentDate = DateTime.Now;
            DateTime before30Days = myCurrentDate.AddDays(-30);
            DateTime after30Days = myCurrentDate.AddDays(30);
            Console.WriteLine("The date with 30 days before is:{0}", before30Days);
            Console.WriteLine("The date with 30 days after is:{0}", after30Days);
            Console.WriteLine();
        }
        ////11.	Write a program to calculate a number of days between two dates.
        public static void NumberOfdayBetweenDates()
        {
            DateTime firstDate = DateTime.Now;
            DateTime secondDate = new DateTime(1989, 10, 20);
            TimeSpan diff = firstDate - secondDate;
            int numberOfDays = diff.Days;
            Console.WriteLine($"The number of days between two date is:{numberOfDays}");
            Console.WriteLine();
        }
        //12.	Write a program to print yesterday, today, tomorrow.
        public static void PrintYesterdayTodayTomorrow()
        {
            DateTime todayDate = DateTime.Today;
            Console.WriteLine($"Today is:{todayDate.ToString("yyyy-MM-dd")}");
            DateTime yesterdayDate = todayDate.AddDays(-1);
            Console.WriteLine($"Yesterday is:{yesterdayDate.ToString("yyyy-MM-dd")}");
            DateTime tomorrowDate = todayDate.AddDays(1);
            Console.WriteLine($"Tomorrow is:{tomorrowDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine();
        }
        //10.	Write program to print next 5 days starting from today.
        public static void PrintNext5days()
        {
            DateTime todayDate = DateTime.Today;
            int numberOfdays = 5;
            for (int i = 0; i < numberOfdays; i++)
            {
                DayOfWeek day = todayDate.AddDays(i).DayOfWeek;
                Console.WriteLine($"The next 5 days starting from today are {day}");
            }
            Console.WriteLine();
        }
        //*11. Write a program to find the date of the first Monday of a given week
        //Input  : 2015, 50
        //Output : Mon Dec 14 00:00:00 2015      
        public static void FirstMonday()
        {
            Console.WriteLine("Enter the year:");
            //Input  : 2015
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the week:");
            //Input 50
            int week = int.Parse(Console.ReadLine());
            DateTime myCurrentDate = new DateTime(year, 1, 1).AddDays(week * 7);
            while (myCurrentDate.DayOfWeek != DayOfWeek.Monday)
            {
                myCurrentDate = myCurrentDate.AddDays(-1);
            }
            Console.WriteLine(myCurrentDate.ToLongDateString() + " " + myCurrentDate.TimeOfDay);
            Console.WriteLine();
        }
        //*12. Write a program to get days between two dates.
        //Input :  
        //2000,2,2
        //2001,2,28
        //Output : 366 days, 0:00:00
        public static void GetDayBetweenDates()
        {
            DateTime firstDate = new DateTime(2000, 2, 2);
            DateTime secondDate = new DateTime(2001, 2, 28);
            TimeSpan diff = secondDate - firstDate;
            int numberOfDays = diff.Days;
            Console.WriteLine($"The number of days between two date is:{numberOfDays}");
            Console.WriteLine();
        }
        // *13. Write a program to select all the Sundays of a specified year and display their dates
        //Output:
        //2020-01-05
        //2020-01-12 
        //2020-01-19
        public static void SelectAllTheSundays()
        {
            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            for (int month = 1; month <= 12; month++)
            {
                for (int i = 1; i <= CultureInfo.InvariantCulture.Calendar.GetDaysInMonth(year, month); i++)
                {
                    DateTime d = new DateTime(year, month, i);
                    if (d.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Console.WriteLine($"The dates of all the Sundays from {year} are:{d.ToString("yyyy-MM-dd")}");
                    }
                }

            }
        }

    }
}
