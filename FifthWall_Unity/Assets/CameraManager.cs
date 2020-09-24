using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraManager : MonoBehaviour
{

    public Camera[] cameras;
    private int currentCam = 0;

    void Start()
    {
      for (int i = 0; i < cameras.Length; i++) {
        if(i == 0){
          cameras[i].enabled = true;
        } else {
          cameras[i].enabled = false;
        }
      }
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)){
        currentCam++;
        if(currentCam == cameras.Length){
          currentCam = 0;
        }
      }
      for (int i = 0; i < cameras.Length; i++) {
        if (i == currentCam) {
          cameras[i].enabled = true;
        } else {
          cameras[i].enabled = false;
        }
      }
    }
}
