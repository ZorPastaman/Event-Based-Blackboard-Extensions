// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3Vector3_Quaternion
{
	[CustomLabelInfo("From", nameof(Vector3), 0)]
	[CustomLabelInfo("To", nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Quaternion), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3, Vector3) => (Quaternion)/Quaternion From To Rotation Operator")]
	public sealed class QuaternionFromToRotationOperator : SingleReturnBinaryOperator<Vector3, Vector3, Quaternion>
	{
		protected override Func<Vector3, Vector3, Quaternion> operation => DefaultOperators.QuaternionFromToRotation;
	}
}
