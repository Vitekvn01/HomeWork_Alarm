using UnityEngine;

public class Criminal : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;

    private void OnValidate()
    {
        if (_speed < 0)
        {
            _speed = 0;
        }
    }

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        _animator.SetFloat("Speed", _speed);
        transform.position += transform.forward * (_speed * Time.deltaTime);
    }
}
