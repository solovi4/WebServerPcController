using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YeelightAPI;
using YeelightAPI.Models.ColorFlow;

namespace MyPcController.Services
{
    public class LightService
    {
        public static async Task Rainbow()
        {
            var device = new Device("192.168.1.41");
            var device2 = new Device("192.168.1.42");
            var device3 = new Device("192.168.1.43");

            ColorFlow flow = new ColorFlow(0, ColorFlowEndAction.Keep);
            flow.Add(new ColorFlowRGBExpression(255, 0, 0, 50, 1000)); //красный
            flow.Add(new ColorFlowRGBExpression(255, 255, 0, 50, 1000)); //желный
            flow.Add(new ColorFlowRGBExpression(0, 255, 0, 50, 1000)); //зеленый
            flow.Add(new ColorFlowRGBExpression(0, 255, 255, 50, 1000)); //голубой
            flow.Add(new ColorFlowRGBExpression(0, 0, 255, 50, 1000)); //синий
            flow.Add(new ColorFlowRGBExpression(255, 0, 255, 50, 1000)); //фиолетовый

            var group = new DeviceGroup(device, device2, device3);
            await group.Connect();
            await group.StartColorFlow(flow);
            group.Disconnect();
        }
    }
}
