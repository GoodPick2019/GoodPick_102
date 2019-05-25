using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor.SceneManagement;

public class NewEditModeTestLevelStar {

	[Test]
	public void NewEditModeTestLevelStarSimplePasses() {
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

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
	public IEnumerator NewEditModeTestLevelStarWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}

    [UnityTest]
    public IEnumerator LeveltestingPlaymode()
    {
        {

            var star1 = true;
            var star2 = true;
            var star3 = true;
            var score = true;
            bool successs = star1 & star2 & star3;

            Assert.That(score, Is.EqualTo(successs));

            yield return null;
        }
    }
}
