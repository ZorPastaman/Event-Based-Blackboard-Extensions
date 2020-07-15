// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Matrix4x4Matrix4x4_Bool
{
	[CustomLabelInfo(null, nameof(Matrix4x4), 0)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Matrix4x4, Matrix4x4) => (Bool)/Matrix4x4 Equal Operator")]
	public sealed class Matrix4x4EqualOperator : SingleReturnBinaryOperator<Matrix4x4, Matrix4x4, bool>
	{
		protected override Func<Matrix4x4, Matrix4x4, bool> operation => DefaultOperators.Matrix4x4Equal;
	}
}
