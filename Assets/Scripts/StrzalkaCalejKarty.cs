using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrzalkaCalejKarty : MonoBehaviour
{
    public GameObject tablica;
    public bool czyWusuwamy;
    public float szybkoscWys;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (czyWusuwamy && tablica.transform.position != Vector3.zero)
        {
            tablica.transform.position = Vector3.Lerp(tablica.transform.position, Vector3.zero, Time.deltaTime * szybkoscWys);
        }
        else
        {
            czyWusuwamy = false;
        }
    }


    private void OnMouseDown()
    {
        czyWusuwamy = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }


}
