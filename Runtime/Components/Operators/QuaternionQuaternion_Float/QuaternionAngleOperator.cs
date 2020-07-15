// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.QuaternionQuaternion_Float
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[CustomLabelInfo(null, nameof(Single), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion, Quaternion)/Quaternion Angle Operator")]
	public sealed class QuaternionAngleOperator : SingleReturnBinaryOperator<Quaternion, Quaternion, float>
	{
		protected override Func<Quaternion, Quaternion, float> operation => DefaultOperators.QuaternionAngle;
	}
}
