using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TapToPlaceRA : MonoBehaviour
{

    private ARRaycastManager _arRaycastManager;
    private Vector2 posicaoToque;

    public GameObject mapa;

    public GameObject placaTeste;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    // Start is called before the first frame update

    private void Awake(){
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(!pegaPosicaoToque(out Vector2 posicaoToque))
        // return;



        // if(_arRaycastManager.Raycast(posicaoToque, hits, TrackableType.PlaneWithinPolygon)){
        //     var hitPose = hits[0].pose;
        //     Vector3 posicaoMapa = mapa.transform.position;
        //     Vector3 posicaoPlano = hitPose.position;
        //     Vector3 novaPosicaoMapa = new Vector3(posicaoMapa.x, posicaoPlano.y, posicaoMapa.z);
        //     mapa.transform.position = novaPosicaoMapa;
        // }

        // Vector3 posicaoYplaca = new Vector3(mapa.transform.position.x, placaTeste.transform.position.y, mapa.transform.position.z);
        // mapa.transform.position = posicaoYplaca;
        // Vector3 rotacaoPlaca = new Vector3(placaTeste.transform.eulerAngles.x, mapa.transform.eulerAngles.y, placaTeste.transform.eulerAngles.z);
        // mapa.transform.eulerAngles = rotacaoPlaca;
    }

    bool pegaPosicaoToque(out Vector2 posicaoToque){

        if(Input.touchCount > 0){
            posicaoToque = Input.GetTouch(0).position;
            return true;
        }
        posicaoToque = default;
        return false;
    }

}
