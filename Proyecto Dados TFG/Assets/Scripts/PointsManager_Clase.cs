using UnityEngine;
using UnityEngine.UI;

public class PointsManager_Clase : MonoBehaviour
{
    [SerializeField] GameObject[] _cellsP1;
    [SerializeField] GameObject[] _cellsP2;

    public int[] rowValueP1;
    public Text[] rowValueP1Text;

    public int[] rowValueP2;
    //public Text[] rowValueP2Text;

    void Update()
    {
        RowValueCalculation();
    }

    public void RowValueCalculation() //calcula el valor de cada fila y lo muestra en los textos
    {
        int GetDiceValue(GameObject position) //chequea si la fila esta completa
        {
            DiceInfo_Clase diceController = position.GetComponentInChildren<DiceInfo_Clase>();
            return diceController != null ? diceController.diceValue : 0;
        }

        #region P1 Rows
        rowValueP1[0] = GetDiceValue(_cellsP1[0]) + GetDiceValue(_cellsP1[1]) + GetDiceValue(_cellsP1[2]);
        rowValueP1Text[0].text = rowValueP1[0].ToString();

        rowValueP1[1] = GetDiceValue(_cellsP1[3]) + GetDiceValue(_cellsP1[4]) + GetDiceValue(_cellsP1[5]);
        rowValueP1Text[1].text = rowValueP1[1].ToString();

        rowValueP1[2] = GetDiceValue(_cellsP1[6]) + GetDiceValue(_cellsP1[7]) + GetDiceValue(_cellsP1[8]);
        rowValueP1Text[2].text = rowValueP1[2].ToString();
        #endregion

        #region P2 Rows
        rowValueP2[0] = GetDiceValue(_cellsP2[0]) + GetDiceValue(_cellsP2[1]) + GetDiceValue(_cellsP2[2]);
        //rowValueP2Text[0].text = rowValueP2[0].ToString();

        rowValueP2[1] = GetDiceValue(_cellsP2[3]) + GetDiceValue(_cellsP2[4]) + GetDiceValue(_cellsP2[5]);
        //rowValueP2Text[1].text = rowValueP2[1].ToString();

        rowValueP2[2] = GetDiceValue(_cellsP2[6]) + GetDiceValue(_cellsP2[7]) + GetDiceValue(_cellsP2[8]);
        //rowValueP2Text[2].text = rowValueP2[2].ToString();
        #endregion
    }

    public void HorizontalValueCalculation()
    {
        int GetDiceValue(GameObject position) //chequea si la fila esta completa
        {
            DiceInfo_Clase diceController = position.GetComponentInChildren<DiceInfo_Clase>();
            return diceController != null ? diceController.diceValue : 0;
        }

        #region P1 Rows
        if (GetDiceValue(_cellsP1[0]) == GetDiceValue(_cellsP1[1]) && GetDiceValue(_cellsP1[0]) == GetDiceValue(_cellsP1[2])
            && GetDiceValue(_cellsP1[1]) == GetDiceValue(_cellsP1[2]))
        {
            rowValueP1[0] += GetDiceValue(_cellsP1[2]);
            Debug.Log("furula");
        }

        if (GetDiceValue(_cellsP1[3]) == GetDiceValue(_cellsP1[4]) && GetDiceValue(_cellsP1[3]) == GetDiceValue(_cellsP1[5])
            && GetDiceValue(_cellsP1[4]) == GetDiceValue(_cellsP1[5]))
        {
            rowValueP1[1] += GetDiceValue(_cellsP1[4]);
            Debug.Log("furula");

        }

        if (GetDiceValue(_cellsP1[6]) == GetDiceValue(_cellsP1[7]) && GetDiceValue(_cellsP1[6]) == GetDiceValue(_cellsP1[8])
            && GetDiceValue(_cellsP1[7]) == GetDiceValue(_cellsP1[8]))
        {
            rowValueP1[2] += GetDiceValue(_cellsP1[6]);
            Debug.Log("furula");

        }
        #endregion

        #region P2 Rows
        if (GetDiceValue(_cellsP2[0]) == GetDiceValue(_cellsP2[1]) && GetDiceValue(_cellsP2[0]) == GetDiceValue(_cellsP2[2])
            && GetDiceValue(_cellsP2[1]) == GetDiceValue(_cellsP2[2]))
        {
            rowValueP2[0] += GetDiceValue(_cellsP2[2]);
        }

        if (GetDiceValue(_cellsP2[3]) == GetDiceValue(_cellsP2[4]) && GetDiceValue(_cellsP2[3]) == GetDiceValue(_cellsP2[5])
            && GetDiceValue(_cellsP2[4]) == GetDiceValue(_cellsP2[5]))
        {
            rowValueP2[1] += GetDiceValue(_cellsP2[4]);
        }

        if (GetDiceValue(_cellsP2[6]) == GetDiceValue(_cellsP2[7]) && GetDiceValue(_cellsP2[6]) == GetDiceValue(_cellsP2[8])
            && GetDiceValue(_cellsP2[7]) == GetDiceValue(_cellsP2[8]))
        {
            rowValueP2[2] += GetDiceValue(_cellsP2[6]);
        }
        #endregion
    }

    public void DiagonalValueCalculation()
    {

    }
}
