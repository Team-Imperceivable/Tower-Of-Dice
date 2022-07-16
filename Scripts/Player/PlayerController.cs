using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool doneWithTurn;

    [SerializeField] private CombatHandler combatHandler;
    private FrameInputs inputs;

    private int selectedItemSlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GatherInputs();
        CheckSelect();
    }

    #region Selecting
    private void CheckSelect()
    {
        if(inputs.select)
        {
            Collider2D[] hitColliders = Physics2D.OverlapPointAll(inputs.mousePos);
            foreach(Collider2D collider in hitColliders)
            {
                if(collider != null && collider.tag.Equals("Enemy") && !doneWithTurn)
                {
                    if(selectedItemSlot != 0)
                    {
                        combatHandler.UseItem(selectedItemSlot, collider.gameObject);
                    }
                }
            }
        }
    }

    public void SelectItem(int selectedSlot)
    {
        selectedItemSlot = selectedSlot;
    }
    #endregion

    public void TakeTurn()
    {
        combatHandler.TakeTurn();
    }

    private void GatherInputs()
    {
        inputs = new FrameInputs
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition),
            select = Input.GetButtonDown("Fire1"),
            endTurn = Input.GetButtonDown("Jump")
        };
    }
}