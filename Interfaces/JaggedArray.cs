namespace Interfaces
{
    public sealed class JaggedArray : ArrayBase, IJaggedArray
    {
        private int[][] _array;

        public JaggedArray(int[][] array)
        {
            _array = array;
        }

        public JaggedArray(int rows, bool userFilled)
        {
            _array = new int[rows][];

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
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine("Введите количество столбцов");
                int columns = int.Parse(Console.ReadLine());
                _array[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите элемент массива с индексами: {i} {j}");
                    _array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void FillArrayWithRandomValues()
        {
            Random rnd = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                int columns = rnd.Next(1, 10);
                _array[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    _array[i][j] = rnd.Next(-100, 100);
                }
            }
        }


        public override void Print()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    Console.Write(_array[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public override double CalculateAverage()
        {
            double sum = 0;
            int total = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    sum += _array[i][j];
                    total++;
                }
            }

            return sum / total;
        }

        public void MultiplyEvenElements()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    if (_array[i][j] % 2 == 0)
                    {
                        _array[i][j] = i * j;
                    }
                }
            }
        }

        public void RecreateArray(int rows, bool userFilled)
        {
            _array = new int[rows][];

            if (userFilled)
            {
                FillArrayFromUserInput();
            }
            else
            {
                FillArrayWithRandomValues();
            }
        }
    }
}