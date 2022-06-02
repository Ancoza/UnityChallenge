using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    public GameObject helice;

    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical1");
        horizontalInput = Input.GetAxis("Horizontal1");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        
        transform.Rotate(  Vector3.left * rotationSpeed * verticalInput* Time.deltaTime);
        transform.Rotate(Vector3.forward * horizontalInput * rotationSpeed * Time.deltaTime);
        
        helice.transform.Rotate(0,0, 100* speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
