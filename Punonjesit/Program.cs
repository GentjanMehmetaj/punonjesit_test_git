﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punonjesit
{
    class Program
    {
        static void Main(string[] args)
        {
            punonjesFulltime FTP = new punonjesFulltime
            {
                Id = 1,
                FirstName = "Gentjan",
                LastName = "Mehmetaj",
                PageseVjetore = 60000
            };
            punonjesPartTime PTP = new punonjesPartTime
            {
                Id = 2,
                FirstName = "Albana",
                LastName = "Sufaj",
                HourlyPay = 500,
                TotalHoursWorked = 40
            };

            Console.WriteLine(FTP.GetFulName());
            Console.WriteLine(FTP.GetMonthlySalary());
            Console.WriteLine("-------");
            Console.WriteLine(PTP.GetFulName());
            Console.WriteLine(PTP.GetMonthlySalary());
        }
    }
}