using UnityEngine;

public class CollisionTriggerTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
    }
}
