// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Matrix4x4_Vector3
{
	[CustomLabelInfo(null, nameof(Matrix4x4), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Matrix4x4) => (Vector3)/Matrix4x4 Lossy Scale Operator")]
	public sealed class Matrix4x4LossyScaleOperator : SingleReturnUnaryOperator<Matrix4x4, Vector3>
	{
		protected override Func<Matrix4x4, Vector3> operation => DefaultOperators.Matrix4x4LossyScale;
	}
}
