using System.Collections.Generic;
using UnityEngine;

public class Board_Controller : MonoBehaviour
{
    GameManager _gameManager;

    public GameObject diceBoard;

    public List<GameObject> diceSlots = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = GameManager.Instance;

        foreach (Transform slot in diceBoard.transform)
        {
            diceSlots.Add(slot.gameObject);
        }
    }


}
