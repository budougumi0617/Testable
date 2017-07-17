using System;
using System.Linq;
using System.Reflection;
namespace Testable
{
    /// <summary>
    /// Test Utility class like a Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject.
    /// </summary>
    /// <seealso cref="https://msdn.microsoft.com/ja-jp/library/microsoft.visualstudio.testtools.unittesting.privateobject.aspx"/>
    public class PrivateObject
    {
        Object target;
        /// <summary>
        /// Initializes a new instance of the PrivateObject class that creates the wrapper for the specified object.
        /// </summary>
        /// <param name="obj">The object to wrap.</param>
        public PrivateObject(Object obj)
        {
            target = obj;
        }

        /// <summary>
        /// Gets a value from a named field, based on the name.
        /// </summary>
        /// <param name="name">The name of the private field to get.</param>
        /// <returns>The value set for the name field.</returns>
        public object GetField(string name)
        {
            var info = target.GetType().GetTypeInfo();
            var f = info.GetField(name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField);
            return f.GetValue(target);
        }

        /// <summary>
        /// Sets a value for the field of the wrapped object, identified by name.
        /// </summary>
        /// <param name="name">The name of the field to set a value.</param>
        /// <param name="value">The value to set.</param>
        public void SetField(string name, Object value)
        {
            var info = target.GetType().GetTypeInfo();
            var f = info.GetField(name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField);
            f.SetValue(target, value);
        }

        /// <summary>
        /// Execut methods of the private object.
        /// </summary>
        /// <returns>The invoke.</returns>
        /// <param name="name">The name of the method.</param>
        /// <param name="argTypes">
        /// An array of Type objects that represents the number, order, and type of the parameters for the method to access.
        /// -or-
        /// An empty array of the type Type(that is, Type[] types = new Type[0]) to get a method that takes no parameters.
        /// </param>
        /// <param name="args">Any arguments that the member requires.</param>
        public Object Invoke(string name, Type[] argTypes, Object[] args)
        {
            // TODO Need to validate argTypes, args are samg length.
            var info = target.GetType().GetTypeInfo();
            var members = info.GetMember(name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod);

            foreach (var memberInfo in members)
            {
                if (memberInfo.MemberType != MemberTypes.Method)
                {
                    continue;
                }
                var mi = memberInfo as MethodInfo;
                var parms = mi.GetParameters();
                if (argTypes == null || args.Length == 0 && parms.Length == 0)
                {
                    return mi.Invoke(target, new Object[0]);
                }
                if (parms.Length == argTypes.Length
                   && parms.Select(p => p.ParameterType).SequenceEqual(argTypes))
                {
                    return mi.Invoke(target, args);
                }
            }
            throw new InvalidOperationException("Cannot find method.");
        }
    }
}
