using System;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    private AudioSource _alarmSound;

    private bool _isAlarm = false;
    
    private float _minVolume = 0f;
    private float _maxVolume = 1f;
    private float _currentVolume;
    private float _volumeChangeSpeed = 0.1f;

    public void StartAlarm()
    {
        _isAlarm = true;
        _alarmSound.Play();
    }

    public void EndAlarm()
    {
        _isAlarm = false;
    }
    
    private void Start()
    {
        _alarmSound = GetComponent<AudioSource>();
        _currentVolume = _alarmSound.volume;
    }

    private void Update()
    {
        if (_isAlarm)
        {
            AddMaxVolume();
        }
        else
        {
            RemoveMinVolume();

            if (_currentVolume == 0)
            {
                _alarmSound.Pause();
            }
        }
    }

    private void RemoveMinVolume()
    {
        _currentVolume = Mathf.MoveTowards(_currentVolume, _minVolume, _volumeChangeSpeed * Time.deltaTime);
        SetVolume(_currentVolume);
    }

    private void AddMaxVolume()
    {
        _currentVolume = Mathf.MoveTowards(_currentVolume, _maxVolume, _volumeChangeSpeed * Time.deltaTime);
        SetVolume(_currentVolume);
    }

    private void SetVolume(float volume)
    {
        _alarmSound.volume = volume;
    }
}
