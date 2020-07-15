// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Transform_Matrix4x4
{
	[CustomLabelInfo(null, nameof(Transform), 0)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Transform) => (Matrix4x4)/Transform Get World To Local Matrix Operator")]
	public sealed class TransformGetWorldToLocalMatrixOperator : SingleReturnUnaryOperator<Transform, Matrix4x4>
	{
		protected override Func<Transform, Matrix4x4> operation => DefaultOperators.TransformGetWorldToLocalMatrix;
	}
}
