using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour {
	public Rigidbody rb;
	public GameObject numText;
	public bool finish = false;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ShootDice()
    {
		finish = false;
		float dirX = Random.Range(0, 500);
		float dirY = Random.Range(0, 500);
		float dirZ = Random.Range(0, 500);
		transform.position = startPos;
		transform.rotation = Quaternion.identity;
		rb.AddForce(transform.up * 500);
		rb.AddTorque(dirX, dirY, dirZ);
	}

	public void FinishRoll(int num)
    {
		finish = true;
		numText.GetComponent<Text>().text = num.ToString();
    }
}
