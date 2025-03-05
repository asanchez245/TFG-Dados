using DG.Tweening;
using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Camera _virtualCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void CameraShakes(float intensity, float duration)
    //{
    //    CinemachineBasicMultiChannelPerlin noise = _virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

    //    // Asegurar que el ruido comienza en 0
    //    noise.m_AmplitudeGain = 0;

    //    // Aplicar DOTween: sube a la intensidad deseada y luego baja a 0
    //    DOTween.To(() => noise.m_AmplitudeGain, x => noise.m_AmplitudeGain = x, intensity, duration * 0.5f)
    //        .OnComplete(() =>
    //        {
    //            DOTween.To(() => noise.m_AmplitudeGain, x => noise.m_AmplitudeGain = x, 0, duration * 0.5f);
    //        });
    //}
}
