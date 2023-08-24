using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Barcode;
using Telerik.Windows.Controls;

namespace ThemingControl {
    public class ThemingViewModel : ViewModelBase, INotifyPropertyChanged {

        //=============================================
        // FIELDS
        //=============================================
        private readonly DelegateCommand<string> _chooseThemeCommand;


        //=============================================
        // CONSTRUCTORS
        //=============================================

        public ThemingViewModel() {
            _chooseThemeCommand = new DelegateCommand<string>((s) => { this.ChooseThemeExecute(); });

            foreach (var contact in source.GetContacts())
            {
                ContactsList.Add(contact);
            }
        }

        private ThemeInfo _currentThemeInfo;
        public ThemeInfo CurrentThemeInfo {
            get
            {
                return _currentThemeInfo;
            }
            set
            {
                if (value != _currentThemeInfo)
                {
                    _currentThemeInfo = value;
                }
                OnPropertyChanged(nameof(CurrentThemeInfo));
            }
        }

        //=============================================
        // PROPERTIES
        //=============================================
        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand<string> ChooseThemeCommand {
            get { return _chooseThemeCommand; }
        }

        private ObservableCollection<ThemeInfo> _themes;
        public ObservableCollection<ThemeInfo> Themes {
            get
            {
                if (this._themes is null || this._themes.Count == 0)
                {
                    this._themes = new ObservableCollection<ThemeInfo>();
                    //this._themes.Add(new ThemeInfo("Windows11Compact", "Windows11 Compact", "#FFFFFFFF", "#FFEBEBEB", "#FF0078D4"));
                    //this._themes.Add(new ThemeInfo("Windows11Compact_Dark", "Windows11 Compact Dark", "#FF404040", "#FF262626", "#FF60CDFF"));
                    this._themes.Add(new ThemeInfo("Windows11", "Windows11", "#FFFFFFFF", "#FFEBEBEB", "#FF0078D4"));
                    //this._themes.Add(new ThemeInfo("Windows11_Dark", "Windows11 Dark", "#FF404040", "#FF262626", "#FF60CDFF"));
                    //this._themes.Add(new ThemeInfo("Office2019_HighContrast", "Office2019 HighContrast", "#FF1AEBFF", "#FF000000", "#FFFFFF01"));
                    this._themes.Add(new ThemeInfo("Office2019", "Office2019", "#FF106EBE", "#FFF1F1F1", "#FF2F96ED"));
                    //this._themes.Add(new ThemeInfo("Office2019_Gray", "Office2019 Gray", "#FF106EBE", "#FFCBCBCB", "#FF2F96ED"));
                    //this._themes.Add(new ThemeInfo("Office2019_Dark", "Office2019 Dark", "#FF106EBE", "#FF3C3C3C", "#FF2F96ED"));
                    this._themes.Add(new ThemeInfo("VisualStudio2019", "VisualStudio2019", "#F5CC84", "#F7F9FE", "#AAC0FF"));
                    //this._themes.Add(new ThemeInfo("VisualStudio2019_Dark", "VisualStudio2019 Dark", "#007ACC", "#1B1B1C", "#3399FF"));
                    //this._themes.Add(new ThemeInfo("Crystal_Light", "Crystal Light", "#FF1C83FF", "#FFCDCDCD", "#FF0060CF"));
                    //this._themes.Add(new ThemeInfo("Crystal_Dark", "Crystal Dark", "#FF1C83FF", "#FF3A3A3A", "#FF0060CF"));
                    //this._themes.Add(new ThemeInfo("Fluent_Light", "Fluent Light", "#0099bc", "#e6e6e6", "#15d7ff"));
                    //this._themes.Add(new ThemeInfo("Fluent_Dark", "Fluent Dark", "#0099bc", "#2b2b2b", "#15d7ff"));
                    this._themes.Add(new ThemeInfo("Material", "Material", "#3F51B5", "#E0E0E0", "#FFAB40"));
                    //this._themes.Add(new ThemeInfo("Material_Dark", "Material Dark", "#7986CB", "#171717", "#00ACC1"));
                    this._themes.Add(new ThemeInfo("Office2016Touch", "Office2016 Touch", "#2A579A", "#88C3FF", "#3E6DB6"));
                    this._themes.Add(new ThemeInfo("Office2016", "Office2016", "#3E6DB6", "#E8A800", "#2B7402"));
                    //this._themes.Add(new ThemeInfo("Green_Light", "Green Light", "#4fa520", "#e0e0e0", "#8ebc00"));
                    //this._themes.Add(new ThemeInfo("Green_Dark", "Green Dark", "#2b7402", "#2b2c2e", "#8ebc00"));
                    this._themes.Add(new ThemeInfo("VisualStudio2013", "VisualStudio2013", "#3399ff", "#eeeef2", "#c9def5"));
                    //this._themes.Add(new ThemeInfo("VisualStudio2013_Dark", "VisualStudio2013 Dark", "#3399ff", "#2d2d30", "#3e3e40"));
                    //this._themes.Add(new ThemeInfo("VisualStudio2013_Blue", "VisualStudio2013 Blue", "#3399ff", "#e6ebf5", "#fdf4bf"));
                    this._themes.Add(new ThemeInfo("Office2013", "Office2013", "#0072c6", "#f9f9f9", "#cce3f4"));
                    //this._themes.Add(new ThemeInfo("Office2013_LightGray", "Office2013 LightGray", "#0072c6", "#f1f1f1", "#cce3f4"));
                    //this._themes.Add(new ThemeInfo("Office2013_DarkGray", "Office2013 DarkGray", "#444444", "#e5e5e5", "#cce3f4"));
                    this._themes.Add(new ThemeInfo("Windows8Touch", "Windows8 Touch", "#26a0da", "#d6d4d4", "#ffffff"));
                    this._themes.Add(new ThemeInfo("Windows8", "Windows8", "#25a0da", "#cccccc", "#f9f9f9"));
                    this._themes.Add(new ThemeInfo("Expression_Dark", "Expression Dark", "#2d2e32", "#565656", "#6c6c6c"));
                    this._themes.Add(new ThemeInfo("Windows7", "Windows7", "#c0dafb", "#d9e3f2", "#edf2fb"));
                    this._themes.Add(new ThemeInfo("Transparent", "Transparent", "#e8e8e8", "#f6f6f6", "#ffffff"));
                    this._themes.Add(new ThemeInfo("Vista", "Vista", "#b7e4fc", "#256889", "#d5eefb"));
                    this._themes.Add(new ThemeInfo("Summer", "Summer", "#0e7193", "#80bed3", "#c2dae3"));
                    this._themes.Add(new ThemeInfo("Office_Silver", "Office Silver", "#b2b7ca", "#d3d5e1", "#fcd2a7"));
                    this._themes.Add(new ThemeInfo("Office_Blue", "Office Blue", "#adcaef", "#d0e6fe", "#fcd2a7"));
                    this._themes.Add(new ThemeInfo("Office_Black", "Office Black", "#141414", "#585858", "#fcd2a7"));
                }
                return this._themes;
            }
        }

        Data source = new Data();

        private ObservableCollection<Contact> _contactsList = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> ContactsList {
            get
            {
                return this._contactsList;
            }
        }

        //=============================================
        // METHODS
        //=============================================
        private void OnPropertyChanged(string property) {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void ChooseThemeExecute() {
            string selectedThemeName = CurrentThemeInfo.ThemeName;

            try
            {
                Application.Current.Resources.MergedDictionaries.Clear();

                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.Input.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes." + selectedThemeName + ";component/Themes/Telerik.Windows.Controls.GridView.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Spreadsheet.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.SpreadsheetUI.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.SyntaxEditor.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.VirtualGrid.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Chart.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Data.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.DataVisualization.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.ImageEditor.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.RibbonView.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.FileDialogs.xaml ", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Pivot.xaml", UriKind.RelativeOrAbsolute)
                });
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.RichTextBox.xaml", UriKind.RelativeOrAbsolute)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing theme. " + ex.Message);
            }

            // testing using theme palette objects
            //    //Office2019Palette.LoadPreset(Office2019Palette.ColorVariation.Gray);
            //    //this.Background = new SolidColorBrush() { Color = Office2019Palette.Palette.BaseBackgroundColor };
            //    //this.ThemesList.Background = this.Background;


            //    //Windows11Palette.LoadPreset(Windows11Palette.ColorVariation.Dark);
            //    //this.Background = new SolidColorBrush() { Color = Colors.Black };
            //    //this.ThemesList.Background = this.Background;
        }
    }
}
