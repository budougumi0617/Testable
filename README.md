# Testable
[![NuGet version](https://badge.fury.io/nu/budougumi0617.Testable.svg)](https://badge.fury.io/nu/budougumi0617.Testable)
[![Build status](https://ci.appveyor.com/api/projects/status/nv8feqr5attxrx5j?svg=true)](https://ci.appveyor.com/project/budougumi0617/testable)
[![codecov](https://codecov.io/gh/budougumi0617/Testable/branch/master/graph/badge.svg)](https://codecov.io/gh/budougumi0617/Testable)


# Introduction

Allows test code to call fields, methods, ~~and properties~~ even if non public, like a `PrivateObject`.

[Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject](https://msdn.microsoft.com/ja-jp/library/microsoft.visualstudio.testtools.unittesting.privateobject.aspx)

And, you can call static fiealds like a `PrivateType`. but, you do not need create wrapper instance if you want to call static members. 

[Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType](https://msdn.microsoft.com/ja-jp/library/microsoft.visualstudio.testtools.unittesting.privatetype.aspx)

# How to use

Easy sample is below. If you want to read more example, please check [test codes](./Testable.Tests/PrivateObjectTests.cs).

```cs
 public class TargetClass
 {
    private int privateInt;
    private static privateStaticInt;
    static string throughString(string s)
    {
        return s;
    }
 }

---

PrivateObject pivateObject = new PrivateObject(new TargetClass() as Object);
int privateIntField = Convert.ToInt32(po.GetField("privateInt"));
po.SetField("privateInt", 1000);


// Access private static field by extension methods.

typeof(TargetClass).SetStaticField("privateStaticInt", 100);
int privateStaticIntField = Convert.ToInt32(typeof(TargetClass).GetStaticField("privateStaticInt"));

typeof(TargetClass).SetStaticField("privateStaticMethod", 100);

// Call private static method by extension methods.

var argTypes = new Type[] { typeof(string) };
var args = new Object[] { "arguments" };
var returnString = (string)typeof(TargetClass).InvokeStatic("throughString", argTypes, args); 
```

# Features

## `Testable.PrivateObject`

|Method|Description|
|---|---|
|`PrivateObject(Object)`|Initializes a new instance of the PrivateObject class that creates the wrapper for the specified object.|
|`GetField(String)`|Gets a value from a named field, based on the name.|
|`SetField(String, Object)`|Sets a value for the field of the wrapped object, identified by name.|
|`Invoke(String, Type[], Object[])`|Used to access the methods of the private object.|
|???|Now implementing...|

## `Testable.PrivateStaticAccessor`
|Method|Description|
|---|---|
|`GetStaticField(this Type, string)`|Gets a value from a named static field, based on the name.|
|`SetStaticField(this Type, string, Object)`|Sets a value for a named static field, identified by name.|
|`InvokeStatic(this Type, string, Type[], Object[])`|Invokes static method.|
|???|Now implementing...|
