using UnityEngine;

public class Chain : MonoBehaviour {
    public GameObject pref;
    int resolution = 64;
    void Start() {
        for (int y = 0; y < resolution; y++) {
            for (int x = 0; x < resolution; x++) {
                Instantiate(
                    pref, new Vector3(transform.position.x + x,
                    transform.position.y + y,
                    transform.position.z), transform.rotation
                   );
            }

        }
    }

    // Update is called once per frame
    void Update() {

    }
}
