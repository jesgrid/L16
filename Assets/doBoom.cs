using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doBoom : MonoBehaviour
{
    public BoxCollider triggerBoxCollider;
    Vector3 vector = new Vector3(0, 0, 0);
    int i = 0;
    private void OnTriggerEnter(Collider other)
    {
        vector = other.transform.position - triggerBoxCollider.transform.position;
        if(i == 0)
        {
            GetComponent<BoxCollider>().size = GetComponent<BoxCollider>().size * 2;
            Debug.Log("Bomb do boom!");
            i = 1;
        }
        other.attachedRigidbody.AddForce(vector * 10, ForceMode.Impulse);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
