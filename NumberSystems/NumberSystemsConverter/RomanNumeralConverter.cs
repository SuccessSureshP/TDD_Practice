using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemsConverter
{
    public class RomanNumeralConverter
    {
        private readonly List<RomanNumeralPair> _romanNumeralList;
        public RomanNumeralConverter()
        {
            _romanNumeralList = new List<RomanNumeralPair>();
            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.M),
                RomanNumericalRepresentation = RomanNumeralsType.M.ToString()
            }
             );

            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.D),
                RomanNumericalRepresentation = RomanNumeralsType.D.ToString()
            }
            );

            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.C),
                RomanNumericalRepresentation = RomanNumeralsType.C.ToString()
            }
            );

            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.L),
                RomanNumericalRepresentation = RomanNumeralsType.L.ToString()
            }
            );
            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.X),
                RomanNumericalRepresentation = RomanNumeralsType.X.ToString()
            }
            );
            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.V),
                RomanNumericalRepresentation = RomanNumeralsType.V.ToString()
            }
            );
            _romanNumeralList.Add(new RomanNumeralPair()
            {
                NumericValue = Convert.ToInt32(RomanNumeralsType.I),
                RomanNumericalRepresentation = RomanNumeralsType.I.ToString()
            }
            );
           

        }
        public string ConvertRomanNumeral(int number)
        {
            if (number < 1 || number > 3000)
            {
                throw new IndexOutOfRangeException("The number supplied is out of expected range (1 to 3000)");
            }

            StringBuilder sb = new StringBuilder();

            foreach(var currentPair in _romanNumeralList)
            {
                while(number >= currentPair.NumericValue)
                {
                    sb.Append(currentPair.RomanNumericalRepresentation);
                    number -= currentPair.NumericValue;
                }
            }

            return sb.ToString();
        }
    }
}
