using System;
using Spring.Context;
using Spring.Context.Support;

namespace Core
{
    public class ObjectFactory
    {

        public static IApplicationContext GetApplicationContext()
        {
            return ContextRegistry.GetContext();
        }

        public static object GetObject(string objectName)
        {
            return GetApplicationContext()[objectName];
        }

    }
}