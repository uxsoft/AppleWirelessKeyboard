using AppleWirelessKeyboard.Keyboard;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppleWirelessKeyboard.Views
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {

        private class Item
        {
            public string Name { get; set; }
            public string Module { get; set; }
            public string Category { get; set; }
        }

        public Configuration()
        {
            InitializeComponent();
            this.Inject();

            grdBindings.ItemsSource = App.Keyboard.Profile;
            clmnKey.ItemsSource = Enum.GetValues(typeof(Key));

            ListCollectionView collectionView = new ListCollectionView(Modules
                .OrderBy(l => l.Metadata.Name)
                .Select(l => new Item
                {
                    Module = l.Metadata.Name,
                    Name = Properties.Resources.ResourceManager.GetString(l.Metadata.Name, System.Threading.Thread.CurrentThread.CurrentUICulture) ?? l.Metadata.Name,
                    Category = l.Metadata.Category
                }).ToList());
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Category"));
            clmnModule.ItemsSource = collectionView;
        }

        [ImportMany]
        private IEnumerable<Lazy<Action<KeyboardEvent>, IFunctionalityModuleExportMetadata>> Modules { get; set; }

        private void cmbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = cmbLanguage.SelectedValue as CultureInfo;
            Properties.Settings.Default.Language = (cmbLanguage.SelectedValue as CultureInfo).ToString();
        }

        private void cmbLanguage_Loaded(object sender, RoutedEventArgs e)
        {
            cmbLanguage.ItemsSource = SupportedLanguages();
            cmbLanguage.SelectedItem = new CultureInfo(Properties.Settings.Default.Language);
        }

        private IEnumerable<CultureInfo> SupportedLanguages()
        {
            yield return new CultureInfo("en");
            yield return new CultureInfo("cs");
            yield return new CultureInfo("de");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            grdBindings.CancelEdit();
            Properties.Settings.Default.Save();
            StartupShortcut.Check();
        }

        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            if (grdBindings.SelectedItem != null)
            {
                App.Keyboard.Profile.Remove(grdBindings.SelectedItem as Keyboard.KeyBinding);
                CollectionViewSource.GetDefaultView(grdBindings.ItemsSource).Refresh();
            }
        }
    }
}
