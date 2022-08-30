using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("The door is open!");
    }
}
