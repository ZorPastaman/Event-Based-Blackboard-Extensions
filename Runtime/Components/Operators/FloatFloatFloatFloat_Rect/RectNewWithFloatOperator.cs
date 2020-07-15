// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloatFloat_Rect
{
	[CustomLabelInfo("X", nameof(Single), 0)]
	[CustomLabelInfo("Y", nameof(Single), 1)]
	[CustomLabelInfo("Width", nameof(Single), 2)]
	[CustomLabelInfo("Height", nameof(Single), 3)]
	[CustomLabelInfo(null, nameof(Rect), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float, Float) => (Rect)/Rect New With Floats Operator")]
	public sealed class RectNewWithFloatOperator : SingleReturnQuaternaryOperator<float, float, float, float, Rect>
	{
		protected override Func<float, float, float, float, Rect> operation => DefaultOperators.RectNewWithFloats;
	}
}
