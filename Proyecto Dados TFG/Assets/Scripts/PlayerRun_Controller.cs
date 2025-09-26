using System.Collections.Generic;
using UnityEngine;

public class PlayerRun_Controller : MonoBehaviour
{
    public static PlayerRun_Controller Instance { get; private set; }

    #region ------------------- SINGLETON -------------------
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return; // evita que el duplicado haga nada más
        }
    }
    #endregion

    public List<Dice_SO> initialDices;

    public List<Dice_SO> playerDices;

    public int dicesPerTurn = 3;


    void Start()
    {
        foreach (Dice_SO dice in initialDices)
        {
            playerDices.Add(dice);
        }
    }


}
