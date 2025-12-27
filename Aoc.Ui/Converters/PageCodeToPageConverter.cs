using Aoc.Ui.Enums;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Aoc.Ui.Converters
{
    public class PageCodeToPageConverter : IValueConverter
    {
        public required Page LandingPage { get; set; }

        public required Page Year2024Day1Page { get; set; }

        public required Page Year2025Day1Page { get; set; }
        public required Page Year2025Day2Page { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(object))
                throw new ArgumentException("The target type must be a page.", nameof(targetType));

            if (value is null)
                return LandingPage;

            if (value is not PageCode pageCode)
                throw new ArgumentException("The value must be a page code enum representing the selected page.", nameof(value));

            switch (pageCode)
            {
                case PageCode.LandingPage:
                    return LandingPage;

                case PageCode.Year2024Day1:
                    return Year2024Day1Page;

                case PageCode.Year2025Day1:
                    return Year2025Day1Page;
                case PageCode.Year2025Day2:
                    return Year2025Day2Page;
                default:
                    throw new ArgumentException("The provided page code does not have an associated page.", nameof(value));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException("Converting back to a boolean value from a page instance is not supported.");
    }
}
