using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Collectable : MonoBehaviour
{
    public string nameCollectable;
    public int score;
    public int restoreHP;

    public Collectable(string name, int scoreValue,int restoreValue)
    {
        this.nameCollectable = name;
        this.score = scoreValue;
        this.restoreHP = restoreValue;
    }

    public void UpdateScore()
    {
        ScoreController.scoreController.UpdateScore(score);
    }
   
   
}
