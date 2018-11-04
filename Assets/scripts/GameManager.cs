using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject StartPage;
    public GameObject GameOverPage;
    public GameObject CountdownPage;
    public Text ScoreText;

    enum PageState
    {
        None,
        Start,
        GameOver,
        Countdown
    }
}
