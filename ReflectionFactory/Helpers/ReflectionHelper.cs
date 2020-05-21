using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionFactory.Helpers
{
    internal static class ReflectionHelper
    {
        /// <see cref="https://stackoverflow.com/questions/5411694/get-all-inherited-classes-of-an-abstract-class"/>
        internal static IEnumerable<Type> GetDerivedClasses<T>() where T : class =>
            Assembly.GetAssembly(typeof(T))
                .GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)));
    }
}