using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class AngularVelocityConTrol : MonoBehaviour
{
    public float angularSpeed = 0f;

    private Rigidbody _rb;


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            _rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        else
        {
            _rb.angularVelocity = Vector3.zero;
        }
    }
}
