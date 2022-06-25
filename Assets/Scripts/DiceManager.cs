using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public GameObject nums;
    GameObject[] dices;
    // Start is called before the first frame update
    void Start()
    {
        dices = GameObject.FindGameObjectsWithTag("RollingDice");
    }

    // Update is called once per frame
    void Update()
    {
        bool chk = false;
        foreach (GameObject dice in dices)
        {
            if (!dice.GetComponent<DiceScript>().finish)
            {
                chk = true;
                break;
            }
        }

        if (chk)
            nums.SetActive(false);
        else
            nums.SetActive(true);
    }

    public void ShootDice()
    {
        foreach (GameObject dice in dices)
        {
            dice.GetComponent<DiceScript>().ShootDice();
        }
    }
}
