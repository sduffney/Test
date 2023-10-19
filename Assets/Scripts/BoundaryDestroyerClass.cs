using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroyerClass : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

}
