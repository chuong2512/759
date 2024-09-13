using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SongButton : MonoBehaviour
{
    [SerializeField] private int _songID;
    [SerializeField] private Image _songImage;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private Button _button;

    [SerializeField] private GameObject _lockObj;
    [SerializeField] private GameObject _chooseObj;

    private bool _isUnlock;

    public bool IsUnlock
    {
        get => _isUnlock;
        set => _isUnlock = value;
    }

    public int SongID
    {
        get => _songID;
        set => _songID = value;
    }

    private void OnValidate()
    {
        _button = GetComponent<Button>();
    }

    void Start()
    {
        _button?.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {

    }

    public void SetID(int id)
    {
    }

    public void Refresh()
    {
        _lockObj.SetActive(!_isUnlock);
        Choose(_songID == GameDataManager.Instance.currentID);
    }

    public void Choose(bool b)
    {
        _chooseObj.SetActive(b);
    }
}