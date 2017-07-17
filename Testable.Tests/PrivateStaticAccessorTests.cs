//
// PrivateStaticAccessorTests.cs
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
    public class PrivateStaticAccessorTests
    {
        public PrivateStaticAccessorTests()
        {
            TargetClass.SetPrivateStaticInt();
            TargetClass.StaticStringProperty = TargetClass.DefaultString;
        }

        [Fact]
        public void GetPrivateStaticStringTest()
        {
            var actual = typeof(TargetClass).GetStaticField("privateStaticString") as string;
            Assert.Equal(TargetClass.DefaultString, actual);
        }

        [Fact]
        public void SetPrivateStaticStringTest()
        {
            var expected = "SetPrivateStaticStringTest";
            typeof(TargetClass).SetStaticField("privateStaticString", expected);
            Assert.Equal(expected, TargetClass.StaticStringProperty);
        }
    }
}
