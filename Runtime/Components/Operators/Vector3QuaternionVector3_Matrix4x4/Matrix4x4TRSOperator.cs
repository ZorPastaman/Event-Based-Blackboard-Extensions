// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3QuaternionVector3_Matrix4x4
{
	[CustomLabelInfo("Position", nameof(Vector3), 0)]
	[CustomLabelInfo("Rotation", nameof(Quaternion), 1)]
	[CustomLabelInfo("Scale", nameof(Vector3), 2)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3, Quaternion, Vector3) => (Matrix4x4)/Matrix4x4 TRS Operator")]
	public sealed class Matrix4x4TRSOperator : SingleReturnTernaryOperator<Vector3, Quaternion, Vector3, Matrix4x4>
	{
		protected override Func<Vector3, Quaternion, Vector3, Matrix4x4> operation => DefaultOperators.Matrix4x4TRS;
	}
}
