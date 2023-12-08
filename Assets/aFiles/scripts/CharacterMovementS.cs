using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementS : MonoBehaviour
{
    public int currentMapNumber;
    public float speed = 5f;
    private void Awake()
    {
        currentMapNumber = 1;
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        movement.Normalize();

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
