using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public SoundEffectPlayer soundEffect;
    public void PressingButton()
    {
        soundEffect.buttonPressed();
    }
}
