using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotoback : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(4);

        SceneManager.LoadScene("Main");
    }
}
