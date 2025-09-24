using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceGenerator_Controller : MonoBehaviour
{
    GameManager _gameManager;
    PlayerRun_Controller _playerRunController;

    public GameObject dicePrefab;
    GameObject _instantiatedDice;

    public List<Dice_SO> dicePool;
    public List<GameObject> playerDiceSlots;
    bool diceInstantiated = false;

    void Start()
    {
        _gameManager = GameManager.Instance;
        _playerRunController = PlayerRun_Controller.Instance;

        dicePool = _playerRunController.playerDices;
    }

    public void GenerateRoundDices()
    {
        for (int i = 0; i < _playerRunController.dicesPerRound; i++)
        {
            int randomIndex = Random.Range(0, dicePool.Count);
            Dice_SO selectedDice = dicePool[randomIndex];
            Debug.Log($"Dado {i + 1}: {selectedDice.diceName}");
            InstantiateNewDice();
            if (!diceInstantiated) break;
            DiceInfo_Controller diceInfo = _instantiatedDice.GetComponent<DiceInfo_Controller>();
            LoadDiceStats(diceInfo, selectedDice);
            dicePool.RemoveAt(randomIndex);
        }
    }

    public void InstantiateNewDice()
    {
        for(int i = 0; i < playerDiceSlots.Count-1; i++)
        {
            if(i == playerDiceSlots.Count && !SlotIsAvalaible(playerDiceSlots[i]))
            {
                Debug.Log("No hay espacio para más dados");
                diceInstantiated = false;
                break;
            }
            if (SlotIsAvalaible(playerDiceSlots[i]))
            {
                Debug.Log("slot disponible");

                _instantiatedDice = Instantiate(dicePrefab, transform.position, Quaternion.identity, playerDiceSlots[i].transform);
                diceInstantiated = true;
                break;
            }
            else
            {
                if (playerDiceSlots[i+1] != null && SlotIsAvalaible(playerDiceSlots[i + 1]))
                {
                    Debug.Log("agregando en siguiente slot");

                    _instantiatedDice = Instantiate(dicePrefab, transform.position, Quaternion.identity, playerDiceSlots[i+1].transform);
                    diceInstantiated = true;
                    break;
                }

                diceInstantiated = false;
                Debug.Log("No hay espacio para más dados");              
            }
        }
    }

    public bool SlotIsAvalaible(GameObject diceSLot)
    {
        if (diceSLot.transform.childCount == 0)
        {
            return true;
        }      
        return false;
    }

    public void LoadDiceStats(DiceInfo_Controller diceInfo, Dice_SO diceSO)
    {
        diceInfo.diceSO = diceSO;
        diceInfo.originalValue = Random.Range(0, 6);
        LoadDiceSprite(_instantiatedDice, diceSO, diceInfo.originalValue);
    }

    public void LoadDiceSprite(GameObject diceGO, Dice_SO diceSO, int diceFaceNumber)
    {
        diceGO.GetComponent<Image>().sprite = diceSO.facesSprites[diceFaceNumber];
    }

}
