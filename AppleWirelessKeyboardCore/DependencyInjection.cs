using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using AppleWirelessKeyboardCore.Keyboard;
using System.IO;

namespace AppleWirelessKeyboardCore
{
    public static class DependencyInjection
    {
        static DependencyInjection()
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            Service = catalog.CreateCompositionService();
            Container = new CompositionContainer(catalog);
        }

        public static CompositionContainer Container { get; set; }
        public static CompositionService Service { get; set; }

        public static void Inject(this object o)
        {
            Service.SatisfyImportsOnce(o);
        }
    }

    public static class DependencyInjectionExports
    {
        [Export]
        public static Profile Profile
        {
            get
            {
                return new Profile(AppleWirelessKeyboard.Properties.Settings.Default.Profile);
            }
        }
    }
}
