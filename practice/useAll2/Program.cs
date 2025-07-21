using System;
using System.Collections.Generic;

// 1. Interface ISmartDevice
interface ISmartDevice
{
    void TurnOn();
    void TurnOff();
    void GetStatus();
}

// 2. Interface ISmartEnergyMonitor
interface ISmartEnergyMonitor
{
    int GetEnergyUsage();
}

// Delegate for DeviceStatusChanged event
public delegate void DeviceStatusChangedHandler(object sender, string message);

// 3. Base Class SmartDevice implementing ISmartDevice
class SmartDevice : ISmartDevice
{
    public string DeviceName { get; set; }
    public string Manufacturer { get; set; }
    private bool isOn;

    public event DeviceStatusChangedHandler DeviceStatusChanged;

    public bool IsOn
    {
        get => isOn;
        private set
        {
            if (isOn != value)
            {
                isOn = value;
                // Trigger event when status changes
                OnDeviceStatusChanged($"{DeviceName} turned {(isOn ? "ON" : "OFF")}");
            }
        }
    }

    protected virtual void OnDeviceStatusChanged(string message)
    {
        DeviceStatusChanged?.Invoke(this, message);
    }

    public virtual void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{DeviceName} is now ON.");
    }

    public virtual void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{DeviceName} is now OFF.");
    }

    public virtual void GetStatus()
    {
        Console.WriteLine($"{DeviceName} status: {(IsOn ? "ON" : "OFF")}");
    }
}

// 4. Derived Class SmartLight
class SmartLight : SmartDevice, ISmartEnergyMonitor
{
    private int brightnessLevel;
    public int BrightnessLevel
    {
        get => brightnessLevel;
        private set
        {
            if (value < 0) brightnessLevel = 0;
            else if (value > 100) brightnessLevel = 100;
            else brightnessLevel = value;
        }
    }

    public void SetBrightness(int level)
    {
        BrightnessLevel = level;
        Console.WriteLine($"{DeviceName} brightness set to {BrightnessLevel}%.");
    }

    public int GetEnergyUsage()
    {
        // Example: energy usage = brightness percentage (1 watt per 1% brightness)
        return BrightnessLevel;
    }
}

// 5. Derived Class SmartThermostat
class SmartThermostat : SmartDevice, ISmartEnergyMonitor
{
    private int temperature;
    public int Temperature
    {
        get => temperature;
        private set
        {
            if (value < 10) temperature = 10;    // minimum temp limit
            else if (value > 30) temperature = 30; // maximum temp limit
            else temperature = value;
        }
    }

    public void SetTemperature(int temp)
    {
        Temperature = temp;
        Console.WriteLine($"{DeviceName} temperature set to {Temperature}°C.");
    }

    public int GetEnergyUsage()
    {
        // Example: base 50 watts + 5 watts per degree above 10
        if (Temperature <= 10) return 50;
        return 50 + 5 * (Temperature - 10);
    }
}

// 6. SmartHomeManager class
class SmartHomeManager
{
    private List<ISmartDevice> devices = new List<ISmartDevice>();

    public void AddDevice(ISmartDevice device)
    {
        devices.Add(device);
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }

    public void DisplayDeviceStatuses()
    {
        foreach (var device in devices)
        {
            device.GetStatus();
        }
    }
}

// 7. Main Program
class Program
{
    static void Main()
    {
        // Create devices
        SmartLight light = new SmartLight()
        {
            DeviceName = "Living Room Light",
            Manufacturer = "BrightLights Co"
        };

        SmartThermostat thermostat = new SmartThermostat()
        {
            DeviceName = "Hallway Thermostat",
            Manufacturer = "ThermoTech Ltd"
        };

        // Subscribe to status change events
        light.DeviceStatusChanged += OnDeviceStatusChanged;
        thermostat.DeviceStatusChanged += OnDeviceStatusChanged;

        // Create manager and add devices
        SmartHomeManager manager = new SmartHomeManager();
        manager.AddDevice(light);
        manager.AddDevice(thermostat);

        // Turn all devices ON
        manager.TurnOnAllDevices();

        // Adjust brightness and temperature
        light.SetBrightness(75);
        thermostat.SetTemperature(22);

        // Display statuses
        manager.DisplayDeviceStatuses();

        // Show energy usage using interface casting
        Console.WriteLine($"{light.DeviceName} energy usage: {((ISmartEnergyMonitor)light).GetEnergyUsage()} watts");
        Console.WriteLine($"{thermostat.DeviceName} energy usage: {((ISmartEnergyMonitor)thermostat).GetEnergyUsage()} watts");

        // Turn all devices OFF
        manager.TurnOffAllDevices();
    }

    // Event handler method
    static void OnDeviceStatusChanged(object sender, string message)
    {
        Console.WriteLine($"[EVENT] {message}");
    }
}
