using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public interface IDamageable
{
      void ApplyDamage(RaycastHit hit);

        void ApplyExplosionDamage(Vector3 velocity);
        

}