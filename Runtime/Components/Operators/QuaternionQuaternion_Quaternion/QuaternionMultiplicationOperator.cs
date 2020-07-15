// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.QuaternionQuaternion_Quaternion
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[CustomLabelInfo(null, nameof(Quaternion), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion, Quaternion) => (Quaternion)/Quaternion Multiplication Operator")]
	public sealed class QuaternionMultiplicationOperator :
		SingleReturnBinaryOperator<Quaternion, Quaternion, Quaternion>
	{
		protected override Func<Quaternion, Quaternion, Quaternion> operation =>
			DefaultOperators.QuaternionMultiplication;
	}
}
