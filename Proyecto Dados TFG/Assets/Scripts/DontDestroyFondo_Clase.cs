using UnityEngine;

public class DontDestroyFondo_Clase : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    } 
}
