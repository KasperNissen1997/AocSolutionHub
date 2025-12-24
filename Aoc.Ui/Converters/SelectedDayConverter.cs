using System.Globalization;
using System.Windows.Data;

namespace Aoc.Ui.Converters
{
    public class SelectedDayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new ArgumentException("Target type must be a boolean.", nameof(targetType));

            if (value is not int selectedDay)
                throw new ArgumentException("Value must be an integer representing the selected day.", nameof(value));

            // We expect a string here instead of an int, because of XAML limitations with binding parameters.
            if (parameter is not string currentDayString)
                throw new ArgumentException("Parameter must be an string representing the current day.", nameof(parameter));

            if (!int.TryParse(currentDayString, out int currentDay))
                throw new ArgumentException("Parameter string must be convertible to an integer representing the current day.", nameof(parameter));

            return selectedDay == currentDay;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(int))
                throw new ArgumentException("Target type must be an integer.", nameof(targetType));

            if (value is not bool isSelected)
                throw new ArgumentException("Value must be a boolean indicating selection state.", nameof(value));

            // We expect a string here instead of an int, because of XAML limitations with binding parameters.
            if (parameter is not string currentDay)
                throw new ArgumentException("Parameter must be an string representing the current day.", nameof(parameter));

            if (!int.TryParse(currentDay, out int currentDayInt))
                throw new ArgumentException("Parameter string must be convertible to an integer representing the current day.", nameof(parameter));

            return isSelected ? currentDay : Constants.DEFAULT_DAY;
        }
    }
}
