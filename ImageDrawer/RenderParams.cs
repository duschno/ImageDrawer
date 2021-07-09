﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDrawer
{

	public enum SmoothingType
	{
		None,
		Antialias,
	}

	public enum LineType
	{
		Line,
		Dot,
		Curve
	}

	public enum MethodType
	{
		Ridge,
		Squiggle
	}

	public enum BackendType
	{
		GDIPlus,
		Cairo
	}

	public struct RenderParams
	{
		public int LinesCount;
		public int Width;
		public int Factor;
		public int ChunkSize;
		public SmoothingType Smoothing;
		public LineType LineType;
		public MethodType Method;
		public BackendType Backend;
	}
}
