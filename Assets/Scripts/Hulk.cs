using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hulk : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", 3.0f);
        if(Input.GetButtonDown("Fire1")){
            anim.SetTrigger("dead2");
        }
    }
}
