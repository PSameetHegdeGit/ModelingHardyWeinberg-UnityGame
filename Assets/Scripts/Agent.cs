using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = Random.Range(-16.37f, 16.37f);
        var z = Random.Range(-16.37f, 16.37f);
        var y = 0f;

        agent.SetDestination(new Vector3(x, y, z));

    }
}
