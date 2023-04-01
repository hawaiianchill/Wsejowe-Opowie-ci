using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ZmianaKartki : MonoBehaviour
{
    private GameObject tera;


    public zwrocDzieci obszar;
    private List<GameObject> dzieci;

    private int ileEkranow;
    private int ktoryScren = 1;

    public GameObject kolejnyDzien;
    private Strzalka strz;

     private void Start()
     {

        dzieci = obszar.dejKarty();

        ileEkranow = dzieci.Count;

        tera = dzieci[0];
        
        
     }

    private void Awake()
    {
        strz = FindObjectOfType<Strzalka>();
    }

    private void zmianaStanu(GameObject t)
    {
        for(int i = 0; i < dzieci.Count; i++)
        {
            if(t == dzieci[i])
            {

                tera = dzieci[i + 1];

                break;
            }
        }
    }


    private void OnMouseDown()
    {

        if (ktoryScren != ileEkranow)
        {
            

            tera.gameObject.SetActive(false);
            zmianaStanu(tera);

            tera.gameObject.SetActive(true);
            ktoryScren++;
        }

        else
        {
            
            ktoryScren = 1;




            strz.ustawTablice(Instantiate(kolejnyDzien, new Vector3(-18, 0, 0), quaternion.identity));
            Debug.Log(strz.tablica);
            Debug.Log(obszar);


            strz.czyPrzesuwany = false;


            strz.OdpalStrzalke();

            obszar.gameObject.SetActive(false);


            
            
      

        }


        

    }

    private void SetObszar(zwrocDzieci ob)
    {
        obszar = ob;
    }










}
