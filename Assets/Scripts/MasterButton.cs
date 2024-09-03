using UnityEngine;
using UnityEngine.Audio;

public class MasterButton : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private string _parameterName = "MasterVolume";

    private float _minValueMusic = -80f;
    private float _unmuteValueMusic = 0f;

    public void MuteMaster()
    {
        _mixer.SetFloat(_parameterName, _minValueMusic);
    }

    public void UnmuteMaster()
    {
        _mixer.SetFloat(_parameterName, _unmuteValueMusic); 
    }
}