using UnityEngine;

public class Changecolor : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.color = Color.pink;

        other.gameObject.GetComponent<Renderer>().material.color = Color.black;  
    
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.blue;

        other.gameObject.GetComponent<Renderer>().material.color = Color.orange;
    }
}
