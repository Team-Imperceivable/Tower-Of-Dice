using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Die
{
    private List<int> sides;
    public Die(List<int> sidesOfDice)
    {
        sides = sidesOfDice;
    }

    public int Roll()
    {
        return sides[Random.Range(0, sides.Count)];
    }

    public List<int> GetSides()
    {
        return sides;
    }

    public int MaxRoll()
    {
        int max = System.Int32.MinValue;
        foreach (int num in sides)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}