﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace SQLiteWpfApp.Views.Converters
{
    public class InverseIntToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (int)value > 0 ? false : true;

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture) => (bool)value ? 0 : 1;
    }
}