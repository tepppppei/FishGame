using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {
    private Vector3 touchPos;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            touchPos = Input.mousePosition;
        } else if (Input.GetMouseButtonUp(0)) {
            Vector3 releasePos = Input.mousePosition;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            touchEffect(worldPos.x, worldPos.y);
        }
    }

    void touchEffect(float x, float y) {
        GameObject circlePrefab = (GameObject)Resources.Load("Prefab/Circle");
        Instantiate (circlePrefab, new Vector3(x, y, -2), Quaternion.identity);
    }
}
