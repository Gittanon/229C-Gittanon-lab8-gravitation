using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float force;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //force = 10.5f;
    }

    
    void Update()
    {
        rb.AddForce(new Vector3(0,0,force));    
    }
}
