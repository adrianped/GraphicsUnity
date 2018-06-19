using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBlend : MonoBehaviour {

    //Grabs Public animator
    public Animator anim;


    public void Scale()
    {
        //Sets Blend float to Scale
        anim.SetFloat("Blend", 1);
    }

    public void Rotate()
    {
        //Sets Blend float to Rotate
        anim.SetFloat("Blend", 0);
    }

    public void Blend()
    {
        //Sets Blend float to Blend
        anim.SetFloat("Blend", 0.5f);
    }
}
