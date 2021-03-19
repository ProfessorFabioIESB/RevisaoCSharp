using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    public float timeToDestroy = 4;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Desappear", timeToDestroy);
    }

    void Desappear(){
        GameObject.FindObjectOfType<Teste>().ResetCakePosition();
        Destroy(gameObject);
    }
}
