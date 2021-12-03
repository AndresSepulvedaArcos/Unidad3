using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FakeDirectionalLight : MonoBehaviour
{

     

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("LightDirection",transform.forward);

    }
}
