using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    CharacterController character;
    public Transform cameraTransform;
    bool moving = false;
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        character = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraTransform.eulerAngles.x > 35.0f && cameraTransform.eulerAngles.x < 90.0f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        if (moving)
        {
            Vector3 CameraOrientation = cameraTransform.TransformDirection(Vector3.forward);
            character.SimpleMove(CameraOrientation*speed);
        }
    }
}
