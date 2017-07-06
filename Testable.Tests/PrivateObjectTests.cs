//
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
using NUnit.Framework;
using System;
namespace Testable.Tests
{
    [TestFixture]
    public class PrivateObjectTests
    {
        PrivateObject po;
        [SetUp]
        public void SetUp(){
            Object obj = new TargetClass() as Object;
            po = new PrivateObject(obj);
        }

        [Test, Description("Able to get private field of primitive type."), Category("Basic")]
        public void GetPrivatePrimitiveInt()
        {
            int ac = Convert.ToInt32(po.GetField("PrivateInt"));
            Assert.AreEqual(TargetClass.DefaultInt, ac);
        }

		[Test, Description("Able to get private field of primitive type."), Category("Basic")]
		public void GetPrivatePrimitiveString()
		{
			int ac = Convert.ToInt32(po.GetField("PrivateString"));
			Assert.AreEqual(TargetClass.DefaultInt, ac);
		}
    }
}
