﻿using UnityEngine;

namespace Hover.Common.Input {

	/*================================================================================================*/
	public interface IHoverCursorData {

		CursorType Type { get; }
		float Size { get; }
		float DisplayStrength { get; }
		Vector3 WorldPosition { get; }
		Quaternion WorldRotation { get; }

	}

}
