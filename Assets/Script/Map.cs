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

    private void changeTexture(TimeOfDays timeOfDays)
    {
        switch (timeOfDays)
        {
            case TimeOfDays.morning:
                {

                    _BG.sprite = _curentLocation._morning;
                    break;
                }
            case TimeOfDays.day:
                {
                    _BG.sprite = _curentLocation._day;
                    break;
                }
            case TimeOfDays.evening:
                {
                    _BG.sprite = _curentLocation._evening;
                    break;
                }
            case TimeOfDays.night:
                {
                    _BG.sprite = _curentLocation._night;
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

        Debug.Log(button._nextLocation._buttons.Count);
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
            Debug.Log(button._nextLocation._buttons[i]._RotationZ);
            buff.gameObject.GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, button._nextLocation._buttons[i]._RotationZ);
            buff.gameObject.GetComponent<RectTransform>().transform.localScale =
                new Vector3(button._nextLocation._buttons[i]._Scale, button._nextLocation._buttons[i]._Scale,
                button._nextLocation._buttons[i]._Scale);
            buff.AddComponent<ClickMapButton>();
            buff.GetComponent<ClickMapButton>()._mapButton = button._nextLocation._buttons[i];
            buff.GetComponent<ClickMapButton>()._map = this;
        }


        _curentLocation = button._nextLocation;
        ChangeTimeOfDaysAndWeatherManager.changedTimeOfDays?.Invoke(ChangeTimeOfDaysAndWeatherManager._timeOfDays);
    }
}
