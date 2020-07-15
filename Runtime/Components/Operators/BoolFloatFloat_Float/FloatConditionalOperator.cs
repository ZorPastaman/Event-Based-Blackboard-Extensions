// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolFloatFloat_Float
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Single), 1)]
	[CustomLabelInfo("False", nameof(Single), 2)]
	[CustomLabelInfo(null, nameof(Single), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Float, Float) => (Float)/Float Conditional Operator")]
	public sealed class FloatConditionalOperator : SingleReturnTernaryOperator<bool, float, float, float>
	{
		protected override Func<bool, float, float, float> operation => DefaultOperators.FloatConditional;
	}
}
