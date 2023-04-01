using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacje : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim; 
    public Player player;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("gora",player.gora());
        anim.SetBool("dol", player.dol());
        anim.SetBool("bok", player.bok());

    }
}
