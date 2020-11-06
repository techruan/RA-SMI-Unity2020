using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class MoveCameraOnImgDetected : MonoBehaviour{

    private ARTrackedImageManager _arTrackedImageManager;
    private GameObject ARcamera;
    private void Awake(){
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable(){
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable(){
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args) {
        ARcamera = GameObject.FindGameObjectWithTag("MainCamera");
        foreach (var imagemDetectada in args.added){
            if(imagemDetectada.name.Equals("smug")){
                Vector3 novaPosicao = new Vector3(2, ARcamera.transform.position.y, 5);
                Vector3 posicaoParede = new Vector3(2.2f, ARcamera.transform.position.y, 5);
                ARcamera.transform.position = novaPosicao;
                ARcamera.transform.LookAt(posicaoParede);
            }else if(imagemDetectada.name.Equals("catglasses")){
                Vector3 novaPosicao = new Vector3(-5, ARcamera.transform.position.y, 2);
                ARcamera.transform.position = novaPosicao;
            }
        }

    }
}
