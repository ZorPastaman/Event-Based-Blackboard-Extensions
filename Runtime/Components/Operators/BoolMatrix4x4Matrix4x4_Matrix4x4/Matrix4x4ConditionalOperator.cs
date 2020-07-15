// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolMatrix4x4Matrix4x4_Matrix4x4
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Matrix4x4), 1)]
	[CustomLabelInfo("False", nameof(Matrix4x4), 2)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Matrix4x4, Matrix4x4) => (Matrix4x4)/Matrix4x4 Conditional Operator")]
	public sealed class Matrix4x4ConditionalOperator :
		SingleReturnTernaryOperator<bool, Matrix4x4, Matrix4x4, Matrix4x4>
	{
		protected override Func<bool, Matrix4x4, Matrix4x4, Matrix4x4> operation =>
			DefaultOperators.Matrix4x4Conditional;
	}
}
