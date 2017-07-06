using System;
namespace Testable
{
	/// <summary>
	/// Test Utility class like a Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject.
	/// </summary>
	/// <seealso cref="https://msdn.microsoft.com/ja-jp/library/microsoft.visualstudio.testtools.unittesting.privateobject.aspx"/>
	public class PrivateObject
    {
		/// <summary>
		/// Initializes a new instance of the PrivateObject class that creates the wrapper for the specified object.
		/// </summary>
		/// <param name="obj">The object to wrap.</param>
		public PrivateObject(Object obj)
        {
            
        }

		/// <summary>
		/// Gets a value from a named field, based on the name.
		/// </summary>
		/// <param name="name">The name of the private field to get.</param>
		/// <returns>The value set for the name field.</returns>
		public object GetField(string name){
            return null;
        }
    }
}
