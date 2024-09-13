using UnityEngine;

namespace BabySound.Scripts
{
    public abstract class BasePopup : MonoBehaviour, IPopup
    {
        [SerializeField] private CanvasGroup _canvasGroup;

        public virtual void OnOpen()
        {
            throw new System.NotImplementedException();
        }

        public bool IsActive { get; set; }
        public void SetActive(bool b)
        {
            throw new System.NotImplementedException();
        }

        public void CloseView()
        {
            throw new System.NotImplementedException();
        }

        public void Back()
        {
            throw new System.NotImplementedException();
        }

        public void Show()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Hide()
        {
            throw new System.NotImplementedException();
        }
    }
}