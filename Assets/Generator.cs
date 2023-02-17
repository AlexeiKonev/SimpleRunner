using UnityEngine;

public class Generator : MonoBehaviour {
    public Transform parent;
    public GameObject[] prefs = new GameObject[4];
    void Start() {



        for (int i = 0; i < prefs.Length ; i++) {
            foreach (Transform child in parent) {
                prefs[i] = child.gameObject;
            }

        }


        // Update is called once per frame
        void Update() {

        }
    }
}