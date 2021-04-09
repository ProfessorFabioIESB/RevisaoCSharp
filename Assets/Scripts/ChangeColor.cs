using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public delegate void Change();
    public Change change;

    public Material redMat;

    // Start is called before the first frame update
    void Awake()
    {
        change += Message;
        change += ChangeForRed;

        if(change != null)
            change();
    }

    void OnDisable(){
        //change -= Message;
        //change -= ChangeForRed;
        //change = null;
    }

    // Update is called once per frame
    void Message(){
        Debug.Log("Mudar de cor");
    }

    void ChangeForRed(){
        GetComponent<MeshRenderer>().material = redMat;
    }
}
