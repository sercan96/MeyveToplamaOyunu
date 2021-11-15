using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text zamanText;
    public float kalansure;
    public Text puanText;
    public Text kaybettinizText;
    int puanim;
    public bool OyunDurum;
    public Text kazandinizText;
    private void Start()
    {
        OyunDurum = true;
    }
    private void Update()
    {
        KalanZaman();
    }
    public void KalanZaman()
    {
        if (OyunDurum)
        {
            kalansure -= Time.deltaTime;
            zamanText.text = "Zaman : " + (int)kalansure;
            if (kalansure <= 0)
            {
                kaybettinizText.gameObject.SetActive(true);
                OyunDurum = false;
            }
        }
        
    }
    public void PaunArttir()
    {
        puanim += 10;
        puanText.text = "Puan : " + puanim;
        if(puanim == 50)
        {
            kazandinizText.gameObject.SetActive(true);
            OyunDurum = false;
        }
    }
   
}
