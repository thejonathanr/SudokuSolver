﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuSolver_Try1 {
	public partial class MainUI : Form {

		public Program program;
		public MainUI self;

		public MainUI() {
			InitializeComponent();
		}

		private new void TextChanged(object sender, Tile obj, EventArgs e) {
			//program.Databoard.GetCell(obj.X, obj.Y).Value = obj.field.Text;
			if (cb_FocusHighlight.Checked) {
				program.Gameboard.UIHighlight.CreateFocusHighlight(program.Gameboard.Databoard, tb_HighlightText.Text);
			}
			program.Gameboard.UpdateFromTextbox(obj);

			// Should always come last.
			ShowPossibilities();
			SetCount();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void btn_ShowHighlight_MouseUp(object sender, MouseEventArgs e) {
			if (cb_FocusHighlight.Checked) {
				program.Gameboard.UIHighlight.CreateFocusHighlight(program.Gameboard.Databoard, tb_HighlightText.Text);
			}
		}

		private void highlightText_TextChanged(object sender, EventArgs e) {
			if (cb_FocusHighlight.Checked) {
				program.Gameboard.UIHighlight.CreateFocusHighlight(program.Gameboard.Databoard, tb_HighlightText.Text);
			}
			ShowPossibilities();
			SetCount();

		}

		private void highlight_Click(object sender, Tile obj, EventArgs e) {
			//rcHighlight(obj);
		}

		private void btn_ClearGrid_MouseUp(object sender, MouseEventArgs e) {
			//program.UIboard.Clear();
		}

		private void btn_LoadPreset_MouseUp(object sender, MouseEventArgs e) {
			SSP ssp = new SSP(program, self);

			ssp.Load();

		}

		private void btn_autoCycle_MouseUp(object sender, MouseEventArgs e) {
			program.Gameboard.MasterCycle();
		}

		private void focusHighlight_CheckedChanged(object sender, EventArgs e) {
			if (cb_FocusHighlight.Checked) {
				program.Gameboard.UIHighlight.CreateFocusHighlight(program.Gameboard.Databoard, tb_HighlightText.Text);
			} else {
				program.Gameboard.UIHighlight.ClearLayer(Highlight.DepthType.Focus);
			}
		}

		private void clickHighlight_Click_1(object sender, EventArgs e) {
		}

		private void cb_possib_CheckedChanged(object sender, EventArgs e) {
			if (cb_ShowPossibilities.Checked) {
				ShowPossibilities();
			} else {
				program.Gameboard.UIHighlight.ClearLayer(Highlight.DepthType.Possibilities);
			}
		}

		private void clickHighlight_CheckedChanged(object sender, EventArgs e) {
			if(!cb_ClickHighlight.Checked) {
				//RemoveHighlight(Color.LightBlue, true);
				//RemoveHighlight(Color.Blue, true);
			} else {
				if (program.LastExec != null) {
					//rcHighlight(program.LastExec);
				}
			}
		}

		private void btn_ClearHighlight_MouseUp(object sender, MouseEventArgs e) {
			tb_HighlightText.Text = "";
			SetCount();
			program.Gameboard.UIHighlight.Clear();

			cb_ShowPossibilities.Checked = false;
			cb_FocusHighlight.Checked = false;
		}

		private void cb_autoFill_CheckedChanged(object sender, EventArgs e) {
			if (cb_AutoFillPossibilities.Checked) {
				ShowPossibilities();
			}
		}

		private void btn_Save_MouseDown(object sender, MouseEventArgs e) {
			SSP ssp = new SSP(program, self);

			ssp.Save();
		}

		private void tb_HighlightText_KeyPress(object sender, KeyPressEventArgs e) {

		}
	}
}
