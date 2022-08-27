using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MapLocation_CampExt", menuName = "Map/MapLocation_CampExt")]
public class MapLocation_CampExt : MapLocation
{
    [SerializeField] public TimesOfDaysSprites _noCloudy;
    [SerializeField] public TimesOfDaysSprites _cloudy;
}
