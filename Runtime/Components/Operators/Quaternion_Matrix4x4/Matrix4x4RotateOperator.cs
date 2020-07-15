// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Quaternion_Matrix4x4
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion) => (Matrix4x4)/Matrix4x4 Rotate Operator")]
	public sealed class Matrix4x4RotateOperator : SingleReturnUnaryOperator<Quaternion, Matrix4x4>
	{
		protected override Func<Quaternion, Matrix4x4> operation => DefaultOperators.Matrix4x4Rotate;
	}
}
