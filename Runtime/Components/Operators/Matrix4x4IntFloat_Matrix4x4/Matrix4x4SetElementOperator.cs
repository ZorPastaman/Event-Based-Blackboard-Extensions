// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Matrix4x4IntFloat_Matrix4x4
{
	[CustomLabelInfo(null, nameof(Matrix4x4), 0)]
	[CustomLabelInfo("Index", nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Single), 2)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Matrix4x4, Int, Float) => (Matrix4x4)/Matrix4x4 Set Element Operator")]
	public sealed class Matrix4x4SetElementOperator : SingleReturnTernaryOperator<Matrix4x4, int, float, Matrix4x4>
	{
		protected override Func<Matrix4x4, int, float, Matrix4x4> operation => DefaultOperators.Matrix4x4SetElement;
	}
}
