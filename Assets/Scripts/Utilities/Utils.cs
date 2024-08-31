using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(List<NormalItem.eNormalType> types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }

    public static NormalItem.eNormalType GetLeastNormalTypeExcept(List<NormalItem.eNormalType> types, Dictionary<NormalItem.eNormalType, int> CurLeastTypeAmountOnBoard)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int leastAmount = -1;
        NormalItem.eNormalType leastType = list[0];
        foreach( NormalItem.eNormalType type in list )
        {
            if (CurLeastTypeAmountOnBoard.ContainsKey(type)) {
                if (leastAmount == -1)
                {
                    leastAmount = CurLeastTypeAmountOnBoard[type];
                    leastType = type;
                }

                if (leastAmount >= CurLeastTypeAmountOnBoard[type])
                {
                    leastAmount = CurLeastTypeAmountOnBoard[type];
                    leastType = type;
                }
            }
        }

        return leastType;
    }
}
