﻿// Copyright 2012, Ben Aston (ben@bj.ma).
// 
// This file is part of NState.
// 
// NState is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// NState is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with NState. If not, see <http://www.gnu.org/licenses/>.

namespace NState.Test.Fast.UserInterfaceExample
{
	using System;

	public class WorkingPanelTransition
	{
		[Serializable]
		public class SelectAccountMode : StateTransition<LucidState>
		{
			public SelectAccountMode(
				Action<LucidState, IStateMachine<LucidState>, dynamic> transitionAction = null)
				: base(transitionAction) {}

			public override LucidState[] InitialStates {
				get { return new[] {new WorkingPanelState.SearchMode(),}; }
			}

			public override LucidState[] EndStates {
				get { return new[] {new WorkingPanelState.AccountMode(),}; }
			}
		}

		[Serializable]
		public class SelectSearchMode : StateTransition<LucidState>
		{
			public SelectSearchMode(
				Action<LucidState, IStateMachine<LucidState>, dynamic> transitionAction = null)
				: base(transitionAction) {}

			public override LucidState[] InitialStates {
				get { return new[] {new WorkingPanelState.AccountMode(),}; }
			}

			public override LucidState[] EndStates {
				get { return new[] {new WorkingPanelState.SearchMode(),}; }
			}
		}
	}
}