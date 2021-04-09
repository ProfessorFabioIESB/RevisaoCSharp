using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move(target));
    }

    IEnumerator Move(Transform t){
        while(Vector3.Distance(transform.position, t.position) > 0.05f){
            transform.position = Vector3.Lerp(transform.position, t.position, smoothing*Time.deltaTime);
            yield return null;
        }

        Debug.Log("Alcançou o alvo");

        yield return new WaitForSeconds(3);
        Debug.Log("FIM");
    }
}
