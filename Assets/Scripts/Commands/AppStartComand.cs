﻿using System.Collections;
using strange.extensions.command.impl;
using UnityEngine;

public class AppStartCommand : Command {
    public override void Execute()
    {
        Debug.Log("app start");
    }
}
