﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour {

	public void Play_game()
    {
        SceneManager.LoadScene("El nivel");
    }
}
