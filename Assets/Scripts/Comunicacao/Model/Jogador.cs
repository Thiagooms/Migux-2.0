using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Jogador: Id
{
    public string especie, sala, sexo;
    public Color corPrimaria, corSecundaria;
}

[Serializable]
public class Id
{
    public string id;
}

[Serializable]
public class ListaDeJogadores
{
    public List<Jogador> jogadores;
}