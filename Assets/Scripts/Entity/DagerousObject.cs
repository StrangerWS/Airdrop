using UnityEngine;

namespace Entity
{
    public class DagerousObject : MonoBehaviour
    {
        private RectTransform _alertIcon;

        public GameObject dangerSign;
        public Canvas canvas;
        public float maxHeight;
        
        public void Destroy()
        {
            Destroy(this.gameObject);
            Destroy(_alertIcon.gameObject);
        }

        protected void CreateAlertIcon()
        {
            _alertIcon = Instantiate(dangerSign, canvas.transform, false).GetComponent<RectTransform>();

            Vector2 canvasAnchor = Camera.main.WorldToViewportPoint(gameObject.transform.position);
            canvasAnchor.y = 0f;

            _alertIcon.anchorMin = canvasAnchor;
            _alertIcon.anchorMax = _alertIcon.anchorMin;

            _alertIcon.anchoredPosition = new Vector2(_alertIcon.localPosition.x, 50.0f);
        
            _alertIcon.anchorMin = new Vector2(0.5f, 0f);
            _alertIcon.anchorMax = _alertIcon.anchorMin;
        }
    }
}