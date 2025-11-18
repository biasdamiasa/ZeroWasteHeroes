using UnityEngine;

public class AudioObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public AudioSource _SFXDaurUlang;
   public AudioSource _SFXTdkDaurUlang;
   public AudioSource _SFXRacun;

   public void putarSFXDaurUlang ()
    {
        _SFXDaurUlang.Play();
        
    }

    public void putarSFXTdkDaurUlang ()
    {
        _SFXTdkDaurUlang.Play();
        
    }

    public void putarSFXRacun ()
    {
        _SFXRacun.Play();
        
    }
}
