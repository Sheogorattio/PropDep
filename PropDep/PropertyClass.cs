using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PropDep
{
    internal class PropertyClass : FrameworkElement
    {
        public static DependencyProperty DataProperty;

        static PropertyClass()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(PropertyClass));
        }

        public int Data
        {
            get { 
                return getDoubleValue((int)GetValue(DataProperty));
            }
            set { SetValue(DataProperty, value); }
        }

        int getDoubleValue(int value)
        {
            return value * 2;
        }

    }
}
