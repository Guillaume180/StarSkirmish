using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public Color characterColor;
    public SpriteRenderer characterSprite;

    public void ChangeColorofCharactertoBlue()
    {
        characterColor = Color.blue;
        characterSprite.color = characterColor;
    }

    public void ChangeColorofCharactertoRed()
    {
        characterColor = Color.red;
        characterSprite.color = characterColor;
    }

    public void ChangeColorofCharactertoGreen()
    {
        characterColor = Color.green;
        characterSprite.color = characterColor;
    }

    public void ChangeColorofCharactertoWhite()
    {
        characterColor = Color.white;
        characterSprite.color = characterColor;
    }
}
