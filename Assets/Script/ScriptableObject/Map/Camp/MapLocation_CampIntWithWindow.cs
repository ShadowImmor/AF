using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MapLocation_CampIntWithWindow", menuName = "Map/MapLocation_CampIntWithWindow")]
public class MapLocation_CampIntWithWindow : MapLocation
{
    public bool Light;
    [Header("Sprite with light")]
    [SerializeField] public TimesOfDaysSprites _noCloudyLight;
    [SerializeField] public TimesOfDaysSprites _cloudyLight;
    [Header("Sprite without light")]
    [SerializeField] public TimesOfDaysSprites _noCloudyNoLight;
    [SerializeField] public TimesOfDaysSprites _cloudyNoLight;
}
