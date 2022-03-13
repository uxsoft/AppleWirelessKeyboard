using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using AppleWirelessKeyboardCore.ControlInterfaces;
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

            var collectionView = new ListCollectionView(Modules
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

        [ImportMany] IEnumerable<Lazy<Action<KeyboardEvent>, IFunctionalityModuleExportMetadata>> Modules { get; set; } = null!;

        void cmbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbLanguage.SelectedValue is string value)
                SettingsService.Default.ActiveLanguage = Enum.Parse<Language>(value);
        }

        void cmbLanguage_Loaded(object sender, RoutedEventArgs e)
        {
            cmbLanguage.ItemsSource = Enum.GetValues(typeof(Language));
            cmbLanguage.SelectedItem = SettingsService.Default.ActiveLanguage;
        }

        async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            grdBindings.CancelEdit();
            await SettingsService.Default.SaveAsync();
            StartupShortcutService.Check();
        }

        void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            if (grdBindings.SelectedItem is Keyboard.KeyBinding binding)
            {
                SettingsService.Default.KeyBindings.Remove(binding);
                CollectionViewSource.GetDefaultView(grdBindings.ItemsSource).Refresh();
            }
        }

        async void btnFactoryReset_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure you want to replace your key bindings to the defaults?", "Reset Bindings", MessageBoxButton.YesNo))
            {
                SettingsService.Default.KeyBindings.Clear();
                SettingsService.Default.KeyBindings.Add(new()
                {
                    Key = Key.F13,
                    Module = nameof(PowerControl.ToggleFMode)
                });
                SettingsService.Default.KeyBindings.Add(new()
                {
                    Key = Key.F12,
                    Module = nameof(VolumeControl.VolumeUp)
                });
                SettingsService.Default.KeyBindings.Add(new()
                {
                    Key = Key.F11,
                    Module = nameof(VolumeControl.VolumeDown)
                });
                SettingsService.Default.KeyBindings.Add(new()
                {
                    Key = Key.F10,
                    Module = nameof(VolumeControl.VolumeMute)
                });
               
                await SettingsService.Default.SaveAsync();
            }
        }
    }
}
