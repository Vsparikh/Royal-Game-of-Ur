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

    [SerializeField]
    private string rollingTag; 

    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();
        spriteRenderer = transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
    }

    public bool IsRolling()
    {
        if (animController)
        {
            return animController.GetCurrentAnimatorStateInfo(0).IsTag(rollingTag);
        }

        Debug.LogWarning(this.gameObject.name + ": Anim Controller not found");
        return true;
    }
    public void RollDice(bool rollZero)
    {

        if (!animController)
        {
            Debug.LogWarning( this.gameObject.name + ": Anim Controller not found");
        }

        if (!spriteRenderer)
        {
            Debug.LogWarning(this.gameObject.name + ": Sprite render not found");
        }

        if (rollZero)
        {
            int index = Random.Range(0, zeroRollTriggers.Count);

            if (animController) 
            {
                animController.SetTrigger(zeroRollTriggers[index]);
            }
            
            if (spriteRenderer)
            {
                spriteRenderer.sprite = zeroRollSprite;
            }    
        }
        else
        {
            int index = Random.Range(0, oneRollTriggers.Count);

            if (animController)
            {
                animController.SetTrigger(oneRollTriggers[index]);
            }

            if (spriteRenderer)
            {
                spriteRenderer.sprite = oneRollSprite;
            } 
        }
    }
}
