using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        var playerAgent = GetComponent<NavMeshAgent>();
        playerAgent.destination = goal.position;
    }
}
