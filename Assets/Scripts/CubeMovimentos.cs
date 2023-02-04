using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovimentos : MonoBehaviour

{
    [SerializeField] private Rigidbody _body;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _speedRot = 360;

    private Vector3 _input;

    private void Update()
    {
        GatherInput();
        look();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void GatherInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    void look()
    {
        if (_input == Vector3.zero) return;
        {

        var relative = (transform.position + _input) - transform.position;
        var rot = Quaternion.LookRotation(relative, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot,_speedRot * Time.deltaTime);
        }
    }

    private void Move()
    {
        _body.MovePosition(transform.position + transform.forward * _input.normalized.magnitude * _speed * Time.deltaTime);
    }


}
