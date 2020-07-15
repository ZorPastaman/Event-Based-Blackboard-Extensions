// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.TransformQuaternion_Void
{
	[CustomLabelInfo(null, nameof(Transform), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Transform, Quaternion) => (Void)/Transform Set Rotation Operator")]
	public sealed class TransformSetRotationOperator : NoReturnBinaryOperator<Transform, Quaternion>
	{
		protected override Action<Transform, Quaternion> operation => DefaultOperators.TransformSetRotation;
	}
}
