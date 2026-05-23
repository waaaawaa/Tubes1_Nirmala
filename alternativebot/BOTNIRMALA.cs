using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BOTNIRMALA : Bot
{
    static void Main(string[] args)
    {
        new BOTNIRMALA().Start();
    }

    BOTNIRMALA() : base(BotInfo.FromFile("BOTNIRMALA.json")) { }

    public override void Run()
    {
        // Tema Biru
        BodyColor = Color.FromArgb(0x1E, 0x90, 0xFF);
        TurretColor = Color.FromArgb(0x00, 0xBF, 0xFF);
        RadarColor = Color.FromArgb(0x87, 0xCE, 0xFA);
        BulletColor = Color.FromArgb(0xFF, 0x45, 0x00);
        ScanColor = Color.FromArgb(0xFF, 0xFF, 0x00);
        TracksColor = Color.FromArgb(0x19, 0x19, 0x70);
        GunColor = Color.FromArgb(0x00, 0x00, 0x8B);

        while (IsRunning)
        {
            Forward(150);

            TurnGunRight(360);

            TurnRight(45);

            Back(100);
        }
    }

    // Heuristic: menyerang musuh terdekat
    public override void OnScannedBot(ScannedBotEvent e)
    {
        Fire(3);

        Forward(50);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(100);

        TurnRight(90);
    }
}