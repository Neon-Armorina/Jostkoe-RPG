using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public void Awake()
    {
        if (GameManager.Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        SceneManager.sceneLoaded += Load_state;
        DontDestroyOnLoad(gameObject);
    }

    // Resources
    public List<Sprite> player_sprites;
    public List<Sprite> weapon_sprite;
    public List<int> weapon_prices;
    public List<int> xp_table;

    // References
    public Player Player;

    // Logic
    public int coins;
    public int XP;

    // Some states
    public void Save_state()
    {

    }

    public void Load_state()
    {

    }
}
