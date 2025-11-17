using System.Collections;
using UnityEngine;

public class ScriptSampahManager : MonoBehaviour
{
    public GameObject daurUlangObject;
    public GameObject tdkDaurUlangObject;
    public GameObject racunObject;
    public bool masihSpawn = true;

    public Sprite[] daftarGambarDaurUlang;
    public Sprite[] daftarGambarTdkDaurUlang;
    public Sprite[] daftarGambarRacun;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnDaurUlang());
        StartCoroutine(spawnTdkDaurUlang());
        StartCoroutine(spawnRacun());
        
    }

    IEnumerator spawnDaurUlang()
    {
        while (masihSpawn)
        {
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), 5, 0);

            //Instantiate 1 daurUlangObject di spawnPosition kemudian simpan di objectBaru
            GameObject objectBaru = Instantiate(daurUlangObject, spawnPosition, Quaternion.identity);

            // cek apakah array gambar untuk sampah daur ulang > 0
            if(daftarGambarDaurUlang.Length > 0)
            {
                // ambil nilai random dari 0 s.d. Length daftarGambarDaurUlang untuk menentukan index gambar yang mau ditampilkan
                int index = Random.Range(0, daftarGambarDaurUlang.Length);

                //buat object Sprite untuk menyimpan gambar sampah daur ulang terpilih melalui pengacakan index
                Sprite gambarTerpilih = daftarGambarDaurUlang[index];

                //render objectBaru dengan gambar terpilih
                objectBaru.GetComponent<SpriteRenderer>().sprite = gambarTerpilih;
                
                BoxCollider2D colliderBox = objectBaru.GetComponent<BoxCollider2D>();

                if(colliderBox != null)
                {
                    colliderBox.size = gambarTerpilih.bounds.size;
                    colliderBox.offset = Vector2.zero;
                }
                
            }

            //menentukan delay s.d. pemanggilan berikutnya di 2 detik
            yield return new WaitForSeconds(2);            
        }
    }

    IEnumerator spawnTdkDaurUlang()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(5);            
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), 5, 0);

            //Instantiate 1 tdkDaurUlangObject di spawnPosition kemudian simpan di objectBaru
            GameObject objectBaru = Instantiate(tdkDaurUlangObject, spawnPosition, Quaternion.identity);

            // cek apakah array daftarGambarTdkDaurUlang > 0
            if(daftarGambarTdkDaurUlang.Length > 0)
            {
                // ambil nilai random dari 0 s.d. Length daftarGambarTdkDaurUlang untuk menentukan index gambar yang mau ditampilkan
                int index = Random.Range(0, daftarGambarTdkDaurUlang.Length);

                //buat object Sprite untuk menyimpan gambar sampah tidak daur ulang terpilih melalui pengacakan index
                Sprite gambarTerpilih = daftarGambarTdkDaurUlang[index];

                //render objectBaru dengan gambar terpilih
                objectBaru.GetComponent<SpriteRenderer>().sprite = gambarTerpilih;
                
                BoxCollider2D colliderBox = objectBaru.GetComponent<BoxCollider2D>();

                if(colliderBox != null)
                {
                    colliderBox.size = gambarTerpilih.bounds.size;
                    colliderBox.offset = Vector2.zero;
                }
            }

            //menentukan delay s.d. pemanggilan berikutnya di 2 detik
        }
    }

    IEnumerator spawnRacun()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(7);            
            //ambil posisi untuk spawn dengan posisi x antara -8 s.d. 8 dan posisi y tetap di 5
            Vector3 spawnPosition = new Vector3(Random.Range(-8,8), 5, 0);

            //Instantiate 1 tdkDaurUlangObject di spawnPosition kemudian simpan di objectBaru
            GameObject objectBaru = Instantiate(racunObject, spawnPosition, Quaternion.identity);

            // cek apakah array gambar untuk racun > 0
            if(daftarGambarRacun.Length > 0)
            {
                // ambil nilai random dari 0 s.d. Length daftarGambarRacun untuk menentukan index gambar yang mau ditampilkan
                int index = Random.Range(0, daftarGambarRacun.Length);

                //buat object Sprite untuk menyimpan gambar racun yang dipilih melalui pengacakan index
                Sprite gambarTerpilih = daftarGambarRacun[index];

                //render objectBaru dengan gambar terpilih
                objectBaru.GetComponent<SpriteRenderer>().sprite = gambarTerpilih;
                
                BoxCollider2D colliderBox = objectBaru.GetComponent<BoxCollider2D>();

                if(colliderBox != null)
                {
                    colliderBox.size = gambarTerpilih.bounds.size;
                    colliderBox.offset = Vector2.zero;
                }
            }

            //menentukan delay s.d. pemanggilan berikutnya di 2 detik
        }
    }
}
