using System;
using System.Globalization;
using Xamarin.Forms;

namespace SampleApp.Converters
{
    public class TabBackgroundFrameColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var currentActiveTab = (int)value;
            var currentTab = int.Parse(parameter.ToString());
            return (currentActiveTab == currentTab) ? (Color)Application.Current.Resources["LightVioletColor"] : Color.Transparent;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
