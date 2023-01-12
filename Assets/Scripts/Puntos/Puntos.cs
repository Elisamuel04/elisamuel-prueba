using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    
    public float puntos;
    public Text textoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    private void Update()
    {
        textoPuntos.text = "Life: " + puntos.ToString();
    }
}
