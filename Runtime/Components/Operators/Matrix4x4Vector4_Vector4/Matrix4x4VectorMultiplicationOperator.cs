// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Matrix4x4Vector4_Vector4
{
	[CustomLabelInfo(null, nameof(Matrix4x4), 0)]
	[CustomLabelInfo(null, nameof(Vector4), 1)]
	[CustomLabelInfo(null, nameof(Vector4), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Matrix4x4, Vector4) => (Vector4)/Matrix4x4 Vector Multiplication Operator")]
	public sealed class Matrix4x4VectorMultiplicationOperator : SingleReturnBinaryOperator<Matrix4x4, Vector4, Vector4>
	{
		protected override Func<Matrix4x4, Vector4, Vector4> operation =>
			DefaultOperators.Matrix4x4VectorMultiplication;
	}
}
