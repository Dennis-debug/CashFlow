using System;

namespace cleanCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello and welcome to my CashFlow program.\nThis program is a C# function that returns, at any point during the payment stream , the \'value\' of the outstanding series of payments between the ages of \"10\" and \"63\" and, if desired, the probability.");

            Payments a = new Payments();

            Console.WriteLine("\nWhat is the claimant's starting age or would you like to use the default settings?");
            a.startingAge = GetAgeInput(10);

            Console.WriteLine("\nWhat is the claimant's survival age or would you like to use the default settings?");
            a.survivalAge = GetAgeInput(63);

            Console.WriteLine(a.getPayment(a.startingAge, a.survivalAge));

            Console.WriteLine("\nYes or no, Would you like to calculate the probability of the claimant using the data you have already declared?");
            Console.WriteLine(GetProbabilityInput(a.survivalAge));


        }
        static int GetAgeInput(int defaultAge)
        {
            int i = 0;
            do
            {
                string GetAgeInput = Console.ReadLine();
                if (GetAgeInput.ToLower() == "default")
                {
                    return defaultAge;
                }
                else
                {
                    if (int.TryParse(GetAgeInput, out int result))
                    {
                            if (result >= 10 && result <= 63)
                        {
                            return result;
                        }
                            else
                        {
                            Console.WriteLine($"\n You typed in {result}, which is not within the specified range. \nPlease input the word \"default\" or an interger between \"10\" and \"63\".");
                        }
                    }
                    else
                    {
                        if (double.TryParse(GetAgeInput, out double doubleresult))
                        {
                            string typeOfResult = "double";
                            Console.WriteLine($"\nYou typed in {GetAgeInput}, which is a {typeOfResult}.\nPlease input the word \"default\" or an interger (like 52).");
                        }
                        else if (bool.TryParse(GetAgeInput, out bool boolresult))
                        {
                            string typeOfResult = "bool";
                            Console.WriteLine($"\nYou typed in {GetAgeInput}, which is a {typeOfResult}.\nPlease input the word \"default\" or an interger (like 52).");
                        }
                        else if (char.TryParse(GetAgeInput, out char charresult))
                        {
                            string typeOfResult = "char";
                            Console.WriteLine($"\nYou typed in {GetAgeInput}, which is a {typeOfResult}.\nPlease input the word \"default\" or an interger (like 52).");
                        }

                    }
                }
            }
            while (i++ < 10);
            Console.WriteLine($"\n You have not entered the correct input 10 times. Therefore, the default \"{defaultAge}\" will be used.");
            return defaultAge;
        }

        static string GetProbabilityInput(int survivalAge)
        {
            Probability b = new Probability();
            int z = 0;
            do
            {
                string responseProbability = Console.ReadLine();
                if (responseProbability.ToLower() == "yes")
                {
                    return b.getProbability(survivalAge);
                }
                else if (responseProbability.ToLower() == "no")
                {
                    return "\nThank you for using the CashFlow program. You have now exited the program. Goodbye!";
                }
                else
                {
                    if (int.TryParse(responseProbability, out int result))
                    {
                        string typeOfResultProb = "interger";
                        return $"\nYou typed in {responseProbability}, which is a {typeOfResultProb}.\nPlease input \"YES\" or \"NO\" to the question: Would you like to calculate the probability of the claimant using the data you have already declared?.";
                    }
                    else if (double.TryParse(responseProbability, out double doubleresult))
                    {
                        string typeOfResultProb = "double";
                        return $"\nYou typed in {responseProbability}, which is a {typeOfResultProb}.\nPlease input \"YES\" or \"NO\" to the question: Would you like to calculate the probability of the claimant using the data you have already declared?.";
                    }
                    else if (bool.TryParse(responseProbability, out bool boolresult))
                    {
                        string typeOfResultProb = "bool";
                        return $"\nYou typed in {responseProbability}, which is a {typeOfResultProb}.\nPlease input \"YES\" or \"NO\" to the question: Would you like to calculate the probability of the claimant using the data you have already declared?.";
                    }
                    else if (char.TryParse(responseProbability, out char charresult))
                    {
                        string typeOfResultProb = "char";
                        return $"\nYou typed in {responseProbability}, which is a {typeOfResultProb}.\nPlease input \"YES\" or \"NO\" to the question: Would you like to calculate the probability of the claimant using the data you have already declared?.";
                    }
                }
            }
            while (z++ < 10);
            Console.WriteLine("\nYou have not entered the correct input 10 times. Therefore, the default \"YES\" will be used.");
            return b.getProbability(survivalAge);
        }
    }
}

