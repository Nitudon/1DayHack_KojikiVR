using UnityEngine;
using UniRx;
using System.Collections;

public class ObjectManager : MonoBehaviour {

    [SerializeField]
    private GameObject Coin;

    [SerializeField]
    private GameObject Bug;

    [SerializeField]
    private GameObject Gavage;

    [SerializeField]
    private float Xoffset;

    [SerializeField]
    private float Zoffset;

    private GameObject Camera;

	// Use this for initialization
	void Start () {
        Camera = GameObject.FindGameObjectWithTag("Player");

        Observable.Interval(System.TimeSpan.FromSeconds(2f))
            .Subscribe(_ => CreateCoin());
	}

    void CreateCoin()
    {
        Vector3 position = Camera.transform.position;
        Vector3 CoinPosition = new Vector3(Random.Range(position.x+0.1f-Xoffset,position.x+Xoffset+0.1f), 0, Random.Range(position.z+Zoffset, position.z + Zoffset+0.2f));

        int judge = Random.Range(0, 12);
        if(judge<9)
        Instantiate(Coin,CoinPosition,Coin.transform.rotation);
        else if(judge == 10)
            Instantiate(Bug, CoinPosition, Coin.transform.rotation);
        else
        {
            Instantiate(Gavage, CoinPosition, Coin.transform.rotation);
        }

    }


	// Update is called once per frame
	void Update () {
	
	}
}
