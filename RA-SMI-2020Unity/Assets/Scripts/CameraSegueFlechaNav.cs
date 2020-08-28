using UnityEngine;

public class CameraSegueFlechaNav : MonoBehaviour
{
    public Transform flechaNav;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = flechaNav.position + offset;
        Vector3 posicaoFlecha = new Vector3(flechaNav.position.x, transform.position.y, flechaNav.position.z);
        transform.LookAt(posicaoFlecha);
        
    }
}
