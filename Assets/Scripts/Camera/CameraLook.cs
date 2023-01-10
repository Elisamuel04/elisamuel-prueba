using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public float mouseSensitivity = 80f; //Variable de sensibilidad para mover la camara
    public Transform playerBody; //para generar movimiento de camara con respecto al punto en el plano
    float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked; //limitar rotaciones a la pantalla del juego
    }

    // Update is called once per frame
    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime; //Camara horizontal
      float mouseY = Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime; //Camara vertical
      xRotation -=mouseY; //rotacion vertical
      xRotation = Mathf.Clamp(xRotation, -90f, 90f); //se toma de referencia xrotation para limitar rotaciones mayores a 90 grados
      transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
      playerBody.Rotate(Vector3.up * mouseX); //Rotacion horizontal

    }
}
