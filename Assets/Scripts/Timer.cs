using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : WordManager
{
    public int timeLeft = 300;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
        //Game = true;
        timeLeft = 300;
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);

        if (timeLeft <= 0||!Game)
        {
            timeLeft = 0;
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
        }
    }


    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
