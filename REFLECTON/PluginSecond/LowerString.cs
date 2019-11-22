using SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSecond
{
    public class LowerString : IPlugin
    {
        public string Action(string text)
        {
            return text.ToLower();
        }

        public string Name()
        {
            return "Küçük Harf";
        }
    }
}
