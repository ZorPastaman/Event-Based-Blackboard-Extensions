// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3Vector3_Bool
{
	[CustomLabelInfo(null, nameof(Vector3), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3, Vector3) => (Bool)/Vector3 Not Equal Operator")]
	public sealed class Vector3NotEqualOperator : SingleReturnBinaryOperator<Vector3, Vector3, bool>
	{
		protected override Func<Vector3, Vector3, bool> operation => DefaultOperators.Vector3NotEqual;
	}
}
