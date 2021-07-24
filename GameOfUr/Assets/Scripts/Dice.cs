using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Dice : MonoBehaviour
{
    [SerializeField]
    private Animator animController;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private List<string> zeroRollTriggers;

    [SerializeField]
    private List<string> oneRollTriggers;

    [SerializeField]
    private Sprite zeroRollSprite, oneRollSprite;

    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();
        spriteRenderer = transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
    }

    public void RollDice(bool rollZero)
    {
        if (rollZero)
        {
            int index = Random.Range(0, zeroRollTriggers.Count);

            animController.SetTrigger(zeroRollTriggers[index]);
            spriteRenderer.sprite = zeroRollSprite;
        }
        else
        {
            int index = Random.Range(0, oneRollTriggers.Count);

            animController.SetTrigger(oneRollTriggers[index]);
            spriteRenderer.sprite = oneRollSprite;
        }

    }
}
