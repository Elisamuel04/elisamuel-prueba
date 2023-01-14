using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform spawnPoint; 
    public GameObject bullet; //bala
    public float shotForce = 1500f; //velocidad de la bala
    public float shotRate = 0.5f; //tiempo de retardo

    private float shotRateTime = 0; //reset para volver a disparar
    private AudioSource audioSource;
    public AudioClip shotShound;

    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRateTime)
            {
                audioSource.PlayOneShot(shotShound);
                GameObject newBullet;
                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation); //instanciar el objeto 
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                shotRateTime = Time.time + shotRate;
                Destroy(newBullet, 4);
            }
            
        }
    }
}
