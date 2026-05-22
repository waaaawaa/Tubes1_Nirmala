using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BOTKETIGA : Bot
{
    static void Main(string[] args)
    {
        new BOTKETIGA().Start();
    }

    BOTKETIGA() : base(BotInfo.FromFile("BOTKETIGA.json")) { }

    public override void Run()
    {
        // Tema Hijau
        BodyColor = Color.FromArgb(0x00, 0xCC, 0x66);
        TurretColor = Color.FromArgb(0x00, 0xFF, 0x99);
        RadarColor = Color.FromArgb(0x66, 0xFF, 0xCC);
        BulletColor = Color.FromArgb(0xCC, 0xFF, 0x00);
        ScanColor = Color.FromArgb(0x00, 0xFF, 0x00);
        TracksColor = Color.FromArgb(0x00, 0x66, 0x33);
        GunColor = Color.FromArgb(0x00, 0x99, 0x66);

        while (IsRunning)
        {
            Forward(100);

            TurnRight(120);

            TurnGunRight(360);

            Back(50);
        }
    }

    // Heuristic: menghindar setelah menyerang
    public override void OnScannedBot(ScannedBotEvent e)
    {
        Fire(1);

        Back(120);

        TurnLeft(90);
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        TurnRight(90);

        Forward(150);
    }
}