using UnityEngine;
using UniRx;
using System.Collections;

public class VRFaceDirectionController : MonoBehaviour {

    [SerializeField]
    private GameObject MentalBar;

	// Use this for initialization
	void Start () {
        Observable.EveryUpdate()
            .Subscribe(_ => MentalBar.transform.position += new Vector3(0.3f,0f,0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
