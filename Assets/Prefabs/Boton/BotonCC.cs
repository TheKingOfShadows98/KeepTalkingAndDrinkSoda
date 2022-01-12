using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum botonColor
{
    blue,
    red,
    yellow,
    green
}
enum botonPhrase
{
    press,
    release,
    detonate,
    drink
}
public class BotonCC : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] botonColor color;
    [SerializeField] botonPhrase phrase;
    [SerializeField] private float timeLapse ;
    [SerializeField] private bool isDeactiveOnRelease;
    [SerializeField] private SpriteRenderer LucesitaSprite;
    [SerializeField] private char digitformBomb;

    // separar a singleton
    [SerializeField] private CounterCC counter;

    /// Serparar Luego
    [SerializeField] private Color defaultColor;
    [SerializeField] private Color activeColor;
    private float delay;


    // Update is called once per frame
    public void OnDown()
    {
        anim.SetBool("isPressed", true);

        delay = Time.time + timeLapse;
        LucesitaSprite.color = activeColor;
    }

    public void OnPress()
    {


    }

    public void OnUp()
    {

        anim.SetBool("isPressed", false);
        LucesitaSprite.color = defaultColor;
        if (isDeactiveOnRelease && delay >= Time.time)
        {
            Debug.Log("Has Desactivado la bomba");

        }
        else if(!isDeactiveOnRelease )
        {
            if (counter.ContaintDigit(digitformBomb))
            {
                Debug.Log("Has Desactivado la bomba");
            }
            else Debug.Log("Explotaste Puto");
            {

            }

        }
        else Debug.Log("Explotaste Puto");

    }
}
