using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSCT : MonoBehaviour, IDamageable
{
    public void ApplyDamage(RaycastHit hit)
    {
        hit.transform.GetComponent<Rigidbody>()?.AddForce(hit.normal * -1, ForceMode.Impulse);

    }

    public void ApplyExplosionDamage(Vector3 velocity)
    {
        GetComponent<Rigidbody>().AddForce(velocity,ForceMode.Impulse);
    }

    public void ApplyAttractionForce(Vector3 attractionForce, bool Activate)
    {
        if (!Activate)
        {
            GetComponent<Rigidbody>().useGravity = true;
            ApplyExplosionDamage(attractionForce * -1);
            return;
        }
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().AddForce(attractionForce, ForceMode.Force);
    }

}
