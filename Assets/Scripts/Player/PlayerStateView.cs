using TMPro;
using Player;

namespace State
{
    class PlayerStateView
    {
        private TextMeshProUGUI stateText;

        public PlayerStateView(TextMeshProUGUI stateText)
        {
            this.stateText = stateText;
            PlayerInput.onStateChange += ViewText;
        }

        public void ViewText(int stateCount)
        {
            switch (stateCount)
            {
                case 0:
                    stateText.text = ShootState.Name;
                    break;
                case 1:
                    stateText.text = ZoneState.Name;
                    break;
                case 2:
                    stateText.text = InvisibleState.Name;
                    break;
            }
        }
    }
}