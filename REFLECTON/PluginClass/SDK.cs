using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDK
{
    public class Plug
    {
        public string pName;
        public string pFName;
        public string pPath;
    }

    public interface IPlugin
    {
        string Action(string text);
        string Name();
    }

    public class Kit
    {
        public static List<Plug> GetAllPlugins(string path)
        {
            List<Plug> MyPlugins = new List<Plug>();
            if (Directory.Exists(path))
            {
                return MyPlugins;
            }
            string[] dlls = Directory.GetFiles(path, "*.dll");
            foreach (var dll in dlls)
            {
                Assembly asm = Assembly.LoadFile(dll);
                Type[] tipler = asm.GetTypes();

                foreach (Type tip in tipler)
                {
                    if (tip.GetInterface("IPlugin")!=null)
                    {
                        Plug myP = new Plug();
                        myP.pFName = tip.FullName;
                        myP.pPath = path + dll;

                        object obj = asm.CreateInstance(tip.FullName);
                        myP.pName = obj.GetType().InvokeMember("name", BindingFlags.InvokeMethod,null, obj, null).ToString();
                        MyPlugins.Add(myP);
                    }
                }                
            }
            return MyPlugins;
        }

        public static object CreateP(Plug p)
        {
            Assembly asm = Assembly.LoadFile(p.pPath);
            object obj = asm.CreateInstance(p.pFName);
            return obj;
        }
    }
}
