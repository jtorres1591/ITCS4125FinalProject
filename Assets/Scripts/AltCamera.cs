using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltCamera : MonoBehaviour
{
    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(Input.GetAxis("Mouse Y") * -MouseSensitivity, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
    }
}
