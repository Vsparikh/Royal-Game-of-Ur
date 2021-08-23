using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    [SerializeField]
    private Dice[] dices;

    private int[] diceValues = new int[4];
    private int result = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnRollDice()
    {
        if (!canRoll())
        {
            Debug.LogWarning("Cannot Roll Dice, because dice is already rolling");
            return;
        }

        result = 0;
        for (int i = 0; i < diceValues.Length; ++i)
        {
            diceValues[i] = Random.Range(0, 2);
            result += diceValues[i];
            dices[i].RollDice(diceValues[i] == 0);
        }

        Debug.LogFormat("Dice Roll Result: {1} [{0}]", string.Join(", ", diceValues), result);
    }

    public bool canRoll()
    {
        foreach (Dice dice in dices)
        {
            if (dice.IsRolling())
            {
                return false;
            }
               
        }
        return true;
    }
}