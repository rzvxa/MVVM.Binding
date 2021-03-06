﻿using System;
using UnityEngine;

namespace MVVM.Binding.Converters
{
    public class FormatStringConverter : ValueConverterBase
    {
        [SerializeField]
        string _format = "{0}";

        public override object Convert(object value, Type targetType, object parameter)
        {
            return string.Format(_format, value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter)
        {
            throw new NotImplementedException();
        }

    }
}

