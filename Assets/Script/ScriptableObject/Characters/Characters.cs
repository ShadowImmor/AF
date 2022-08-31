using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable] public struct main_characteristics
{
    public int _strength;
    public int _dexterity;
    public int _intelligence;
    public int _health;
}

[Serializable] public struct secondary_characteristics
{
    [Min(0)]
    public int _HP;
    public float _basic_lifting;
    public float _max_lifting;
    public float _speed;
    public int _will;
    public int _perception;
    public int _fatigue;
}
[Serializable] public struct sprites_emotions
{
    public List<GameObject> _body;
    public List<GameObject> _emotions;
    public List<GameObject> _other;
}

[CreateAssetMenu(fileName = "Character", menuName = "Characters/Character")]
public class Characters : ScriptableObject
{
    [Header("Main characteristics")]
    public main_characteristics _mainCharacteristics;
    [Header("Secondary characteristics")]
    [Tooltip("_HP = _strength*10\n" +
        "_basic_lifting = (_strength*_strength)/5\n" +
        "_max_lifting = (_strength*_strength)/2\n" +
        "_speed = _dexterity/2\n" +
        "_will = _intelligence\n" +
        "_perception = _intelligence\n" +
        "_fatigue = _health\n")]
    public secondary_characteristics _secondaryCharacteristics;
}
