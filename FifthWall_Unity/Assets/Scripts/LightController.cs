using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public LibPdInstance patcher;

    // Start is called before the first frame update
    void Start()
    {
        patcher.Bind("mid");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void brightness(string name, float val)
    {
        GetComponent<Light>().intensity = (float)(val / 2.0);
    }
}