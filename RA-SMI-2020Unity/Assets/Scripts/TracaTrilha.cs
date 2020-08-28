using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TracaTrilha : MonoBehaviour
{
    public GameObject flecha;
    public Transform alvo;
    private Queue<GameObject> filaDeFlecha;
    public float distanciaDoChao;
    private NavMeshAgent agenteFlecha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0)){
            //agenteFlecha = flecha.GetComponent<NavMeshAgent>();
            flecha.GetComponent<NavMeshAgent>().destination = alvo.position;
            
        }
    }
}
