using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CheckInventory : MonoBehaviour
{
    public bool checkInv = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "GPlayer")
        {
            checkInv = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "GPlayer")
        {
            checkInv = false;
        }
    }
}
