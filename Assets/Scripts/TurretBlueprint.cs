using System.Collections;
using UnityEngine;

 [System.Serializable]
public class TurretBlueprint 
{
    public GameObject prefab;
    public int Cost;

    public GameObject upgradedPrefab;
    public int upgradeCost; 

    public int GetSellAmmount()
    {
        return Cost / 2; 
    }
}
