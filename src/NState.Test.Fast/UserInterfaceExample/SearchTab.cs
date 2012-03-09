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
	public class SearchTab : Stateful<UIRoot, LucidState>
	{
		public SearchTab(IStateMachine<LucidState> stateMachine)
			: base(stateMachine) {}

		public SearchTab Hide() {
			return TriggerTransition(this, new SearchTabState.Hidden());
		}

		public SearchTab Show() {
			return TriggerTransition(this, new SearchTabState.Visible());
		}
	}
}