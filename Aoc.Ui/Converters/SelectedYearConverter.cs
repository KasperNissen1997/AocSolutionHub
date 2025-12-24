using System.Globalization;
using System.Windows.Data;

namespace Aoc.Ui.Converters
{
    public class SelectedYearConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new ArgumentException("Target type must be a boolean.", nameof(targetType));

            if (value is not int selectedYear)
                throw new ArgumentException("Value must be an integer representing the selected year.", nameof(value));

            // We expect a string here instead of an int, because of XAML limitations with binding parameters.
            if (parameter is not string currentYearString)
                throw new ArgumentException("Parameter must be an string representing the current year.", nameof(parameter));

            if (!int.TryParse(currentYearString, out int currentYear))
                throw new ArgumentException("Parameter string must be convertible to an integer representing the current year.", nameof(parameter));

            return selectedYear == currentYear;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(int))
                throw new ArgumentException("Target type must be an integer.", nameof(targetType));

            if (value is not bool isSelected)
                throw new ArgumentException("Value must be a boolean indicating selection state.", nameof(value));

            // We expect a string here instead of an int, because of XAML limitations with binding parameters.
            if (parameter is not string currentYearString)
                throw new ArgumentException("Parameter must be an string representing the current year.", nameof(parameter));

            if (!int.TryParse(currentYearString, out int currentYear))
                throw new ArgumentException("Parameter string must be convertible to an integer representing the current year.", nameof(parameter));

            return isSelected ? currentYear : Constants.DEFAULT_YEAR;
        }
    }
}
