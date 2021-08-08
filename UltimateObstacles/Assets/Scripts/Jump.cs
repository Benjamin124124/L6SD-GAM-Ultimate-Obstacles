using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField] private float _jumpforce = 300f;
    private bool _shouldJump;

    private void Awake() => _rigidbody = GetComponent<Rigidbody>();

    private void Update()
    {
        if (_shouldJump == false)
            _shouldJump = Input.GetKey(KeyCode.Space);
    }
    
    private void FixedUpdate()
    {
        if (_shouldJump)
            _rigidbody.AddForce(_jumpforce * Vector3.up);
            _shouldJump = false;
    }

}
