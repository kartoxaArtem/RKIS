using System;
using Avalonia.Media;
using RefactorMe.Common;

namespace RefactorMe
{
    class Risovatel
    {
        static float x, y;
        static IGraphics graphic;

        public static void Initialization(IGraphics newGraphic)
        {
            graphic = newGraphic;
            //grafika.SmoothingMode = SmoothingMode.None;
            graphic.Clear(Colors.Black);
        }

        public static void SetPosition(float x0, float y0)
        { x = x0; y = y0; }

        public static void MakeStep(Pen pen, double Length, double corner)
        {
            //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
            var x1 = (float)(x + Length * Math.Cos(corner));
            var y1 = (float)(y + Length * Math.Sin(corner));
            graphic.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ChangePosition(double Length, double corner)
        {
            x = (float)(x + Length * Math.Cos(corner));
            y = (float)(y + Length * Math.Sin(corner));
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int Width, int Height, double corner, IGraphics graphics)
        {
            var drawer = new Risovatel();
            Risovatel.Initialization(graphics);

            var Size = Math.Min(Width, Height);
            var Length = Math.Sqrt(2) * (Size * 0.375f + Size * 0.04f) / 2;

            var centerX = (float)(Length * Math.Cos(Math.PI / 4 + Math.PI)) + Width / 2f;
            var centerY = (float)(Length * Math.Sin(Math.PI / 4 + Math.PI)) + Height / 2f;
            Risovatel.SetPosition(centerX, centerY);

            DrawSide(drawer, Size, 0);
            DrawSide(drawer, Size, -Math.PI / 2);
            DrawSide(drawer, Size, Math.PI);
            DrawSide(drawer, Size, Math.PI / 2);
        }
        private static void DrawSide(Risovatel drawer, float Size, double Angle)
        {
            var pen = new Pen(Brushes.Yellow);

            Risovatel.MakeStep(pen, Size * 0.375f, 0 + Angle);
            Risovatel.MakeStep(pen, Size * 0.04f * Math.Sqrt(2), Math.PI / 4 + Angle);
            Risovatel.MakeStep(pen, Size * 0.375f, Math.PI + Angle);
            Risovatel.MakeStep(pen, Size * 0.375f - Size * 0.04f, Math.PI / 2 + Angle);

            Risovatel.ChangePosition(Size * 0.04f, Math.PI + Angle);
            Risovatel.ChangePosition(Size * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4 + Angle);
        }
    }
}
