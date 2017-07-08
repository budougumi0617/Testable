using System;
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
            var f = info.GetField(name, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField);
            f.SetValue(target, value);
		}
    }
}
