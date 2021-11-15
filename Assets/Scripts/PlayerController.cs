using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] meyve;
    public GameController gameC;
    float zaman = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
      if(gameC.OyunDurum)
        {
            MeyveOlusturma();
            OyunHareket();
        }
       
        
    }
    public void MeyveOlusturma()
    {
        if(gameC.OyunDurum)
        {
            zaman -= Time.deltaTime;  // zaman--; yaparsak update sürekli çalýþtýðý için saniye cinsinden azaltmaz.
            if (zaman <= 0)
            {
                Vector3 pos = new Vector3(Random.Range(-6.17f, 6.17f), 6.25f, 0f);
                Instantiate(meyve[Random.Range(0,4)], pos, Quaternion.identity);
                zaman = 2f;
            }
        }
       
        
    }
    void OyunHareket()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 6f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 6f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 6f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 6f);
        }
    }
    void KalanMeyveleriYoket()
    {
        
    }
}
