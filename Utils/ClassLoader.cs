using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Inventory.Utils
{
    class ClassLoader
    {
        public static Type LoadByName(String AssemblyName, String ClassName)
        {
            try
            {
                Assembly assembly = Assembly.Load(AssemblyName);
                return assembly.GetType(ClassName);
            }
            catch (Exception e)
            {
                //log error
            }
            return null;
        }
    }
}
