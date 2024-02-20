namespace Interfaces
{
    public class WeekDays : IPrinter
    {
        private string[] _days = { "Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday" };

        public void Print()
        {
            foreach (string day in _days)
            {
                Console.Write(day + " ");
            }
        }
    }
}