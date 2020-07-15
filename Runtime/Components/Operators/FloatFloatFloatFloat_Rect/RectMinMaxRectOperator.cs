// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloatFloat_Rect
{
	[CustomLabelInfo("X Min", nameof(Single), 0)]
	[CustomLabelInfo("Y Min", nameof(Single), 1)]
	[CustomLabelInfo("X Max", nameof(Single), 2)]
	[CustomLabelInfo("Y Max", nameof(Single), 3)]
	[CustomLabelInfo(null, nameof(Single), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float, Float) => (Rect)/Rect Min Max Rect Operator")]
	public sealed class RectMinMaxRectOperator : SingleReturnQuaternaryOperator<float, float, float, float, Rect>
	{
		protected override Func<float, float, float, float, Rect> operation => DefaultOperators.RectMinMaxRect;
	}
}
