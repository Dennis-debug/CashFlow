
using System;
using System.Collections.Generic;
using System.Linq;

namespace cleanCoding
{
	class Probability
	{
        public static int[] probabilityOfAge = new int[]
{
            5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
            15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
            27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38,
            39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
            51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62,
            63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
            75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86,
            87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
            99, 100, 101, 102, 103, 104, 105, 106, 107, 108,
            109, 110, 111, 112, 113, 114
};
        private static double[] probabilityStats = new double[]
        {
            0.999886925,0.999897073,0.999910171,
            0.999916366,0.999915209,0.999912495,0.999898095,
            0.99987564,0.999849547,0.999817158,0.999766564,
            0.999681481,0.999585841,0.999519183,0.999483173,
            0.99946704,0.999465421,0.999452725,0.999426993,
            0.999410801,0.999401376,0.999392682,0.999382045,
            0.999354539,0.999293966,0.999207102,0.999107842,
            0.999013142,0.998948844,0.998895547,0.998821144,
            0.998747466,0.998698743,0.998656371,0.99859303,
            0.998495655,0.998375622,0.998241879,0.998103123,
            0.997964337,0.997811603,0.997628789,0.997406765,
            0.99714076,0.996832813,0.996507121,0.996175052,
            0.995839244,0.995492697,0.995121131,0.994748484,
            0.994401392,0.994053114,0.99364468,0.993088048,
            0.99231547,0.991380795,0.990402198,0.989411307,
            0.988356062,0.987270069,0.986197345,0.985086632,
            0.983950006,0.982814661,0.98151916,0.979909162,
            0.978115764,0.976114958,0.973598231,0.970454324,
            0.966766935,0.962698854,0.958239198,0.953086101,
            0.947145164,0.94070781,0.934180756,0.92762091,
            0.92088719,0.913733937,0.905935721,0.897372884,
            0.886885399,0.874519284,0.862655689,0.851280846,
            0.839044279,0.825894314,0.811778479,0.796643931,
            0.780437951,0.763108529,0.744605035,0.724878977,
            0.703884845,0.681581037,0.657930861,0.632903594,
            0.606475583,0.578631352,0.549364643,0.518679108,
            0.486587051,0.453093315,0.418005909,0.376522116,
            0.343062608,0.5,0
        };
                static Probability()
        {
            for (int i = 0; i < probabilityOfAge.Length; i++)
            {
                agesToProbability.Add(probabilityOfAge[i], probabilityStats[i]);
            };
        }

        public static IDictionary<int, double> agesToProbability = new Dictionary<int, double>();

		public string getProbability(int survivalAge)
        {
            double resultProbability = 1;
            foreach (int probabilityAge in probabilityOfAge)
            {
                if (probabilityAge > survivalAge)
                {
                    agesToProbability[probabilityAge] = 1;
                }
                resultProbability = resultProbability * agesToProbability[probabilityAge];
            }
            double probabilityAdjustedPresentValue = resultProbability * (Data.agesToPayments[survivalAge] / Math.Pow(1.015, Data.agesToTimes[survivalAge]));
            double percentOfResult = resultProbability * 100;
            return $"\nThe probability of the claimant living until {survivalAge.ToString()}, assuming that the accident occured at 5 years old, is {Math.Round((double)percentOfResult,2).ToString()}%.\nThe probability adjusted present value of the payment at age 63 would be £{Math.Round(probabilityAdjustedPresentValue,2).ToString()}.\nThank you for using the CashFlow program. You have now exited the program. Goodbye!";
        }
	}
}
