using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName ="Location", menuName ="Map/Location")]
public class MapLocation : ScriptableObject
{
    public Sprite _morning;
    public Sprite _day;
    public Sprite _evening;
    public Sprite _night;
    public List<MapButton> _buttons;
}
