using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  public void Start()
  {
  Character character = new Character();
  character.HP = 100;
  Debug.Log(character.HP);
  character.name = "Jett";
  Debug.Log(character.name);

  character.name = "Sova"
  Debug.Log(character.name);

  Character characterTwo = new Character()
