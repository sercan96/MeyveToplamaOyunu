using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altduvar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meyve1"))
        {
            Destroy(collision.gameObject,1f);
        }
    }
}
