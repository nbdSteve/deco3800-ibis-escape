﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PickupTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PickupTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator PickupTestWithEnumeratorPasses()
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            var script = new GameObject().AddComponent<OnCollision>();

            // Use yield to skip a frame.
            yield return null;

            bool doesObjectExist = player != null;
            Assert.True(doesObjectExist);
        }
    }
}
