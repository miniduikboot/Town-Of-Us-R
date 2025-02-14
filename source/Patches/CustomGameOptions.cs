using TownOfUs.CrewmateRoles.EngineerMod;
using TownOfUs.CrewmateRoles.MedicMod;
using TownOfUs.CustomOption;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.CrewmateRoles.HaunterMod;

namespace TownOfUs
{
    public static class CustomGameOptions
    {
        public static int MayorOn => (int)Generate.MayorOn.Get();
        public static int JesterOn => (int)Generate.JesterOn.Get();
        public static int LoversOn => (int)Generate.LoversOn.Get();
        public static int SheriffOn => (int)Generate.SheriffOn.Get();
        public static int JanitorOn => (int)Generate.JanitorOn.Get();
        public static int EngineerOn => (int)Generate.EngineerOn.Get();
        public static int SwapperOn => (int)Generate.SwapperOn.Get();
        public static int AmnesiacOn => (int)Generate.AmnesiacOn.Get();
        public static int InvestigatorOn => (int)Generate.InvestigatorOn.Get();
        public static int TimeLordOn => (int)Generate.TimeLordOn.Get();
        public static int MedicOn => (int)Generate.MedicOn.Get();
        public static int SeerOn => (int)Generate.SeerOn.Get();
        public static int GlitchOn => (int)Generate.GlitchOn.Get();
        public static int MorphlingOn => (int)Generate.MorphlingOn.Get();
        public static int CamouflagerOn => (int)Generate.CamouflagerOn.Get();
        public static int ExecutionerOn => (int)Generate.ExecutionerOn.Get();
        public static int SpyOn => (int)Generate.SpyOn.Get();
        public static int SnitchOn => (int)Generate.SnitchOn.Get();
        public static int MinerOn => (int)Generate.MinerOn.Get();
        public static int SwooperOn => (int)Generate.SwooperOn.Get();
        public static int ArsonistOn => (int)Generate.ArsonistOn.Get();
        public static int AltruistOn => (int)Generate.AltruistOn.Get();
        public static int UndertakerOn => (int)Generate.UndertakerOn.Get();
        public static int UnderdogOn => (int)Generate.UnderdogOn.Get();
        public static int PhantomOn => (int)Generate.PhantomOn.Get();
        public static int VigilanteOn => (int)Generate.VigilanteOn.Get();
        public static int HaunterOn => (int)Generate.HaunterOn.Get();
        public static int GrenadierOn => (int)Generate.GrenadierOn.Get();
        public static int VeteranOn => (int)Generate.VeteranOn.Get();
        public static int TrackerOn => (int)Generate.TrackerOn.Get();
        public static int PoisonerOn => (int)Generate.PoisonerOn.Get();
        public static int TraitorOn => (int)Generate.TraitorOn.Get();
        public static int TransporterOn => (int)Generate.TransporterOn.Get();
        public static int TorchOn => (int)Generate.TorchOn.Get();
        public static int DiseasedOn => (int)Generate.DiseasedOn.Get();
        public static int FlashOn => (int)Generate.FlashOn.Get();
        public static int TiebreakerOn => (int)Generate.TiebreakerOn.Get();
        public static int DrunkOn => (int)Generate.DrunkOn.Get();
        public static int GiantOn => (int)Generate.GiantOn.Get();
        public static int ButtonBarryOn => (int)Generate.ButtonBarryOn.Get();
        public static int BaitOn => (int)Generate.BaitOn.Get();
        public static int SleuthOn => (int)Generate.SleuthOn.Get();
        public static int VanillaGame => (int)Generate.VanillaGame.Get();
        public static float InitialCooldowns => Generate.InitialCooldowns.Get();
        public static bool BothLoversDie => Generate.BothLoversDie.Get();
        public static bool NeutralLovers => Generate.NeutralLovers.Get();
        public static bool SheriffKillOther => Generate.SheriffKillOther.Get();
        public static bool SheriffKillsJester => Generate.SheriffKillsJester.Get();
        public static bool SheriffKillsGlitch => Generate.SheriffKillsGlitch.Get();
        public static bool SheriffKillsExecutioner => Generate.SheriffKillsExecutioner.Get();
        public static bool SheriffKillsArsonist => Generate.SheriffKillsArsonist.Get();
        public static float SheriffKillCd => Generate.SheriffKillCd.Get();
        public static int MayorVoteBank => (int)Generate.MayorVoteBank.Get();
        public static bool MayorAnonymous => Generate.MayorAnonymous.Get();
        public static bool MayorButton => Generate.MayorButton.Get();
        public static bool SwapperButton => Generate.SwapperButton.Get();
        public static float FootprintSize => Generate.FootprintSize.Get();
        public static float FootprintInterval => Generate.FootprintInterval.Get();
        public static float FootprintDuration => Generate.FootprintDuration.Get();
        public static bool AnonymousFootPrint => Generate.AnonymousFootPrint.Get();
        public static bool VentFootprintVisible => Generate.VentFootprintVisible.Get();
        public static bool JesterButton => Generate.JesterButton.Get();
        public static bool JesterVent => Generate.JesterVent.Get();
        public static bool RewindRevive => Generate.RewindRevive.Get();
        public static float RewindDuration => Generate.RewindDuration.Get();
        public static float RewindCooldown => Generate.RewindCooldown.Get();
        public static int RewindMaxUses => (int) Generate.RewindMaxUses.Get();
        public static bool TimeLordVitals => Generate.TimeLordVitals.Get();
        public static ShieldOptions ShowShielded => (ShieldOptions)Generate.ShowShielded.Get();

        public static NotificationOptions NotificationShield =>
            (NotificationOptions)Generate.WhoGetsNotification.Get();

        public static bool ShieldBreaks => Generate.ShieldBreaks.Get();
        public static float MedicReportNameDuration => Generate.MedicReportNameDuration.Get();
        public static float MedicReportColorDuration => Generate.MedicReportColorDuration.Get();
        public static bool ShowReports => Generate.MedicReportSwitch.Get();
        public static float SeerCd => Generate.SeerCooldown.Get();
        public static bool CrewKillingRed => Generate.CrewKillingRed.Get();
        public static bool NeutBenignRed => Generate.NeutBenignRed.Get();
        public static bool NeutEvilRed => Generate.NeutEvilRed.Get();
        public static bool NeutKillingRed => Generate.NeutKillingRed.Get();
        public static float MimicCooldown => Generate.MimicCooldownOption.Get();
        public static float MimicDuration => Generate.MimicDurationOption.Get();
        public static float HackCooldown => Generate.HackCooldownOption.Get();
        public static float HackDuration => Generate.HackDurationOption.Get();
        public static float GlitchKillCooldown => Generate.GlitchKillCooldownOption.Get();
        public static int GlitchHackDistance => Generate.GlitchHackDistanceOption.Get();
        public static bool GlitchVent => Generate.GlitchVent.Get();
        public static float MorphlingCd => Generate.MorphlingCooldown.Get();
        public static float MorphlingDuration => Generate.MorphlingDuration.Get();
        public static bool MorphlingVent => Generate.MorphlingVent.Get();
        public static float CamouflagerCd => Generate.CamouflagerCooldown.Get();
        public static float CamouflagerDuration => Generate.CamouflagerDuration.Get();
        public static bool ColourblindComms => Generate.ColourblindComms.Get();
        public static bool MeetingColourblind => Generate.MeetingColourblind.Get();
        public static OnTargetDead OnTargetDead => (OnTargetDead)Generate.OnTargetDead.Get();
        public static bool ExecutionerButton => Generate.ExecutionerButton.Get();
        public static bool SnitchOnLaunch => Generate.SnitchOnLaunch.Get();
        public static bool SnitchSeesNeutrals => Generate.SnitchSeesNeutrals.Get();
        public static int SnitchTasksRemaining => (int)Generate.SnitchTasksRemaining.Get();
        public static bool SnitchSeesImpInMeeting => Generate.SnitchSeesImpInMeeting.Get();
        public static float MineCd => Generate.MineCooldown.Get();
        public static float SwoopCd => Generate.SwoopCooldown.Get();
        public static float SwoopDuration => Generate.SwoopDuration.Get();
        public static bool SwooperVent => Generate.SwooperVent.Get();
        public static bool ImpostorSeeRoles => Generate.ImpostorSeeRoles.Get();
        public static bool DeadSeeRoles => Generate.DeadSeeRoles.Get();
        public static bool DisableLevels => Generate.DisableLevels.Get();
        public static bool WhiteNameplates => Generate.WhiteNameplates.Get();
        public static bool SeeTasksDuringRound => Generate.SeeTasksDuringRound.Get();
        public static bool SeeTasksDuringMeeting => Generate.SeeTasksDuringMeeting.Get();
        public static bool SeeTasksWhenDead => Generate.SeeTasksWhenDead.Get();
        public static float DouseCd => Generate.DouseCooldown.Get();
        public static bool ArsonistGameEnd => Generate.ArsonistGameEnd.Get();
        public static bool ArsonistButton => Generate.ArsonistButton.Get();
        public static int MaxNeutralRoles => (int)Generate.MaxNeutralRoles.Get();
        public static bool ParallelMedScans => Generate.ParallelMedScans.Get();
        public static EngineerFixPer EngineerFixPer => (EngineerFixPer)Generate.EngineerPer.Get();
        public static float ReviveDuration => Generate.ReviveDuration.Get();
        public static bool AltruistTargetBody => Generate.AltruistTargetBody.Get();
        public static bool SheriffBodyReport => Generate.SheriffBodyReport.Get();
        public static float DragCd => Generate.DragCooldown.Get();
        public static bool UndertakerVent => Generate.UndertakerVent.Get();
        public static bool UndertakerVentWithBody => Generate.UndertakerVentWithBody.Get();
        public static bool AssassinGuessNeutrals => Generate.AssassinGuessNeutrals.Get();
        public static bool AssassinCrewmateGuess => Generate.AssassinCrewmateGuess.Get();
        public static int AssassinKills => (int)Generate.AssassinKills.Get();
        public static int NumberOfAssassins => (int)Generate.NumberOfAssassins.Get();
        public static bool AmneTurnAssassin => Generate.AmneTurnAssassin.Get();
        public static bool TraitorCanAssassin => Generate.TraitorCanAssassin.Get();
        public static bool AssassinMultiKill => Generate.AssassinMultiKill.Get();
        public static bool AssassinSnitchViaCrewmate => Generate.AssassinSnitchViaCrewmate.Get();
        public static float UnderdogKillBonus => Generate.UnderdogKillBonus.Get();
        public static bool UnderdogIncreasedKC => Generate.UnderdogIncreasedKC.Get();
        public static int PhantomTasksRemaining => (int)Generate.PhantomTasksRemaining.Get();
        public static bool VigilanteGuessNeutrals => Generate.VigilanteGuessNeutrals.Get();
        public static int VigilanteKills => (int)Generate.VigilanteKills.Get();
        public static bool VigilanteMultiKill => Generate.VigilanteMultiKill.Get();
        public static int HaunterTasksRemainingClicked => (int)Generate.HaunterTasksRemainingClicked.Get();
        public static int HaunterTasksRemainingAlert => (int)Generate.HaunterTasksRemainingAlert.Get();
        public static bool HaunterRevealsNeutrals => Generate.HaunterRevealsNeutrals.Get();
        public static HaunterCanBeClickedBy HaunterCanBeClickedBy => (HaunterCanBeClickedBy)Generate.HaunterCanBeClickedBy.Get();
        public static float GrenadeCd => Generate.GrenadeCooldown.Get();
        public static float GrenadeDuration => Generate.GrenadeDuration.Get();
        public static bool GrenadierVent => Generate.GrenadierVent.Get();
        public static float FlashRadius => Generate.FlashRadius.Get();
        public static int LovingImpPercent => (int)Generate.LovingImpPercent.Get();
        public static bool KilledOnAlert => Generate.KilledOnAlert.Get();
        public static float AlertCd => Generate.AlertCooldown.Get();
        public static float AlertDuration => Generate.AlertDuration.Get();
        public static int MaxAlerts => (int)Generate.MaxAlerts.Get();
        public static float UpdateInterval => Generate.UpdateInterval.Get();
        public static float TrackCd => Generate.TrackCooldown.Get();
        public static bool ResetOnNewRound => Generate.ResetOnNewRound.Get();
        public static int MaxTracks => (int)Generate.MaxTracks.Get();
        public static float PoisonCd => Generate.PoisonCooldown.Get();
        public static float PoisonDuration => Generate.PoisonDuration.Get();
        public static bool PoisonerVent => Generate.PoisonerVent.Get();
        public static int LatestSpawn => (int)Generate.LatestSpawn.Get();
        public static bool GlitchStopsTraitor => Generate.GlitchStopsTraitor.Get();
        public static float TransportCooldown => Generate.TransportCooldown.Get();
        public static int TransportMaxUses => (int) Generate.TransportMaxUses.Get();
        public static bool TransporterVitals => Generate.TransporterVitals.Get();
        public static bool RememberArrows => Generate.RememberArrows.Get();
        public static float RememberArrowDelay => Generate.RememberArrowDelay.Get();
    }
}