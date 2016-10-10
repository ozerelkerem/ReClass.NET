﻿using System.Runtime.InteropServices;

namespace ReClassNET.Nodes
{
	class Matrix4x4Node : BaseVecNode
	{
		[StructLayout(LayoutKind.Explicit)]
		struct Matrix4x4Data
		{
			[FieldOffset(0)]
			public float _11;
			[FieldOffset(4)]
			public float _12;
			[FieldOffset(8)]
			public float _13;
			[FieldOffset(12)]
			public float _14;
			[FieldOffset(16)]
			public float _21;
			[FieldOffset(20)]
			public float _22;
			[FieldOffset(24)]
			public float _23;
			[FieldOffset(28)]
			public float _24;
			[FieldOffset(32)]
			public float _31;
			[FieldOffset(36)]
			public float _32;
			[FieldOffset(40)]
			public float _33;
			[FieldOffset(44)]
			public float _34;
			[FieldOffset(48)]
			public float _41;
			[FieldOffset(52)]
			public float _42;
			[FieldOffset(56)]
			public float _43;
			[FieldOffset(60)]
			public float _44;
		}

		public override int MemorySize => 16 * 4;

		public override int Draw(ViewInfo view, int x, int y)
		{
			if (IsHidden)
			{
				return DrawHidden(view, x, y);
			}

			AddSelection(view, x, y, view.Font.Height);
			AddDelete(view, x, y);
			AddTypeDrop(view, x, y);

			x = x + TXOFFSET;

			x = AddIcon(view, x, y, Icons.Matrix, HotSpot.NoneId, HotSpotType.None);

			var tx = x;

			x = AddAddressOffset(view, x, y);

			x = AddText(view, x, y, view.Settings.Type, HotSpot.NoneId, "Matrix ");
			x = AddText(view, x, y, view.Settings.Name, HotSpot.NameId, Name);
			x = AddOpenClose(view, x, y);

			x += view.Font.Width;

			x = AddComment(view, x, y);

			if (levelsOpen[view.Level])
			{
				var value = view.Memory.ReadObject<Matrix4x4Data>(Offset);

				y += view.Font.Height;
				x = tx;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 0, $"{value._11,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 1, $"{value._12,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 2, $"{value._13,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 3, $"{value._14,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");

				y += view.Font.Height;
				x = tx;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 4, $"{value._21,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 5, $"{value._22,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 6, $"{value._23,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 7, $"{value._24,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");

				y += view.Font.Height;
				x = tx;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 8, $"{value._31,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 9, $"{value._32,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 10, $"{value._33,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 11, $"{value._34,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");

				y += view.Font.Height;
				x = tx;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 12, $"{value._41,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 13, $"{value._42,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 14, $"{value._43,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 15, $"{value._44,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
			}

			return y + view.Font.Height;
		}

		public override void Update(HotSpot spot)
		{
			base.Update(spot);

			Update(spot, 16);
		}
	}
}
