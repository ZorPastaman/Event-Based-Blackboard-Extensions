// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloat_Float
{
	[CustomLabelInfo(null, nameof(Single), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Single), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float) => (Float)/Float Max Operator")]
	public sealed class FloatMaxOperator : SingleReturnBinaryOperator<float, float, float>
	{
		protected override Func<float, float, float> operation => DefaultOperators.FloatMax;
	}
}
