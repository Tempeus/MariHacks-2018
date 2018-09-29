using UnityEngine;
using System.Collections;

public class TimedText : MonoBehaviour
{
		public float time = 5; //Seconds to read the text

		void Start ()
		{
				Destroy(gameObject, time);
		}
}
