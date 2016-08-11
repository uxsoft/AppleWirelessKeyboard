using AppleWirelessKeyboard.ControlInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppleWirelessKeyboard.Tests
{
    [TestClass]
    public class KeyboardControlFilterTests
    {
        [TestMethod]
        public void ExpectTests()
        {
            KeyboardControlFilter filter = new KeyboardControlFilter();

            filter.Expect(Key.A, true);
            Assert.IsFalse(filter.Key(Key.A, true));
            filter.Expect(Key.A, false);
            Assert.IsTrue(filter.Key(Key.A, true));
            Assert.IsFalse(filter.Key(Key.A, false));

            filter.Expect(Key.LeftCtrl, true);
            filter.Expect(Key.LeftCtrl, false);
            Assert.IsFalse(filter.Key(Key.LeftCtrl, true));
            Assert.IsFalse(filter.Ctrl(true));
            Assert.IsTrue(filter.Key(Key.LeftCtrl, true));
            Assert.IsTrue(filter.Ctrl(true));

        }
    }
}
