using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
     //Camel case notation: prashantThapa
    public Camera _camera;
    public float zoomSize= 0.01f;

    // it is called per once frame
    void Update()
    {
        CameraSizeZoomInZoomOut();
    }
    void CameraSizeZoomInZoomOut(){
        if (Input.GetKey(KeyCode.Q)){
            if(_camera.orthographicSize <10){
                _camera.orthographicSize += zoomSize;
                }
        }
         if (Input.GetKey(KeyCode.E)){
            if (_camera.orthographicSize>1){
                _camera.orthographicSize -= zoomSize;
            }
        }
    }
}

