//
// PrivateStaticAccessor.cs
//
// Author:
//       budougumi0617 <budougumi0617@gmail.com>
//
// Copyright (c) 2017 budougumi0617
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Reflection;

namespace Testable
{
    /// <summary>
    /// PrivateStaticAccessor has extension methods to access private static fields, and execute private static methods.
    /// Each methods extend <see cref="System.Type"/> class.
    /// </summary>
    public static class PrivateStaticAccessor
    {
        /// <summary>
        /// Gets a value from a named static field, based on the name.
        /// </summary>
        /// <param name="t">The <see cref="System.Type"/> of class has private field</param>
        /// <param name="name">The name of the private field to get.</param>
        /// <returns>The value set for the name field.</returns>
        public static object GetStaticField(this Type t, string name)
        {
            var info = t.GetTypeInfo();
            var f = info.GetField(name, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.GetField);
            return f.GetValue(null);
        }

        /// <summary>
        /// Sets a value for a named static field, identified by name.
        /// </summary>
        /// <param name="t">The <see cref="System.Type"/> of class has private field</param>
        /// <param name="name">The name of the field to set a value.</param>
        /// <param name="value">The value to set.</param>
        public static void SetStaticField(this Type t, string name, Object value)
        {
            var info = t.GetTypeInfo();
            var f = info.GetField(name, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.SetField);
            f.SetValue(null, value);
        }
    }
}
