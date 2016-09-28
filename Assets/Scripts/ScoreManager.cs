using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UniRx;
using UniRx.Triggers;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static int Score;
    private int Time;

    [SerializeField]
    private GameObject ScorePanel;

    [SerializeField]
    private Text ScoreText;

    [SerializeField]
    private Text TimeText;

    [SerializeField]
    private Text ResultScoreText;

    [SerializeField]
    private Text ResultTimeText;

    [SerializeField]
    private GameObject ResultPanel;

    [SerializeField]
    private GameObject TitlePanel;

    [SerializeField]
    private GameObject StartLOGO;

    [SerializeField]
    private GameObject Bar;

    // Use this for initialization
    void Start () {

        Observable.Interval(System.TimeSpan.FromSeconds(1f))
           .Subscribe(_ => Time--);

        Observable.Timer(System.TimeSpan.FromSeconds(5f))
            .Subscribe(_ => TitlePanel.SetActive(false));

        TitlePanel.OnDisableAsObservable()
            .Subscribe(_ => StartLOGO.SetActive(true));

        StartLOGO.OnEnableAsObservable()
            .Delay(System.TimeSpan.FromSeconds(1f))
            .Subscribe(_ => { StartLOGO.SetActive(false);
                ScorePanel.SetActive(true);
            });


        Observable.EveryUpdate()
            .Where(_ => Time==0)
           .Subscribe(_ => ResultPanel.SetActive(true));

        ResultPanel.OnEnableAsObservable()
            .Subscribe(_ => {
                ScorePanel.SetActive(false);
                ResultScoreText.text = Score.ToString();
                ResultTimeText.text = (Score / 10).ToString();
            });

        ResultPanel.OnEnableAsObservable()
            .Delay(System.TimeSpan.FromSeconds(10f))
           .Subscribe(_ => {
               SceneManager.LoadScene("test");
           });


        Score = 0;
        Time = 66;
	}
	

	// Update is called once per frame
	void Update () {
        ScoreText.text ="所持金："+ Score.ToString() + "円";
        TimeText.text = "残り時間：" + Time.ToString();

    }
}
