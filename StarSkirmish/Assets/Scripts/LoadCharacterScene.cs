using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCharacterScene : MonoBehaviour
{
    public void loadCharacter()
    {
        SceneManager.LoadScene("CharacterCustomise");
    }
}
