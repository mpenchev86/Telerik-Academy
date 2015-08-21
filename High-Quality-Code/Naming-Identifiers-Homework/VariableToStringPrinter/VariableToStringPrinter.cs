namespace VariablesWorkers
{
    using System;

    internal class VariablePrinter
    {
        private const int MaxCount = 6;
        
        public static void Main()
        {
            VariablePrinter.Printer instance = new VariablePrinter.Printer();
            instance.PrintVariable(true);
        }

        internal class Printer
        {
            public void PrintVariable(bool variable)
            {
                string variableAsString = variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}
