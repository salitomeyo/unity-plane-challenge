using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of the plane given in x/s")]
    private float speed;
    [SerializeField] 
    [Tooltip("Speed of rotation of the plane given in grades/s")]
    private float rotationSpeed;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        verticalInput = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
