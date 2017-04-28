namespace WebAssembly.Instructions
{
	/// <summary>
	/// A unary operator that discards the value of its operand.
	/// </summary>
	public class Drop : Instruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Drop"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Drop;

		/// <summary>
		/// Creates a new  <see cref="Drop"/> instance.
		/// </summary>
		public Drop()
		{
		}
	}
}