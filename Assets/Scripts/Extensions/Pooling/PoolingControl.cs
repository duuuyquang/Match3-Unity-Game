using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingControl : MonoBehaviour
{
    [SerializeField] PoolAmount[] poolAmounts;

    private void Awake()
    {
        // Load from resources
        GameUnit[] gameUnits = Resources.LoadAll<GameUnit>("Pool/");
        for (int i = 0; i < gameUnits.Length; i++)
        {
            SimplePool.Preload(gameUnits[i], 0, new GameObject(gameUnits[i].name).transform);
        }

        // Load from list
        for (int i = 0; i < poolAmounts.Length; i++)
        {
            SimplePool.Preload(poolAmounts[i].prefab, poolAmounts[i].amount, poolAmounts[i].parent);
        }
    }
}

public enum PoolType
{
    none                = -1,
    cellBackground      = 0,
    itemBonusBomb       = 1,
    itemBonusHorizontal = 2,
    itemBonusVertical   = 3,
    itemNormal01        = 4,
    itemNormal02        = 5,
    itemNormal03        = 6,
    itemNormal04        = 7,
    itemNormal05        = 8,
    itemNormal06        = 9,
    itemNormal07        = 10,
}

[System.Serializable]

public class PoolAmount
{
    public GameUnit prefab;
    public Transform parent;
    public int amount;
}