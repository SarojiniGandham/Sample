using System;
using System.Globalization;
using Xamarin.Forms;
namespace SampleApp.Converters
{
    public class TabTextColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var currentActiveTab = (int)value;
            var currentTab = int.Parse(parameter.ToString());
            return (currentActiveTab == currentTab) ? (Xamarin.Forms.Color)Application.Current.Resources["TabsCurrentColor"] : (Xamarin.Forms.Color)Application.Current.Resources["BlackColor"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
