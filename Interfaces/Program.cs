namespace Interfaces
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IArray[] data = new IArray[3];

            data[0] = new OneDimensionalArray(new int[] { 1, 2, 3, 4 });
            data[1] = new TwoDimensionalArray(new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } });
            data[2] = new JaggedArray(new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 8, 9 }
            });


            for (int i = 0; i < data.Length; i++)
            {
                data[i].Print();
                Console.WriteLine(data[i].CalculateAverage());
            }

            IPrinter[] printer = new IPrinter[4];

            printer[0] = (IPrinter)data[0];
            printer[1] = (IPrinter)data[1];
            printer[2] = (IPrinter)data[2];
            printer[3] = new WeekDays();

            for (int i = 0; i < printer.Length; i++)
            {
                printer[i].Print();
            }
        }
    }
}