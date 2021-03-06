using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ronald : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTransform.position);
        transform.LookAt(playerTransform);
    }
}
