using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeyveController : MonoBehaviour
{
    private void Start()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("_Script").GetComponent<GameController>().PaunArttir();
            Destroy(gameObject);
        }

    }
}
 
