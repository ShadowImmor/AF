using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    [SerializeField]private MapLocation _curentLocation;
    [SerializeField]private Image _BG;
    [SerializeField]private GameObject _ButtonPref;

    private void OnEnable()
    {
        ChangeTimeOfDaysAndWeatherManager.changedTimeOfDays += changeTexture;
    }
    private void OnDisable()
    {
        ChangeTimeOfDaysAndWeatherManager.changedTimeOfDays += changeTexture;
    }

    private void changeTexture(TimeOfDays timeOfDays, Weather weather)
    {
        switch (_curentLocation._typeLocation)
        {
            case TypeLocation.CampExt:
                {
                    switch (timeOfDays)
                    {
                        case TimeOfDays.morning:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._noCloudy._morning;
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._morning;
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._morning;
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._morning;
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._morning;
                                            break;
                                        }
                                }
                                break;
                            }
                        case TimeOfDays.day:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._noCloudy._day;
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._day;
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._day;
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._day;
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._day;
                                            break;
                                        }
                                }
                                break;
                            }
                        case TimeOfDays.evening:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._noCloudy._evening;
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._evening;
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._evening;
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._evening;
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._evening;
                                            break;
                                        }
                                }
                                break;
                            }
                        case TimeOfDays.night:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._noCloudy._night;
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._night;
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._night;
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._night;
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            _BG.sprite = (_curentLocation as MapLocation_CampExt)._cloudy._night;
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                    break;
                }
            case TypeLocation.CampIntWithWindow:
                {

                    switch (timeOfDays)
                    {
                        case TimeOfDays.morning:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyLight._morning;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyNoLight._morning;
                                            }
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._morning;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._morning;
                                            }
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._morning;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._morning;
                                            }
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._morning;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._morning;
                                            }
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._morning;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._morning;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case TimeOfDays.day:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyLight._day;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyNoLight._day;
                                            }
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._day;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._day;
                                            }
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._day;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._day;
                                            }
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._day;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._day;
                                            }
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._day;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._day;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case TimeOfDays.evening:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyLight._evening;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyNoLight._evening;
                                            }
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._evening;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._evening;
                                            }
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._evening;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._evening;
                                            }
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._evening;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._evening;
                                            }
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._evening;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._evening;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case TimeOfDays.night:
                            {
                                switch (weather)
                                {
                                    case Weather.no_cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyLight._night;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._noCloudyNoLight._night;
                                            }
                                            break;
                                        }
                                    case Weather.cloudy:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._night;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._night;
                                            }
                                            break;
                                        }
                                    case Weather.rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._night;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._night;
                                            }
                                            break;
                                        }
                                    case Weather.shower:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._night;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._night;
                                            }
                                            break;
                                        }
                                    case Weather.radioactive_rain:
                                        {
                                            if ((_curentLocation as MapLocation_CampIntWithWindow).Light)
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyLight._night;
                                            }
                                            else
                                            {
                                                _BG.sprite = (_curentLocation as MapLocation_CampIntWithWindow)._cloudyNoLight._night;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                    break;
                }
            case TypeLocation.CampIntWithoutWindow:
                {
                    if ((_curentLocation as MapLocation_CampIntWithoutWindow).Light)
                    {
                        _BG.sprite = (_curentLocation as MapLocation_CampIntWithoutWindow)._Light;
                    }
                    else
                    {
                        _BG.sprite = (_curentLocation as MapLocation_CampIntWithoutWindow)._noLight;
                    }
                    break;
                }
        }
    }

    public void changeCurentLocation(MapButton button)
    {
        GameObject buff;
        GameObject[] mapButtons = GameObject.FindGameObjectsWithTag("MapButton");

        for (int i = 0; i < mapButtons.Length; i++)
        {
            Destroy(mapButtons[i]);
        }

        //Debug.Log(button._nextLocation._buttons.Count);
        for (int i = 0; i < button._nextLocation._buttons.Count; i++)
        {
            buff = Instantiate(_ButtonPref, 
                new Vector3(button._nextLocation._buttons[i]._PositionX, button._nextLocation._buttons[i]._PositionY),
                new Quaternion(0, 0, button._nextLocation._buttons[i]._RotationZ, 0),
                _BG.gameObject.transform.parent.transform);
            buff.GetComponent<Image>().sprite = button._nextLocation._buttons[i]._ButtonSprite;
            /*buff.gameObject.GetComponent<RectTransform>().transform.SetPositionAndRotation(
                new Vector3(button._nextLocation._buttons[i]._PositionX, button._nextLocation._buttons[i]._PositionY),
                new Quaternion(0, 0, button._nextLocation._buttons[i]._RotationZ,0));*/
            buff.gameObject.GetComponent<RectTransform>().transform.localPosition = 
                new Vector3(button._nextLocation._buttons[i]._PositionX, button._nextLocation._buttons[i]._PositionY);
            //Debug.Log(button._nextLocation._buttons[i]._RotationZ);
            buff.gameObject.GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, button._nextLocation._buttons[i]._RotationZ);
            buff.gameObject.GetComponent<RectTransform>().transform.localScale =
                new Vector3(button._nextLocation._buttons[i]._Scale, button._nextLocation._buttons[i]._Scale,
                button._nextLocation._buttons[i]._Scale);
            buff.AddComponent<ClickMapButton>();
            buff.GetComponent<ClickMapButton>()._mapButton = button._nextLocation._buttons[i];
            buff.GetComponent<ClickMapButton>()._map = this;
        }


        _curentLocation = button._nextLocation;
        ChangeTimeOfDaysAndWeatherManager.changedTimeOfDays?.Invoke(ChangeTimeOfDaysAndWeatherManager._timeOfDays, ChangeTimeOfDaysAndWeatherManager._weather);
    }
}
