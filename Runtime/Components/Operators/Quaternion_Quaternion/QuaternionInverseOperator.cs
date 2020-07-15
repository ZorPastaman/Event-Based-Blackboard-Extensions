// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Quaternion_Quaternion
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion) => (Quaternion)/Quaternion Inverse Operator")]
	public sealed class QuaternionInverseOperator : SingleReturnUnaryOperator<Quaternion, Quaternion>
	{
		protected override Func<Quaternion, Quaternion> operation => DefaultOperators.QuaternionInverse;
	}
}
