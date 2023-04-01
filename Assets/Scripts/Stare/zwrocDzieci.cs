using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zwrocDzieci : MonoBehaviour
{




    public List<GameObject> children = new List<GameObject>();
    void Start()
    {
        //foreach (Transform t in transform)
        //{
        //    if(t.gameObject.tag == "karta")
        //    {

        //        children.Add(t.gameObject);
        //    }
        //}

  

    }


   public List<GameObject> dejKarty()
    {
        return children;
    }





    public List<GameObject> GetCzildren()
    {
        foreach (Transform t in transform)
        {
            if (t.gameObject.tag == "karta")
            {

                children.Add(t.gameObject);
            }
        }

        return children;
    }


}



