// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3_Quaternion
{
	[CustomLabelInfo(null, nameof(Vector3), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3) => (Quaternion)/Quaternion Euler Operator")]
	public sealed class QuaternionEulerOperator : SingleReturnUnaryOperator<Vector3, Quaternion>
	{
		protected override Func<Vector3, Quaternion> operation => DefaultOperators.QuaternionEuler;
	}
}
