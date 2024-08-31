using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Cache
{
    private static Dictionary<Collider2D, Cell> bridgeCells = new Dictionary<Collider2D, Cell>();
    private static Dictionary<float, WaitForSeconds> bridgeWaitSecs = new Dictionary<float, WaitForSeconds>();

    public  static Cell GetCell(Collider2D col)
    {
        if(!bridgeCells.ContainsKey(col))
        {
            bridgeCells.Add(col, col.GetComponent<Cell>());
        }
        return bridgeCells[col];
    }

    public static WaitForSeconds GetWaitForSeconds(float waitSec)
    {
        if (!bridgeWaitSecs.ContainsKey(waitSec))
        {
            bridgeWaitSecs.Add(waitSec, new WaitForSeconds(waitSec));
        }
        return bridgeWaitSecs[waitSec];
    }
}
