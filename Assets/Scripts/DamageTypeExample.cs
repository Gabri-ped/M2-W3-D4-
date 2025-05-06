using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE {SLASHING,PIERCING,BLUDGEONING,MAGICAL,FORCE }
    public DAMAGE_TYPE attacktype;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;

    public int baseDamage;
    // Start is called before the first frame update
    void Start()
    {
        if (attacktype == resistance)
        {
            baseDamage /= 2;
            Debug.Log("il nemico è resistente a questo tipo di attacco " + baseDamage);
        }
        if (attacktype == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole a questo tipo di attacco " + baseDamage);
        }
        Debug.Log("Danno inflitto " + baseDamage);

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
