using System.Globalization;

public static class DateOnlyExtensions
{
    // 15/01/1996
    public static string ToUkFormat(this DateOnly date) =>
        date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

    // 15 January 1996
    public static string ToUkLongFormat(this DateOnly date) =>
        date.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("en-GB"));

    // 15 Jan 1996
    public static string ToUkShortFormat(this DateOnly date) =>
        date.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("en-GB"));

    // 1996-01-15
    public static string ToIsoFormat(this DateOnly date) =>
        date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

    // 01/15/1996
    public static string ToUsFormat(this DateOnly date) =>
        date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

    // January 15, 1996
    public static string ToUsLongFormat(this DateOnly date) =>
        date.ToString("MMMM dd, yyyy", CultureInfo.GetCultureInfo("en-US"));

    // 15.01.1996
    public static string ToEuropeanFormat(this DateOnly date) =>
        date.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
}
