using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreaterShield : Item
{
    public GreaterShield()
    {
        name = "Greater Shield";
        effect = "Block";
        description = "Now this is more like it";
        cost = 7;
        amount = 10;
    }
}