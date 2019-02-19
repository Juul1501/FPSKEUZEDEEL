using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public float waitTime;
    public int Amount;
    public Text RoundCounter;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            for (int i = 0; i < Amount; i++)
            {
                Instantiate(enemy, transform.position, transform.rotation);
            }
            timer = 0f;
        }

    }
}
