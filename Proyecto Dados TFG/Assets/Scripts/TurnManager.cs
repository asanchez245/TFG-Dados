using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public bool p1Turn; //if true player1 turn si active - if false p2 turn is active
    public GameObject[] p1RowSelectionButtons;
    public GameObject[] p2RowSelectionButtons;

    public bool gameStarts;


    void Update()
    {
        if (gameStarts)
        {
            switch (p1Turn)
            {
                case true: //turno p1
                    for (int i = 0; i < p1RowSelectionButtons.Length; i++)
                    {
                        p1RowSelectionButtons[i].SetActive(true);
                        p2RowSelectionButtons[i].SetActive(false);
                    }


                    break;
                case false: //turno p2
                    for (int i = 0; i < p1RowSelectionButtons.Length; i++)
                    {
                        p1RowSelectionButtons[i].SetActive(false);
                        p2RowSelectionButtons[i].SetActive(true);
                    }


                    break;
            }
        }
        else
        {
            for (int i = 0; i < p1RowSelectionButtons.Length; i++)
            {
                p1RowSelectionButtons[i].SetActive(false);
                p2RowSelectionButtons[i].SetActive(false);
            }
        }

    }

    public void ChangePlayerTurn()
    {
        p1Turn = !p1Turn;
    }
}
