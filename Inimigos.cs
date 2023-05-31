using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigos: MonoBehaviour
{
    private NavMeshAgent inimigo;
    private Transform point;

    // Start is called before the first frame update
    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        point = GameObject.Find("Jogador").transform;
    }

    // Update is called once per frame
    void Update()
    {
        inimigo.SetDestination(point.position);
    }
}
