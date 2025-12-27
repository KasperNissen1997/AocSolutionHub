using Aoc.Ui.Enums;
using System.Globalization;
using System.Windows.Data;

namespace Aoc.Ui.Converters
{
    public class PageCodeToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new ArgumentException("The target type must be a boolean.", nameof(targetType));

            // This can be null if no page is selected.
            if (value is null)
                return false;

            if (value is not PageCode pageCode)
                throw new ArgumentException("The value must be a page code enum representing the selected page.", nameof(value));

            // We need the parameter, as it is used to specify which part of the treeview this converter is being used on.
            // This value represents the page code associated with the calling treeview item.
            if (parameter is not PageCode associatedPageCode)
                throw new ArgumentException("The parameter must be page code enum associated with the calling treeview item.", nameof(parameter));

            return pageCode == associatedPageCode;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(PageCode?))
                throw new ArgumentException("The target type must be a page code enum.", nameof(targetType));

            if (value is not bool isSelected)
                throw new ArgumentException("The value must be a boolean indicating the selection state.", nameof(value));

            if (parameter is not PageCode associatedPageCode)
                throw new ArgumentException("The parameter must be a page code enum associated with the calling treeview item.", nameof(parameter));

            return isSelected ? associatedPageCode : Constants.DefaultPageCode;
        }
    }
}
