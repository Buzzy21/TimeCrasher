using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfxrb, sxfru, sxfrp, sxfre, sxfrd, sxfrbutton;

    public void playerBreak()
    {
        src.clip = sfxrb;
        src.Play();
    }
    public void playerUse()
    {
        src.clip = sxfru;
        src.Play();
    }
    public void playerPickup()
    {
        src.clip = sxfrp;
        src.Play();
    }
    public void dimensionSwitch()
    {
        src.clip = sxfrd;
        src.Play();
    }
    public void buttonPressed()
    {
        src.clip = sxfrbutton;
        src.Play();
    }
}
