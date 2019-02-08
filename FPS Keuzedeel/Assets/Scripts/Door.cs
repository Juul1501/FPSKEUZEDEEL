using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public enum doorTypes {Bars, CellDoor};
    public doorTypes doorType;
    public int id;
    public bool open = false;
    private Animator dooranimator;
    
    void Start()
    {
        dooranimator = GetComponentInParent<Animator>();
    }

    void Update()
    {
        //if (doorType == doorTypes.CellDoor)
        //{
        //    if (open && transform.rotation.eulerAngles.y < 80)
        //    {
        //        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 80, 0), 5);
        //    }
        //    else if (!open && transform.rotation.eulerAngles.y > 0)
        //    {
        //        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), 5);
        //    }
        //}

    }

    public void Open()
    {
        if (id == -1  || Inventory.instance.HasKey(id))
        {
            open = !open;
            dooranimator.SetBool("Open", open);
        }
    }

    public void Action()
    {
        Open();
    }
}
