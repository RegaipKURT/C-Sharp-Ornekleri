using SDK;

namespace PluginFirst
{
    public class BiggerString : IPlugin
    {
        public string Action(string text) => text.ToUpper();

        public string Name()
        {
            return "Büyük Harf";
        }
    }
}
