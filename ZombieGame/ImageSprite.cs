using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ZombieGame
{
    class ImageSprite
    {
        public float Angle;
        public PointF Center;
        public Bitmap Picture;
        public float Radius;

        public ImageSprite(float angle, PointF center, Bitmap picture)
        {
            Angle = angle;
            Center = center;
            Picture = picture;
            Radius = Math.Min(picture.Width, picture.Height) / 2f;
        }

        public void Draw(Graphics gr)
        {
            GraphicsState state = gr.Save();
            gr.ResetTransform();
            gr.RotateTransform(Angle);
            gr.TranslateTransform(Center.X, Center.Y, MatrixOrder.Append);
            gr.DrawImage(Picture, new PointF(-Radius, -Radius));
            gr.Restore(state);

        }
    }
}
