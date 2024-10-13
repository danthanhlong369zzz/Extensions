namespace StringExtensions.DateTime
{
    /// <summary>
/// Common format strings used in C#
/// 
/// 1. Numeric Format Strings:
/// 
/// | Format String | Description                                       | Example                                      |
/// |---------------|---------------------------------------------------|----------------------------------------------|
/// | "C" or "c"    | Currency - Displays number with currency symbol and thousand separators. | 12345.678.ToString("C2") => "$12,345.68"    |
/// | "D" or "d"    | Decimal - Displays an integer in decimal format.  | 123.ToString("D5") => "00123"               |
/// | "E" or "e"    | Exponential - Displays number in exponential notation. | 12345.ToString("E2") => "1.23E+004"      |
/// | "F" or "f"    | Fixed-point - Displays a floating-point number with a fixed number of decimal places. | 123.4567.ToString("F2") => "123.46" |
/// | "G" or "g"    | General - Displays number in the most compact form (either fixed-point or scientific). | 12345.67.ToString("G") => "12345.67" |
/// | "N" or "n"    | Number - Displays number with thousand separators. | 1234567.89.ToString("N") => "1,234,567.89"  |
/// | "P" or "p"    | Percent - Multiplies the number by 100 and appends a percent symbol. | 0.123.ToString("P2") => "12.30%"         |
/// | "X" or "x"    | Hexadecimal - Displays an integer in hexadecimal format. | 255.ToString("X") => "FF"               |
/// 
/// 2. Date and Time Format Strings:
/// 
/// | Format String | Description                                      | Example                                      |
/// |---------------|--------------------------------------------------|----------------------------------------------|
/// | "d"           | Short date - Displays short date format.          | DateTime.Now.ToString("d") => "10/13/2024"   |
/// | "D"           | Long date - Displays long date format.            | DateTime.Now.ToString("D") => "Sunday, October 13, 2024" |
/// | "f"           | Full date short time - Displays long date and short time. | DateTime.Now.ToString("f") => "Sunday, October 13, 2024 5:43 PM" |
/// | "F"           | Full date long time - Displays long date and long time. | DateTime.Now.ToString("F") => "Sunday, October 13, 2024 5:43:10 PM" |
/// | "g"           | General date short time - Displays short date and short time. | DateTime.Now.ToString("g") => "10/13/2024 5:43 PM" |
/// | "G"           | General date long time - Displays short date and long time. | DateTime.Now.ToString("G") => "10/13/2024 5:43:10 PM" |
/// | "M" or "m"    | Month day - Displays only month and day.          | DateTime.Now.ToString("M") => "October 13"  |
/// | "O" or "o"    | Round-trip date/time - Displays date and time in round-trip format. | DateTime.Now.ToString("O") => "2024-10-13T17:43:10.0000000" |
/// | "R" or "r"    | RFC1123 date/time - Displays date and time in RFC1123 format. | DateTime.Now.ToString("R") => "Sun, 13 Oct 2024 17:43:10 GMT" |
/// | "s"           | Sortable date/time - Displays date and time in ISO8601 format. | DateTime.Now.ToString("s") => "2024-10-13T17:43:10" |
/// | "T"           | Long time - Displays long time format.            | DateTime.Now.ToString("T") => "5:43:10 PM"  |
/// | "t"           | Short time - Displays short time format.          | DateTime.Now.ToString("t") => "5:43 PM"     |
/// | "u"           | Universal sortable date/time - Displays date and time in UTC sortable format. | DateTime.Now.ToString("u") => "2024-10-13 17:43:10Z" |
/// | "U"           | Universal full date/time - Displays full date and time in UTC. | DateTime.Now.ToString("U") => "Sunday, October 13, 2024 5:43:10 PM UTC" |
/// | "Y" or "y"    | Year month - Displays only year and month.        | DateTime.Now.ToString("Y") => "October 2024" |
/// 
/// 3. Custom Format Strings for DateTime:
/// 
/// | Custom Format String | Description                               | Example                                      |
/// |----------------------|-------------------------------------------|----------------------------------------------|
/// | "yyyy"               | Full year (4 digits).                     | DateTime.Now.ToString("yyyy") => "2024"      |
/// | "MM"                 | Month (2 digits).                         | DateTime.Now.ToString("MM") => "10"          |
/// | "dd"                 | Day in month (2 digits).                  | DateTime.Now.ToString("dd") => "13"          |
/// | "HH"                 | Hour (24-hour format).                    | DateTime.Now.ToString("HH") => "17"          |
/// | "mm"                 | Minutes.                                  | DateTime.Now.ToString("mm") => "43"          |
/// | "ss"                 | Seconds.                                  | DateTime.Now.ToString("ss") => "10"          |
/// | "tt"                 | AM or PM.                                 | DateTime.Now.ToString("tt") => "PM"          |
/// 
/// 4. TimeSpan Format Strings:
/// 
/// | Format String | Description                                      | Example                                      |
/// |---------------|--------------------------------------------------|----------------------------------------------|
/// | "c"           | Standard TimeSpan format.                        | TimeSpan.FromMinutes(123).ToString("c") => "02:03:00" |
/// | "g"           | General short TimeSpan format.                   | TimeSpan.FromMinutes(123).ToString("g") => "2:03:00"   |
/// | "G"           | General long TimeSpan format.                    | TimeSpan.FromMinutes(123).ToString("G") => "0:02:03:00.0000000" |
/// 
/// </summary>

    public static class Class1
    {
        //HH:MM:SSAM
        //HH:MM:SSPM
        //12:01:00AM -> 00:01:00
        //07:45:00PM -> 19:45:00
        public static string timeConversion(string value) {
            string meridiem = value.Substring(8, 2);
            int hour = Int32.Parse(value[..2]);
            string minuteAndSecond = value.Substring(2, 6); //skip AM/PM

            if (meridiem == "pm" && hour != 12) hour += 12;
            else if(meridiem == "am" && hour == 12) hour = 0;

            return hour.ToString("D2") + minuteAndSecond;
        }
    }
}
