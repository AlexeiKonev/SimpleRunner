using System;
using UnityEngine;

public class Generator : MonoBehaviour {
    public Transform parent;
    public GameObject[] prefs = new GameObject[4];
    public Action onRotated;
    int i = 0;
    void Start() {

        onRotated += DoSpawnObstacle;
        onRotated += DoDisableObstacle;


        foreach (Transform child in parent) {
            prefs[i] = child.gameObject;
            i++;
        }



        onRotated.Invoke();

        // Update is called once per frame
        void DoSpawnObstacle() {
            Debug.Log("DoSpawnObstacle");
        }
        void DoDisableObstacle() {
            Debug.Log("DoDisableObstacle");
        }
    }
}