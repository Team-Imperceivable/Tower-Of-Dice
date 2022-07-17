using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingGem : Item
{
    public HealingGem()
    {
        name = "Healing Gem";
        effect = "Heal";
        description = "Heal 1hp";
        cost = 4;
        amount = 1;
        diceSides = 0;
        uses = -1;
    }
}
