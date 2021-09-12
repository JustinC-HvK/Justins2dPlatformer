using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is always calling, Once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Ground") {
            Destroy(collision.gameObject);
        }
    }
}
