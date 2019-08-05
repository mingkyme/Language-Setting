using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Language_Setting
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceSet resourceSet = null;
            

            switch ((sender as MenuItem).Header)
            {
                case "ko-KR":
                    resourceSet = Language_Setting.Languages.ko_KR.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                    break;
                case "en-US":
                    resourceSet = Language_Setting.Languages.en_US.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
                    break;
            }
            foreach (DictionaryEntry entry in resourceSet)
            {
                Properties.Language.Default[entry.Key.ToString()] = entry.Value.ToString();
            }
            Properties.Language.Default.Save();
        }
    }
}
