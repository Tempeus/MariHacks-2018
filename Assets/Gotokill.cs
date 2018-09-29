using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gotokill : MonoBehaviour
{

	

    void Start () {
        StartCoroutine(Example());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("3.attack");
    }
}
