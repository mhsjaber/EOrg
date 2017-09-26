using System;

namespace EOrg.Web.Utility
{
    public class DateTimeToString
    {
        public static string ToFullMonthDateYear(DateTime date)
        {
            return date.ToString("MMMM dd, yyyy");
        }

        public static string ToShortMonthDateYear(DateTime date)
        {
            return date.ToString("MMM dd, yyyy");
        }
    }
}