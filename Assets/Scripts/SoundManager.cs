using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSrc;
    [SerializeField] private Slider musicSlider;
    public float musicVolume = 0.6f;

    void Start(){
        AudioSrc.volume = musicVolume;
    }

    void Update(){
        AudioSrc.volume = musicSlider.value;
    }
    
    void Awake(){
        DontDestroyOnLoad(transform.gameObject);
    }
}