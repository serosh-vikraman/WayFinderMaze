using System;
using System.Threading;
using System.Threading.Tasks;

using AzureMapsControl.Components.Map;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using RestSharp;

namespace AzureMapsCreator.Pages
{
    public partial class ViewMap
    {


        [Inject] AzureMapsControl.Components.Indoor.IIndoorService IndoorService { get; set; }
        [Inject] IConfiguration Configuration { get; set; }
        [Inject] Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        private string  spinnerClassName = "hidden";
        private string mappathClassName = "hidden";
        private string mapClassName = "visible";
        private string fromValue = "";
        private string fileName = "";
        public async Task OnMapReadyAsync(MapEventArgs eventArgs)
        {
            var levelControl = new AzureMapsControl.Components.Indoor.LevelControl(new AzureMapsControl.Components.Indoor.LevelControlOptions
            {
                Position = AzureMapsControl.Components.Controls.ControlPosition.TopRight
            });

            var statesetId = await LocalStorage.GetItemAsync<string>("stateset-udid");

            var options = new AzureMapsControl.Components.Indoor.IndoorManagerOptions
            {
                Geography = Configuration["AzureMaps:Geography"],
                LevelControl = levelControl,
                StatesetId = statesetId,
                TilesetId = await LocalStorage.GetItemAsync<string>("tileset-udid")
            };

            var indoorManager = await IndoorService.CreateIndoorManagerAsync(options, AzureMapsControl.Components.Indoor.IndoorManagerEventActivationFlags.All());

            indoorManager.OnFacilityChanged += eventArgs =>
            {
                Console.WriteLine("OnFacilityChanged");
                Console.WriteLine($"Switched facility from {eventArgs.PrevFacilityId} to {eventArgs.FacilityId}");
                Console.WriteLine($"Switched level from {eventArgs.PrevLevelNumber} to {eventArgs.LevelNumber}");
            };

            indoorManager.OnLevelChanged += eventArgs =>
            {
                Console.WriteLine("OnLevelChanged");
                Console.WriteLine($"Switched facility from {eventArgs.PrevFacilityId} to {eventArgs.FacilityId}");
                Console.WriteLine($"Switched level from {eventArgs.PrevLevelNumber} to {eventArgs.LevelNumber}");
            };

            if (!string.IsNullOrWhiteSpace(statesetId))
            {
                await indoorManager.SetDynamicStylingAsync(true);
            }
        }
        private async Task GetMapPath()
        {
            Thread.Sleep(1000);
            mappathClassName = "visible";
            mapClassName = "hidden";
            if (fromValue == "147")
            {
                fileName = "Path1.jpg";
            }
            else  
            {
                fileName = "Path2.jpg";
            }
        }
        private async Task Clear()
        {
            Thread.Sleep(1000);
            mappathClassName = "hidden";
            mapClassName = "visible";
        }
    }
}