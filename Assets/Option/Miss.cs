using UnityEngine;
using System.Collections;

public class Miss : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Miss")) {
            Application.LoadLevel("GameOver");
        }
    }
}
