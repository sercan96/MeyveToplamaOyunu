using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altduvar : MonoBehaviour
{
    public GameController gameC;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meyve1"))
        {
            gameC.KalanCan();
            Destroy(collision.gameObject,1f);
        }
    }
}
