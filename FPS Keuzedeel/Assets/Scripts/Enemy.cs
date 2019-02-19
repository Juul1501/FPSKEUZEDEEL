using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, IEnemy
{
    public NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update

    void Awake()
    {
        if(agent == null)
        agent = GetComponent<NavMeshAgent>();
        if (player == null)
        player = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
    public void Action()
    {
        PlayerController.score += 100;
        Destroy(this.gameObject);
    }
}
