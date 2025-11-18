using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource _SFX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void putarSFX ()
    {
        _SFX.Play();
        
    }
}
