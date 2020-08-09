﻿using OpenTK;
using SmartAutoAR.VirtualObject.Cameras;
using System;

namespace SmartAutoAR
{
	/// <summary>
	/// 定義場景功能的介面
	/// </summary>
	public interface IScene :IDisposable
	{
		public ICamera Camera { get; }

		public void Render(float aspectRatio);
	}
}
