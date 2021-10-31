using System;
using GTANetworkAPI;

namespace Server
{
    public class App : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void ResourceStarEventHandler()
        {
            NAPI.Util.ConsoleOutput($"Starting SERVER Resource");
            NAPI.Util.ConsoleOutput($"DRDRDRDRDR");
        }

        [ServerEvent(Event.PlayerConnected)]
        public void Joined()
        {
            NAPI.Util.ConsoleOutput($"Connected");
        }

        [Command("veh")]
        public void CreateVehicleCommand(Player player, VehicleHash vehicleHash, int color1, int color2) 
        {
            NAPI.Vehicle.CreateVehicle(vehicleHash, player.Position, player.Rotation, color1, color2);                                                                                        
        }
    }
}
