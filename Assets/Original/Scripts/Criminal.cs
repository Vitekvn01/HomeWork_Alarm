using UnityEngine;

public class Criminal : MonoBehaviour
{
    private const string SpeedVariable = "Speed";
    
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
        _animator.SetFloat(SpeedVariable, _speed);
        transform.position += transform.forward * (_speed * Time.deltaTime);
    }
}
