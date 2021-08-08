using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _moveForce = 10f;

    private void Awake() => _rigidbody = GetComponent<Rigidbody>();
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(_moveForce * Vector3.right);

        if (Input.GetKey(KeyCode.A))
            _rigidbody.AddForce(_moveForce * Vector3.left);

        if (Input.GetKey(KeyCode.W))
            _rigidbody.AddForce(_moveForce * Vector3.forward);

        if (Input.GetKey(KeyCode.S))
            _rigidbody.AddForce(_moveForce * Vector3.back);

        if (Input.GetKey(KeyCode.R))
            transform.position = new Vector3(0,1f,0);

    }
}
