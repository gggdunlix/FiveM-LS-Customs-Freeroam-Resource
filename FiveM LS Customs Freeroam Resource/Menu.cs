// Decompiled with JetBrains decompiler
// Type: client.Menu
// Assembly: client.net, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 644B6342-F48C-41E6-9B71-76A04DFA2F19
// Assembly location: D:\txData\QBCoreFramework_C9E8E1.base\resources\[gui]\LSCustoms\client.net.dll

using CitizenFX.Core;
using CitizenFX.Core.Native;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace client
{
    public class Menu : BaseScript
    {
        public static MenuPool _menuPool;
        public static UIMenu mainMenu;
        public static UIMenuItem EnterCustoms;
        private static int playervehicle;

        public static void CreateList(Vehicle car) => Menu.playervehicle = API.GetVehiclePedIsIn(API.GetPlayerPed(-1), true);

        public void UpgradeOptions(UIMenu menu)
        {
            UIMenu vehicleupgradesub = Menu._menuPool.AddSubMenu(menu, "Vehicle Modifications");
            int num1 = 0;
            while (num1 < 1)
                ++num1;
            vehicleupgradesub.MouseEdgeEnabled = false;
            vehicleupgradesub.ControlDisablingEnabled = false;
            List<object> Spoiler = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> FrontBumper = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> RearBumper = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> SideSkirt = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Exhaust = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Frame = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Grille = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Hood = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Fender = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Roof = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Engine = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Brakes = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Transmission = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Horns = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Suspension = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> Armor = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> FrontWheels = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            List<object> RearWheels = new List<object>()
      {
        (object) "0",
        (object) "1"
      };
            Menu.mainMenu.OnItemSelect += (ItemSelectEvent)((sender, item, index) =>
            {
                if (item != Menu.EnterCustoms)
                    return;
                Spoiler.Clear();
                FrontBumper.Clear();
                RearBumper.Clear();
                SideSkirt.Clear();
                Exhaust.Clear();
                Frame.Clear();
                Grille.Clear();
                Hood.Clear();
                Fender.Clear();
                Roof.Clear();
                Engine.Clear();
                Brakes.Clear();
                Transmission.Clear();
                Horns.Clear();
                Suspension.Clear();
                Armor.Clear();
                FrontWheels.Clear();
                RearWheels.Clear();
                for (int index1 = 0; index1 <= API.GetNumVehicleMods(Menu.playervehicle, 0); ++index1)
                    Spoiler.Add((object)index1.ToString());
                for (int index2 = 0; index2 <= API.GetNumVehicleMods(Menu.playervehicle, 1); ++index2)
                    FrontBumper.Add((object)index2.ToString());
                for (int index3 = 0; index3 <= API.GetNumVehicleMods(Menu.playervehicle, 2); ++index3)
                    RearBumper.Add((object)index3.ToString());
                for (int index4 = 0; index4 <= API.GetNumVehicleMods(Menu.playervehicle, 3); ++index4)
                    SideSkirt.Add((object)index4.ToString());
                for (int index5 = 0; index5 <= API.GetNumVehicleMods(Menu.playervehicle, 4); ++index5)
                    Exhaust.Add((object)index5.ToString());
                for (int index6 = 0; index6 <= API.GetNumVehicleMods(Menu.playervehicle, 5); ++index6)
                    Frame.Add((object)index6.ToString());
                for (int index7 = 0; index7 <= API.GetNumVehicleMods(Menu.playervehicle, 6); ++index7)
                    Grille.Add((object)index7.ToString());
                for (int index8 = 0; index8 <= API.GetNumVehicleMods(Menu.playervehicle, 7); ++index8)
                    Hood.Add((object)index8.ToString());
                for (int index9 = 0; index9 <= API.GetNumVehicleMods(Menu.playervehicle, 8); ++index9)
                    Fender.Add((object)index9.ToString());
                for (int index10 = 0; index10 <= API.GetNumVehicleMods(Menu.playervehicle, 10); ++index10)
                    Roof.Add((object)index10.ToString());
                for (int index11 = 0; index11 <= API.GetNumVehicleMods(Menu.playervehicle, 11); ++index11)
                    Engine.Add((object)index11.ToString());
                for (int index12 = 0; index12 <= API.GetNumVehicleMods(Menu.playervehicle, 12); ++index12)
                    Brakes.Add((object)index12.ToString());
                for (int index13 = 0; index13 <= API.GetNumVehicleMods(Menu.playervehicle, 13); ++index13)
                    Transmission.Add((object)index13.ToString());
                for (int index14 = 0; index14 <= API.GetNumVehicleMods(Menu.playervehicle, 14); ++index14)
                    Horns.Add((object)index14.ToString());
                for (int index15 = 0; index15 <= API.GetNumVehicleMods(Menu.playervehicle, 15); ++index15)
                    Suspension.Add((object)index15.ToString());
                for (int index16 = 0; index16 <= API.GetNumVehicleMods(Menu.playervehicle, 16); ++index16)
                    Armor.Add((object)index16.ToString());
                for (int index17 = 0; index17 <= API.GetNumVehicleMods(Menu.playervehicle, 23); ++index17)
                    FrontWheels.Add((object)index17.ToString());
                for (int index18 = 0; index18 <= API.GetNumVehicleMods(Menu.playervehicle, 24); ++index18)
                    RearWheels.Add((object)index18.ToString());
                vehicleupgradesub.RefreshIndex();
                Menu.mainMenu.Visible = false;
                vehicleupgradesub.Visible = true;
            });
            UIMenuListItem SpoilerUpgrade = new UIMenuListItem("Spoiler", Spoiler, 0);
            vehicleupgradesub.AddItem((UIMenuItem)SpoilerUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != SpoilerUpgrade)
                    return;
                int num2 = int.Parse(SpoilerUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 0, num2, false);
            });
            UIMenuListItem FrontBumperUpgrade = new UIMenuListItem("Front Bumper", FrontBumper, 0);
            vehicleupgradesub.AddItem((UIMenuItem)FrontBumperUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != FrontBumperUpgrade)
                    return;
                int num3 = int.Parse(FrontBumperUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 1, num3, false);
            });
            UIMenuListItem RearBumperUpgrade = new UIMenuListItem("Rear Bumper", RearBumper, 0);
            vehicleupgradesub.AddItem((UIMenuItem)RearBumperUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != RearBumperUpgrade)
                    return;
                int num4 = int.Parse(RearBumperUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 2, num4, false);
            });
            UIMenuListItem SideSkirtsUpgrade = new UIMenuListItem("Side Skirt", SideSkirt, 0);
            vehicleupgradesub.AddItem((UIMenuItem)SideSkirtsUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != SideSkirtsUpgrade)
                    return;
                int num5 = int.Parse(SideSkirtsUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 3, num5, false);
            });
            UIMenuListItem ExhaustUpgrade = new UIMenuListItem("Exhaust", Exhaust, 0);
            vehicleupgradesub.AddItem((UIMenuItem)ExhaustUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != ExhaustUpgrade)
                    return;
                int num6 = int.Parse(ExhaustUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 4, num6, false);
            });
            UIMenuListItem FrameUpgrade = new UIMenuListItem("Frame", Frame, 0);
            vehicleupgradesub.AddItem((UIMenuItem)FrameUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != FrameUpgrade)
                    return;
                int num7 = int.Parse(FrameUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 5, num7, false);
            });
            UIMenuListItem GrilleUpgrade = new UIMenuListItem("Grille", Grille, 0);
            vehicleupgradesub.AddItem((UIMenuItem)GrilleUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != GrilleUpgrade)
                    return;
                int num8 = int.Parse(GrilleUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 6, num8, false);
            });
            UIMenuListItem HoodUpgrade = new UIMenuListItem("Hood", Hood, 0);
            vehicleupgradesub.AddItem((UIMenuItem)HoodUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != HoodUpgrade)
                    return;
                int num9 = int.Parse(HoodUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 7, num9, false);
            });
            UIMenuListItem FenderUpgrade = new UIMenuListItem("Fender", Fender, 0);
            vehicleupgradesub.AddItem((UIMenuItem)FenderUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != FenderUpgrade)
                    return;
                int num10 = int.Parse(FenderUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 8, num10, false);
            });
            UIMenuListItem RoofUpgrade = new UIMenuListItem("Roof", Roof, 0);
            vehicleupgradesub.AddItem((UIMenuItem)RoofUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != RoofUpgrade)
                    return;
                int num11 = int.Parse(RoofUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 10, num11, false);
            });
            UIMenuListItem EngineUpgrade = new UIMenuListItem("Engine", Engine, 0);
            vehicleupgradesub.AddItem((UIMenuItem)EngineUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != EngineUpgrade)
                    return;
                int num12 = int.Parse(EngineUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 11, num12, false);
            });
            UIMenuListItem BrakeUpgrade = new UIMenuListItem("Brakes", Brakes, 0);
            vehicleupgradesub.AddItem((UIMenuItem)BrakeUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != BrakeUpgrade)
                    return;
                int num13 = int.Parse(BrakeUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 12, num13, false);
            });
            UIMenuListItem TransmissionUpgrade = new UIMenuListItem("Transmission", Transmission, 0);
            vehicleupgradesub.AddItem((UIMenuItem)TransmissionUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != TransmissionUpgrade)
                    return;
                int num14 = int.Parse(TransmissionUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 13, num14, false);
            });
            UIMenuListItem HornUpgrade = new UIMenuListItem("Horns", Horns, 0);
            vehicleupgradesub.AddItem((UIMenuItem)HornUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != HornUpgrade)
                    return;
                int num15 = int.Parse(HornUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 14, num15, false);
            });
            UIMenuListItem SuspensionUpgrade = new UIMenuListItem("Suspension", Suspension, 0);
            vehicleupgradesub.AddItem((UIMenuItem)SuspensionUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != SuspensionUpgrade)
                    return;
                int num16 = int.Parse(SuspensionUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 15, num16, false);
            });
            UIMenuListItem ArmorUpgrade = new UIMenuListItem("Armor", Armor, 0);
            vehicleupgradesub.AddItem((UIMenuItem)ArmorUpgrade);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != ArmorUpgrade)
                    return;
                int num17 = int.Parse(ArmorUpgrade.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 16, num17, false);
            });
            UIMenuListItem FrontWheelUpgrades = new UIMenuListItem("Front Wheels", FrontWheels, 0);
            vehicleupgradesub.AddItem((UIMenuItem)FrontWheelUpgrades);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != FrontWheelUpgrades)
                    return;
                int num18 = int.Parse(FrontWheelUpgrades.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 23, num18, false);
            });
            UIMenuListItem RearWheelUpgrades = new UIMenuListItem("Rear Wheels", RearWheels, 0);
            vehicleupgradesub.AddItem((UIMenuItem)RearWheelUpgrades);
            vehicleupgradesub.OnListChange += (ListChangedEvent)((sender, item, index) =>
            {
                if (item != RearWheelUpgrades)
                    return;
                int num19 = int.Parse(RearWheelUpgrades.CurrentItem());
                API.SetVehicleModKit(Menu.playervehicle, 0);
                API.SetVehicleMod(Menu.playervehicle, 24, num19, false);
            });
        }

        public Menu()
        {
            Menu._menuPool = new MenuPool();
            Menu.mainMenu = new UIMenu("Los Santos Customs", "Mod by ~b~Abel Gaming");
            Menu._menuPool.Add(Menu.mainMenu);
            Menu.EnterCustoms = new UIMenuItem("Enter Customs", "~r~Must select before selecting vehicle modifications");
            Menu.mainMenu.AddItem(Menu.EnterCustoms);
            this.UpgradeOptions(Menu.mainMenu);
            Menu._menuPool.MouseEdgeEnabled = false;
            Menu._menuPool.ControlDisablingEnabled = false;
            Menu._menuPool.RefreshIndex();
            this.Tick += (Func<Task>)(async () => Menu._menuPool.ProcessMenus());
        }
    }
}
