﻿using System;

public class Data
{

	public Data() {
		/*
		{
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
			{ " "," "," "," "," "," "," "," "," "},
		}
		*/
	}

	public int entries = 5;
	public string[,,] presets = {
									{// Easy - 12
										{"6"," ","8"," "," "," "," "," "," "},
										{" ","7"," "," ","3","2","6"," ","5"},
										{"1","5"," ","4"," "," "," "," "," "},
										{" "," "," ","8","9"," ","3"," "," "},
										{" "," ","4"," "," "," "," ","1","8"},
										{" ","8"," ","5"," "," ","7"," "," "},
										{" ","1","3"," ","4"," ","5"," "," "},
										{"9"," "," ","2","8","3"," "," ","6"},
										{"2"," "," "," "," "," "," "," "," "},
									},
									{// Easy - 17
										{" "," ","7"," ","3","1"," "," "," "},
										{" "," ","9"," ","6"," ","5"," ","2"},
										{"4"," "," "," ","5"," ","9","7"," "},
										{"5"," ","2","3"," "," ","7"," "," "},
										{" ","3"," "," ","4"," "," "," "," "},
										{" "," "," ","5"," "," ","6","4","3"},
										{" ","9"," ","4","1","2"," "," "," "},
										{" "," ","5"," "," "," "," "," "," "},
										{" ","1"," "," "," "," "," "," ","6"},
									},
									{// Challenging - 150
										{"6","3"," "," "," "," "," "," ","5"},
										{"2"," "," ","6","1"," ","3"," "," "},
										{"4"," "," "," "," "," "," ","6","2"},
										{"7"," "," "," "," ","4","6"," ","9"},
										{" "," ","5","9"," ","7","4"," "," "},
										{" ","6"," "," "," ","5","1"," "," "},
										{" ","9"," "," "," "," ","2"," "," "},
										{" "," "," "," "," "," "," "," "," "},
										{" "," ","7"," ","3"," "," ","8"," "},
									},
									{// Challenging - 159
										{" ","9"," ","7","6","4"," "," "," "},
										{"2","6"," ","3"," "," "," "," "," "},
										{" "," ","8"," "," "," "," ","4","3"},
										{" "," "," "," "," "," ","9"," ","5"},
										{" "," "," "," "," "," "," ","3"," "},
										{" "," "," "," ","8","9","1"," "," "},
										{"1","7"," ","4"," "," "," ","2"," "},
										{"9","4"," "," "," ","1"," "," "," "},
										{" "," ","3","2","7"," "," "," "," "},
									},
									{// 63 Sudoku
										{ " "," "," "," "," "," ","4"," "," "},
										{ "6"," "," "," "," ","3","7"," "," "},
										{ " "," "," ","8","7"," "," ","6","1"},
										{ " ","5","2","6"," "," "," ","8"," "},
										{ "8","4"," "," "," "," ","6"," "," "},
										{ " "," ","6"," "," ","9","5"," "," "},
										{ " "," "," ","3"," ","2"," "," "," "},
										{ " ","8"," "," ","6","4"," "," "," "},
										{ "9"," "," "," ","1"," "," ","3"," "},
									}
								 };
}