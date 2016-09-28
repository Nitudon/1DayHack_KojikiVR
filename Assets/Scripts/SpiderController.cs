using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System.Collections;

public class SpiderController : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "GameController")
        {
            if (ScoreManager.Score > 500)
                ScoreManager.Score -= 500;
            else
                ScoreManager.Score = 0;
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
