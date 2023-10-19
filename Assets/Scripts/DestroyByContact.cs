using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject bigExplosion;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(bigExplosion,transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
