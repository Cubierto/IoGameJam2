using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour {
    
    private string _alphabet = "abcdefghijklmnopqrstwuvxyz";
    private Dictionary<char, Dictionary<char, List<string>>> _wordsTree = new Dictionary<char, Dictionary<char, List<string>>>();
    public TextAsset wordsDocument;

    string palabraJugador="hola";

    // Use this for initialization
    void Start()
    {
        //This will create a tree like thing.

        foreach (char __letter in _alphabet)
        {
            _wordsTree.Add(__letter, new Dictionary<char, List<string>>());
        }

        foreach (char __nodeKey in _wordsTree.Keys)
        {
            foreach (char __letter in _alphabet)
            {
                _wordsTree[__nodeKey].Add(__letter, new List<string>());
            }
        }

        //Then you'll have to do read your document word by word and add to the tree:

        //This foreach is just a fake ideia of code, i don't remmeber how to read words from
        // a document just look on google shouldn't be hard to find.
        foreach (string __word in wordsDocument.text.Split('\n'))
        {
            //This will consider all words as lower case, if you want to have upper case
            //just add the upper case letters into the alphabet string and remove the __word.ToLower()
            //just leave the TrimeEnd.
            //Some of the words have a space at the end Trim will remove it.
            string __lowerCaseWord = __word.ToLower().TrimEnd();

            if (__lowerCaseWord.Length > 1)
            {
                //This is accutualy how you would add something to the tree.
                _wordsTree[__lowerCaseWord[0]][__lowerCaseWord[1]].Add(__lowerCaseWord);
            }
        }

        //Then to see if the word exist just do:

        //string __playerWord = "fuck"; //This is the word the player entered.
        //Debug.Log(_wordsTree[__playerWord[0]][__playerWord[1]].Contains(__playerWord));
        ingresarPalabra("hi");
        ingresarPalabra("fuck");
        ingresarPalabra("no");
        ingresarPalabra("sadhgsakdushakjd");
        ingresarPalabra("idontthing");
        ingresarPalabra("nope");
        ingresarPalabra("yes");

        ponerenCola('k');
        botardeCola();
    }

    void ingresarPalabra(string palabra)
    {
        bool existe = _wordsTree[palabra[0]][palabra[1]].Contains(palabra);
        Debug.Log("La palabra: " + palabra + " es " + existe);
    }

    void ponerenCola(char letra)
    {
        palabraJugador = palabraJugador + letra;
        Debug.Log(palabraJugador);
    }
    void botardeCola()
    {
        palabraJugador = palabraJugador.Remove(palabraJugador.Length - 1);
        Debug.Log(palabraJugador);
    }
}
