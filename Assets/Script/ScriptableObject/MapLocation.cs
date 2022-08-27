using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable] public struct TimesOfDaysSprites
{
    public Sprite _morning;
    public Sprite _day;
    public Sprite _evening;
    public Sprite _night;
}
public enum TypeLocation{
    CampExt,
    CampIntWithWindow,
    CampIntWithoutWindow,
}

[CreateAssetMenu(fileName ="Location", menuName ="Map/Location")]
public class MapLocation : ScriptableObject
{
    public TypeLocation _typeLocation;
    public List<MapButton> _buttons;
}
