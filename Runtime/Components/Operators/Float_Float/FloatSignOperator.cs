// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Float_Float
{
	[CustomLabelInfo(null, nameof(Single), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float) => (Int)/Float Sign Operator")]
	public sealed class FloatSignOperator : SingleReturnUnaryOperator<float, float>
	{
		protected override Func<float, float> operation => DefaultOperators.FloatFloatSign;
	}
}
