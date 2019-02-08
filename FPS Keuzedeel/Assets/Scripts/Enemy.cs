using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IEnemy
{
    public NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        if(agent == null)
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
    public void Action()
    {
        Destroy(this.gameObject);
    }
}
