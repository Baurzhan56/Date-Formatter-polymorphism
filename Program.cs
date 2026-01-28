using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Linq.Expressions;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime;
namespace CsharpEssentials
{
    public class BaseDate
    {
        public int Year{ get; set;}
        public int Month {get;set;}
        public int Daye { get; set;}
        public BaseDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Daye = day;
        }
        public virtual string GetFormat()
        {
            return string.Format("год:{0:0000}, месяц:{1:00}, день:{2:00}", Year,Month,Daye);
        }
    }
    public class AmericanDate : BaseDate
    {
        public AmericanDate(int year, int month, int day):base(year,month,day)
        {}
        public override string GetFormat()
        {
            return string.Format("{0:00}.{1:00}.{2:0000}", Month, Daye, Year);
        }
    }
    public class EuropeanDate : BaseDate
    {
        public EuropeanDate(int year, int month, int day):base(year, month, day)
        {
            
        }
        public override string GetFormat()
        {
            return string.Format("{0:00}.{1:00}.{2:0000}", Daye, Month,Year);
            
        }
    }


    class Program
    {
        public static void Main()
        {
            BaseDate date = new BaseDate(2021, 3, 24);
            AmericanDate date1 = new AmericanDate(2021, 3, 24);
            EuropeanDate date2 = new EuropeanDate(2021, 3, 24);

            List<BaseDate> dates = new List<BaseDate>
    {
     date,date1, date2
    };

            foreach (var item in dates)
            {
                Console.WriteLine(item.GetFormat());
            }
        }
    }
}
