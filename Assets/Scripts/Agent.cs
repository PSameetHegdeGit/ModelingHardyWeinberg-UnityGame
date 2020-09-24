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
        if (agent.velocity == Vector3.zero) {
            StartCoroutine(translate());

        }
    }

    IEnumerator translate()
    {
   
        var x = Random.Range(-16.37f, 16.37f);
        var z = Random.Range(-16.37f, 16.37f);
        var y = Random.Range(-16.37f, 16.37f);

        var newPosition = new Vector3(x, y, z);

        agent.SetDestination(newPosition);

        //while (agent.transform.position != newPosition)
        //{
        //    continue;
        //}

        yield return new WaitForSeconds(3);
    }

}
