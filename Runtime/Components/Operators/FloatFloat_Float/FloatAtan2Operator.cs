// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloat_Float
{
	[CustomLabelInfo("Y", nameof(Single), 0)]
	[CustomLabelInfo("X", nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Single), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float) => (Float)/Float Atan2 Operator")]
	public sealed class FloatAtan2Operator : SingleReturnBinaryOperator<float, float, float>
	{
		protected override Func<float, float, float> operation => DefaultOperators.FloatAtan2;
	}
}
