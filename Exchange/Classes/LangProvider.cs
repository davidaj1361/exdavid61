using HandyControl.Properties.Langs;
using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Exchange.Classes
{
    public class LangProvider :INotifyPropertyChanged
    {
        internal static LangProvider Instance => ResourceHelper.GetResource<LangProvider>("");

        private static string CultureInfoStr;

        public static CultureInfo Culture
        {
            get => Lang.Culture;
            set
            {
                if (value == null) return;
                if (Equals(CultureInfoStr, value.EnglishName)) return;
                Lang.Culture = value;
                CultureInfoStr = value.EnglishName;

                Instance.UpdateLangs();
            }
        }

        public static string GetLang(string key) => Lang.ResourceManager.GetString(key, Culture);

        public static void SetLang(DependencyObject dependencyObject, DependencyProperty dependencyProperty, string key) =>
            BindingOperations.SetBinding(dependencyObject, dependencyProperty, new Binding(key)
            {
                Source = Instance,
                Mode = BindingMode.OneWay
            });

        private void UpdateLangs()
        {
           // OnPropertyChanged(nameof(About));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

       // public string About => Lang.About;
    }
    public class LangKeys
    {
        public static string About = nameof(About);
    }
}

