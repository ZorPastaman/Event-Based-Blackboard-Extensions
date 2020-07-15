// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Operating
{
	/// <summary>
	/// Operates an operation with blackboard properties of types <typeparamref name="TFirstOperand"/>,
	/// <typeparamref name="TSecondOperand"/>, <typeparamref name="TThirdOperand"/>
	/// and <typeparamref name="TFourthOperand"/> that returns nothing.
	/// </summary>
	/// <typeparam name="TFirstOperand">First operand value type.</typeparam>
	/// <typeparam name="TSecondOperand">Second operand value type.</typeparam>
	/// <typeparam name="TThirdOperand">Third operand value type.</typeparam>
	/// <typeparam name="TFourthOperand">Fourth operand value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Operators.NoReturnQuaternaryOperator{TFirstOperand,TSecondOperand,TThirdOperand,TFourthOperand}"/>
	public sealed class NoReturnQuaternaryOperator<TFirstOperand, TSecondOperand, TThirdOperand, TFourthOperand>
	{
		private readonly Blackboard m_firstOperandBlackboard;
		private readonly BlackboardPropertyName m_firstOperandPropertyName;
		private readonly Blackboard m_secondOperandBlackboard;
		private readonly BlackboardPropertyName m_secondOperandPropertyName;
		private readonly Blackboard m_thirdOperandBlackboard;
		private readonly BlackboardPropertyName m_thirdOperandPropertyName;
		private readonly Blackboard m_fourthOperandBlackboard;
		private readonly BlackboardPropertyName m_fourthOperandPropertyName;

		private readonly bool m_operateOnEnable;

		private readonly Action<TFirstOperand, TSecondOperand, TThirdOperand, TFourthOperand> m_operation;

		private readonly Action<BlackboardChangeInfo<TFirstOperand>> m_onFirstOperandChanged;
		private readonly Action<BlackboardChangeInfo<TSecondOperand>> m_onSecondOperandChanged;
		private readonly Action<BlackboardChangeInfo<TThirdOperand>> m_onThirdOperandChanged;
		private readonly Action<BlackboardChangeInfo<TFourthOperand>> m_onFourthOperandChanged;

		private bool m_enabled;

		public NoReturnQuaternaryOperator([NotNull] Blackboard firstOperandBlackboard,
			BlackboardPropertyName firstOperandPropertyName,
			[NotNull] Blackboard secondOperandBlackboard,
			BlackboardPropertyName secondOperandPropertyName,
			[NotNull] Blackboard thirdOperandBlackboard,
			BlackboardPropertyName thirdOperandPropertyName,
			[NotNull] Blackboard fourthOperandBlackboard,
			BlackboardPropertyName fourthOperandPropertyName,
			bool operateOnEnable,
			[NotNull] Action<TFirstOperand, TSecondOperand, TThirdOperand, TFourthOperand> operation)
		{
			m_firstOperandBlackboard = firstOperandBlackboard;
			m_firstOperandPropertyName = firstOperandPropertyName;

			m_secondOperandBlackboard = secondOperandBlackboard;
			m_secondOperandPropertyName = secondOperandPropertyName;

			m_thirdOperandBlackboard = thirdOperandBlackboard;
			m_thirdOperandPropertyName = thirdOperandPropertyName;

			m_fourthOperandBlackboard = fourthOperandBlackboard;
			m_fourthOperandPropertyName = fourthOperandPropertyName;

			m_operateOnEnable = operateOnEnable;

			m_operation = operation;

			m_onFirstOperandChanged = OnFirstOperandChanged;
			m_onSecondOperandChanged = OnSecondOperandChanged;
			m_onThirdOperandChanged = OnThirdOperandChanged;
			m_onFourthOperandChanged = OnFourthOperandChanged;
		}

		/// <summary>
		/// If true, the
		/// <see cref="NoReturnQuaternaryOperator{TFirstOperand,TSecondOperand,TThirdOperand,TFourthOperand}"/>
		/// is subscribed; if false, the
		/// <see cref="NoReturnQuaternaryOperator{TFirstOperand,TSecondOperand,TThirdOperand,TFourthOperand}"/>
		/// is not subscribed and does nothing.
		/// </summary>
		/// <remarks>False by default.</remarks>
		public bool enabled
		{
			get => m_enabled;
			set
			{
				if (m_enabled == value)
				{
					return;
				}

				m_enabled = value;

				if (m_enabled)
				{
					Enable();
				}
				else
				{
					Disable();
				}
			}
		}

		private void Enable()
		{
			m_firstOperandBlackboard.Subscribe(m_firstOperandPropertyName, m_onFirstOperandChanged);
			m_secondOperandBlackboard.Subscribe(m_secondOperandPropertyName, m_onSecondOperandChanged);
			m_thirdOperandBlackboard.Subscribe(m_thirdOperandPropertyName, m_onThirdOperandChanged);
			m_fourthOperandBlackboard.Subscribe(m_fourthOperandPropertyName, m_onFourthOperandChanged);

			if (!m_operateOnEnable)
			{
				return;
			}

			if (m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName, out TFirstOperand firstOperand)
				&& m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName, out TSecondOperand secondOperand)
				&& m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName, out TThirdOperand thirdOperand)
				&& m_fourthOperandBlackboard.TryGetValue(m_fourthOperandPropertyName, out TFourthOperand fourthOperand))
			{
				m_operation(firstOperand, secondOperand, thirdOperand, fourthOperand);
			}
		}

		private void Disable()
		{
			m_firstOperandBlackboard.Unsubscribe(m_firstOperandPropertyName, m_onFirstOperandChanged);
			m_secondOperandBlackboard.Unsubscribe(m_secondOperandPropertyName, m_onSecondOperandChanged);
			m_thirdOperandBlackboard.Unsubscribe(m_thirdOperandPropertyName, m_onThirdOperandChanged);
			m_fourthOperandBlackboard.Unsubscribe(m_fourthOperandPropertyName, m_onFourthOperandChanged);
		}

		private void OnFirstOperandChanged(BlackboardChangeInfo<TFirstOperand> firstInfo)
		{
			if (firstInfo.removed
				|| !m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName,
					out TSecondOperand secondOperand)
				|| !m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName,
					out TThirdOperand thirdOperand)
				|| !m_fourthOperandBlackboard.TryGetValue(m_fourthOperandPropertyName,
					out TFourthOperand fourthOperand))
			{
				return;
			}

			m_operation(firstInfo.value, secondOperand, thirdOperand, fourthOperand);
		}

		private void OnSecondOperandChanged(BlackboardChangeInfo<TSecondOperand> secondInfo)
		{
			if (secondInfo.removed
				|| !m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName,
					out TFirstOperand firstOperand)
				|| !m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName,
					out TThirdOperand thirdOperand)
				|| !m_fourthOperandBlackboard.TryGetValue(m_fourthOperandPropertyName,
					out TFourthOperand fourthOperand))
			{
				return;
			}

			m_operation(firstOperand, secondInfo.value, thirdOperand, fourthOperand);
		}

		private void OnThirdOperandChanged(BlackboardChangeInfo<TThirdOperand> thirdInfo)
		{
			if (thirdInfo.removed
				|| !m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName,
					out TFirstOperand firstOperand)
				|| !m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName,
					out TSecondOperand secondOperand)
				|| !m_fourthOperandBlackboard.TryGetValue(m_fourthOperandPropertyName,
					out TFourthOperand fourthOperand))
			{
				return;
			}

			m_operation(firstOperand, secondOperand, thirdInfo.value, fourthOperand);
		}

		private void OnFourthOperandChanged(BlackboardChangeInfo<TFourthOperand> fourthInfo)
		{
			if (fourthInfo.removed
				|| !m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName,
					out TFirstOperand firstOperand)
				|| !m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName,
					out TSecondOperand secondOperand)
				|| !m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName,
					out TThirdOperand thirdOperand))
			{
				return;
			}

			m_operation(firstOperand, secondOperand, thirdOperand, fourthInfo.value);
		}
	}
}
