using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;




public class SettingsPanel : MonoBehaviour
{
    [Header("Settings Menu")]
    [SerializeField] private GameObject _sliderVolume;
    [SerializeField] private AudioMixer _audioMixer;
    public Slider _slider;
    public Toggle _toggle;
    public float _currentVolume;

    [Header("Quality settings")]
    [Tooltip("Reference to dropdown")]
    [SerializeField] private Dropdown qualityDropdown;

    public void SetQualityLevelDropdown(int index)
    {
        
        QualitySettings.SetQualityLevel(index, false);
        Debug.Log(index);
    }

    public void SetResolutionLevelDropdown(int index)
    {
        if (index == 0)
        {
            Screen.SetResolution(800,600, true);
        }
        if (index == 1)
        {
            Screen.SetResolution(1280,720, true);
        }
        if (index == 2)
        {
            Screen.SetResolution(1920,1080, true);
        }
    }


    //[SerializeField] private AudioSource ClickSound;


    
    private void Start()
    {
        LoadSettings();   
    }
    public void SetVolume(float desiredVolume)
    {
        //PlayerPrefs.SetFloat("Volume", desiredVolume);
        _currentVolume = desiredVolume;
        _audioMixer.SetFloat("Master", _currentVolume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    public void SaveSettings()
    {
        //ClickSound.Play();
        PlayerPrefs.SetFloat("Volume", _currentVolume);
        PlayerPrefs.SetInt("Fullscreen", System.Convert.ToInt32(Screen.fullScreen));

    }
    public void LoadSettings() 
    {
        if (PlayerPrefs.HasKey("Fullscreen"))
        {
            _toggle.isOn = System.Convert.ToBoolean(PlayerPrefs.GetInt("Fullscreen"));
            Screen.fullScreen = System.Convert.ToBoolean(PlayerPrefs.GetInt("Fullscreen"));
        }
        else
        { 
            _toggle.isOn = true;
            Screen.fullScreen = true;
        }

        if (PlayerPrefs.HasKey("Volume"))
        {
            _slider.value = PlayerPrefs.GetFloat("Volume");
            _audioMixer.SetFloat("Master", PlayerPrefs.GetFloat("Volume") );
        }
        else
        {
            _slider.value = 0;
            _audioMixer.SetFloat("Master",0);
        }
    }
    public void Reset()
    {
        
    }
}