using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class GameController : MonoBehaviour
{
    DiceMovement_Clase diceMovement_Clase;
    [SerializeField] GameObject diceMovement;

    PointsManager_Clase pointsManager_Clase;
    [SerializeField] GameObject pointsManager;

    [Header("Paneles fin de juego")]
    [SerializeField] GameObject panelWinP1_GO;
    [SerializeField] GameObject panelWinP2_GO;
    [SerializeField] GameObject panelEmpate_GO;
    [SerializeField] GameObject botonReset;
    [SerializeField] GameObject botonMainMenu;



    public int[] rowResult;
    public int rowsWinnedP1;
    public int rowsWinnedP2;

    public int roundsWinnedP1;
    public int roundsWinnedP2;


    void Start()
    {
        diceMovement_Clase = diceMovement.GetComponent<DiceMovement_Clase>();
        pointsManager_Clase = pointsManager.GetComponent<PointsManager_Clase>();
        panelWinP1_GO.SetActive(false);
        panelWinP2_GO.SetActive(false);
        panelEmpate_GO.SetActive(false);
    }

    public void EndGame()
    {
        CompareRowPoints();
        SelectRoundWinner();
        StartCoroutine(SelectGameWinner());
    }

    public void CompareRowPoints()
    {
        rowResult[0] = pointsManager_Clase.rowTotalValueP1[0] - pointsManager_Clase.rowTotalValueP2[0];
        rowResult[1] = pointsManager_Clase.rowTotalValueP1[1] - pointsManager_Clase.rowTotalValueP2[1];
        rowResult[2] = pointsManager_Clase.rowTotalValueP1[2] - pointsManager_Clase.rowTotalValueP2[2];


        switch (rowResult[0] == 0)
        {
            case true:
                //EMPATE
                break;

            case false:
                if (rowResult[0] > 0)
                {
                    //GANA LA LINEA P1
                    rowsWinnedP1 += 1;
                }
                else
                {
                    //GANA LA LINEA P2
                    rowsWinnedP2 += 1;
                }

                break;
        }
        switch (rowResult[1] == 0)
        {
            case true:
                //EMPATE
                break;

            case false:
                if (rowResult[1] > 0)
                {
                    //GANA LA LINEA P1
                    rowsWinnedP1 += 1;
                }
                else
                {
                    //GANA LA LINEA P2
                    rowsWinnedP2 += 1;
                }

                break;
        }
        switch (rowResult[2] == 0)
        {
            case true:
                //EMPATE
                break;

            case false:
                if (rowResult[2] > 0)
                {
                    //GANA LA LINEA P1
                    rowsWinnedP1 += 1;
                }
                else
                {
                    //GANA LA LINEA P2
                    rowsWinnedP2 += 1;
                }

                break;
        }
    }

    public void SelectRoundWinner()
    {
        switch (rowsWinnedP1 == rowsWinnedP2)
        {
            case true:
                //EMPATE
                Debug.LogWarning("Empate");
                break;

            case false:
                if (rowsWinnedP1 > rowsWinnedP2)
                {
                    //GANA LA RONDA P1
                    roundsWinnedP1 += 1;
                }
                else
                {
                    //GANA LA RONDA P2
                    roundsWinnedP2 += 1;
                }

                break;
        }
    }

    public IEnumerator SelectGameWinner()
    {
        yield return new WaitForSeconds(2);
        switch(roundsWinnedP1 == 0)
        {
            case true:
                if(roundsWinnedP2 == 1)
                {
                    Debug.Log("Player 2 wins");
                    panelWinP2_GO.SetActive(true);
                }
                else
                {
                    Debug.Log("Empate");
                    panelEmpate_GO.SetActive(true);
                }

                break;
            case false:
                Debug.Log("Player 1 wins");
                panelWinP1_GO.SetActive(true);

                break;
        }
        EventSystem.current.SetSelectedGameObject(botonReset);
        botonReset.SetActive(true);
        botonMainMenu.SetActive(true);
    }
}
