/*
	RaylibSharp: Color

	Written By: Ryan Smith
*/
using System.Runtime.InteropServices;

namespace RaylibSharp;

[StructLayout(LayoutKind.Sequential)]
public struct Color
{
	/* Constructors */
	public Color(byte red, byte green, byte blue): this(red, green, blue, 255) { }
	public Color(byte red, byte green, byte blue, byte alpha)
	{
		this.R = red;
		this.G = green;
		this.B = blue;
		this.A = alpha;
	}
	/* Properties */
	public byte R;
	public byte G;
	public byte B;
	public byte A;
	/* Class Properties */
    public static readonly Color LightGray = new(200, 200, 200);
    public static readonly Color Gray = new(130, 130, 130);
    public static readonly Color DarkGray = new(80, 80, 80);
    public static readonly Color Yellow = new(253, 249, 0);
    public static readonly Color Gold = new(255, 203, 0);
    public static readonly Color Orange = new(255, 161, 0);
    public static readonly Color Pink = new(255, 109, 194);
    public static readonly Color Red = new(230, 41, 55);
    public static readonly Color Maroon = new(190, 33, 55);
    public static readonly Color Green = new(0, 228, 48);
    public static readonly Color Lime = new(0, 158, 47);
    public static readonly Color DarkGreen = new(0, 117, 44);
    public static readonly Color SkyBlue = new(102, 191, 255);
    public static readonly Color Blue = new(0, 121, 241);
    public static readonly Color DarkBlue = new(0, 82, 172);
    public static readonly Color Purple = new(200, 122, 255);
    public static readonly Color Violet = new(135, 60, 190);
    public static readonly Color DarkPurple = new(112, 31, 126);
    public static readonly Color Beige = new(211, 176, 131);
    public static readonly Color Brown = new(127, 106, 79);
    public static readonly Color DarkBrown = new(76, 63, 47);
    public static readonly Color White = new(255, 255, 255);
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color Blank = new(0, 0, 0, 0);
    public static readonly Color Magenta = new(255, 0, 255);
    public static readonly Color RayWhite = new(245, 245, 245);
}
