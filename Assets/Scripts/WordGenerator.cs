using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = { "cat", "dog", "bear", "air", "our", "hut", "son", "nap",
        "dot", "are", "fox", "link", "vine", "ring", "wasp", 
        "sand", "grit", "yolk", "jars", "queue", "whale", "squid",
        "extol", "staid", "waltz", "maxim", "vogue", "mosque", "torpid",
        "plexus", "vermin", "drowsy", "jinxed", "quench", "pyjama", "zelkova",
        "xanthin", "carouse", "swarthy", "fajitas", "equinox", "ziplock",  "mahjong",
        "lysozyme", "abstruse", "macaques", "juvenile", "apoplexy", "neophyte", "overseas",
        "joyously", "idiosyncratic", "ubiquitous", "maelstrom", "apocryphal", "embezzlement", "phlegmatic", "xylophone", "diaphanous" };


    public static string GetWord()
    {
        int wordIndex = Random.Range(0, wordList.Length);
        string printWord = wordList[wordIndex];

        return printWord;
    }

}
