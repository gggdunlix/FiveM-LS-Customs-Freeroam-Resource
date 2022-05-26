using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json.Schema;

namespace client
{
    public class Main : BaseScript
    {






        public Main()
        {

            var configfile = API.LoadResourceFile(API.GetCurrentResourceName(), "/config.json");
            var config = JObject.Parse(configfile.ToString());
            Array CustomLocations = config["locations"].ToArray();

            Debug.Write("\nConfig File: " + configfile);
            Debug.Write("\nConfig JSON: " + config);
            Debug.Write("\nCustom Locations: " + CustomLocations);

            foreach (JToken locationInfo in CustomLocations)
            {
                Debug.Write("\nLoc Info: " + locationInfo);

                var customLocation = locationInfo["location"];
                Debug.Write("\ncustom Location: " + customLocation);
                var locName = locationInfo["name"];
                Debug.Write("\nLoc Name: " + locName);


            }

            Debug.WriteLine("LS Customs script loaded. Made by GGGDunlix. Derived from Abel Gaming's resource.");
            Tick += DrawMarkers;
            Tick += CheckMarkers;
        }


        private static async Task DrawMarkers()
        {
            var configfile = API.LoadResourceFile(API.GetCurrentResourceName(), "/config.json");
            var config = JObject.Parse(configfile.ToString());
            Array CustomLocations = config["locations"].ToArray();

            foreach (JToken locationInfo in CustomLocations) // Grandpa Rex Helped!!!
            {
                //Get info from this shop
                var customLocation = locationInfo["location"];
                var locName = locationInfo["name"];

                //convert to strings and numbers etc...
                string[] customLocCoords = ((string)customLocation).Split(',');
                float.TryParse(customLocCoords[0], out float locationX);
                float.TryParse(customLocCoords[1], out float locationY);
                float.TryParse(customLocCoords[2], out float locationZ);

                //make a Vector3 from it
                Vector3 LSCustoms = new Vector3(locationX, locationY, locationZ);

                //Actual Script
                API.DrawMarker(1, LSCustoms.X, LSCustoms.Y, LSCustoms.Z, 0.0f, 0.0f, 0.0f, 0.0f, 180f, 0.0f, 3f, 3f, 3f, 0, 0, 200, 200, true, true, 2, false, (string)null, (string)null, false);
                Blip LSBlip = World.CreateBlip(LSCustoms);
                LSBlip.Name = locName.ToString();
                LSBlip.Sprite = BlipSprite.LosSantosCustoms;
            }
        }

        private static async Task CheckMarkers()
        {
            var configfile = API.LoadResourceFile(API.GetCurrentResourceName(), "/config.json");
            var config = JObject.Parse(configfile.ToString());
            Array CustomLocations = config["locations"].ToArray();

            foreach (JToken locationInfo in CustomLocations)
            {
                //Get info from this shop
                var customLocation = locationInfo["location"];
                var locName = locationInfo["name"];

                //convert to strings and numbers etc...
                string[] customLocCoords = ((string)customLocation).Split(',');
                float.TryParse(customLocCoords[0], out float locationX);
                float.TryParse(customLocCoords[1], out float locationY);
                float.TryParse(customLocCoords[2], out float locationZ);

                //make a Vector3 from it
                Vector3 LSCustoms = new Vector3(locationX, locationY, locationZ);

                //Camera oldnormalcam = World.RenderingCamera;


                float MarkerDistance = World.GetDistance(((Entity)Game.Player.Character).Position, LSCustoms);
                if ((double)MarkerDistance <= 1.5)
                {
                    //Camera normalcam = World.RenderingCamera;
                    if (Game.Player.Character.IsInVehicle())
                    {

                        Screen.DisplayHelpTextThisFrame("Press ~INPUT_PICKUP~ to enter ~y~ " + locName);
                        if (API.IsControlJustPressed(0, 38))
                        {
                            Menu.CreateList(Game.Player.Character.CurrentVehicle);
                            Menu.mainMenu.Visible = true;
                            Game.Player.CanControlCharacter = false;
                            Screen.Hud.IsVisible = false;
                            Screen.Hud.IsRadarVisible = false;
                            Vector3 carpos = Game.Player.Character.CurrentVehicle.Position;
                            //Camera vehcam = World.CreateCamera(new Vector3(carpos.X + 5, carpos.Y + 5, carpos.Z + 5), carpos, 200f);
                            //World.RenderingCamera = vehcam;
                        }

                    }
                    else
                    {
                        Screen.DisplayHelpTextThisFrame("You need to be in a vehicle to enter " + locName);
                    }
                    if (!Menu._menuPool.IsAnyMenuOpen())
                    {
                        Game.Player.CanControlCharacter = true;
                        Screen.Hud.IsVisible = true;
                        Screen.Hud.IsRadarVisible = true;
                        //World.RenderingCamera = normalcam;
                    }
                }
                else if (!Menu._menuPool.IsAnyMenuOpen())
                {
                    Game.Player.CanControlCharacter = true;
                    Screen.Hud.IsVisible = true;
                    Screen.Hud.IsRadarVisible = true;
                   // World.RenderingCamera = oldnormalcam;
                }
            }
        }
    }
}