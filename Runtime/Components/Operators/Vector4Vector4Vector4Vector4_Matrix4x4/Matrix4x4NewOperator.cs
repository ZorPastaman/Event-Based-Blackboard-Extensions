// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector4Vector4Vector4Vector4_Matrix4x4
{
	[CustomLabelInfo(null, nameof(Vector4), 0)]
	[CustomLabelInfo(null, nameof(Vector4), 1)]
	[CustomLabelInfo(null, nameof(Vector4), 2)]
	[CustomLabelInfo(null, nameof(Vector4), 3)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector4, Vector4, Vector4, Vector4) => (Matrix4x4)/Matrix4x4 New Operator")]
	public sealed class Matrix4x4NewOperator :
		SingleReturnQuaternaryOperator<Vector4, Vector4, Vector4, Vector4, Matrix4x4>
	{
		protected override Func<Vector4, Vector4, Vector4, Vector4, Matrix4x4> operation =>
			DefaultOperators.Matrix4x4New;
	}
}
