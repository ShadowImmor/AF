using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MapLocation_CampIntWithoutWindow", menuName = "Map/MapLocation_CampIntWithoutWindow")]
public class MapLocation_CampIntWithoutWindow : MapLocation
{
    public bool Light;
    [SerializeField] public Sprite _noLight;
    [SerializeField] public Sprite _Light;
}
