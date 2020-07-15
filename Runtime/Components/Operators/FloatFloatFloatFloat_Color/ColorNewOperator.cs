// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloatFloat_Color
{
	[CustomLabelInfo("Red", nameof(Single), 0)]
	[CustomLabelInfo("Green", nameof(Single), 1)]
	[CustomLabelInfo("Blue", nameof(Single), 2)]
	[CustomLabelInfo("Alpha", nameof(Single), 3)]
	[CustomLabelInfo(null, nameof(Color), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float, Float) => (Color)/Color New Operator")]
	public sealed class ColorNewOperator : SingleReturnQuaternaryOperator<float, float, float, float, Color>
	{
		protected override Func<float, float, float, float, Color> operation => DefaultOperators.ColorNew;
	}
}
