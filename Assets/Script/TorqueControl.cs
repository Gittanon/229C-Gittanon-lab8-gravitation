using UnityEngine;

public class TorqueControl : MonoBehaviour
{
    public float TorquePower = 0f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        _rb.AddTorque(Vector3.right*TorquePower);

    
    }
}
