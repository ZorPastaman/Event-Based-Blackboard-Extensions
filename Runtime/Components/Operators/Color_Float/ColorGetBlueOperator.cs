// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Color_Float
{
	[CustomLabelInfo(null, nameof(Color), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Color) => (Float)/Color Get Blue Operator")]
	public sealed class ColorGetBlueOperator : SingleReturnUnaryOperator<Color, float>
	{
		protected override Func<Color, float> operation => DefaultOperators.ColorGetBlue;
	}
}
