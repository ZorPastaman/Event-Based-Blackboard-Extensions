// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Matrix4x4_Float
{
	[CustomLabelInfo(null, nameof(Matrix4x4), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Matrix4x4) => (Float)/Matrix4x4 Determinant Operator")]
	public sealed class Matrix4x4DeterminantOperator : SingleReturnUnaryOperator<Matrix4x4, float>
	{
		protected override Func<Matrix4x4, float> operation => DefaultOperators.Matrix4x4Determinant;
	}
}
