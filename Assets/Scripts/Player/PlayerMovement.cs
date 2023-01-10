using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;
    public float speed = 12f;
    public float gravity = -9.81f; //variable de gravedad

  
    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;  

    bool isGrounded;
    Vector3 velocity;

    public float jumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

      isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask); //Booleana define si esta en el suelo o no
      if (isGrounded && velocity.y < 0)
      {
        velocity.y = -2f;
      }

      float x = Input.GetAxis("Horizontal"); //captura movimiento en el mando y teclas A y D
      float z = Input.GetAxis("Vertical"); //captura movimiento en el mando y teclas W Y S
      Vector3 move = transform.right * x + transform.forward * z; 

      if (Input.GetKeyDown(KeyCode.Space) && isGrounded)

      {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity); //formula matematicas para definir el salto
      }

      characterController.Move(move * speed * Time.deltaTime); //controlar la velocidad de movimiento & deltatime unifica la velocidad a los fps
      velocity.y += gravity * Time.deltaTime; //gravedad aplicado al eje de las y
      characterController.Move(velocity * Time.deltaTime);
    }  
}
