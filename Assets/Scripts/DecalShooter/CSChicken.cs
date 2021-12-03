using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSChicken : MonoBehaviour,IDamageable
{
    public void ApplyDamage(RaycastHit hit)
    {
         Destroy(gameObject);
    }
     
}
