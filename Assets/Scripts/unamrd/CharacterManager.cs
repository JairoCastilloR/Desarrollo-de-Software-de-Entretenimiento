using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterManager : MonoBehaviour
{
    public CharacterDataBase characterDB;
    public TMP_Text nameText;
    public TMP_Text info;
    public SpriteRenderer artworkSprite;

    private int selectOption = 0;
    void Start()
    {
        UpdateCharacter(selectOption);
    }

    public void NextOption()
    {
        selectOption++;

        if(selectOption >= characterDB.CharacterCount)
        {
            selectOption = 0;
        }
        UpdateCharacter(selectOption);
    }
    public void BackOption()
    {
        selectOption--;
        if (selectOption < 0)
        {
            selectOption = characterDB.CharacterCount-1;
        }
        UpdateCharacter(selectOption);
    }
    private void UpdateCharacter(int selectOption)
    {
        Character character = characterDB.GetCharacter(selectOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
        info.text = character.description;
    }
}
