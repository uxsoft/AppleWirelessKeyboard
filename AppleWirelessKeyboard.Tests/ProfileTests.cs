using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppleWirelessKeyboard.Keyboard;

namespace AppleWirelessKeyboard.Tests
{
    [TestClass]
    public class ProfileTests
    {
        [TestMethod]
        public void Serialization()
        {
            Profile p = new Profile();
            p.Add(new KeyBinding()
            {
                Key = System.Windows.Input.Key.F1,
                Module = "F1Module"
            });
            p.Add(new KeyBinding()
            {
                Key = System.Windows.Input.Key.Execute,
                Module = "asdasasd",
                Ctrl = true,
                Fn = false
            });

            string serialized = p.ToString();
            Assert.IsFalse(string.IsNullOrWhiteSpace(serialized));

            Profile p2 = new Profile(serialized);
            Assert.AreEqual(p.Count, p2.Count);
            Assert.IsTrue(p2.ToString() == p.ToString());

            new Profile("");
            new Profile("asdadasd isiffapj");
        }
    }
}
