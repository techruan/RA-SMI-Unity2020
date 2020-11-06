using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class MapaNoPlanoOnPlaneDetected : MonoBehaviour
{

    private GameObject mapa;
    private ARPlaneManager _arPlaneManager;
    // Start is called before the first frame update
    void Awake(){
        _arPlaneManager = FindObjectOfType<ARPlaneManager>();
        mapa = GameObject.FindGameObjectWithTag("MapaPrincipal");
        
    }

    void OnEnable(){
        _arPlaneManager.planesChanged += OnPlaneUpdated;
    }

    void OnDisable(){
        _arPlaneManager.planesChanged -= OnPlaneUpdated;
    }

    void OnPlaneUpdated(ARPlanesChangedEventArgs args){        
        foreach (var plane in args.updated){
            Vector3 posicaoPlano = new Vector3(mapa.transform.position.x, plane.transform.position.y, mapa.transform.position.z);
            Vector3 rotacaoPlano = new Vector3(plane.transform.eulerAngles.x, mapa.transform.eulerAngles.y, plane.transform.eulerAngles.z);

            mapa.transform.position = posicaoPlano;
            mapa.transform.eulerAngles = rotacaoPlano;
        }
        {
            
        }
    }
}
