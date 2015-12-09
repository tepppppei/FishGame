using UnityEngine;
using System.Collections;
using System;

public class FishScript : MonoBehaviour {
    SardineCharacter sardineCharacter;
    private bool startFlg = false;

    // Use this for initialization
    void Start () {
        sardineCharacter = GetComponent<SardineCharacter> ();
    }

    // Update is called once per frame
    void Update () {
        if (!startFlg) {
            startFlg = true;
            StartCoroutine(randomMove());
        }
    }

    IEnumerator randomMove() {
        while (true) {
            //進む方向
            int direction = UnityEngine.Random.Range(0, 1);
            //待機時間
            float waitTime = UnityEngine.Random.Range(0.5f, 2.0f);

            if (direction == 0) {
                sardineCharacter.TurnLeft();
            } else {
                sardineCharacter.TurnRight();
            }

            sardineCharacter.MoveForward();

            yield return new WaitForSeconds(waitTime);
        }
    }
}
