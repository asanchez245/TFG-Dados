using UnityEngine;
using UnityEngine.EventSystems;


public class DiceSlot_Controller : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DiceMovement_Controller DM = dropped.GetComponent<DiceMovement_Controller>();

        if (transform.childCount == 0)
        {
            DM.parentAfterDrag = transform;
        }
        else
        {
            // Buscamos el objeto dentro del slot que NO sea el que estamos soltando
            GameObject diceToSwap = null;
            foreach (Transform child in transform)
            {
                if (child.gameObject != dropped)
                {
                    diceToSwap = child.gameObject;
                    break;
                }
            }

            if (diceToSwap != null)
            {
                DM.SwapParent(dropped, diceToSwap);
                Debug.Log(dropped.name + " swapped with " + diceToSwap.name);
            }
        }
    }

}
