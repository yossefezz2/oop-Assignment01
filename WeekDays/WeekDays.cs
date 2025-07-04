using System.Dynamic;

namespace Shared
{
    internal enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class WeekDayClass
    {
        public void GetWeeksDays()
        {
            foreach (var item in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(item);
            }
        }
    }

}
