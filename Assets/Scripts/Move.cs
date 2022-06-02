using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public int ID_PLAYER;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 20;
    private float turnSpeed = 45.0f;
    [SerializeField] private bool isPlayer;
    
    [SerializeField] 
    private GameObject w1, w2, w3, w4;
    
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu");
        }
        if (isPlayer)
        {
            horizontalInput = Input.GetAxis("Horizontal"+ID_PLAYER);
            verticalInput = Input.GetAxis("Vertical"+ID_PLAYER);
            //Move Fordward
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
            w1.transform.localRotation = Quaternion.Euler(Vector3.up * horizontalInput * Time.deltaTime * 5000);
            w2.transform.localRotation = Quaternion.Euler(Vector3.up * horizontalInput * Time.deltaTime * 5000);
        
            if (verticalInput != 0)
            {
                w1.transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * 1000);
                w2.transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * 1000);
                w3.transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * 1000);
                w4.transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * 1000);
                transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);
            }
            
            if(Input.GetKeyDown(switchKey))
            {
                mainCamera.enabled = !mainCamera.enabled;
                hoodCamera.enabled = !hoodCamera.enabled;
            }
        }
        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime * 2);
        }

    }
}
