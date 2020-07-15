// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Transform_Quaternion
{
	[CustomLabelInfo(null, nameof(Transform), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Transform) => (Quaternion)/Transform Get Local Rotation Operator")]
	public sealed class TransformGetLocalRotationOperator : SingleReturnUnaryOperator<Transform, Quaternion>
	{
		protected override Func<Transform, Quaternion> operation => DefaultOperators.TransformGetLocalRotation;
	}
}
