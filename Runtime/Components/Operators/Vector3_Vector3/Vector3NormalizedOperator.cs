// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3_Vector3
{
	[CustomLabelInfo(null, nameof(Vector3), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3) => (Vector3)/Vector3 Normalized Operator")]
	public sealed class Vector3NormalizedOperator : SingleReturnUnaryOperator<Vector3, Vector3>
	{
		protected override Func<Vector3, Vector3> operation => DefaultOperators.Vector3Normalized;
	}
}
