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


    int[] rowResult;



    void Start()
    {
        diceMovement_Clase = diceMovement.GetComponent<DiceMovement_Clase>();
        pointsManager_Clase = pointsManager.GetComponent<PointsManager_Clase>();

    }

    void Update()
    {
        CompareRowPoints();
        SelectWinner();
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
                }
                else
                {
                    //GANA LA LINEA P2
                }

                break;
        }
    }

    public void SelectWinner()
    {

    }
}
