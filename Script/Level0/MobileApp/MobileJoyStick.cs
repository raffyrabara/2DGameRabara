using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class MobileJoyStick : MonoBehaviour, IPointerUpHandler, IDragHandler, IPointerDownHandler
{
    private RectTransform joystickTransform;

    [SerializeField] private float dragThreshold = 0.6f;
    [SerializeField] private int dragMovementDistance = 30;
    [SerializeField] private int dragOffsetDistance = 100;
    public event Action<Vector2> OnMove;

    public Vector2 JoystickInput { get; private set; }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 offset;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joystickTransform,
            eventData.position,
            null,
            out offset);
        offset = Vector2.ClampMagnitude(offset, dragOffsetDistance) / dragOffsetDistance;
        Debug.Log(offset);
        joystickTransform.anchoredPosition = offset * dragMovementDistance;  

        JoystickInput = CalculateMovementInput(offset);
        OnMove?.Invoke(JoystickInput);   
    }

    private Vector2 CalculateMovementInput(Vector2 offset)
    {
        float x = Mathf.Abs(offset.x) > dragThreshold ? offset.x : 0;
        float y = Mathf.Abs(offset.y) > dragThreshold ? offset.y : 0;
        return new Vector2(x, y);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
     
        joystickTransform.anchoredPosition = Vector2.zero;
        JoystickInput = Vector2.zero;
        OnMove?.Invoke(Vector2.zero);
    }

     public void OnPointerDown(PointerEventData eventData)
    {
       
    }
    





    private void Awake()
    {
        joystickTransform = (RectTransform)transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
