using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectByTag : MonoBehaviour
{
    public string tagToDestroy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagToDestroy)
        {
            Destroy(other.gameObject);
        }
    }
}
