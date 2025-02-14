using UnityEngine;

namespace TownOfUs.Roles
{
    public class Medic : Role
    {
        public Medic(PlayerControl player) : base(player)
        {
            Name = "Medic";
            ImpostorText = () => "Create a shield to protect a crewmate";
            TaskText = () => "Protect a crewmate with a shield";
            Color = Patches.Colors.Medic;
            RoleType = RoleEnum.Medic;
            AddToRoleHistory(RoleType);
            ShieldedPlayer = null;
        }

        public PlayerControl ClosestPlayer;
        public bool UsedAbility { get; set; } = false;
        public PlayerControl ShieldedPlayer { get; set; }
        public PlayerControl exShielded { get; set; }
    }
}