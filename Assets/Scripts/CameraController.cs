using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Rigidbody player;
    public float sensitivity;

    private Vector3 offset;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    private void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
            transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);
        }
    }
}
