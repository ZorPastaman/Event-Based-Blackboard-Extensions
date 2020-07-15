// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3Vector3Vector3_Matrix4x4
{
	[CustomLabelInfo("From", nameof(Vector3), 0)]
	[CustomLabelInfo("To", nameof(Vector3), 1)]
	[CustomLabelInfo("Up", nameof(Vector3), 2)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3, Vector3, Vector3) => (Matrix4x4)/Matrix4x4 Look At Operator")]
	public sealed class Matrix4x4LookAtOperator : SingleReturnTernaryOperator<Vector3, Vector3, Vector3, Matrix4x4>
	{
		protected override Func<Vector3, Vector3, Vector3, Matrix4x4> operation => DefaultOperators.Matrix4x4LookAt;
	}
}
