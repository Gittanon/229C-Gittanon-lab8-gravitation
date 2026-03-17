using UnityEngine;

public class RotationCollision : MonoBehaviour
{
    [SerializeField] float torque;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //force = 10.5f;
    }


    void Update()
    {
        //rb.AddForce(new Vector3.up);
    }
    private void OnCollisionEnter(Collision other)
    {
        other.rigidbody.AddTorque(Vector3.up * torque);   
    }
}
