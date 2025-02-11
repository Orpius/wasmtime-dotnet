// DV
using System;

namespace Wasmtime
{
	/// <summary>
	/// This enum defines the allowed operations that can be performed on a directory.
	/// </summary>
	[Flags]
	public enum DirPerms : ulong
	{
		/// <summary>
		/// Reading is allowed.
		/// </summary>
		Read = 0b1,

		/// <summary>
		/// Altering is allowed.
		/// </summary>
		Mutate = 0b10,

		/// <summary>
		/// All combined.
		/// </summary>
		All = Read | Mutate
	}
}
