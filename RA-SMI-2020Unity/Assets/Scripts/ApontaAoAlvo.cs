using UnityEngine;

public class ApontaAoAlvo : MonoBehaviour
{
    public Transform alvo;
    //public Transform cameraRA;
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // //Salva a posicao da camera em 1 variavel
        // Vector3 posicaoCameraRA = new Vector3(cameraRA.position.x, transform.position.y, cameraRA.position.z);
        // //Posiciona este objeto de acordo com a variavel
        // transform.position = posicaoCameraRA;
        // //Salva a posicao do alvo em 1 variavel
        Vector3 posicaoAlvo = new Vector3(alvo.position.x, transform.position.y, alvo.position.z);
        //Este objeto 'olha' na direcao do alvo
        transform.LookAt(posicaoAlvo);
        
    }
}
