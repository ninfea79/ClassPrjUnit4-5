using UnityEngine;
using System;
using System.Collections.Generic;

public enum ProprietaPersonaggio
{
   
    CharacterM,
    CharacterF,
    Classe,
    Giocabile,
    Vita,
    Livello,
    Mana,  
    Xp,
    Attacco,
    Difesa
}

public enum classiPersonaggi
{
   
    magoAcqua,
    goblin,
    magoTerra
}

[System.Serializable]
public class caratteristichePersonaggioV2 : ScriptableObject
{
   
    public  GameObject character_M;
    public GameObject character_F;

   
    public string[] schieraProprietaC = new string[Enum.GetValues(typeof(ProprietaPersonaggio)).Length];
    public List<ClasseValorPersonaggioV2> matriceProprieta;
    
    public List<String> classePersonaggio = new List<string>();
}

[System.Serializable]
public class ClasseValorPersonaggioV2
{
    
    public string nomeM="nessun nome";
    public string nomeF = "nessun nome";
    public classiPersonaggi classe = classiPersonaggi.magoAcqua;
    public bool giocabile = false;
    public float Vita = 10f;
    public int Livello = 0;
    public float Mana = 10f;
    public float Xp = 0f;
    public float Attacco = 10f;
    public float difesa = 20f;
}


