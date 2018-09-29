using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBar : MonoBehaviour {
	public float TimeBeforeAttack;
	public float CurrentTimeBeforeAttack;
	public float subtractPerSecond = 1;

	// Use this for initialization
	void Start ()
	{
		TimeBeforeAttack = CurrentTimeBeforeAttack;
	}


	public void Update() {
    //subtract at a constant rate
    CurrentTimeBeforeAttack -= subtractPerSecond * Time.deltaTime;
		if (CurrentTimeBeforeAttack <= 0)
			{
				CurrentTimeBeforeAttack = TimeBeforeAttack;
			}

		transform.localScale = new Vector3((CurrentTimeBeforeAttack / TimeBeforeAttack), 1, 1);
	}
}
