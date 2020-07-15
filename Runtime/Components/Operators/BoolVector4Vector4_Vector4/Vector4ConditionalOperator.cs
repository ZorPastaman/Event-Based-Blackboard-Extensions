// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolVector4Vector4_Vector4
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Vector4), 1)]
	[CustomLabelInfo("False", nameof(Vector4), 2)]
	[CustomLabelInfo(null, nameof(Vector4), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Vector4, Vector4) => (Vector4)/Vector4 Conditional Operator")]
	public sealed class Vector4ConditionalOperator : SingleReturnTernaryOperator<bool, Vector4, Vector4, Vector4>
	{
		protected override Func<bool, Vector4, Vector4, Vector4> operation => DefaultOperators.Vector4Conditional;
	}
}
