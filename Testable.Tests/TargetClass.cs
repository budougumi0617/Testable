//
// TargetClass.cs
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
namespace Testable.Tests
{
    /// <summary>
    /// Target class has many private members.
    /// </summary>
    public class TargetClass
    {
        public const int DefaultInt = 3;
        public const string DefaultString = "Default";

        public int publicInt;
        int privateInt;
        static int privateStaticInt = DefaultInt;
        string privateString;
        static string privateStaticString = DefaultString;

        public TargetClass()
        {
            publicInt = DefaultInt;
            privateInt = DefaultInt;
            privateString = DefaultString;
        }

        int privateAddOne(int i){
            return i + 1;
        }

        public int MyIntProperty
        {
            get
            {
                return privateInt;
            }
        }

        public string MyStringProperty
        {
            get
            {
                return privateString;
            }
        }

        int addOne(int n)
        {
            return n + 1;
        }

        int addOne()
        {
            return 1;
        }

        static string throughString(string s)
        {
            return s;
        }

        public static void SetPrivateStaticInt()
        {
            privateStaticInt = DefaultInt;
        }

        public static string StaticStringProperty
        {
            get
            {
                return privateStaticString;
            }
            set
            {
                privateStaticString = value;
            }
        }
    }
}
