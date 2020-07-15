// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.QuaternionVector3_Vector3
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Vector3), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion, Quaternion) => (Vector3)/Quaternion Point Multiplication Operator")]
	public sealed class QuaternionPointMultiplicationOperator : SingleReturnBinaryOperator<Quaternion, Vector3, Vector3>
	{
		protected override Func<Quaternion, Vector3, Vector3> operation =>
			DefaultOperators.QuaternionPointMultiplication;
	}
}
