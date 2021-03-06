﻿using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor.SceneManagement;

public class NewPlayModeTest {

    [Test]
    public void NewEditModeTestSimplePasses()
    {
        // Use the Assert class to test conditions.
    }

    [Test]
    public void BasicTest()
    {
        bool isActive = false;

        Assert.AreEqual(false, isActive);
    }

    [Test]
    public void CatchingErrors()
    {
        GameObject gameObject = new GameObject("test");

        Assert.Throws<MissingComponentException>(() => gameObject.GetComponent<Rigidbody>().velocity = Vector3.one);
    }

    [SetUp]
    public void ResetScence()
    {
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
    }

    [UnityTest]
    public IEnumerator UserInfoPlayMode()
    {
        var playerUsername = "Deniel2019";
        var playerPassword = "1s2s3s4s5s6s7s8";

        var loggedUser = playerUsername + playerPassword;

        Assert.That(loggedUser, Is.EqualTo(playerUsername + playerPassword));

        yield return null;
    }


    [UnityTest]
	public IEnumerator NewPlayModeTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}

    [UnityTest]
    public IEnumerator  LeveltestingPlaymode()
    {
        //var user = new NewPlayModeTest();
        var score = 100;
        var correct = 10;
        var objects = 10;
        var totalscore = correct * objects;


        Assert.That(score, Is.EqualTo(totalscore));

        yield return null;
    }

}
