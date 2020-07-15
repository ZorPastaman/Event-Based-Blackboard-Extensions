// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3_Matrix4x4
{
	[CustomLabelInfo(null, nameof(Vector3), 0)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3) => (Matrix4x4)/Matrix4x4 Scale Operator")]
	public sealed class Matrix4x4ScaleOperator : SingleReturnUnaryOperator<Vector3, Matrix4x4>
	{
		protected override Func<Vector3, Matrix4x4> operation => DefaultOperators.Matrix4x4Scale;
	}
}
