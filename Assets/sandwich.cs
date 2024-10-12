using PennBoy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwich : MonoBehaviour
{
    private rajiv Rajiv;
    public Vector3 downPosition = new Vector3(0, -5, 0); // The target position when spacebar is not pressed
    public Vector3 originalPosition; // The original position of the object
    public bool eating;
    public Vector3 largeScale = new Vector3(1000f, 1000f, 1000f); // The large size scale
    public Vector3 originalScale; // Store the original scale of the object

    // Start is called before the first frame update
    void Start()
    {
        Rajiv = GetComponent<rajiv>();
        originalPosition = transform.position; // Store the initial position of the object
        originalScale = transform.localScale; // Store the initial scale of the object
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // When spacebar is pressed, set the object to its original position
            transform.position = originalPosition;
            eating = true;
        }
        else
        {
            // Move the object instantly to the downPosition when spacebar is not pressed
            transform.position = downPosition;
            eating = false;
        }

        if (Rajiv.facingClass && eating)
        {
            // Scale the sandwich object to be very big
            transform.localScale = largeScale;
        }
    }
}
