using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimBlend : MonoBehaviour {

    //Grabs Public animator
    public Animator anim;
    public Slider Blender;



    public void Update()
    {
        //Sets Blend value For animation
        anim.SetFloat("Blend", Blender.value);
    }
}
