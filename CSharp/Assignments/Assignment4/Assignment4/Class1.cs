using System;

delegate void RingEventHandler();

class MobilePhone
{
    public event RingEventHandler OnRing;

    public void ReceiveCall()
    {
        if (OnRing != null)
        {
            OnRing();
        }
    }
}

class RingtonePlayer
{
    public void PlayRingtone()
    {
        Console.WriteLine("Playing ringtone...");
    }
}

class ScreenDisplay
{
    public void ShowCallerInfo()
    {
        Console.WriteLine("Displaying caller information...");
    }
}

class VibrationMotor
{
    public void StartVibrating()
    {
        Console.WriteLine("Phone is vibrating...");
    }
}

class Program2
{
    static void Main()
    {
        MobilePhone phone = new MobilePhone();

        RingtonePlayer sound = new RingtonePlayer();
        ScreenDisplay screen = new ScreenDisplay();
        VibrationMotor vibe = new VibrationMotor();

        phone.OnRing += sound.PlayRingtone;
        phone.OnRing += screen.ShowCallerInfo;
        phone.OnRing += vibe.StartVibrating;

        phone.ReceiveCall();
    }
}
