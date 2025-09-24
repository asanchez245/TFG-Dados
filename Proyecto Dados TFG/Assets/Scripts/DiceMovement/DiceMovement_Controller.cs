using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DiceMovement_Controller : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform originalParent;
    [HideInInspector] public Transform parentAfterDrag;

    public bool swapping;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        transform.localPosition = Vector3.zero;
        image.raycastTarget = true;
    }

    public void SwapParent(GameObject diceMoving, GameObject diceToSwap)
    {
        Transform oldParent = originalParent;
        Transform newParent = diceToSwap.transform.parent;

        Vector3 diceMovingWorldPos = originalParent.position;

        // Intercambiamos los padres
        diceMoving.transform.SetParent(newParent, true);
        diceToSwap.transform.SetParent(oldParent, true);

        // Actualizamos el parentAfterDrag del dado en movimiento
        DiceMovement_Controller movingDM = diceMoving.GetComponent<DiceMovement_Controller>();
        if (movingDM != null) movingDM.parentAfterDrag = newParent;

        // También podemos actualizar el otro si es necesario
        DiceMovement_Controller swapDM = diceToSwap.GetComponent<DiceMovement_Controller>();
        if (swapDM != null) swapDM.parentAfterDrag = oldParent;

        // Ajustamos posiciones
        diceMoving.transform.position = diceMovingWorldPos; 
        diceToSwap.transform.DOLocalMove(Vector3.zero, 0.3f);
    }

}
