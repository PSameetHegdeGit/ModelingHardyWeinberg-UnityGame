using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public GameObject agentTemplate;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            var x = Random.Range(-39f, 39f);
            var z = Random.Range(-39f, 39f);
            var y = 0f;

            var startPosition = new Vector3(x, y, z);

            Instantiate(agentTemplate, startPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
