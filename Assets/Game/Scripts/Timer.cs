using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float waktu;
    public float MaximumWaktu;

    public TMP_Text TextTimer;
    public bool WaktuBerjalan = true;

    public Coroutine HitungTimerCoroutine;

    public Image ProgresFill;   //refere
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(HitungTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (waktu <= 0)
        {
            Load();
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

    public void Load()
    {
        SceneManager.LoadScene("GameOver");

    }
}
