﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class BossGUI : MonoBehaviour
{
    /// <summary>
    /// Enemy Boss GUI slider needs to be handle on enemy side
    /// </summary>
    public Text bossName;
    public static Slider bossSlider;
    public static int damage = 10;

    void bossGUI()
    {
        // When the boss appears, I need to turn on the bossSlider and bossName on.
        if (bossSlider.value == 0)
        {
            GUIManager.instance.Activate("UIBoss", false);
        }
    }
}
