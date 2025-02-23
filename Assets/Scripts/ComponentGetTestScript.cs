using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        [SerializeField] private Rigidbody _rigidbody;
        private Collider _sphereCollider;

        private void Awake() 
        {
            _rigidbody = GetComponent<Rigidbody>();
            _sphereCollider = GetComponent<Collider>();    
        }
        private void Start() 
        {
            _rigidbody.useGravity = false;
        }
}
