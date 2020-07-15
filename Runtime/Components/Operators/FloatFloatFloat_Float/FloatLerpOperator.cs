// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloat_Float
{
	[CustomLabelInfo("A", nameof(Single), 0)]
	[CustomLabelInfo("B", nameof(Single), 1)]
	[CustomLabelInfo("Time", nameof(Single), 2)]
	[CustomLabelInfo(null, nameof(Single), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float) => (Float)/Float Lerp Operator")]
	public sealed class FloatLerpOperator : SingleReturnTernaryOperator<float, float, float, float>
	{
		protected override Func<float, float, float, float> operation => DefaultOperators.FloatLerp;
	}
}
