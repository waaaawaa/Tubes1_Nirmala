using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BOTKEDUA : Bot
{
    static void Main(string[] args)
    {
        new BOTKEDUA().Start();
    }

    BOTKEDUA() : base(BotInfo.FromFile("BOTKEDUA.json")) { }

    public override void Run()
    {
        // Tema Ungu
        BodyColor = Color.FromArgb(0x80, 0x00, 0xFF);
        TurretColor = Color.FromArgb(0x99, 0x33, 0xFF);
        RadarColor = Color.FromArgb(0xCC, 0x99, 0xFF);
        BulletColor = Color.FromArgb(0xFF, 0x00, 0xFF);
        ScanColor = Color.FromArgb(0x00, 0xFF, 0xFF);
        TracksColor = Color.FromArgb(0x33, 0x00, 0x66);
        GunColor = Color.FromArgb(0x66, 0x00, 0xCC);

        while (IsRunning)
        {
            Forward(200);

            TurnGunRight(360);

            TurnLeft(90);

            Forward(100);
        }
    }

    // Heuristic: menyerang terus menerus
    public override void OnScannedBot(ScannedBotEvent e)
    {
        Fire(2);

        TurnRight(30);

        Forward(80);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        TurnRight(180);

        Forward(100);
    }
}