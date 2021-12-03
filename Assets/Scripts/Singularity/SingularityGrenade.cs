using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SingularityGrenade : MonoBehaviour
{
    public float explosionRadius = 2f;
    public float attractionForce = 2f;
    public float duration=10f;
    bool isAttracting;


    // Start is called before the first frame update
    async void Start()
    {
        isAttracting=true;
       await Explode();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

    private void FixedUpdate()
    {
        if(isAttracting)
            Attract();
    }

    void Attract()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        for (int i = 0; i < colliders.Length; i++)
        {
            Vector3 direction = (transform.position-colliders[i].transform.position  ).normalized;
            colliders[i].GetComponent<IDamageable>()?.ApplyAttractionForce(direction * attractionForce,true);

        }
        
    }

    async Task Explode()
    {
        await Task.Delay(1000*(int)duration);
        isAttracting=false;
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        for (int i = 0; i < colliders.Length; i++)
        {
            Vector3 direction = (transform.position - colliders[i].transform.position).normalized;
            colliders[i].GetComponent<IDamageable>()?.ApplyAttractionForce(direction * attractionForce,false);

        }
    }
}
