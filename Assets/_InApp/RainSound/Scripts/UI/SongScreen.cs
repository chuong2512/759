using System;
using ABCBoard.Scripts.UI;
using UnityEngine;
using UnityEngine.UI;

public class SongScreen : BaseScreenWithModel<SongModel>
{
    private int _songID;

    [SerializeField] private Image _songImage;
    [SerializeField] private Button _buttonPlay;

    void Start()
    {
        _buttonPlay?.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
    }

    public override void BindData(SongModel model)
    {
        _songID = model.songID;
        SetImage();
    }

    private void SetImage()
    {
    }
}

public class SongModel
{
    public int songID;
}