using UnityEngine;
using UnityEngine.EventSystems;

namespace ScreenNavigation
{
    public class Screen : MonoBehaviour
    {
        public bool isOverlay;
        [SerializeField] private GameObject firstSelected;
        private Canvas _canvas;

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();
        }

        public void Show()
        {
            _canvas.enabled = true;
            EventSystem.current.SetSelectedGameObject(firstSelected);
        }

        public void Hide()
        {
            _canvas.enabled = false;
        }
    }
}