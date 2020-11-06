using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TracaRota : MonoBehaviour
{
	private LineRenderer tracaLinha;
    private Vector3[] pontos;
    private NavMeshPath caminho;
    public GameObject localcameraRA;
	public Transform goal;
    public bool tracandoRota;
    public Transform cameraRA;
    public float linhaDistanciaDoChao;
    public Transform mapaPrincipal;

    private Vector3 pontoHitRaycast;
    
    
    // Start is called before the first frame update
    void Start()
    {
        tracaLinha = GetComponent<LineRenderer>();
        caminho = new NavMeshPath();
        tracandoRota = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        // NavMeshPath caminho = new NavMeshPath();
        //         
        localcameraRA.transform.position = cameraRA.position;
        pontoHitRaycast = RaycastAbaixo();
        if(pontoHitRaycast != null){
            localcameraRA.transform.position = new Vector3(localcameraRA.transform.position.x, pontoHitRaycast.y, localcameraRA.transform.position.z);
        }
        if(Input.GetMouseButtonUp(0)){
            tracandoRota = !tracandoRota;
        }
        if(tracandoRota){
            NavMesh.CalculatePath(localcameraRA.transform.position, goal.position, NavMesh.AllAreas, caminho);
            AtualizaRota();
        }else{
            tracaLinha.positionCount = 0;
        }
    }

    private void AtualizaRota()
    {
        int i = 1;
        while(i < caminho.corners.Length){
            tracaLinha.positionCount = caminho.corners.Length;
            pontos = caminho.corners;
            for(int j = 0; j < pontos.Length; j++){
                tracaLinha.SetPosition(j, pontos[j]);
            }

            i++;
        }
    }

    private Vector3 RaycastAbaixo(){
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(localcameraRA.transform.position, localcameraRA.transform.TransformDirection(Vector3.down), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(localcameraRA.transform.position, localcameraRA.transform.TransformDirection(Vector3.down) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            return hit.point;
        }
        else
        {
            Debug.DrawRay(localcameraRA.transform.position, localcameraRA.transform.TransformDirection(Vector3.down) * 1000, Color.white);
            Debug.Log("Did not Hit");
            return hit.point;
        }
    }

    public void mudarPosicaoAlvo(string local){
        string[] localSeparado = local.Split(',');
        float x = float.Parse(localSeparado[0]);
        float z = float.Parse(localSeparado[1]);
        Vector3 novoGoal = new Vector3(x, goal.position.y, z); 
        goal.position = novoGoal;
    }
}
