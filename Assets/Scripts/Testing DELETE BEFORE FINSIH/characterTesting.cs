using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterTesting : MonoBehaviour
{
    public Character Draconia;

    // Start is called before the first frame update
    void Start()
    {
        Draconia = CharacterManager.instance.GetCharacter("Draconia");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
