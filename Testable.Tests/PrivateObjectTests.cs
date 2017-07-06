﻿//
// PrivateObjectTests.cs
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
using Xunit;
namespace Testable.Tests
{
    public class PrivateObjectTests
    {
        PrivateObject po;

        public PrivateObjectTests()
        {
            Object obj = new TargetClass() as Object;
            po = new PrivateObject(obj);
        }

        [Fact]//(DisplayName = "Able to get private field of primitive type.")]
        public void GetPrivatePrimitiveInt()
        {
            var ac = Convert.ToInt32(po.GetField("privateInt"));
            Assert.Equal(TargetClass.DefaultInt, ac);
        }

        [Fact]//(DisplayName = "Able to get private field of primitive type.")]
		public void GetPrivatePrimitiveString()
		{
            var ac = Convert.ToString(po.GetField("privateString"));
            Assert.Equal(TargetClass.DefaultString, ac);
		}
    }
}
