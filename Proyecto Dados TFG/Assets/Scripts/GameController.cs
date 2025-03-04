using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    DiceMovement_Clase diceMovement_Clase;
    [SerializeField] GameObject diceMovement;

    PointsManager_Clase pointsManager_Clase;
    [SerializeField] GameObject pointsManager;

    [Header("Paneles fin de juego")]
    [SerializeField] GameObject panelWinP1_GO;
    [SerializeField] GameObject panelWinP2_GO;


    public int[] rowResult;
    public int rowsWinnedP1;
    public int rowsWinnedP2;

    public int roundsWinnedP1;
    public int roundsWinnedP2;


    void Start()
    {
        diceMovement_Clase = diceMovement.GetComponent<DiceMovement_Clase>();
        pointsManager_Clase = pointsManager.GetComponent<PointsManager_Clase>();

    }

    public void CompareRowPoints()
    {
        //rowResult[0] = pointsManager_Clase.rowTotalValueP1[0] - pointsManager_Clase.rowTotalValueP2[0];
        //rowResult[1] = pointsManager_Clase.rowTotalValueP1[1] - pointsManager_Clase.rowTotalValueP2[1];
        //rowResult[2] = pointsManager_Clase.rowTotalValueP1[2] - pointsManager_Clase.rowTotalValueP2[2];

        rowResult[0] = pointsManager.GetComponent<PointsManager_Clase>().rowTotalValueP1[0] - pointsManager.GetComponent<PointsManager_Clase>().rowTotalValueP2[0];
        rowResult[1] = pointsManager.GetComponent<PointsManager_Clase>().rowTotalValueP1[1] - pointsManager.GetComponent<PointsManager_Clase>().rowTotalValueP2[1];
        rowResult[2] = pointsManager.GetComponent<PointsManager_Clase>().rowTotalValueP1[2] - pointsManager.GetComponent<PointsManager_Clase>().rowTotalValueP2[2];

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
                    //GANA LA LINEA P1
                    roundsWinnedP1 += 1;
                }
                else
                {
                    //GANA LA LINEA P2
                    roundsWinnedP2 += 1;
                }

                break;
        }
    }

    public void SelectGameWinner()
    {
        if(roundsWinnedP1 == 1)
        {
            Debug.Log("Player 1 wins");
        }
        if (roundsWinnedP2 == 1)
        {
            Debug.Log("Player 2 wins");
        }
    }
}
