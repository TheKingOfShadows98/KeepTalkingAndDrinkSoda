using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveObj : TouchAbleObject
{
    public UnityEvent onClickDown = new UnityEvent();
    public UnityEvent onClickPress = new UnityEvent();
    public UnityEvent onClickUp = new UnityEvent();

    protected override void OnDown() {
    if(onClickDown != null)
        {
            onClickDown.Invoke();
        }
    }
    protected override void OnPress() {
        if (onClickPress != null)
        {
            onClickPress.Invoke();
        }
    }
    protected override void OnUp() {

        if (onClickUp != null)
        {
            onClickUp.Invoke();
        }
    }
}
