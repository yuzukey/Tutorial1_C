using UnityEngine;
using System.Collections;

public class Clear : MonoBehaviour {

    private int blockcount;
	
	// Update is called once per frame
	void Update () {
        blockcount = GameObject.FindGameObjectsWithTag("Block").Length;
        if (blockcount == 0) {
            Application.LoadLevel("Clear");
        }

	
	}
}
