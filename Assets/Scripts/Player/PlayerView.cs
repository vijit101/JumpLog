using UnityEngine;
namespace LogJump.Player
{
    public class PlayerView : MonoBehaviour
    {
        PlayerController playerController;
        public PlayerViewType playerViewType;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetMyController(PlayerController controller)
        {
            playerController = controller;
        }
        public void SetPlayerViewType(PlayerViewType viewType)
        {
            playerViewType = viewType;
        }
        public void SetPlayerPos(Vector3 transformPosition)
        {
            transform.position = transformPosition;
        }
    }
}
