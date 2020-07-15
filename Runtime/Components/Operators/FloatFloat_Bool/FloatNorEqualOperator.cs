// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloat_Bool
{
	[CustomLabelInfo(null, nameof(Single), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float) => (Bool)/Float Not Equal Operator")]
	public sealed class FloatNotEqualOperator : SingleReturnBinaryOperator<float, float, bool>
	{
		protected override Func<float, float, bool> operation => DefaultOperators.FloatNotEqual;
	}
}
