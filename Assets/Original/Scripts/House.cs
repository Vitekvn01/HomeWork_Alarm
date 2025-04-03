using UnityEngine;

public class House : MonoBehaviour
{
    private Alarm _alarm;
    
    private void Awake()
    {
        _alarm = GetComponentInChildren<Alarm>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Criminal>() != null)
        {
            _alarm.StartAlarm();
            Debug.Log("Вор в здании!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Criminal>() != null)
        {
            _alarm.EndAlarm();
            Debug.Log("Вор ушел!");
        }
    }
}
