using UnityEngine;

public class PointsManager_Clase : MonoBehaviour
{
    [SerializeField] GameObject[] _cellsP1;
    [SerializeField] GameObject[] _cellsP2;

    [SerializeField] int[] _rowPointsP1;
    [SerializeField] int[] _rowPointsP2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        RowValueCalculation();
    }

    public void RowValueCalculation() //calcula el valor de cada fila
    {
        int GetDiceValue(GameObject position) //chequea si la fila esta completa
        {
            DiceInfo_Clase diceController = position.GetComponentInChildren<DiceInfo_Clase>();
            return diceController != null ? diceController.diceValue : 0;
        }

        #region P1 Rows
        _rowPointsP1[0] = GetDiceValue(_cellsP1[0]) + GetDiceValue(_cellsP1[1]) + GetDiceValue(_cellsP1[2]);
        //rowValueText[0].text = rowValue[0].ToString();

        _rowPointsP1[1] = GetDiceValue(_cellsP1[3]) + GetDiceValue(_cellsP1[4]) + GetDiceValue(_cellsP1[5]);
        //rowValueText[1].text = rowValue[1].ToString();

        _rowPointsP1[2] = GetDiceValue(_cellsP1[6]) + GetDiceValue(_cellsP1[7]) + GetDiceValue(_cellsP1[8]);
        //rowValueText[2].text = rowValue[2].ToString();
        #endregion

        #region P2 Rows
        _rowPointsP2[0] = GetDiceValue(_cellsP2[0]) + GetDiceValue(_cellsP2[1]) + GetDiceValue(_cellsP2[2]);
        //rowValueText[0].text = rowValue[0].ToString();

        _rowPointsP2[1] = GetDiceValue(_cellsP2[3]) + GetDiceValue(_cellsP2[4]) + GetDiceValue(_cellsP2[5]);
        //rowValueText[1].text = rowValue[1].ToString();

        _rowPointsP2[2] = GetDiceValue(_cellsP2[6]) + GetDiceValue(_cellsP2[7]) + GetDiceValue(_cellsP2[8]);
        //rowValueText[2].text = rowValue[2].ToString();
        #endregion


    }
}
