namespace ProgressTaskTwo
{
    using System;
    using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.UtcNow;
            DateTime timeSec = new DateTime(2015, 2, 12);
            DateTime timeThir = new DateTime(209, 2, 12, 7, 12, 10);

            var date = DateConvertions(time);
            var dateSec = DateConvertions(timeSec);
            var dateThir = DateConvertions(timeThir);

            Console.WriteLine(date);
            Console.WriteLine(dateSec);
            Console.WriteLine(dateThir);
        }

        private static string DateConvertions(DateTime time)
        {
            return time.ToString("yyyy-MM-dd");
        }

    }
        

   
}
