using System;
using UnityEngine;

namespace BabySound.Scripts.UI
{
    public class SetTimePopup : BasePopup
    {
        [SerializeField] private SetTimeButton[] _setTimeButtons;
        
        private void Start()
        {
            for (int i = 0; i < _setTimeButtons.Length; i++)
            {
                _setTimeButtons[i].SetTime(i);
            }
        }
    }
}