// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Matrix4x4_Quaternion
{
	[CustomLabelInfo(null, nameof(Matrix4x4), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Matrix4x4) => (Quaternion)/Matrix4x4 Rotation Operator")]
	public sealed class Matrix4x4RotationOperator : SingleReturnUnaryOperator<Matrix4x4, Quaternion>
	{
		protected override Func<Matrix4x4, Quaternion> operation => DefaultOperators.Matrix4x4Rotation;
	}
}
