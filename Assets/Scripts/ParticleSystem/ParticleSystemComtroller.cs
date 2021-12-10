using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemComtroller : MonoBehaviour
{
    public GameObject ps;
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        { 
            ps.SetActive(true);
            particleSystem.Play();
            }
    }
}
