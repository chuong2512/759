﻿using System;
using BabySound.Scripts;
using UnityEngine;
using UnityEngine.UI;

namespace ABCBoard.Scripts.UI
{
    public class RateGameScreen : AppPopup
    {
        [SerializeField] private Button _rateButton;


        public override void OnOpen()
        {
            /*transform.DOKill();
            transform.GetComponent<RectTransform>().DOAnchorPosY(2500, 0).OnComplete(() =>
            {
                transform.GetComponent<RectTransform>().DOAnchorPosY(55, 0.5f);
            });*/
        }

        protected override void Start()
        {
            base.Start();
            _rateButton.onClick.AddListener(RateGame);
        }

        private void RateGame()
        {
#if UNITY_ANDROID
            Application.OpenURL(string.Format("market://details?id=" + Application.identifier));
#elif UNITY_IPHONE
            Application.OpenURL("itms-apps://itunes.apple.com/app/" + Application.identifier);
#endif
            GameDataManager.Instance.playerData.Rated();
            Back();
        }
    }
}