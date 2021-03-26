using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public bool automatico = true;
    public static string cor = "RED";
    public Car(){
        marca = "Ford";
        modelo = "KA";
        velocidadeMax = 220;
        automatico =  true;
    }

    public override void MostraInfo(){
        Vehicle v = new Vehicle();
        v.MostraInfo();
        Debug.Log("Automatico: "+automatico);
    }

    public static void Capotar(){
        Debug.Log("CAPOTANDO  TODOS OS  CARROS");
    }
}
