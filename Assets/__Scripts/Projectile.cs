using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision coll) {
       if (explosionPrefab != null) {
            // Instantiate an explosion
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        GetComponent<AudioSource>().Play();
        }
     }
}
