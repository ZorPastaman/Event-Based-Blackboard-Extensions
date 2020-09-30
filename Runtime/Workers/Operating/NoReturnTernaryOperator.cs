// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Operating
{
	/// <summary>
	/// Operates an operation with blackboard properties of types <typeparamref name="TFirstOperand"/>,
	/// <typeparamref name="TSecondOperand"/> and <typeparamref name="TThirdOperand"/> that returns nothing.
	/// </summary>
	/// <typeparam name="TFirstOperand">First operand value type.</typeparam>
	/// <typeparam name="TSecondOperand">Second operand value type.</typeparam>
	/// <typeparam name="TThirdOperand">Third operand value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Operators.NoReturnTernaryOperator{TFirstOperand,TSecondOperand,TThirdOperand}"/>
	public sealed class NoReturnTernaryOperator<TFirstOperand, TSecondOperand, TThirdOperand>
	{
		private readonly Blackboard m_firstOperandBlackboard;
		private readonly BlackboardPropertyName m_firstOperandPropertyName;
		private readonly Blackboard m_secondOperandBlackboard;
		private readonly BlackboardPropertyName m_secondOperandPropertyName;
		private readonly Blackboard m_thirdOperandBlackboard;
		private readonly BlackboardPropertyName m_thirdOperandPropertyName;

		private readonly bool m_operateOnEnable;

		private readonly Action<TFirstOperand, TSecondOperand, TThirdOperand> m_operation;

		private readonly Action<BlackboardChangeInfo<TFirstOperand>> m_onFirstOperandChanged;
		private readonly Action<BlackboardChangeInfo<TSecondOperand>> m_onSecondOperandChanged;
		private readonly Action<BlackboardChangeInfo<TThirdOperand>> m_onThirdOperandChanged;

		private bool m_enabled;

		public NoReturnTernaryOperator([NotNull] Blackboard firstOperandBlackboard,
			BlackboardPropertyName firstOperandPropertyName,
			[NotNull] Blackboard secondOperandBlackboard,
			BlackboardPropertyName secondOperandPropertyName,
			[NotNull] Blackboard thirdOperandBlackboard,
			BlackboardPropertyName thirdOperandPropertyName,
			bool operateOnEnable,
			[NotNull] Action<TFirstOperand, TSecondOperand, TThirdOperand> operation)
		{
			m_firstOperandBlackboard = firstOperandBlackboard;
			m_firstOperandPropertyName = firstOperandPropertyName;

			m_secondOperandBlackboard = secondOperandBlackboard;
			m_secondOperandPropertyName = secondOperandPropertyName;

			m_thirdOperandBlackboard = thirdOperandBlackboard;
			m_thirdOperandPropertyName = thirdOperandPropertyName;

			m_operateOnEnable = operateOnEnable;

			m_operation = operation;

			m_onFirstOperandChanged = OnFirstOperandChanged;
			m_onSecondOperandChanged = OnSecondOperandChanged;
			m_onThirdOperandChanged = OnThirdOperandChanged;
		}

		/// <summary>
		/// If true, the
		/// <see cref="NoReturnTernaryOperator{TFirstOperand,TSecondOperand,TThirdOperand}"/>
		/// is subscribed; if false, the
		/// <see cref="NoReturnTernaryOperator{TFirstOperand,TSecondOperand,TThirdOperand}"/>
		/// is not subscribed and does nothing.
		/// </summary>
		/// <remarks>False by default.</remarks>
		public bool enabled
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
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

			if (!m_operateOnEnable)
			{
				return;
			}

			if (m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName, out TFirstOperand firstOperand)
				&& m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName, out TSecondOperand secondOperand)
				&& m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName, out TThirdOperand thirdOperand))
			{
				m_operation(firstOperand, secondOperand, thirdOperand);
			}
		}

		private void Disable()
		{
			m_firstOperandBlackboard.Unsubscribe(m_firstOperandPropertyName, m_onFirstOperandChanged);
			m_secondOperandBlackboard.Unsubscribe(m_secondOperandPropertyName, m_onSecondOperandChanged);
			m_thirdOperandBlackboard.Unsubscribe(m_thirdOperandPropertyName, m_onThirdOperandChanged);
		}

		private void OnFirstOperandChanged(BlackboardChangeInfo<TFirstOperand> firstInfo)
		{
			if (firstInfo.removed
				|| !m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName,
					out TSecondOperand secondOperand)
				|| !m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName,
					out TThirdOperand thirdOperand))
			{
				return;
			}

			m_operation(firstInfo.value, secondOperand, thirdOperand);
		}

		private void OnSecondOperandChanged(BlackboardChangeInfo<TSecondOperand> secondInfo)
		{
			if (secondInfo.removed
				|| !m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName,
					out TFirstOperand firstOperand)
				|| !m_thirdOperandBlackboard.TryGetValue(m_thirdOperandPropertyName,
					out TThirdOperand thirdOperand))
			{
				return;
			}

			m_operation(firstOperand, secondInfo.value, thirdOperand);
		}

		private void OnThirdOperandChanged(BlackboardChangeInfo<TThirdOperand> thirdInfo)
		{
			if (thirdInfo.removed
				|| !m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName,
					out TFirstOperand firstOperand)
				|| !m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName,
					out TSecondOperand secondOperand))
			{
				return;
			}

			m_operation(firstOperand, secondOperand, thirdInfo.value);
		}
	}
}
