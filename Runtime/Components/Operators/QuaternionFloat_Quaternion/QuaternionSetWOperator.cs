// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.QuaternionFloat_Quaternion
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Quaternion), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion, Float) => (Quaternion)/Quaternion Set W Operator")]
	public sealed class QuaternionSetWOperator : SingleReturnBinaryOperator<Quaternion, float, Quaternion>
	{
		protected override Func<Quaternion, float, Quaternion> operation => DefaultOperators.QuaternionSetW;
	}
}
