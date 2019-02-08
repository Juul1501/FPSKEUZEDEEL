using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float range = 2f;
    public float shootRange = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            Interact();
        }
        if (Input.GetButtonDown("Shoot"))
        {
            Shoot();
        }
    }

    void Interact()
    {
        Ray r = new Ray(transform.position, this.gameObject.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit, range))
        {
            IInteractable i = hit.collider.gameObject.GetComponent<IInteractable>();
            if (i != null)
            {
                i.Action();
            }
        }
    }
    void Shoot()
    {
        Ray r = new Ray(transform.position, this.gameObject.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit, shootRange))
        {
            IEnemy e = hit.collider.gameObject.GetComponent<IEnemy>();
            if (e != null)
            {
                e.Action();
            }
        }
    }
}
