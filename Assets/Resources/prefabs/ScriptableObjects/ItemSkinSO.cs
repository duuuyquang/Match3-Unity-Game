using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NormalItem;

[CreateAssetMenu(menuName = "ItemSkinSO")]
public class ItemSkinSO : ScriptableObject
{
    [SerializeField] Sprite[] sprites;

    public Sprite GetSprite(eNormalType index)
    {
        return sprites[(int)index];
    }
}
