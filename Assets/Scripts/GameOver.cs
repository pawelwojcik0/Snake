using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(BlinkText());
    }

    IEnumerator BlinkText()
    {
        while (true)
        {
            transform.localScale = Vector3.one;
            yield return new WaitForSeconds(0.5f);

            transform.localScale = Vector3.zero;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
