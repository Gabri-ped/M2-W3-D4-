using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public string string1 = "(Aragorn; Left; andry) Che siate attento, non è un gingillo quello che portate!";
    public string string2 = "(Gandalf; right) Uno stregone non è mai in ritardo, arriva precisamente quando intende farlo";
    // Start is called before the first frame update
    void Start()
    {
        string[] S1 = string1.Split(';', '(', ')');
        for (int i = 1; i < S1.Length; i++)
        {
            Debug.Log(S1[i]);
        }
        string[] S2 = string2.Split(';', '(', ')');
        for (int i = 1; i < S2.Length; i++)
        {
            Debug.Log(S2[i]);

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
    
