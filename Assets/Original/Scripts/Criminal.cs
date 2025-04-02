using System;
using UnityEngine;

public class Criminal : MonoBehaviour
{
    [SerializeField] private float _speed; 
    private void Update()
    {
        transform.position += transform.forward * (_speed * Time.deltaTime);
    }
}
