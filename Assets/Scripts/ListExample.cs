using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax;
    List<int> lista = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numeroMax; i++)
        {
            int posizione = i % 3;
            if (posizione == 0)
            {
                lista.Insert(0, i);
            }
            if (posizione == 1)
            {
                lista.Add(i);
            }
            if (posizione == 2)
            {
                int meta = lista.Count / 2;
                lista.Insert(meta, i);
            }
            Debug.Log("Contenuto lista: " + string.Join(',', lista));
            for (int j = 0; j < lista.Count; j++)
            {
                Debug.Log(lista[j]);
            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
