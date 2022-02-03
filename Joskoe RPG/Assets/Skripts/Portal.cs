using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collaidable
{
    public string[] LevelNames;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // Teleport of the Player    
            string SceneName = LevelNames[Random.Range(0, LevelNames.Length)];

            SceneManager.LoadScene(SceneName);
        }
            
    }
}
