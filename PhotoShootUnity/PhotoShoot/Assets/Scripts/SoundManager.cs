using UnityEngine;

public enum SoundType
{
    Ambient,
    Camera,
    GunShot
}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
    //Only one soundmanager
    //Can be accessed from anywhere
    private static SoundManager Instance;
    private AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(SoundType sound, float volume = 1)
    {
        Instance.audioSource.PlayOneShot(Instance.soundList[(int)sound], volume);
    }
}