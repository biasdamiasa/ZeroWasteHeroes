using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text scoreText;

    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;        
    }

    public void tambahScore()
    {
        score += 5;
    }

    public void kurangScore()
    {
        score -= 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D objectTerdeteksi = Physics2D.OverlapPoint(posisiKlik);

            // GameObject objectHapus = objectTerdeteksi.gameObject;

            if (objectTerdeteksi != null)
            {
                if(objectTerdeteksi.CompareTag("daurulang"))
                {
                    GameObject objectHapus = objectTerdeteksi.gameObject;
                    Debug.Log("sampah daur ulang diklik");
                    // Debug.Log("Object dihapus: " + objectHapus.name);
                    Destroy(objectHapus);
                    tambahScore();
                }
                else if(objectTerdeteksi.CompareTag("tdkdaurulang"))
                {
                    GameObject objectHapus = objectTerdeteksi.gameObject;
                    Debug.Log("sampah tidak daur ulang diklik");
                    // Debug.Log("Object dihapus: " + objectHapus.name);
                    Destroy(objectHapus);
                    kurangScore();
                }
                else
                {
                    GameObject objectHapus = objectTerdeteksi.gameObject;
                    Debug.Log("racun diklik");
                    // Debug.Log("Object dihapus: " + objectHapus.name);
                    Destroy(objectHapus);
                    score = 0;
                }
                scoreText.text = "Score: " + score.ToString();
            }
        }
    }
}
