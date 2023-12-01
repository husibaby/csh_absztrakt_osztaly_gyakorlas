using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Employee
    {
        public abstract double CalculateSalary();
    }

    public class Manager : Employee
    {
        private double basicrate;
        private double bonus;

        public Manager(double basicrate, double bonus)
        {
            this.basicrate = basicrate;
            this.bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return basicrate + bonus;
        }
    }

    public class Developer : Employee
    {
        private double hourlyRate;
        private int hoursWorked;


        public Developer(double hourlyRate, int hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }
