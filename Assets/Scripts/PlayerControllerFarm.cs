using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerFarm : MonoBehaviour
{
   
    public Vector2 horizontalInput;
    public float horizontalInput2;
 


    public float speed = 25.0f;
    public float xRange = 20;
    public GameObject projectilePrefab;

    void Update()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        /*
        horizontalInput2 = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput2 * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        */


       //transform.Translate(Vector3.right * horizontalInput2 * Time.deltaTime * speed);
        transform.Translate(Vector3.right * horizontalInput.x * Time.deltaTime * speed);
      

    }


  
    /*
    public void OnMove(InputValue value)
    {
         horizontalInput2 = value.Get<float>();    
     } */
    
public void OnMove2(InputAction.CallbackContext ctx)
    {
        horizontalInput = ctx.ReadValue<Vector2>();
    }


    public void OnFire()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}













