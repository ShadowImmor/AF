using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TimeOfDays
{
    morning = 50,
    day = 100,
    evening = 35,
    night = 15,
}
public enum Weather
{
    no_cloudy,
    cloudy,
    rain,
    shower,
    radioactive_rain,
}

[Serializable]
public class ChangeTimeOfDaysAndWeatherManager : MonoBehaviour
{
    public static Action<TimeOfDays> changedTimeOfDays;
    public static TimeOfDays _timeOfDays = TimeOfDays.morning;

    public void Start()
    {
        StartCoroutine(enumerator());
    }

    IEnumerator enumerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            changedTimeOfDays?.Invoke(_timeOfDays);
            switch (_timeOfDays)
            {
                case TimeOfDays.morning:
                    {

                        _timeOfDays = TimeOfDays.day;
                        break;
                    }
                case TimeOfDays.day:
                    {
                        _timeOfDays = TimeOfDays.evening;
                        break;
                    }
                case TimeOfDays.evening:
                    {
                        _timeOfDays = TimeOfDays.night;
                        break;
                    }
                case TimeOfDays.night:
                    {
                        _timeOfDays = TimeOfDays.morning;
                        break;
                    }
            }
        }
    }
}
