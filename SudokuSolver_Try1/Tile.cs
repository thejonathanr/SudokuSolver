﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public class Tile {
		public enum TileType {
			Empty,
			InProgress,
			Solved
		};

		public int x;
		public int y;
		
		public int group;
		
		public string value = "";
		public List<string> ideas = new List<string>();
		public TextBox field;
		public Panel panel;
		public bool hasField = false;

		public TileType tileType = TileType.Empty;

		public Tile(int _x, int _y, TileType _TileType, string _value, List<string> _ideas, TextBox _field, Panel _panel, bool _hasField, int _w, int _h ) {
			this.x = _x;
			this.y = _y;
			this.tileType = _TileType;
			this.value = _value;
			this.ideas = _ideas;
			this.field = _field;
			this.panel = _panel;
			this.hasField = _hasField;

			var x_g = ((int)(_x / Math.Sqrt(_h + 1)));
			var y_g = ((int)(_y / Math.Sqrt(_w + 1)));

			this.group = (x_g * 3) + (y_g);

		}

	}
}
