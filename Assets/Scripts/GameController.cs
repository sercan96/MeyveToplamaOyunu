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
    public PlayerController playerC;
    public GameObject patlamaefekti;
    public Image[] can;
    int kalancanim = 3;
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
                KalanMeyveleriYoket();
                OyunDurum = false;
                
            }
        }
        
    }
    public void PaunArttir()
    {
        if (OyunDurum)
        {
            puanim += 10;
            puanText.text = "Puan : " + puanim;
            if (puanim == 100)
            {
                kazandinizText.gameObject.SetActive(true);
                KalanMeyveleriYoket();
                OyunDurum = false;
            }
        }
       
    }
    public void KalanCan()
    {
        kalancanim -= 1;
        can[kalancanim].gameObject.SetActive(false);
        if(kalancanim == 0)
        {
            kalansure = 0;
            KalanMeyveleriYoket();
            kaybettinizText.gameObject.SetActive(true);
            OyunDurum = false;
        }
        
    }
    public void KalanMeyveleriYoket()
    {
        GameObject[] kalanmeyveler = GameObject.FindGameObjectsWithTag("meyve1");  //Balonlarý(s) yakala.
        for (int i = 0; i < kalanmeyveler.Length; i++) //.Length =) Kaç tane balon varsa 
        {
            Instantiate(patlamaefekti, kalanmeyveler[i].transform.position, kalanmeyveler[i].transform.rotation);
            Destroy(kalanmeyveler[i]);
        }
    }

}
