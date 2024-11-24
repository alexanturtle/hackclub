using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public int keysToOpenDoor = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Inventory playerInventory = collision.gameObject.GetComponent<Inventory>();

        if(playerInventory.keyCount >= keysToOpenDoor)
        {
            playerInventory.keyCount -= keysToOpenDoor;
            Destroy(gameObject);
        }
    }
}
