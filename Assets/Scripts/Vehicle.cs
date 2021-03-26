using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //[HideInInspector]
    public string marca; //Passa para as classes filhas
    //[SerializeField]
    public string modelo; // Não passsa
    //[SerializeField]
    protected float velocidadeMax;//Passa apenas para as classes filhas

    public virtual void MostraInfo(){
        Debug.Log("Marca: "+marca);
        Debug.Log("Modelo: "+modelo);
        Debug.Log("Velocidade Maxima: "+velocidadeMax);
    }
}
