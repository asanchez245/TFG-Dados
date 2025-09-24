using UnityEditor.Localization.Plugins.XLIFF.V20;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Controllers (auto-detect)")]
    [SerializeField] PlayerRun_Controller _PC;
    [SerializeField] SceneFade_Controller _SC;

    #region Accesos públicos
    public PlayerRun_Controller PC => _PC;
    public SceneFade_Controller SC => _SC;

    #endregion


    #region ------------------- SINGLETON -------------------
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            FindControllers(forceRefresh: true, verbose: false);   // primera escena
        }
        else
        {
            Destroy(gameObject);
            return; // evita que el duplicado haga nada más
        }
    }
    #endregion

    #region ------------------- SUBSCRIPCIÓN  -------------------
    void OnEnable() => SceneManager.sceneLoaded += OnSceneLoaded;
    void OnDisable() => SceneManager.sceneLoaded -= OnSceneLoaded;
    #endregion

    #region ------------------- CALLBACK DE ESCENA  -------------------
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        FindControllers(forceRefresh: true, verbose: true);
    }
    #endregion


    #region ------------------- BÚSQUEDA DE CONTROLADORES  -------------------
    /// <summary>Vuelve a localizar controladores en la escena.</summary>
    void FindControllers(bool forceRefresh = false, bool verbose = true)
    {
        // Player_Controller usa su propio singleton
        if (forceRefresh || _PC == null) _PC = PlayerRun_Controller.Instance;

        // El resto se buscan en la escena activa:
        _SC = GetOrFind(ref _SC, forceRefresh, verbose);

    }

    /// <summary>Devuelve el componente si existe o lo busca en escena.</summary>
    T GetOrFind<T>(ref T field, bool force, bool log) where T : Component
    {
        if (force) field = null;

        if (field == null)
        {
            // Busca todos los objetos de tipo T, incluyendo los inactivos
            var found = FindObjectsByType<T>(FindObjectsSortMode.None);
            if (found.Length > 0)
                field = found[0]; // Te quedas con el primero encontrado
        }
        return field;
    }

    #endregion


}
