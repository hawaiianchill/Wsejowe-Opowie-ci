using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzalka : MonoBehaviour
{

    public GameObject tablica;
    public bool czyPrzesuwany = false;
    public float szybkoscWysuwania;


   

    void Update()
    {
        if(tablica == null)
        {
            Debug.Log("cos nie tak");
        }


        if (czyPrzesuwany)
        {
            tablica.transform.position = Vector3.Lerp(tablica.transform.position, Vector3.zero, szybkoscWysuwania * Time.deltaTime);

            if(tablica.transform.position == Vector3.zero)
            {
                czyPrzesuwany = false;
                
            }
        }


    }

    private void OnMouseDown()
    {
        czyPrzesuwany = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void ustawTablice(GameObject tab)
    {
        tablica = tab;
    }


    public void OdpalStrzalke()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
}
