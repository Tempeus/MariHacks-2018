using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour {

    public List<Word> words;

    public WordSpawner wordSpawner;
    public Text mainWord;
    public int Counter;
    public static bool Game;

    private bool hasActiveWord;
    private Word activeWord;


    private void Start()
    {
        Game = true;
        Counter = -1;
        AddWord();
    }

    private void Update()
    {
        if(words.Count == 0)
        {
            AddWord();  
        }

        if(Counter == 5)
        {
            SceneManager.LoadScene("2.walk");
        }

        if(Game == false)
        {
            SceneManager.LoadScene("5.GameOver");

        }

    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetWord(), wordSpawner.SpawnWord());
        words.Add(word);
        Debug.Log(word.word);
        Counter++;

    }


    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }

        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }



    // what we need is to i += 1 and rerun the print word and check typed = print word

}
