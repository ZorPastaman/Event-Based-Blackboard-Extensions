# Event Based Blackboard Extensions

## What is Event Based Blackboard Extensions?

Event Based Blackboard Extensions is an extension for
[Event Based Blackboard](https://github.com/ZorPastaman/Event-Based-Blackboard).
It contains a lot of useful extensions for Blackboard component usage as well as for regular c# Blackboard usage.

## Installation

This repo is a regular Unity package. You can install it as your project dependency.
More here: https://docs.unity3d.com/Manual/upm-dependencies.html.

## Extensions

- Accessors - a collection of Unity components that provide a simple property with get and set for a blackboard property.
They are especially useful when you use Unity Events.
  - [Components source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Components/Accessors)
  - Add component directory: **Add Component/Event Based Blackboard/Accessors/**
- Applicators - a collection of Unity components that provide simple methods for controlling values in different components.
They are especially useful when you use Unity Events.
  - [Components source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Components/Applicators)
  - Add component directory: **Add Component/Event Based Blackboard/Applicators/**
- Converters - a collection of Unity components and regular c# classes that provide a simple event based conversion from a property into another property.
  - [Components source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Components/Converters)
  - [Regular classes source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Workers/Conversion)
  - Add component directory: **Add Component/Event Based Blackboard/Converters/**
- Listeners - a collection of Unity components and regular c# classes that provide an easy way to subscribe to a blackboard property change.
The components are especially useful as they invoke Unity Events with set values.
  - [Components source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Components/Listeners)
  - [Regular classes source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Workers/Listening)
  - Add component directory: **Add Component/Event Based Blackboard/Listeners/**
- Operators - a collection of Unity components and regular c# classes that provide an easy way to subscribe to blackboard properties changes,
and to operate different operators with them and to set a result to a blackboard property.
  - [Components source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Components/Operators)
  - [Regular classes source code](https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions/tree/master/Runtime/Workers/Operating)
  - Add component directory: **Add Component/Event Based Blackboard/Operators/**
