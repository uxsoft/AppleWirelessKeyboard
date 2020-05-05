using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using AppleWirelessKeyboardCore.Keyboard;
using AppleWirelessKeyboardCore.Services;

namespace AppleWirelessKeyboardCore.Views
{
    public partial class Configuration : Window
    {
        public Configuration()
        {
            InitializeComponent();
            this.Inject();

            grdBindings.ItemsSource = SettingsService.Default.KeyBindings;
            clmnKey.ItemsSource = Enum.GetValues(typeof(Key));

            ListCollectionView collectionView = new ListCollectionView(Modules
                .OrderBy(l => l.Metadata.Name)
                .Select(l => new
                {
                    Module = l.Metadata.Name,
                    Name = TranslationService.Default.Get(l.Metadata.Name) ?? l.Metadata.Name,
                    Category = l.Metadata.Category
                }).ToList());
            collectionView.GroupDescriptions.Add(new PropertyGroupDescription("Category"));
            clmnModule.ItemsSource = collectionView;
        }

        [ImportMany]
        private IEnumerable<Lazy<Action<KeyboardEvent>, IFunctionalityModuleExportMetadata>> Modules { get; set; } = null!;

        private void cmbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbLanguage.SelectedValue is string value)
                SettingsService.Default.ActiveLanguage = Enum.Parse<Language>(value);
        }

        private void cmbLanguage_Loaded(object sender, RoutedEventArgs e)
        {
            cmbLanguage.ItemsSource = Enum.GetValues(typeof(Language));
            cmbLanguage.SelectedItem = SettingsService.Default.ActiveLanguage;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            grdBindings.CancelEdit();
            SettingsService.Default.Save();
            StartupShortcutService.Check();
        }

        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            if (grdBindings.SelectedItem is Keyboard.KeyBinding binding)
            {
                SettingsService.Default.KeyBindings.Remove(binding);
                CollectionViewSource.GetDefaultView(grdBindings.ItemsSource).Refresh();
            }
        }
    }
}
