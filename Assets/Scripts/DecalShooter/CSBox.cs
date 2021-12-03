using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSBox : MonoBehaviour, IDamageable
{
    public GameObject decalPrefab;

    public void ApplyDamage(RaycastHit hit)
    {
        GameObject obj = Instantiate(decalPrefab, hit.point, Quaternion.LookRotation(hit.normal));
        obj.transform.SetParent(hit.transform);

    }
    public void ApplyExplosionDamage(Vector3 velocity)
    {
        GetComponent<Rigidbody>().AddForce(velocity, ForceMode.Impulse);
    }
}
 
