using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Character_people", menuName = "Characters/Character_people")]
public class Characters_people : Characters
{
    [Header("Buff Main characteristics")]
    public main_characteristics _mainCharacteristicsBuff;
    [Header("Buff Secondary characteristics")]
    public secondary_characteristics _secondaryCharacteristicsBuff;
    [Header("Emotions with sprite body")]
    public List<sprites_emotions> _closeSpritesEmotions;
    public List<sprites_emotions> _farSpritesEmotions;
    public List<sprites_emotions> _normalSpritesEmotions;
}
