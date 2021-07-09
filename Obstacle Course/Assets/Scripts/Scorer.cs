using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    private int score = 0;

    private void OnCollisionEnter(Collision other) {

        score += 1;
        Debug.Log(string.Format("Bumped into something {0} times", score));

    }
}
