using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class OnCollision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Analytics.CustomEvent("Object was picked up by player");
            Destroy(this.gameObject);
        }
    }
}
