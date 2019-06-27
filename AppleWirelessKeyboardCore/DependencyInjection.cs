using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

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
}
