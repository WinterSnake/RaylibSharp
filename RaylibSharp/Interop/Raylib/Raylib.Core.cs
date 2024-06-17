/*
	RaylibSharp: Interop
	- [Raylib]Core

	Written By: Ryan Smith
*/
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace RaylibSharp.Interop;

public static partial class Raylib
{
	/* Static Methods */
	// Drawing
	[LibraryImport(Library)]
	public static partial void BeginDrawing();
	[LibraryImport(Library)]
	public static partial void ClearBackground(Color color);
	[LibraryImport(Library)]
	public static partial void EndDrawing();
	// Timing
	[LibraryImport(Library)]
	public static partial float GetFrameTime();
	// Window
	[LibraryImport(Library, StringMarshalling=StringMarshalling.Utf8)]
	public static partial void InitWindow(int width, int height, string title);
	[LibraryImport(Library)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static partial bool WindowShouldClose();
	[LibraryImport(Library)]
	public static partial void CloseWindow();
	/* Class Properties */
	public const string Library = "raylib";
	public const string Version = "5.0.0";
}
