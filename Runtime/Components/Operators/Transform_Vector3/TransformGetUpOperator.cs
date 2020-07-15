// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Transform_Vector3
{
	[CustomLabelInfo(null, nameof(Transform), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Transform) => (Vector3)/Transform Get Up Operator")]
	public sealed class TransformGetUpOperator : SingleReturnUnaryOperator<Transform, Vector3>
	{
		protected override Func<Transform, Vector3> operation => DefaultOperators.TransformGetUp;
	}
}
