using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppleWirelessKeyboard.Keyboard
{
    [PartCreationPolicy(System.ComponentModel.Composition.CreationPolicy.Shared)]
    public class Profile : List<KeyBinding>
    {
        public Profile()
        {

        }
        public Profile(string source)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(source))
                    return;

                XmlSerializer serializer = new XmlSerializer(typeof(Profile));
                StringReader sr = new StringReader(source);
                Profile p = serializer.Deserialize(sr) as Profile;

                if (p != null)
                    foreach (KeyBinding k in p)
                        Add(k);
            }
            catch (Exception ex) {
                App.Log.Log("Error loading profile", ex);
            }
        }

        public override string ToString()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Profile));
            StringWriter sb = new StringWriter();
            serializer.Serialize(sb, this);
            return sb.ToString();
        }
    }
}
