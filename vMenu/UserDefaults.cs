﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuAPI;
using Newtonsoft.Json;
using CitizenFX.Core;
using static CitizenFX.Core.UI.Screen;
using static CitizenFX.Core.Native.API;
using static vMenuClient.CommonFunctions;
using static vMenuShared.PermissionsManager;

namespace vMenuClient
{
    public static class UserDefaults
    {

        // Constants.
        private const string SETTINGS_PREFIX = "settings_";

        #region Public variables.
        #region PlayerOptions
        public static bool PlayerGodMode
        {
            get { return GetSettingsBool("playerGodMode"); }
            set { SetSavedSettingsBool("playerGodMode", value); }
        }

        public static bool PlayerStayInVehicle
        {
            get { return GetSettingsBool("playerStayInVehicle"); }
            set { SetSavedSettingsBool("playerStayInVehicle", value); }
        }

        public static bool UnlimitedStamina
        {
            get { return GetSettingsBool("unlimitedStamina"); }
            set { SetSavedSettingsBool("unlimitedStamina", value); }
        }

        public static bool FastRun
        {
            get { return GetSettingsBool("fastRun"); }
            set { SetSavedSettingsBool("fastRun", value); }
        }

        public static bool FastSwim
        {
            get { return GetSettingsBool("fastSwim"); }
            set { SetSavedSettingsBool("fastSwim", value); }
        }

        public static bool SuperJump
        {
            get { return GetSettingsBool("superJump"); }
            set { SetSavedSettingsBool("superJump", value); }
        }

        public static bool NoRagdoll
        {
            get { return GetSettingsBool("noRagdoll"); }
            set { SetSavedSettingsBool("noRagdoll", value); }
        }

        public static bool NeverWanted
        {
            get { return GetSettingsBool("neverWanted"); }
            set { SetSavedSettingsBool("neverWanted", value); }
        }

        public static bool EveryoneIgnorePlayer
        {
            get { return GetSettingsBool("everyoneIgnorePlayer"); }
            set { SetSavedSettingsBool("everyoneIgnorePlayer", value); }
        }
        #endregion

        #region Vehicle Options
        public static bool VehicleGodMode
        {
            get { return GetSettingsBool("vehicleGodMode"); }
            set { SetSavedSettingsBool("vehicleGodMode", value); }
        }
        public static bool VehicleGodInvincible
        {
            get { return GetSettingsBool("vehicleGodInvincible"); }
            set { SetSavedSettingsBool("vehicleGodInvincible", value); }
        }
        public static bool VehicleGodEngine
        {
            get { return GetSettingsBool("vehicleGodEngine"); }
            set { SetSavedSettingsBool("vehicleGodEngine", value); }
        }
        public static bool VehicleGodVisual
        {
            get { return GetSettingsBool("vehicleGodVisual"); }
            set { SetSavedSettingsBool("vehicleGodVisual", value); }
        }
        public static bool VehicleGodDamage
        {
            get { return GetSettingsBool("vehicleGodDamage"); }
            set { SetSavedSettingsBool("vehicleGodDamage", value); }
        }
        public static bool VehicleGodStrongWheels
        {
            get { return GetSettingsBool("vehicleGodStrongWheels"); }
            set { SetSavedSettingsBool("vehicleGodStrongWheels", value); }
        }
        public static bool VehicleGodRamp
        {
            get { return GetSettingsBool("vehicleGodRamp"); }
            set { SetSavedSettingsBool("vehicleGodRamp", value); }
        }
        public static bool VehicleGodAutoRepair
        {
            get { return GetSettingsBool("vehicleGodAutoRepair"); }
            set { SetSavedSettingsBool("vehicleGodAutoRepair", value); }
        }

        public static bool VehicleNeverDirty
        {
            get { return GetSettingsBool("vehicleNeverDirty"); }
            set { SetSavedSettingsBool("vehicleNeverDirty", value); }
        }

        public static bool VehicleEngineAlwaysOn
        {
            get { return GetSettingsBool("vehicleEngineAlwaysOn"); }
            set { SetSavedSettingsBool("vehicleEngineAlwaysOn", value); }
        }

        public static bool VehicleNoSiren
        {
            get { return GetSettingsBool("vehicleNoSiren"); }
            set { SetSavedSettingsBool("vehicleNoSiren", value); }
        }

        public static bool VehicleNoBikeHelmet
        {
            get { return GetSettingsBool("vehicleNoBikeHelmet"); }
            set { SetSavedSettingsBool("vehicleNoBikeHelmet", value); }
        }

        public static bool VehicleHighbeamsOnHonk
        {
            get { return GetSettingsBool("vehicleHighbeamsOnHonk"); }
            set { SetSavedSettingsBool("vehicleHighbeamsOnHonk", value); }
        }

        public static bool VehicleDisablePlaneTurbulence
        {
            get { return GetSettingsBool("vehicleDisablePlaneTurbulence"); }
            set { SetSavedSettingsBool("vehicleDisablePlaneTurbulence", value); }
        }

        public static bool VehicleBikeSeatbelt
        {
            get { return GetSettingsBool("vehicleBikeSeatbelt"); }
            set { SetSavedSettingsBool("vehicleBikeSeatbelt", value); }
        }
        
        public static int VehicleDefaultRadio
        {
            get { return GetSettingsInt("vehicleDefaultRadio"); }
            set { SetSavedSettingsInt("vehicleDefaultRadio", value); }
        }
        #endregion

        #region Vehicle Spawner Options
        public static bool VehicleSpawnerSpawnInside
        {
            get { return GetSettingsBool("vehicleSpawnerSpawnInside"); }
            set { SetSavedSettingsBool("vehicleSpawnerSpawnInside", value); }
        }

        public static bool VehicleSpawnerReplacePrevious
        {
            get { return GetSettingsBool("vehicleSpawnerReplacePrevious"); }
            set { SetSavedSettingsBool("vehicleSpawnerReplacePrevious", value); }
        }
        #endregion

        #region Weapon Options
        public static bool WeaponsNoReload
        {
            get { return GetSettingsBool("weaponsNoReload"); }
            set { SetSavedSettingsBool("weaponsNoReload", value); }
        }

        public static bool WeaponsUnlimitedAmmo
        {
            get { return GetSettingsBool("weaponsUnlimitedAmmo"); }
            set { SetSavedSettingsBool("weaponsUnlimitedAmmo", value); }
        }

        public static bool WeaponsUnlimitedParachutes
        {
            get { return GetSettingsBool("weaponsUnlimitedParachutes"); }
            set { SetSavedSettingsBool("weaponsUnlimitedParachutes", value); }
        }

        public static bool AutoEquipChute
        {
            get { return GetSettingsBool("autoEquipParachuteWhenInPlane"); }
            set { SetSavedSettingsBool("autoEquipParachuteWhenInPlane", value); }
        }
        #endregion

        #region Misc Settings
        public static bool MiscJoinQuitNotifications
        {
            get { return GetSettingsBool("miscJoinQuitNotifications"); }
            set { SetSavedSettingsBool("miscJoinQuitNotifications", value); }
        }

        public static bool MiscDeathNotifications
        {
            get { return GetSettingsBool("miscDeathNotifications"); }
            set { SetSavedSettingsBool("miscDeathNotifications", value); }
        }

        public static bool MiscSpeedKmh
        {
            get { return GetSettingsBool("miscSpeedoKmh"); }
            set { SetSavedSettingsBool("miscSpeedoKmh", value); }
        }

        public static bool MiscSpeedMph
        {
            get { return GetSettingsBool("miscSpeedoMph"); }
            set { SetSavedSettingsBool("miscSpeedoMph", value); }
        }

        public static bool MiscShowLocation
        {
            get { return GetSettingsBool("miscShowLocation"); }
            set { SetSavedSettingsBool("miscShowLocation", value); }
        }

        public static bool MiscLocationBlips
        {
            get { return GetSettingsBool("miscLocationBlips"); }
            set { SetSavedSettingsBool("miscLocationBlips", value); }
        }

        public static bool MiscShowPlayerBlips
        {
            get { return GetSettingsBool("miscShowPlayerBlips"); }
            set { SetSavedSettingsBool("miscShowPlayerBlips", value); }
        }

        public static bool MiscShowOverheadNames
        {
            get { return GetSettingsBool("miscShowOverheadNames"); }
            set { SetSavedSettingsBool("miscShowOverheadNames", value); }
        }

        public static bool MiscRestorePlayerAppearance
        {
            get { return GetSettingsBool("miscRestorePlayerAppearance"); }
            set { SetSavedSettingsBool("miscRestorePlayerAppearance", value); }
        }

        public static bool MiscRestorePlayerWeapons
        {
            get { return GetSettingsBool("miscRestorePlayerWeapons"); }
            set { SetSavedSettingsBool("miscRestorePlayerWeapons", value); }
        }

        public static bool MiscRespawnDefaultCharacter
        {
            get { return GetSettingsBool("miscRespawnDefaultCharacter"); }
            set { SetSavedSettingsBool("miscRespawnDefaultCharacter", value); }
        }

        public static bool MiscShowTime
        {
            get { return GetSettingsBool("miscShowTime"); }
            set { SetSavedSettingsBool("miscShowTime", value); }
        }

        public static bool MiscRightAlignMenu
        {
            get { return GetSettingsBool("miscRightAlignMenu"); }
            set { SetSavedSettingsBool("miscRightAlignMenu", value); }
        }

        public static bool MiscDisablePrivateMessages
        {
            get { return GetSettingsBool("miscDisablePrivateMessages"); }
            set { SetSavedSettingsBool("miscDisablePrivateMessages", value); }
        }

        public static bool MiscDisableControllerSupport
        {
            get { return GetSettingsBool("miscDisableControllerSupport"); }
            set { SetSavedSettingsBool("miscDisableControllerSupport", value); }
        }

        public static int MiscLastTimeCycleModifierIndex
        {
            get { return GetSettingsInt("miscLastTimeCycleModifierIndex"); }
            set { SetSavedSettingsInt("miscLastTimeCycleModifierIndex", value); }
        }

        public static int MiscLastTimeCycleModifierStrength
        {
            get { return GetSettingsInt("miscLastTimeCycleModifierStrength"); }
            set { SetSavedSettingsInt("miscLastTimeCycleModifierStrength", value); }
        }

        #region keybind menu
        public static bool KbTpToWaypoint
        {
            get { return GetSettingsBool("kbTpToWaypoint"); }
            set { SetSavedSettingsBool("kbTpToWaypoint", value); }
        }
        public static bool KbDriftMode
        {
            get { return GetSettingsBool("kbDriftMode"); }
            set { SetSavedSettingsBool("kbDriftMode", value); }
        }
        public static bool KbRecordKeys
        {
            get { return GetSettingsBool("kbRecordKeys"); }
            set { SetSavedSettingsBool("kbRecordKeys", value); }
        }
        public static bool KbRadarKeys
        {
            get { return GetSettingsBool("kbRadarKeys"); }
            set { SetSavedSettingsBool("kbRadarKeys", value); }
        }
        public static bool KbPointKeys
        {
            get { return GetSettingsBool("kbPointKeys"); }
            set { SetSavedSettingsBool("kbPointKeys", value); }
        }
        #endregion
        #endregion

        #region Voice Chat Settings
        public static bool VoiceChatEnabled
        {
            get { return GetSettingsBool("voiceChatEnabled"); }
            set { SetSavedSettingsBool("voiceChatEnabled", value); }
        }

        public static float VoiceChatProximity
        {
            get { return GetSettingsFloat("voiceChatProximity"); }
            set { SetSavedSettingsFloat("voiceChatProximity", value); }
        }

        public static bool ShowCurrentSpeaker
        {
            get { return GetSettingsBool("voiceChatShowSpeaker"); }
            set { SetSavedSettingsBool("voiceChatShowSpeaker", value); }
        }

        public static bool ShowVoiceStatus
        {
            get { return GetSettingsBool("voiceChatShowVoiceStatus"); }
            set { SetSavedSettingsBool("voiceChatShowVoiceStatus", value); }
        }
        #endregion

        #region Player Appearance
        public static int PAClothingAnimationType
        {
            get { return GetSettingsInt("clothingAnimationType"); }
            set { SetSavedSettingsInt("clothingAnimationType", value >= 0 ? value : 0); }
        }
        #endregion

        #region Weapon Loadouts
        public static bool WeaponLoadoutsSetLoadoutOnRespawn
        {
            get { return GetSettingsBool("weaponLoadoutsSetLoadoutOnRespawn"); }
            set { SetSavedSettingsBool("weaponLoadoutsSetLoadoutOnRespawn", value); }
        }
        #endregion

        #region Personal Vehicle
        public static bool PVEnableVehicleBlip
        {
            get { return GetSettingsBool("pvEnableVehicleBlip"); }
            set { SetSavedSettingsBool("pvEnableVehicleBlip", value); }
        }
        #endregion
        #endregion

        #region Private functions
        /// <summary>
        /// Gets whether or not the specified setting is enabled or disabled in the saved user settings.
        /// Always returns false by default if the setting does not exist.
        /// </summary>
        /// <param name="kvpString">The setting to get.</param>
        /// <returns></returns>
        private static bool GetSettingsBool(string kvpString)
        {
            // Get the current value.
            string savedValue = GetResourceKvpString($"{SETTINGS_PREFIX}{kvpString}");
            // Check if it exists.
            bool exists = !string.IsNullOrEmpty(savedValue);
            // If not, create it and save the new default value of false.
            if (!exists)
            {
                // Some options should be enabled by default:
                if (
                    kvpString == "unlimitedStamina" ||
                    kvpString == "miscDeathNotifications" ||
                    kvpString == "miscJoinQuitNotifications" ||
                    kvpString == "vehicleSpawnerSpawnInside" ||
                    kvpString == "vehicleSpawnerReplacePrevious" ||
                    kvpString == "neverWanted" ||
                    kvpString == "voiceChatShowSpeaker" ||
                    kvpString == "voiceChatEnabled" ||
                    kvpString == "autoEquipParachuteWhenInPlane" ||
                    kvpString == "miscRestorePlayerAppearance" ||
                    kvpString == "miscRestorePlayerWeapons" ||
                    kvpString == "miscRightAlignMenu" ||
                    kvpString == "miscRespawnDefaultCharacter" ||
                    kvpString == "vehicleGodInvincible" ||
                    kvpString == "vehicleGodEngine" ||
                    kvpString == "vehicleGodVisual" ||
                    kvpString == "vehicleGodStrongWheels" ||
                    kvpString == "vehicleGodRamp"
                    )
                {
                    SetSavedSettingsBool(kvpString, true);
                    return true;
                }
                // All other options should be disabled by default:
                else
                {
                    SetSavedSettingsBool(kvpString, false);
                    return false;
                }
            }
            else
            {
                // Return the (new) value.
                return (GetResourceKvpString($"{SETTINGS_PREFIX}{kvpString}").ToLower() == "true");
            }
        }

        /// <summary>
        /// Sets the new saved value for the specified setting.
        /// </summary>
        /// <param name="kvpString">The setting to save.</param>
        /// <param name="newValue">The new value for this setting.</param>
        private static void SetSavedSettingsBool(string kvpString, bool newValue)
        {
            SetResourceKvp(SETTINGS_PREFIX + kvpString, newValue.ToString());
        }

        private static float GetSettingsFloat(string kvpString)
        {
            float savedValue = GetResourceKvpFloat(SETTINGS_PREFIX + kvpString);
            if (savedValue.ToString() != null) // this can still become null for some reason, so that's why we check it.
            {
                if (savedValue.GetType() == typeof(float))
                {
                    return savedValue;
                }
                else
                {
                    return -1f;
                }
            }
            else
            {
                SetSavedSettingsFloat(SETTINGS_PREFIX + kvpString, -1f);
                return -1f;
            }
        }

        private static void SetSavedSettingsFloat(string kvpString, float newValue)
        {
            SetResourceKvpFloat(SETTINGS_PREFIX + kvpString, newValue);
        }


        private static int GetSettingsInt(string kvpString)
        {
            // Get the current value.
            int savedValue = GetResourceKvpInt($"{SETTINGS_PREFIX}{kvpString}");
            return savedValue;
        }

        private static void SetSavedSettingsInt(string kvpString, int newValue)
        {
            SetResourceKvpInt(SETTINGS_PREFIX + kvpString, newValue);
        }
        #endregion

        #region Public Functions
        /// <summary>
        /// Saves all personal settings to the client storage.
        /// </summary>
        public static void SaveSettings()
        {
            ConcurrentDictionaryTryAdd<string, dynamic> prefs = new Dictionary<string, dynamic>();
            if (MainMenu.PlayerOptionsMenu != null)
            {
                EveryoneIgnorePlayer = MainMenu.PlayerOptionsMenu.PlayerIsIgnored;
                prefs.TryAdd("everyoneIgnorePlayer", EveryoneIgnorePlayer);

                FastRun = MainMenu.PlayerOptionsMenu.PlayerFastRun;
                prefs.TryAdd("fastRun", FastRun);

                FastSwim = MainMenu.PlayerOptionsMenu.PlayerFastSwim;
                prefs.TryAdd("fastSwim", FastSwim);

                NeverWanted = MainMenu.PlayerOptionsMenu.PlayerNeverWanted;
                prefs.TryAdd("neverWanted", NeverWanted);

                NoRagdoll = MainMenu.PlayerOptionsMenu.PlayerNoRagdoll;
                prefs.TryAdd("noRagdoll", NoRagdoll);

                PlayerGodMode = MainMenu.PlayerOptionsMenu.PlayerGodMode;
                prefs.TryAdd("playerGodMode", PlayerGodMode);

                PlayerStayInVehicle = MainMenu.PlayerOptionsMenu.PlayerStayInVehicle;
                prefs.TryAdd("playerStayInVehicle", PlayerStayInVehicle);

                SuperJump = MainMenu.PlayerOptionsMenu.PlayerSuperJump;
                prefs.TryAdd("superJump", SuperJump);

                UnlimitedStamina = MainMenu.PlayerOptionsMenu.PlayerStamina;
                prefs.TryAdd("unlimitedStamina", UnlimitedStamina);
            }

            if (MainMenu.MiscSettingsMenu != null)
            {
                MiscDeathNotifications = MainMenu.MiscSettingsMenu.DeathNotifications;
                prefs.TryAdd("miscDeathNotifications", MiscDeathNotifications);

                MiscJoinQuitNotifications = MainMenu.MiscSettingsMenu.JoinQuitNotifications;
                prefs.TryAdd("miscJoinQuitNotifications", MiscJoinQuitNotifications);

                MiscSpeedKmh = MainMenu.MiscSettingsMenu.ShowSpeedoKmh;
                prefs.TryAdd("miscSpeedKmh", MiscSpeedKmh);

                MiscSpeedMph = MainMenu.MiscSettingsMenu.ShowSpeedoMph;
                prefs.TryAdd("miscSpeedMph", MiscSpeedMph);

                MiscShowLocation = MainMenu.MiscSettingsMenu.ShowLocation;
                prefs.TryAdd("miscShowLocation", MiscShowLocation);

                MiscLocationBlips = MainMenu.MiscSettingsMenu.ShowLocationBlips;
                prefs.TryAdd("miscLocationBlips", MiscLocationBlips);

                MiscShowPlayerBlips = MainMenu.MiscSettingsMenu.ShowPlayerBlips;
                prefs.TryAdd("miscShowPlayerBlips", MiscShowPlayerBlips);

                MiscShowOverheadNames = MainMenu.MiscSettingsMenu.MiscShowOverheadNames;
                prefs.TryAdd("miscShowOverheadNames", MiscShowOverheadNames);

                MiscRespawnDefaultCharacter = MainMenu.MiscSettingsMenu.MiscRespawnDefaultCharacter;
                prefs.TryAdd("miscRespawnDefaultCharacter", MiscRespawnDefaultCharacter);

                MiscRestorePlayerAppearance = MainMenu.MiscSettingsMenu.RestorePlayerAppearance;
                prefs.TryAdd("miscRestorePlayerAppearance", MiscRestorePlayerAppearance);

                MiscRestorePlayerWeapons = MainMenu.MiscSettingsMenu.RestorePlayerWeapons;
                prefs.TryAdd("miscRestorePlayerWeapons", MiscRestorePlayerWeapons);

                MiscShowTime = MainMenu.MiscSettingsMenu.DrawTimeOnScreen;
                prefs.TryAdd("miscShowTime", MiscShowTime);

                MiscRightAlignMenu = MainMenu.MiscSettingsMenu.MiscRightAlignMenu;
                prefs.TryAdd("miscRightAlignMenu", MiscRightAlignMenu);

                MiscDisablePrivateMessages = MainMenu.MiscSettingsMenu.MiscDisablePrivateMessages;
                prefs.TryAdd("miscDisablePrivateMessages", MiscDisablePrivateMessages);

                MiscDisableControllerSupport = MainMenu.MiscSettingsMenu.MiscDisableControllerSupport;
                prefs.TryAdd("miscDisableControllerSupport", MiscDisableControllerSupport);

                KbTpToWaypoint = MainMenu.MiscSettingsMenu.KbTpToWaypoint;
                prefs.TryAdd("kbTpToWaypoint", KbTpToWaypoint);

                KbDriftMode = MainMenu.MiscSettingsMenu.KbDriftMode;
                prefs.TryAdd("kbDriftMode", KbDriftMode);

                KbRecordKeys = MainMenu.MiscSettingsMenu.KbRecordKeys;
                prefs.TryAdd("kbRecordKeys", KbRecordKeys);

                KbRadarKeys = MainMenu.MiscSettingsMenu.KbRadarKeys;
                prefs.TryAdd("kbRadarKeys", KbRadarKeys);

                KbPointKeys = MainMenu.MiscSettingsMenu.KbPointKeys;
                prefs.TryAdd("kbPointKeys", KbPointKeys);
            }

            if (MainMenu.VehicleOptionsMenu != null)
            {
                VehicleEngineAlwaysOn = MainMenu.VehicleOptionsMenu.VehicleEngineAlwaysOn;
                prefs.TryAdd("vehicleEngineAlwaysOn", VehicleEngineAlwaysOn);

                VehicleGodMode = MainMenu.VehicleOptionsMenu.VehicleGodMode;
                prefs.TryAdd("vehicleGodMode", VehicleGodMode);

                VehicleGodInvincible = MainMenu.VehicleOptionsMenu.VehicleGodInvincible;
                prefs.TryAdd("vehicleGodInvincible", VehicleGodInvincible);
                VehicleGodEngine = MainMenu.VehicleOptionsMenu.VehicleGodEngine;
                prefs.TryAdd("vehicleGodEngine", VehicleGodEngine);
                VehicleGodVisual = MainMenu.VehicleOptionsMenu.VehicleGodVisual;
                prefs.TryAdd("vehicleGodVisual", VehicleGodVisual);
                VehicleGodStrongWheels = MainMenu.VehicleOptionsMenu.VehicleGodStrongWheels;
                prefs.TryAdd("vehicleGodStrongWheels", VehicleGodStrongWheels);
                VehicleGodRamp = MainMenu.VehicleOptionsMenu.VehicleGodRamp;
                prefs.TryAdd("vehicleGodRamp", VehicleGodRamp);
                VehicleGodAutoRepair = MainMenu.VehicleOptionsMenu.VehicleGodAutoRepair;
                prefs.TryAdd("vehicleGodAutoRepair", VehicleGodAutoRepair);

                //VehicleSpecialGodMode = MainMenu.VehicleOptionsMenu.VehicleSpecialGodMode;
                //prefs.TryAdd("vehicleSpecialGodMode", VehicleSpecialGodMode);

                VehicleNeverDirty = MainMenu.VehicleOptionsMenu.VehicleNeverDirty;
                prefs.TryAdd("vehicleNeverDirty", VehicleNeverDirty);

                VehicleNoBikeHelmet = MainMenu.VehicleOptionsMenu.VehicleNoBikeHelemet;
                prefs.TryAdd("vehicleNoBikeHelmet", VehicleNoBikeHelmet);

                VehicleNoSiren = MainMenu.VehicleOptionsMenu.VehicleNoSiren;
                prefs.TryAdd("vehicleNoSiren", VehicleNoSiren);

                VehicleHighbeamsOnHonk = MainMenu.VehicleOptionsMenu.FlashHighbeamsOnHonk;
                prefs.TryAdd("vehicleHighbeamsOnHonk", VehicleHighbeamsOnHonk);

                VehicleDisablePlaneTurbulence = MainMenu.VehicleOptionsMenu.DisablePlaneTurbulence;
                prefs.TryAdd("vehicleDisablePlaneTurbulence", VehicleDisablePlaneTurbulence);

                VehicleBikeSeatbelt = MainMenu.VehicleOptionsMenu.VehicleBikeSeatbelt;
                prefs.TryAdd("vehicleBikeSeatbelt", VehicleBikeSeatbelt);
            }

            if (MainMenu.VehicleSpawnerMenu != null)
            {
                VehicleSpawnerReplacePrevious = MainMenu.VehicleSpawnerMenu.ReplaceVehicle;
                prefs.TryAdd("vehicleSpawnerReplacePrevious", VehicleSpawnerReplacePrevious);

                VehicleSpawnerSpawnInside = MainMenu.VehicleSpawnerMenu.SpawnInVehicle;
                prefs.TryAdd("vehicleSpawnerSpawnInside", VehicleSpawnerSpawnInside);
            }

            if (MainMenu.VoiceChatSettingsMenu != null)
            {
                VoiceChatEnabled = MainMenu.VoiceChatSettingsMenu.EnableVoicechat;
                prefs.TryAdd("voiceChatEnabled", VoiceChatEnabled);

                VoiceChatProximity = MainMenu.VoiceChatSettingsMenu.currentProximity;
                prefs.TryAdd("voiceChatProximity", VoiceChatProximity);

                ShowCurrentSpeaker = MainMenu.VoiceChatSettingsMenu.ShowCurrentSpeaker;
                prefs.TryAdd("voiceChatShowSpeaker", ShowCurrentSpeaker);

                ShowVoiceStatus = MainMenu.VoiceChatSettingsMenu.ShowVoiceStatus;
                prefs.TryAdd("voiceChatShowVoiceStatus", ShowVoiceStatus);
            }

            if (MainMenu.WeaponOptionsMenu != null)
            {
                WeaponsNoReload = MainMenu.WeaponOptionsMenu.NoReload;
                prefs.TryAdd("weaponsNoReload", WeaponsNoReload);

                WeaponsUnlimitedAmmo = MainMenu.WeaponOptionsMenu.UnlimitedAmmo;
                prefs.TryAdd("weaponsUnlimitedAmmo", WeaponsUnlimitedAmmo);

                WeaponsUnlimitedParachutes = MainMenu.WeaponOptionsMenu.UnlimitedParachutes;
                prefs.TryAdd("weaponsUnlimitedParachutes", WeaponsUnlimitedParachutes);

                AutoEquipChute = MainMenu.WeaponOptionsMenu.AutoEquipChute;
                prefs.TryAdd("autoEquipParachuteWhenInPlane", AutoEquipChute);
            }

            if (PlayerAppearance.ClothingAnimationType >= 0)
            {
                PAClothingAnimationType = PlayerAppearance.ClothingAnimationType;
                prefs.TryAdd("clothingAnimationType", PAClothingAnimationType);
            }

            if (MainMenu.WeaponLoadoutsMenu != null)
            {
                WeaponLoadoutsSetLoadoutOnRespawn = MainMenu.WeaponLoadoutsMenu.WeaponLoadoutsSetLoadoutOnRespawn;
                prefs.TryAdd("weaponLoadoutsSetLoadoutOnRespawn", WeaponLoadoutsSetLoadoutOnRespawn);
            }

            if (MainMenu.PersonalVehicleMenu != null)
            {
                PVEnableVehicleBlip = MainMenu.PersonalVehicleMenu.EnableVehicleBlip;
                prefs.TryAdd("pvEnableVehicleBlip", PVEnableVehicleBlip);
            }

            Notify.Success("Your settings have been saved.");

            Log($"Saving preferences:\n{JsonConvert.SerializeObject(prefs)}");
        }

        #endregion
    }

}
