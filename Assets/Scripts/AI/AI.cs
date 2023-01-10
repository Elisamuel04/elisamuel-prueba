using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    public NavMeshAgent navMeshAgent;
    public GameObject destination1;
    public GameObject destination2;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.destination = destination1.transform.position; //se moverá dónde estará el objeto vacio
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, destination1.transform.position); //guarda lso valores de la distancia
        if (distance < 2) //si la distancia es menor que 2 con respecto a la destination1
        {
            navMeshAgent.destination = destination2.transform.position; //entonces cambia de posicion
        }
    }
}
