using System;
using UnityEngine;
namespace LogJump.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerView : MonoBehaviour
    {
        PlayerController playerController;
        public PlayerViewType playerViewType;
        [HideInInspector]
        public float jumpForce,horizontalStep;
        Rigidbody2D rgbd;
        private void Awake()
        {
            rgbd = gameObject.GetComponent<Rigidbody2D>();
            Physics2D.gravity = new Vector2(-9.81f, 0);
        }
        // Update is called once per frame
       
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
        public void MovePlayer()
        {
            if (playerViewType == PlayerViewType.Player1)
            {
                rgbd.AddForce(new Vector3(0,horizontalStep, jumpForce), ForceMode2D.Impulse);
            }
            if (playerViewType == PlayerViewType.Player2)
            {
                rgbd.AddForce(new Vector3(0,-horizontalStep, jumpForce), ForceMode2D.Impulse);
            }
            
        }
    }
}
