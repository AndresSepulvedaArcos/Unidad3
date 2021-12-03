using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HEGrenade : MonoBehaviour
{
    public float explosionRadius=2f;
    public float explosionForce=2f;


    // Start is called before the first frame update
    void Start()
    {
        Explode();    
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position,explosionRadius);
    }

    void Explode()
    {
         Collider[] colliders=Physics.OverlapSphere(transform.position,explosionRadius);
        for (int i = 0; i < colliders.Length; i++)
        {
            Vector3 direction= (colliders[i].transform.position-transform.position).normalized;
            colliders[i].GetComponent<IDamageable>()?.ApplyExplosionDamage(direction*explosionForce);

        }
        Destroy(gameObject);
    }
}
