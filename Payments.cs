using System;
using System.Globalization;
using System.Linq;

namespace cleanCoding
{
    class Payments
    {
        public int startingAge;
        public int survivalAge;
        public string getPayment(int startingAge, int survivalAge)
        {
        double runningPresentValue = 0;
        double runningPayment = 0;
            foreach (int age in Data.Ages)
            {
                if (age < startingAge)
                {
                    Data.agesToPayments[age] = 0;
                }
                var total = Data.agesToPayments[age] / Math.Pow(1.015, (Data.agesToTimes[age]));
                runningPresentValue += total;
                runningPayment = runningPayment + Data.agesToPayments[age];
            }
            return $"\nIn order to make the payment of £{Math.Round((double)runningPayment, 2).ToString()} between the ages of {startingAge.ToString()} ({Data.agesToTimes[startingAge].ToString()} years after the accident) and {survivalAge.ToString()} ({Data.agesToTimes[survivalAge].ToString()} years after the accident). You must invest the present value of £{Math.Round((double)runningPresentValue, 2).ToString()}.";
        }
    }
}
