using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalShooter : MonoBehaviour
{
    public GameObject decalPrefab;
    public float maxDistance=1000;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PowerShoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         
        RaycastHit[] hit;

            hit=  Physics.RaycastAll(ray,maxDistance);

        for (int i = 0; i < hit.Length; i++)
        {
            hit[i].transform.GetComponent<IDamageable>()?.ApplyDamage(hit[i]);
            Debug.Log("i hit" + hit[i].transform.gameObject);

        }

    }
    void Shoot()
    {
        Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);

         
        RaycastHit hit;



       if(Physics.Raycast(ray,out hit,maxDistance))
        {
           
          
          //  hit.transform.GetComponent<Rigidbody>()?.AddForce(hit.normal*-1,ForceMode.Impulse);
            Debug.Log("i hit"+ hit.transform.gameObject);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            PowerShoot();
        }
    }
}
