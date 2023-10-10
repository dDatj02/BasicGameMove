using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    float speed = 500;
    void FixedUpdate()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hor, 0.5f, ver);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}
