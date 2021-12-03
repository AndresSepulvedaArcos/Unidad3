using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSChicken : MonoBehaviour,IDamageable
{
    public void ApplyDamage(RaycastHit hit)
    {
         Destroy(gameObject);
    }
    public void ApplyExplosionDamage(Vector3 velocity)
    {
        GetComponent<Rigidbody>().AddForce(velocity, ForceMode.Impulse);
    }
}
 
