using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    public GameObject ObjPuntos;
    public float PuntosQueDa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player") 
        {
            ObjPuntos.GetComponent<Puntos>().puntos += PuntosQueDa; 
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
