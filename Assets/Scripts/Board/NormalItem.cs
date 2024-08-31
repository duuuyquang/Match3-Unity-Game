using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    //public override void SetView()
    //{
    //    PoolType type = GetPoolType();

    //    //View = GameObject.Instantiate(prefab).transform;
    //    View = SimplePool.Spawn<GameUnit>(type, Vector2.zero, Quaternion.identity).transform;
    //    View.transform.localScale = Vector2.one;
    //}

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_ONE;
                break;
            case eNormalType.TYPE_TWO:
                prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
                break;
            case eNormalType.TYPE_THREE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
                break;
            case eNormalType.TYPE_FOUR:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
                break;
            case eNormalType.TYPE_FIVE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
                break;
            case eNormalType.TYPE_SIX:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
                break;
            case eNormalType.TYPE_SEVEN:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
                break;
        }

        return prefabname;
    }

    protected override PoolType GetPoolType()
    {
        PoolType type = PoolType.itemNormal01;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                type = PoolType.itemNormal01;
                break;
            case eNormalType.TYPE_TWO:
                type = PoolType.itemNormal02;
                break;
            case eNormalType.TYPE_THREE:
                type = PoolType.itemNormal03;
                break;
            case eNormalType.TYPE_FOUR:
                type = PoolType.itemNormal04;
                break;
            case eNormalType.TYPE_FIVE:
                type = PoolType.itemNormal05;
                break;
            case eNormalType.TYPE_SIX:
                type = PoolType.itemNormal06;
                break;
            case eNormalType.TYPE_SEVEN:
                type = PoolType.itemNormal07;
                break;
        }

        return type;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
