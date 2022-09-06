using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : MonoBehaviour
{
    private CharacterController _controller;
    
    private Vector3 _moveDir;
    private Vector3 _lookDir;
    
    public float _speed = 10f;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        transform.Rotate(transform.up, _lookDir.x);
        
        var right = transform.right;
        var forward = transform.forward;
        var hMovement = new Vector3(right.x, 0f, right.z) * _moveDir.x;
        var vMovement = new Vector3(forward.x, 0f, forward.z) * _moveDir.z;
        _controller.SimpleMove((hMovement + vMovement) * _speed);
    }

    private void OnMove(InputValue value)
    {
        var dir = value.Get<Vector2>();
        _moveDir = new Vector3(dir.x, 0, dir.y);
        
    }

    private void OnLook(InputValue value)
    {
        var dir = value.Get<Vector2>();
        _lookDir = new Vector3(dir.x, 0, dir.y);
    }
}
