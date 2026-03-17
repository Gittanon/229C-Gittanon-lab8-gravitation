using System.Collections.Generic;
using UnityEngine;

public class Gravitation : MonoBehaviour
{
    Rigidbody rb;
    const float G = 0.006674f;
    //List of attractable objects
    public static List<Gravitation> otherObjectList;

    [SerializeField] bool planet = false;
    [SerializeField] int orbitSpeed = 1000;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (otherObjectList == null)
        {
            otherObjectList = new List<Gravitation>();
        }

        otherObjectList.Add(this);

        if (!planet) { rb.AddForce(Vector3.left * orbitSpeed); }
    }

    private void FixedUpdate()
    {
        foreach (Gravitation obj in otherObjectList)
        {
         if (obj != this ){AttractForce(obj);}
        }
    }

    void AttractForce(Gravitation other)
    { 
        Rigidbody otherRb = other.rb;
        //หาทิศทางระหว่างวัตถุ
        Vector3 direction = rb.position - otherRb.position;
        //ระยะห่างระว่างวัตถุ
        float distance = direction.magnitude;
        //ถ้าวัตถุแยู่ตำแห่นงเดียวกันไม่ให้ทำอะไร
        if (distance == 0f) { return; }
        //ใช้สูตรหาแรงดึงดูด F = G*((m1*m2)/r^2)
        float forceMagnitude = G * (rb.mass * otherRb.mass) / Mathf.Pow(distance,2);

        Vector3 gravityForce = forceMagnitude * direction.normalized;

        otherRb.AddForce(gravityForce);
    }
}
