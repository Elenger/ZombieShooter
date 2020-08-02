using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasChecker : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool isThisUI = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isThisUI = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isThisUI = false;
    }
}
