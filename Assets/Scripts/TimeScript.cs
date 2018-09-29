using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : WordManager {
	public float TotalHP;
	public float CurrentHP;
	public float subtractPerSecond = 1;


	// Use this for initialization
	void Start ()
	{
		CurrentHP = TotalHP;
	}


	public void Update()
    {
        if (Game == true)
        {
            CurrentHP -= subtractPerSecond * Time.deltaTime;
            transform.localScale = new Vector3((CurrentHP / TotalHP), 1, 1);
        }

        if (CurrentHP <= 0  )
        {
            Game = false;
        }
	}
}
