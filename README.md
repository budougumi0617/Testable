# Testable
[![NuGet version](https://badge.fury.io/nu/budougumi0617.Testable.svg)](https://badge.fury.io/nu/budougumi0617.Testable)
[![Build status](https://ci.appveyor.com/api/projects/status/nv8feqr5attxrx5j?svg=true)](https://ci.appveyor.com/project/budougumi0617/testable)
[![codecov](https://codecov.io/gh/budougumi0617/Testable/branch/master/graph/badge.svg)](https://codecov.io/gh/budougumi0617/Testable)


# Introduction

Allows test code to call fiealds, ~~methods, and properties~~ even if non public, like a `PrivateObject`.

[Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject](https://msdn.microsoft.com/ja-jp/library/microsoft.visualstudio.testtools.unittesting.privateobject.aspx)


# How to use

Easy sample is below. If you want to read more example, please check [test codes](./Testable.Tests/PrivateObjectTests.cs).

```cs
 public class TargetClass
 {
     private int privateInt;
 }

---

PrivateObject pivateObject = new PrivateObject(new TargetClass() as Object);
int privateIntField = Convert.ToString(po.GetField("privateInt"));
po.SetField("privateInt", 1000);
```

# Features

|Method|Description|
|---|---|
|`PrivateObject(Object)`|Initializes a new instance of the PrivateObject class that creates the wrapper for the specified object.|
|`GetField(String)`|Gets a value from a named field, based on the name.|
|`SetField(String, Object)`|Sets a value for the field of the wrapped object, identified by name.|
|`Invoke(String, Object[])`|Used to access the methods of the private object.|
|???|Now implementing...|
