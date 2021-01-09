using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissappear : MonoBehaviour
{

        // Start is called before the first frame update
    void Start()
    {
        //Start the coroutine
        StartCoroutine(WaitCo());
    }

    IEnumerator WaitCo()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        gameObject.SetActive(false);
    }
}