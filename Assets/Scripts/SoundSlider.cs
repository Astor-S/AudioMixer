using UnityEngine;
using UnityEngine.Audio;

public abstract class SoundSlider : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private float _minValueMusic = -80f;
    private float _maxValueMusic = 20f;

    protected abstract string ParameterName {get;}

    private void ChangeVolume(float volume)
    {
        float logVolume = Mathf.Log10(volume) * 20;
        logVolume = Mathf.Clamp(logVolume, _minValueMusic, _maxValueMusic);
        _mixer.SetFloat(ParameterName, logVolume);
    }
}