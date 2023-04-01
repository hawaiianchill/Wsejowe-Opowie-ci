using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmianaKolorow : MonoBehaviour
{


    public string Wybor1 = "nie";



    private void OnMouseDown()
    {
        if(Wybor1 == "tak")
        {
            Wybor1 = "nie";
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }

        if (Wybor1 == "nie")
        {
            Wybor1 = "tak";
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }







}
