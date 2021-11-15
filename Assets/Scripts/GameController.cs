using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text zaman;
    float kalansure = 30;

    private void Update()
    {
        KalanZaman();
    }
    public void KalanZaman()
    {
        kalansure -= Time.deltaTime;
        zaman.text = "Zaman : " + (int)kalansure;
    }
}
