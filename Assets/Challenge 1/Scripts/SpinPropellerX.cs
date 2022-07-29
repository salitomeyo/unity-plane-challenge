using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField] 
    [Tooltip("Speed of rotation of the propeller given in grades/s")]
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }
}
