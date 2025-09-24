using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager_Clase : MonoBehaviour
{
    [SerializeField] GameObject[] _cellsP1;
    [SerializeField] GameObject[] _cellsP2;

    [Header("P1 Values")]
    public int[] rowTotalValueP1;
    public Text[] rowValueP1Text;

    public int[] rowBasicValueP1;
    public int[] rowHorizontalValueP1;
    public int[] rowDiagonalValueP1;

    [Header("P2 Values")]
    public int[] rowTotalValueP2;
    public Text[] rowValueP2Text;

    public int[] rowBasicValueP2;
    public int[] rowHorizontalValueP2;
    public int[] rowDiagonalValueP2;

    private void Update()
    {
        AllPointsCalculation();
    }

    public void AllPointsCalculation()
    {
        RowFinalValueCalculation();
        RowBasicCalculation();
        HorizontalValueCalculation();
        DiagonalValueCalculation();

    }

    public void RowFinalValueCalculation()
    {
        #region P1 Calculations
        rowTotalValueP1[0] = rowBasicValueP1[0] + rowHorizontalValueP1[0] + rowDiagonalValueP1[0];
        rowTotalValueP1[1] = rowBasicValueP1[1] + rowHorizontalValueP1[1];
        rowTotalValueP1[2] = rowBasicValueP1[2] + rowHorizontalValueP1[2] + rowDiagonalValueP1[2];

        rowValueP1Text[0].text = rowTotalValueP1[0].ToString();
        rowValueP1Text[1].text = rowTotalValueP1[1].ToString();
        rowValueP1Text[2].text = rowTotalValueP1[2].ToString();
        #endregion

        #region P2 Calculations
        rowTotalValueP2[0] = rowBasicValueP2[0] + rowHorizontalValueP2[0] + rowDiagonalValueP2[0];
        rowTotalValueP2[1] = rowBasicValueP2[1] + rowHorizontalValueP2[1];
        rowTotalValueP2[2] = rowBasicValueP2[2] + rowHorizontalValueP2[2] + rowDiagonalValueP2[2];

        rowValueP2Text[0].text = rowTotalValueP2[0].ToString();
        rowValueP2Text[1].text = rowTotalValueP2[1].ToString();
        rowValueP2Text[2].text = rowTotalValueP2[2].ToString();
        #endregion
    }

    public void RowBasicCalculation() //calcula el valor de cada fila y lo muestra en los textos
    {
        int GetDiceValue(GameObject position) //chequea si la fila esta completa
        {
            DiceInfo_Clase diceController = position.GetComponentInChildren<DiceInfo_Clase>();
            return diceController != null ? diceController.diceValue : 0;
        }

        #region P1 Rows
        rowBasicValueP1[0] = GetDiceValue(_cellsP1[0]) + GetDiceValue(_cellsP1[1]) + GetDiceValue(_cellsP1[2]);

        rowBasicValueP1[1] = GetDiceValue(_cellsP1[3]) + GetDiceValue(_cellsP1[4]) + GetDiceValue(_cellsP1[5]);

        rowBasicValueP1[2] = GetDiceValue(_cellsP1[6]) + GetDiceValue(_cellsP1[7]) + GetDiceValue(_cellsP1[8]);
        #endregion

        #region P2 Rows
        rowBasicValueP2[0] = GetDiceValue(_cellsP2[0]) + GetDiceValue(_cellsP2[1]) + GetDiceValue(_cellsP2[2]);

        rowBasicValueP2[1] = GetDiceValue(_cellsP2[3]) + GetDiceValue(_cellsP2[4]) + GetDiceValue(_cellsP2[5]);

        rowBasicValueP2[2] = GetDiceValue(_cellsP2[6]) + GetDiceValue(_cellsP2[7]) + GetDiceValue(_cellsP2[8]);
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
            rowHorizontalValueP1[0] = GetDiceValue(_cellsP1[2]);
        }

        if (GetDiceValue(_cellsP1[3]) == GetDiceValue(_cellsP1[4]) && GetDiceValue(_cellsP1[3]) == GetDiceValue(_cellsP1[5])
            && GetDiceValue(_cellsP1[4]) == GetDiceValue(_cellsP1[5]))
        {
            rowHorizontalValueP1[1] = GetDiceValue(_cellsP1[4]);

        }

        if (GetDiceValue(_cellsP1[6]) == GetDiceValue(_cellsP1[7]) && GetDiceValue(_cellsP1[6]) == GetDiceValue(_cellsP1[8])
            && GetDiceValue(_cellsP1[7]) == GetDiceValue(_cellsP1[8]))
        {
            rowHorizontalValueP1[2] = GetDiceValue(_cellsP1[6]);
        }
        #endregion

        #region P2 Rows
        if (GetDiceValue(_cellsP2[0]) == GetDiceValue(_cellsP2[1]) && GetDiceValue(_cellsP2[0]) == GetDiceValue(_cellsP2[2])
            && GetDiceValue(_cellsP2[1]) == GetDiceValue(_cellsP2[2]))
        {
            rowHorizontalValueP2[0] = GetDiceValue(_cellsP2[2]);
        }

        if (GetDiceValue(_cellsP2[3]) == GetDiceValue(_cellsP2[4]) && GetDiceValue(_cellsP2[3]) == GetDiceValue(_cellsP2[5])
            && GetDiceValue(_cellsP2[4]) == GetDiceValue(_cellsP2[5]))
        {
            rowHorizontalValueP2[1] = GetDiceValue(_cellsP2[4]);

        }

        if (GetDiceValue(_cellsP2[6]) == GetDiceValue(_cellsP2[7]) && GetDiceValue(_cellsP2[6]) == GetDiceValue(_cellsP2[8])
            && GetDiceValue(_cellsP2[7]) == GetDiceValue(_cellsP2[8]))
        {
            rowHorizontalValueP2[2] = GetDiceValue(_cellsP2[6]);
        }
        #endregion
    }

    public void DiagonalValueCalculation()
    {
        int GetDiceValue(GameObject position) //chequea si la fila esta completa
        {
            DiceInfo_Clase diceController = position.GetComponentInChildren<DiceInfo_Clase>();
            return diceController != null ? diceController.diceValue : 0;
        }

        #region P1 Rows
        if (GetDiceValue(_cellsP1[0]) == GetDiceValue(_cellsP1[4]) && GetDiceValue(_cellsP1[0]) == GetDiceValue(_cellsP1[8])
            && GetDiceValue(_cellsP1[4]) == GetDiceValue(_cellsP1[8]))
        {
            rowDiagonalValueP1[0] = GetDiceValue(_cellsP1[4]) * 3;
        }

        if (GetDiceValue(_cellsP1[2]) == GetDiceValue(_cellsP1[4]) && GetDiceValue(_cellsP1[2]) == GetDiceValue(_cellsP1[6])
            && GetDiceValue(_cellsP1[4]) == GetDiceValue(_cellsP1[6]))
        {
            rowDiagonalValueP1[2] = GetDiceValue(_cellsP1[4]) * 3;
        }
        #endregion

        #region P2 Rows
        if (GetDiceValue(_cellsP2[0]) == GetDiceValue(_cellsP2[4]) && GetDiceValue(_cellsP2[0]) == GetDiceValue(_cellsP2[8])
            && GetDiceValue(_cellsP2[4]) == GetDiceValue(_cellsP2[8]))
        {
            rowDiagonalValueP2[0] = GetDiceValue(_cellsP2[4]) * 3;
        }

        if (GetDiceValue(_cellsP2[2]) == GetDiceValue(_cellsP2[4]) && GetDiceValue(_cellsP2[2]) == GetDiceValue(_cellsP2[6])
            && GetDiceValue(_cellsP2[4]) == GetDiceValue(_cellsP2[6]))
        {
            rowDiagonalValueP2[2] = GetDiceValue(_cellsP2[4]) * 3;
        }
        #endregion
    }
}
