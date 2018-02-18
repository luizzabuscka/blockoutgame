using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockScript : MonoBehaviour {

    private static int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Ball") {
            Destroy(gameObject);
            score++;
            Debug.Log("Score: "+score);
            if (score == 6) {
                Debug.Log("Todos destruidos!");   
                SceneManager.LoadScene("intro-scene");
                score = 0;
            }
        }   
    }
}
