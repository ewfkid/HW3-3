namespace Interfaces
{
    public sealed class TwoDimensionalArray : ArrayBase, ITwoDimensionalArray
    {
        private int[,] _array;

        public TwoDimensionalArray(int[,] array)
        {
            _array = array;
        }

        public TwoDimensionalArray(int rows, int columns, bool userFilled)
        {
            _array = new int[rows, columns];

            if (userFilled)
            {
                FillArrayFromUserInput();
            }

            else
            {
                FillArrayWithRandomValues();
            }
        }

        protected override void FillArrayFromUserInput()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите элемент массива с индексом {i} {j}");
                    _array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void FillArrayWithRandomValues()
        {
            Random rnd = new Random();


            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    _array[i, j] = rnd.Next(-100, 100);
                }
            }
        }

        public void RecreateArray(bool userFilled, int rows, int columns)
        {
            _array = new int[rows, columns];

            if (userFilled)
            {
                FillArrayFromUserInput();
            }

            else
            {
                FillArrayWithRandomValues();
            }
        }


        public override void Print()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.Write(_array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public override double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    sum += _array[i, j];
                }
            }

            return sum / _array.Length;
        }


        public void SnakeArray()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < _array.GetLength(1); j++)
                    {
                        Console.Write(_array[i, j] + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    for (int j = _array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(_array[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}