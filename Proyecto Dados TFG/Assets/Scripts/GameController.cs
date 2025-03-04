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
        int row1Resutl = pointsManager_Clase.rowTotalValueP1[0] - pointsManager_Clase.rowTotalValueP2[0];
        int row2Resutl = pointsManager_Clase.rowTotalValueP1[1] - pointsManager_Clase.rowTotalValueP2[1];
        int row3Resutl = pointsManager_Clase.rowTotalValueP1[2] - pointsManager_Clase.rowTotalValueP2[2];

        //switch ()
        //{
        //    case row1Resutl > 0:

        //        break;
        //}
    }

    public void SelectWinner()
    {

    }
}
