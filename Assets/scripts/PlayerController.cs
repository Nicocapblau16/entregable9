using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    private float speed = 20;

    
    private float horizontalInput;
    private float verticalInput;

    private float xRange = 9.5f;
    private float yRange = 5.5f;
    private float yRangeNeg = -3.5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //movimiento
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);

     
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);


        //limites de pantalla
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        if (transform.position.y < yRangeNeg)
        {
            transform.position = new Vector3(transform.position.x, yRangeNeg, transform.position.z);
        }
    }
}
