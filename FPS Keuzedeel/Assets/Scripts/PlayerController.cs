using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float range = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            Interact();
        }
    }

    void Interact()
    {
        Ray r = new Ray(transform.position, transform.forward);
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
}
