using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System.Collections;

public class CoinController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {

        if(collider.gameObject.tag == "GameController")
        {
            ScoreManager.Score += 100;
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {

   
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
