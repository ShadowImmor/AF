using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Button", menuName = "Map/Button")]
public class MapButton : ScriptableObject
{
    public Sprite _ButtonSprite;
    [Range(-914f, 914f)]
    public float _PositionX;
    [Range(-494f, 494f)]
    public float _PositionY;
    [Range(0f, 360f)]
    public float _RotationZ;
    [Range(0f, 1f)]
    public float _Scale = 0.5f;
    public MapLocation _nextLocation;
}
