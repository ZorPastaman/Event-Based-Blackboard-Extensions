// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolVector3Vector3_Vector3
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Vector3), 1)]
	[CustomLabelInfo("False", nameof(Vector3), 2)]
	[CustomLabelInfo(null, nameof(Vector3), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Vector3, Vector3) => (Vector3)/Vector3 Conditional Operator")]
	public sealed class Vector3ConditionalOperator : SingleReturnTernaryOperator<bool, Vector3, Vector3, Vector3>
	{
		protected override Func<bool, Vector3, Vector3, Vector3> operation => DefaultOperators.Vector3Conditional;
	}
}
