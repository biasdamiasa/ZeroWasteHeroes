using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LoseWin : MonoBehaviour
{
    public TMP_Text textHighScore;
    public int highScore, lastscore;
    public TMP_Text textScore;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(PlayerPrefs.HasKey("highscore")) // untuk ambil nilai highscore
        {
            highScore = PlayerPrefs.GetInt("highscore");
            textHighScore.text = "Highscore: " + highScore.ToString(); //untuk menampilkan highscore
        }

        if(PlayerPrefs.HasKey("lastscore"))
        {
            lastscore = PlayerPrefs.GetInt("lastscore"); // untuk ambil nilai lastscore karena yang terakhir kita main
            textScore.text = "Score: " + lastscore.ToString();
        }
    }

    public void MainLagi()
    {
        SceneManager.LoadScene("GamePlay"); // untuk pindah ke scene GamePlay
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Debug.Log("Keluar dari Game"); 
        
        // Perintah standar untuk keluar dari aplikasi. 
        // Ini hanya akan bekerja saat game sudah di-build (file .exe).
        Application.Quit();

        // Optional: Baris di bawah ini hanya untuk membuat tombol Quit berfungsi
        // saat Anda mengujinya di Unity Editor. Hapus baris ini saat di-build.
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}    
