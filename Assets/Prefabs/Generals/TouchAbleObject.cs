using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TouchAbleObject : MonoBehaviour
{
    private float bdelay;
    private float threshold = 0.1f;
    private bool active;
    private void Update()
    {
        if(active && bdelay < Time.time) {
            OnUp();
            active = false;
        }
    }
    public virtual void OnTouch( string info)
    {
       
    }

    protected virtual void OnDown()
    {

    }
    protected virtual void OnUp()
    {

    }
    protected virtual void OnPress()
    {

    }
    public void reciveTouchEvent(string info)
    {
        if (info == "pressed")
        {
            if (!active)
            {
                active = true;
                OnDown();
            }
            else
            {
                OnPress();
            }
            bdelay = Time.time + threshold;
        }
    }
}
