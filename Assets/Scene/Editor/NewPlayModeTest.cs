using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System;
using Helper;

[TestFixture]
public class NewPlayModeTest {

    [Test]
    public void NewPlayModeTestSimplePasses()
    {
        var go = new GameObject("MyGameObject");
        Assert.AreEqual("MyGameObject", go.name);
    }


    [Test]
    public void LogAssertExample()
    {
        //Expect a regular log message
        LogAssert.Expect(LogType.Log, "Log message");
        //A log message is expected so without the following line
        //the test would fail
        Debug.Log("Log message");
        //An error log is printed
        Debug.LogError("Error message");
        //Without expecting an error log, the test would fail
        LogAssert.Expect(LogType.Error, "Error message");
    }

}

