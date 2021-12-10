using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexController : MonoBehaviour
{
    public float mySpeed=0;
    MaterialPropertyBlock propertyBlock;
    // Start is called before the first frame update
    void Start()
    {
          propertyBlock = new MaterialPropertyBlock();
      
    }

    // Update is called once per frame
    void Update()
    {
        propertyBlock.SetFloat("Speed", mySpeed);
        //   GetComponent<MeshRenderer>().sharedMaterial.SetFloat("Speed",mySpeed);
        GetComponent<MeshRenderer>().SetPropertyBlock(propertyBlock);
    }
}
