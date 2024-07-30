using System;
using System.Collections.Generic;

namespace TaskOne
{
    class Fibonacci
    {
        public int _input;
        private int _maxValue;
        private int _Count = 0;

        public List<int> GenerateSequence(int input)
        {
            _input = input;
            List<int> SingleTable = [];
            if (_input == 0)
            {
                SingleTable.Add(0);
                _Count = 0;
                _maxValue = 0;
            }
            else if (_input == 1)
            {
                SingleTable.Add(0);
                SingleTable.Add(1);
                SingleTable.Add(1);
                _Count = 2;
                _maxValue = 1;
            }
            else
            {
                SingleTable.Add(0);
                SingleTable.Add(1);
                _Count = 1;
                _maxValue = SingleTable[_Count];
                while ((_maxValue + SingleTable[_Count - 1]) < input)
                {
                    SingleTable.Add(SingleTable[_Count - 1] + SingleTable[_Count]);
                    _maxValue = SingleTable[_Count + 1];
                    _Count++;
                }
                _Count = SingleTable.Count;
            }
            return SingleTable;
        }
        
        public static void PrintTable(List<int> Table)
        {
            for (int i = 0; i < Table.Count; i++)
            {
                Console.Write(Table[i]);
                if (i != Table.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }

        public int GetMaxValue()
        {
            return _maxValue;
        }
        public int GetIterationCount()
        {
            return _Count;
        }
        public List<int> GetArrayOfResults(int lowerBound, int upperBound)
        {
            List<int>? ExternalTable = GenerateSequence(upperBound);
            List<int> FinalTable = [];

            for (int i = 0; i < ExternalTable.Count; i++)
            {
                if (ExternalTable[i] >= lowerBound)
                {
                    FinalTable.Add(ExternalTable[i]);
                }
            }
            ExternalTable = null;
            return FinalTable;
        }

        public static void PrintGrid(List<int> _result)
        {
            foreach (var value in _result)
            {
                Console.Write(value);
                if (value != _result[_result.Count - 1])
                    Console.Write(",  ");
            }
            Console.WriteLine();
        }

    }

}
