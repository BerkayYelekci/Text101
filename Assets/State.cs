﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject
{
    [TextArea(15,10)] [SerializeField] string storyText;
}
