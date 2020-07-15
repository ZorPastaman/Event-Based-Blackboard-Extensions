// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Quaternion_Vector3
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion) => (Vector3)/Quaternion Euler Angles Operator")]
	public sealed class QuaternionEulerAnglesOperator : SingleReturnUnaryOperator<Quaternion, Vector3>
	{
		protected override Func<Quaternion, Vector3> operation => DefaultOperators.QuaternionEulerAngles;
	}
}
