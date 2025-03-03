using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class MenuController_Clase : MonoBehaviour
{
   
    // VARIABLES AUDIO

    public Slider Slider_Master;

    public Slider Slider_Music;

    public Slider Slider_Sfx;

    public AudioMixer AudioM;

    public EventSystem EvSy;

    //[SerializeField] AudioSource audioBoton;

    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1.0f;
        //master volume
        Slider_Master.value = PlayerPrefs.GetFloat("MasterVolumePP");
        AudioM.SetFloat("MasterVolume", Slider_Master.value);

        //music volume
        Slider_Music.value = PlayerPrefs.GetFloat("MusicVolumePP");
        AudioM.SetFloat("MusicVolume", Slider_Music.value);

        //sfx volume
        Slider_Sfx.value = PlayerPrefs.GetFloat("SfxVolumePP");
        AudioM.SetFloat("SfxVolume", Slider_Sfx.value);

       
    }


    //public void BotonSonido()
    //{
    //    audioBoton.Play();
    //}

    public void CambiarVolumenMaster()
    {
        //master volume
        AudioM.SetFloat("MasterVolume", Slider_Master.value);
        PlayerPrefs.SetFloat("MasterVolumePP", Slider_Master.value);
    }

    public void CambiarVolumenMusic()
    {
        //music volume
        AudioM.SetFloat("MusicVolume", Slider_Music.value);
        PlayerPrefs.SetFloat("MusicVolumePP", Slider_Music.value);
    }

    public void CambiarVolumenSfx()
    {
        //sfx volume
        AudioM.SetFloat("SfxVolume", Slider_Sfx.value);
        PlayerPrefs.SetFloat("SfxVolumePP", Slider_Sfx.value);

    }
    public void LoadScene(int scene)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Pausa()
    {
        Time.timeScale = 0.0f;
       
    }

    public void Volver()
    {
        Time.timeScale = 1.0f;
       
    }
}
