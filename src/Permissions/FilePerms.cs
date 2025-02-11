// DV
using System;

namespace Wasmtime
{
	/// <summary>
	/// This enum defines the allowed operations that can be performed on a file.
	/// </summary>
	[Flags]
	public enum FilePerms : ulong
	{
		/// <summary>
		/// Reading is allowed.
		/// </summary>
		Read = 0b1,

		/// <summary>
		/// Altering is allowed.
		/// </summary>
		Write = 0b10,

		/// <summary>
		/// All combined.
		/// </summary>
		All = Read | Write
	}
}