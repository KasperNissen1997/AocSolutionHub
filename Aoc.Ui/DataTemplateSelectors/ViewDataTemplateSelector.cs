using System.Windows;
using System.Windows.Controls;

namespace Aoc.Ui.DataTemplateSelectors
{
    public class ViewDataTemplateSelector : DataTemplateSelector
    {
        public required DataTemplate Year2024Day1Template { get; set; }

        public required DataTemplate Year2025Day1Template { get; set; }
        public required DataTemplate Year2025Day2Template { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            // Null values can be passed by the designer.
            if (item is null)
                return null!;

            // If it isn't a string we receive, we can't handle it.
            if (item is not string dateCode)
                return null!;

            return dateCode switch
            {
                "2024.1" => Year2024Day1Template,
                "2025.1" => Year2025Day1Template,
                "2025.2" => Year2025Day2Template,
                _ => null!,
            };
        }
    }
}
