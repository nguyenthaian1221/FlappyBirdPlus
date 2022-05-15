using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class TrapObject : MonoBehaviour
{
    private void Reset()
    {
        GetComponent<EdgeCollider2D>().isTrigger = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Bird>().Death();

            PlayerManager.gameOver = true;
        }

    }

}
