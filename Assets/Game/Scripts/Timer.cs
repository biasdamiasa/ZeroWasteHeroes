using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public ScoreScript scoreScript;
    public float waktu;
    public float MaximumWaktu;

    public TMP_Text TextTimer;
    public bool WaktuBerjalan = true;

    public Coroutine HitungTimerCoroutine;

    public Image ProgresFill;

    public int highScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(HitungTimer());
        if(PlayerPrefs.HasKey("highscore"))
        {
            highScore = PlayerPrefs.GetInt("highscore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (waktu <= 0)
        {
            PlayerPrefs.SetInt("lastscore", scoreScript.score);

            if(scoreScript.score > highScore)
            {
                highScore = scoreScript.score;
                PlayerPrefs.SetInt("highscore", highScore);                
            }

            PlayerPrefs.Save();

            if(scoreScript.score < 10)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                SceneManager.LoadScene("YouWin");
            } 

        }
    }

    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true)
        {
            waktu = waktu - 1;
            TextTimer.text = waktu.ToString();
            ProgresFill.fillAmount = waktu / MaximumWaktu;
            yield return new WaitForSeconds(1);
        }

    }

    // public void Load()
    // {
    //     SceneManager.LoadScene("GameOver");

    // }
}
