using UnityEngine;

public class RoundScore_Controller : MonoBehaviour
{
    GameManager _gameManager;
    [SerializeField] Board_Controller _boardController;

    [SerializeField] int turnScore;
    [SerializeField] int roundScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateRoundScore()
    {
        foreach (var dice in _boardController.diceSlots)
        {
            turnScore += dice.GetComponent<DiceInfo_Controller>().finalValue;
        }
    }
}
