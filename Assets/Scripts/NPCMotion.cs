using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NPCMotion : MonoBehaviour
{
    NavMeshAgent theAgent;
    GameObject[] targets;
    GameObject randomTarget;
    GameObject oldTarget;
    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        targets = GameObject.FindGameObjectsWithTag("Target");
        randomTarget = targets[Random.Range(0, targets.Length)];
        oldTarget = randomTarget;
        theAgent.SetDestination(randomTarget.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (theAgent.remainingDistance == 0)
        {
            randomTarget = targets[Random.Range(0, targets.Length)];
            if(randomTarget != oldTarget)
            {
                theAgent.SetDestination(randomTarget.transform.position);
                oldTarget = randomTarget;
            }
        }

    }
}
