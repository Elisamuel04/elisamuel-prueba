using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valor : MonoBehaviour
{
    //public GameObject ObjPuntos;
    //public float PuntosQueDa;

    

    //private void OnTriggerEnter(Collider other)
    //{
        //if (other.tag=="Player") 
        //{
            //ObjPuntos.GetComponent<Puntos>().puntos += PuntosQueDa; 
            //Destroy(gameObject);
        //}
    //}

  public static int score;
  Text text;

    void Awake()
    {
        text = GetComponent<Text>(); 
        score = 0;
    }

    void Update ()
    {
        text.text = "Score: " + score;
    }
}
