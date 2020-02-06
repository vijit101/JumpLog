﻿using LogJump.Player;
using UnityEngine;
public class PlayerPlatformService : MonoBehaviour
{
    public PlayerViewType PlatformForPlayer;
    public PlayerType GetPlayerType;
    public Transform PlayerSpawnPoint;
    private void Start()
    {
        DefaultSetup();
    }

    private void DefaultSetup()
    {
        PlayerController controller = PlayerService.Instance.GetPlayerController(GetPlayerType);
        controller.playerView.SetPlayerPos(PlayerSpawnPoint.position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerView player = collision.gameObject.GetComponent<PlayerView>();
        if (player.playerViewType != PlatformForPlayer)
        {
            Debug.Log(player.playerViewType + "Won");
        }
    }
}
