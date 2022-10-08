using UnityEngine;

public class Pelota : MonoBehaviour
{

    public Vector3 posicion;
    public Vector3 escala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += posicion;
        transform.localScale += escala;
    }
}
