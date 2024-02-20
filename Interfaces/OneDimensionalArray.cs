namespace Interfaces
{
    public sealed class OneDimensionalArray : ArrayBase, IOneDimensionalArray
    {
        private int[] _array;

        public OneDimensionalArray(int[] array)
        {
            _array = array;
        }

        public OneDimensionalArray(bool userFilled, int length)
        {
            _array = new int[length];

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
                Console.WriteLine($"Введите элемент массива с индексом {i}");

                _array[i] = int.Parse(Console.ReadLine());
            }
        }

        protected override void FillArrayWithRandomValues()
        {
            Random rnd = new Random();


            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rnd.Next(-1000, 1000);
            }
        }

        public void RecreateArray(bool userFilled, int length)
        {
            _array = new int[length];

            if (userFilled)
            {
                FillArrayFromUserInput();
            }
            else
            {
                FillArrayWithRandomValues();
            }
        }

        public override double CalculateAverage()
        {
            double sum = 0;

            foreach (int num in _array)
            {
                sum += num;
            }

            return sum / _array.Length;
        }

        public override void Print()
        {
            foreach (int num in _array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }


        public void RemoveDuplicates()
        {
            int count = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (_array[j] == _array[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    count++;
                }
            }

            int[] newArray = new int[count];
            int position = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (_array[j] == _array[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    newArray[position] = _array[i];
                    position++;
                }
            }

            _array = newArray;
        }
    }
}