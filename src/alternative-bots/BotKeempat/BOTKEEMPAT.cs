using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BOTKEEMPAT : Bot
{
    static void Main(string[] args)
    {
        new BOTKEEMPAT().Start();
    }

    BOTKEEMPAT() : base(BotInfo.FromFile("BOTKEEMPAT.json")) { }

    public override void Run()
    {
        // Tema Merah
        BodyColor = Color.FromArgb(0xCC, 0x00, 0x00);
        TurretColor = Color.FromArgb(0xFF, 0x33, 0x33);
        RadarColor = Color.FromArgb(0xFF, 0x66, 0x00);
        BulletColor = Color.FromArgb(0xFF, 0xFF, 0x00);
        ScanColor = Color.FromArgb(0xFF, 0x99, 0x99);
        TracksColor = Color.FromArgb(0x66, 0x00, 0x00);
        GunColor = Color.FromArgb(0x99, 0x00, 0x00);

        while (IsRunning)
        {
            Forward(250);

            TurnRight(90);

            TurnGunRight(360);
        }
    }

    // Heuristic: patrol arena sambil scan
    public override void OnScannedBot(ScannedBotEvent e)
    {
        Fire(2);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(100);

        TurnLeft(90);
    }
}