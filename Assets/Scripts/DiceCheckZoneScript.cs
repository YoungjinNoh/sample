using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }

    void OnTriggerStay(Collider col)
    {
        DiceScript dice = col.transform.parent.GetComponent<DiceScript>();
        if (dice.rb.velocity.x == 0f && dice.rb.velocity.y == 0f && dice.rb.velocity.z == 0f && !dice.finish)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    dice.FinishRoll(6);
                    break;
                case "Side2":
                    dice.FinishRoll(5);
                    break;
                case "Side3":
                    dice.FinishRoll(4);
                    break;
                case "Side4":
                    dice.FinishRoll(3);
                    break;
                case "Side5":
                    dice.FinishRoll(2);
                    break;
                case "Side6":
                    dice.FinishRoll(1);
                    break;
            }
        }
    }
}