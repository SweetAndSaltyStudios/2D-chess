﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sweet_And_Salty_Studios
{
    public class CellDisplay : MonoBehaviour
    {
        public Image Image { get => GetComponent<Image>(); }
        public RectTransform RectTransform { get => transform as RectTransform; }
        public TMP_Text CoordinatesText { get => GetComponentInChildren<TMP_Text>(); }
    }
}