using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterShield : Item
{
    public StarterShield()
    {
        name = "Starter Shield";
        effect = "Block";
        description = "Block 2";
        cost = 3;
        amount = 2;
        diceSides = 0;
        uses = -1;
    }
}
