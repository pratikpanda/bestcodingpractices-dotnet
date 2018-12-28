using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatr.Cqrs.Services
{
    public class DictionaryNumberService : INumberService
    {
        private Dictionary<int, string> numberStringMapper;

        public DictionaryNumberService()
        {
            numberStringMapper = new Dictionary<int, string>
            {
                [0] = "Zero",
                [1] = "One",
                [2] = "Two",
                [3] = "Three",
                [4] = "Four",
                [5] = "Five"
            };
        }

        public string GetNumericStringValue(int number)
        {
            bool foundNumericString = numberStringMapper.TryGetValue(number, out var result);
            return result;
        }

        public bool Add(int number, string numericString)
        {
            bool foundNumericString = numberStringMapper.TryGetValue(number, out var result);
            if (foundNumericString)
            {
                return false;
            }
            else
            {
                numberStringMapper.Add(number, numericString);
                return true;
            }
        }
    }
}
