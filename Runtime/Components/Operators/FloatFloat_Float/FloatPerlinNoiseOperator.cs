// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloat_Float
{
	[CustomLabelInfo("X", nameof(Single), 0)]
	[CustomLabelInfo("Y", nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Single), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float) => (Float)/Float Perlin Noise Operator")]
	public sealed class FloatPerlinNoiseOperator : SingleReturnBinaryOperator<float, float, float>
	{
		protected override Func<float, float, float> operation => DefaultOperators.FloatPerlinNoise;
	}
}
