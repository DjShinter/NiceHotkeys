using ABI_RC.Core;
using ABI_RC.Core.EventSystem;
using ABI_RC.Core.Player;
using UnityEngine;
using MelonLoader;

namespace NiceHotkeys
{
    public sealed class NiceHotkeyMod : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.K) && Input.GetKey(KeyCode.LeftControl))
            {
                ResetAvatar();
            }
            if (Input.GetKeyDown(KeyCode.R) && Input.GetKey(KeyCode.LeftControl))
            {
                Respawn();
            }
            if (Input.GetKeyDown(KeyCode.Z) && Input.GetKey(KeyCode.LeftControl))
            {
                RemoveAllAvatars();
            }
        }
        public static void ResetAvatar()
        {
            AssetManagement.Instance.LoadLocalAvatar("17c267db-18c4-4900-bb73-ad323f082640"); // changes your avatar to space robot kyle
            MelonLogger.Msg("Avatar was reset."); // this just logs to melon logger
        }
        public static void Respawn()
        {
            RootLogic.Instance.Respawn();
            MelonLogger.Msg("Respawned.");
        }

        public static void RemoveAllAvatars()
        {
            CVRPlayerManager.Instance.ClearPlayerAvatars();
            MelonLogger.Msg("All avatars were removed.");
        }

    }
}