namespace Interfaces
{
    public abstract class ArrayBase : IPrinter, IArray
    {
        public abstract double CalculateAverage();

        public abstract void Print();

        protected abstract void FillArrayFromUserInput();

        protected abstract void FillArrayWithRandomValues();
    }
}