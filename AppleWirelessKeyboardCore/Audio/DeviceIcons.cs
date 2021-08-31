using System;
using System.Collections.Generic;
using System.Drawing;

namespace AppleWirelessKeyboardCore.Audio
{
    public static class DeviceIcons
    {
        static readonly List<Icon> ActiveIcons = new();
        static readonly List<Icon> NormalIcons = new();
        static readonly List<Icon> DefaultIcons = new();

        public static void Add(string iconPath)
        {
            var icon = GetIcon(iconPath);
            NormalIcons.Add(icon);
            ActiveIcons.Add(icon);
        }

        public static Icon GetIcon(string iconPath)
        {
            var path = Environment.ExpandEnvironmentVariables(iconPath);
            var iconAdr = path.Split(',');

            if (iconAdr.Length > 1)
            {
                var icon = Vanara.PInvoke.Shell32.ExtractIcon(Vanara.PInvoke.HINSTANCE.NULL, iconAdr[0], int.Parse(iconAdr[1]));
                return icon.ToIcon();
                //return Icon.FromHandle(icon.DangerousGetHandle());
            }
            else
                return new Icon(iconAdr[0], 32, 32);
        }

        public static void Clear()
        {
            ActiveIcons.Clear();
            NormalIcons.Clear();
            DefaultIcons.Clear();
        }

        public static Image AddOverlay(Icon originalIcon, Image overlay)
        {
            using Image original = originalIcon.ToBitmap();
            var bitmap = new Bitmap(originalIcon.Width, originalIcon.Height);
            using var canvas = Graphics.FromImage(bitmap);
            canvas.DrawImage(original, 0, 0);
            canvas.DrawImage(overlay, 0, 0, original.Width, original.Height);
            canvas.Save();
            return bitmap;
        }

        public static Bitmap ChangeColors(Bitmap bmp, int hue, float saturation, float brightness)
        {
            for (var y = 0; y < bmp.Height; y++)
            for (var x = 0; x < bmp.Width; x++)
            {
                var p = bmp.GetPixel(x, y);
                var pb = p.GetBrightness() + brightness;
                pb = pb < 0 ? 0 : pb;
                pb = pb > 1 ? 1 : pb;

                var c = ColorFromAhsb(p.A, hue, p.GetSaturation() + saturation, pb);
                bmp.SetPixel(x, y, c);
            }

            return bmp;
        }

        public static Color ColorFromAhsb(int alpha, float hue, float saturation, float brightness)
        {
            if (0 == saturation)
            {
                return Color.FromArgb(alpha, Convert.ToInt32(brightness * 255),
                    Convert.ToInt32(brightness * 255), Convert.ToInt32(brightness * 255));
            }

            float fMax, fMid, fMin;

            if (0.5 < brightness)
            {
                fMax = brightness - (brightness * saturation) + saturation;
                fMin = brightness + (brightness * saturation) - saturation;
            }
            else
            {
                fMax = brightness + (brightness * saturation);
                fMin = brightness - (brightness * saturation);
            }

            var iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue)
                hue -= 360f;
            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);

            if (0 == iSextant % 2)
                fMid = hue * (fMax - fMin) + fMin;
            else
                fMid = fMin - hue * (fMax - fMin);

            var iMax = Convert.ToInt32(fMax * 255);
            var iMid = Convert.ToInt32(fMid * 255);
            var iMin = Convert.ToInt32(fMin * 255);

            return iSextant switch
            {
                1 => Color.FromArgb(alpha, iMid, iMax, iMin),
                2 => Color.FromArgb(alpha, iMin, iMax, iMid),
                3 => Color.FromArgb(alpha, iMin, iMid, iMax),
                4 => Color.FromArgb(alpha, iMid, iMin, iMax),
                5 => Color.FromArgb(alpha, iMax, iMin, iMid),
                _ => Color.FromArgb(alpha, iMax, iMid, iMin)
            };
        }
    }
}